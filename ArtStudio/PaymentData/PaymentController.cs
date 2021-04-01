using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PayPal.Api;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using System.Threading.Tasks;
using ArtStudio.Models;
using ArtStudio.Services;

namespace ArtStudio.PaymentData
{
    [AllowAnonymous]
    public class PaymentController : Controller
    {
        private PayPal.Api.Payment payment;
        private readonly ApplicationDBContext _context;
        private readonly SessionService _sessionService;
        private readonly UserService _userService;
        public PaymentController(ApplicationDBContext context, SessionService sessionService, UserService userService)
        {
            _context = context;
            _sessionService = sessionService;
            _userService = userService;
        }

        public IActionResult Congratulations()
        {

            return Ok();
        }


        [Route("Payment/PaymentWithPaypal/{id}")]
        public ActionResult PaymentWithPaypal(string id, string Cancel = null)
        {
            try
            {
                if (!User.Identity.IsAuthenticated)
                {
                    return Redirect("/login");

                }

                if (!String.IsNullOrEmpty(id))
                {
                    Package package = _context.Packages.FirstOrDefault(pc => pc.Id.ToString() == id);
                    if (package != null)
                    {

                        string payerId = Request.Query["PayerID"];
                        if (string.IsNullOrEmpty(payerId))
                        {
                            string baseURI = $"{Request.Scheme}://{Request.Host}/Payment/PaymentWithPaypalOnPost";

                            var guid = Guid.NewGuid().ToString();
                            APIContext apiContext = PaypalConfiguration.GetAPIContext();
                            var createdPayment = this.CreatePayment(apiContext, $"{baseURI}?guid={guid}", package);

                            var links = createdPayment.links.GetEnumerator();
                            string paypalRedirectUrl = null;
                            while (links.MoveNext())
                            {
                                Links lnk = links.Current;
                                if (lnk.rel.ToLower().Trim().Equals("approval_url"))
                                {
                                    //saving the payapalredirect URL to which user will be redirected for payment  
                                    paypalRedirectUrl = lnk.href;
                                }
                            }
                            this.HttpContext.Session.SetString("paymentid", createdPayment.id);
                            this.HttpContext.Session.SetString("packageid", id);
                            return Redirect(paypalRedirectUrl);
                        }
                    }
                    else
                    {

                        throw new Exception("Subscription which you want to buy does not exist");
                    }
                }
                else
                {
                    throw new Exception("Parameter can't be null or empty");
                }
            }
            catch (PayPal.PayPalException ex)
            {
                if (ex.InnerException is PayPal.ConnectionException)
                {
                    return RedirectToAction("Error/" + ex.Message + ", you can see more details here" + ex.HelpLink);
                }
                else
                {
                    return RedirectToAction("Error/" + ex.Message + ", you can see more details here" + ex.HelpLink);
                }
            }
            catch (Exception ex)
            {
                return RedirectToAction("Error/" + ex.Message);
            }
            return View("SomethingWentWrong");
        }

        public async Task<ActionResult> PaymentWithPaypalOnPost()
        {
            try
            {
                APIContext apiContext = PaypalConfiguration.GetAPIContext();
                string payerId = Request.Query["PayerID"];
                if (!string.IsNullOrEmpty(payerId))
                {
                    var executedPayment = ExecutePayment(apiContext, payerId, HttpContext.Session.GetString("paymentid"));
                    if (executedPayment.state.ToLower() != "approved")
                    {
                        throw new Exception(
                            "Your transaction was not approved, failure reason code: " + executedPayment.failure_reason + "," +
                            "contact with payment provider to see more details." +
                            "Your payment ID: " + executedPayment.id
                            );
                    }
                }
                else
                {
                    throw new Exception("Payer ID can't be null or empty");
                }
            }
            catch (PayPal.PayPalException ex)
            {
                if (ex.InnerException is PayPal.ConnectionException)
                {
                    return RedirectToAction("Error/" + ex.Message + ", you can see more details here" + ex.HelpLink);
                }
                else
                {
                    return RedirectToAction("Error/" + ex.Message + ", you can see more details here" + ex.HelpLink);
                }
            }
            catch (Exception ex)
            {
                return View("Error/" + ex.Message);
            }
            await AfterSuccessPayment();

            return LocalRedirect("/profile");
        }
        private async Task AfterSuccessPayment()
        {
            string packageId= this.HttpContext.Session.GetString("packageid");
          
            Package package = _context.Packages.FirstOrDefault(p => p.Id.ToString() == packageId);
            DateTime startDate = DateTime.Now;
            DateTime endDate = startDate.AddHours(24 * 31 * 3);
            PaymentInfo paymentInfo = new PaymentInfo()
            {
                ApplicationUserId = _sessionService.GetUserId(),
                Id = Guid.NewGuid(),
                CountOfDownload = package.CountOfDownlaods,
                PackageId = package.Id,
                Enabled = true,
                StartDate = startDate,
                EndDate = endDate,
                DisplayAlias = $"Успешная оплата пакета: {package.DisplayAlias} пользователем: {_sessionService.GetUserName()} в {startDate}"
            };
            _context.PaymentInfos.Add(paymentInfo);
            _context.SaveChanges();
            await _userService.AddCountOfDownload(package.CountOfDownlaods);

        }
        private Payment ExecutePayment(APIContext apiContext, string payerId, string paymentId)
        {
            var paymentExecution = new PaymentExecution()
            {
                payer_id = payerId
            };
            this.payment = new Payment()
            {
                id = paymentId
            };
            return this.payment.Execute(apiContext, paymentExecution);
        }
        private Payment CreatePayment(APIContext apiContext, string redirectUrl, Package package)
        {
            var total = package.Price;

            //create itemlist and add item objects to it  
            var itemList = new ItemList()
            {
                items = new List<Item>()
            };
            //Adding Item Details like name, currency, price etc  
            itemList.items.Add(new Item()
            {
                name = package.DisplayAlias,
                currency = "USD",
                price = total.ToString(),
                quantity = "1",
                sku = "sku"
            });
            var payer = new Payer()
            {
                payment_method = "paypal"
            };
            // Configure Redirect Urls here with RedirectUrls zobject  
            var redirUrls = new RedirectUrls()
            {
                cancel_url = redirectUrl + "&Cancel=true",
                return_url = redirectUrl
            };


            var amount = new Amount()
            {
                currency = "USD",
                total = total.ToString() // Total must be equal to sum of tax, shipping and subtotal or if details does not defined, equal to price from item lsit  
            };
            var transactionList = new List<Transaction>();

            transactionList.Add(new Transaction()
            {
                description = "Transaction description",
                amount = amount,
                item_list = itemList
            });

            this.payment = new Payment()
            {
                intent = "sale",
                payer = payer,
                transactions = transactionList,
                redirect_urls = redirUrls
            };

            return this.payment.Create(apiContext);
        }

    }
}
