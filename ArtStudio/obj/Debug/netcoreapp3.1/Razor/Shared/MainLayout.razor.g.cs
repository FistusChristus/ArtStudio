#pragma checksum "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73509256b9d7d9421c8a9327ee5191cb6b06c6d0"
// <auto-generated/>
#pragma warning disable 1591
namespace ArtStudio.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\_Imports.razor"
using ArtStudio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\_Imports.razor"
using ArtStudio.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\_Imports.razor"
using Microsoft.AspNetCore.Mvc.TagHelpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Shared\MainLayout.razor"
using ArtStudio.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Shared\MainLayout.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Shared\MainLayout.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Shared\MainLayout.razor"
using ArtStudio.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Shared\MainLayout.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Shared\MainLayout.razor"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudLayout>(0);
            __builder.AddAttribute(1, "Class", "leyaout");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudAppBar>(4);
                __builder2.AddAttribute(5, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 20 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Shared\MainLayout.razor"
                          1

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "Dense", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Shared\MainLayout.razor"
                                    true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "Fixed", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Shared\MainLayout.razor"
                                                 true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(9, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(10);
                    __builder3.AddAttribute(11, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Shared\MainLayout.razor"
                              Icons.Material.Filled.ArrowBackIos

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(12, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 21 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Shared\MainLayout.razor"
                                                                         Color.Inherit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(13, "Edge", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Edge>(
#nullable restore
#line 21 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Shared\MainLayout.razor"
                                                                                              Edge.Start

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(14, "Class", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Shared\MainLayout.razor"
                                                                                                                  rotate

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(15, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Shared\MainLayout.razor"
                                                                                                                                    ToggleDrawer

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(16, "\r\n        ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(17);
                    __builder3.AddAttribute(18, "href", "/");
                    __builder3.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(20, "div");
                        __builder4.AddAttribute(21, "class", 
#nullable restore
#line 22 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Shared\MainLayout.razor"
                                       HeaderToggleClass

#line default
#line hidden
#nullable disable
                        );
                        __builder4.OpenElement(22, "span");
                        __builder4.AddAttribute(23, "class", "header_brand");
                        __builder4.AddContent(24, 
#nullable restore
#line 22 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Shared\MainLayout.razor"
                                                                                      HeaderBrand

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(25, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudAppBarSpacer>(26);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "\r\n        ");
                    __builder3.OpenElement(28, "div");
                    __builder3.AddAttribute(29, "class", "ml-auto d-flex");
                    __builder3.AddAttribute(30, "style", "align-items:center; height:56px;");
                    __builder3.AddMarkupContent(31, "\r\n\r\n\r\n            ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(32);
                    __builder3.AddAttribute(33, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder4) => {
                        __builder4.AddMarkupContent(34, "\r\n                    ");
                        __builder4.AddMarkupContent(35, "<div class=\"d-flex justify-content-center align-items-center\">\r\n                        <a href=\"/login\" class=\"shine-button primary-button button-small mr-2\">Вход</a>\r\n                    </div>\r\n                    ");
                        __builder4.OpenComponent<MudBlazor.MudAppBarSpacer>(36);
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(37, "\r\n                    ");
                        __builder4.AddMarkupContent(38, "<div class=\"d-flex justify-content-center align-items-center\">\r\n                        <a href=\"/register\" class=\"shine-button button-small\">Регистрация</a>\r\n                    </div>\r\n                    ");
                        __builder4.OpenComponent<MudBlazor.MudAppBarSpacer>(39);
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(40, "\r\n                ");
                    }
                    ));
                    __builder3.AddAttribute(41, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder4) => {
                        __builder4.AddMarkupContent(42, "\r\n                    ");
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(43);
                        __builder4.AddAttribute(44, "href", "/cart");
                        __builder4.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(46, "\r\n                        ");
                            __builder5.OpenComponent<MudBlazor.MudBadge>(47);
                            __builder5.AddAttribute(48, "Overlap", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 42 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Shared\MainLayout.razor"
                                           true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(49, "Bottom", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 42 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Shared\MainLayout.razor"
                                                         true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(50, "Class", "mx-6 my-4");
                            __builder5.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(52, "\r\n                            ");
                                __builder6.OpenComponent<MudBlazor.MudIcon>(53);
                                __builder6.AddAttribute(54, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 43 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Shared\MainLayout.razor"
                                            Icons.Material.Filled.ShoppingCart

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(55, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 43 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Shared\MainLayout.razor"
                                                                                       Color.Primary

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(56, "\r\n                        ");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(57, "\r\n                    ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(58, "\r\n                    ");
                        __builder4.OpenElement(59, "div");
                        __builder4.AddAttribute(60, "class", "d-flex justify-content-center align-items-center");
                        __builder4.AddMarkupContent(61, "\r\n                        ");
                        __builder4.OpenElement(62, "a");
                        __builder4.AddAttribute(63, "href", "/");
                        __builder4.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Shared\MainLayout.razor"
                                              LogOut

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(65, "class", "shine-button button-small");
                        __builder4.AddMarkupContent(66, "Выход");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(67, "\r\n                    ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(68, "\r\n                ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(69, "\r\n        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(70, "\r\n\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(71, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudDrawer>(72);
                __builder2.AddAttribute(73, "Class", "sidebar-bg");
                __builder2.AddAttribute(74, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 54 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Shared\MainLayout.razor"
                                                                1

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(75, "Open", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 54 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Shared\MainLayout.razor"
                                               open

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(76, "OpenChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => open = __value, open))));
                __builder2.AddAttribute(77, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(78, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudNavMenu>(79);
                    __builder3.AddAttribute(80, "Style", "color:white; font-family:Gilroy");
                    __builder3.AddAttribute(81, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(82, "\r\n\r\n            ");
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(83);
                        __builder4.AddAttribute(84, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder5) => {
                            __builder5.AddMarkupContent(85, "\r\n                    ");
                            __builder5.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(86);
                            __builder5.AddAttribute(87, "href", "profile");
                            __builder5.AddAttribute(88, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(89, "\r\n                        ");
                                __builder6.OpenElement(90, "div");
                                __builder6.AddAttribute(91, "class", "text-center");
                                __builder6.AddContent(92, 
#nullable restore
#line 63 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Shared\MainLayout.razor"
                                                  context.User.Identity.Name

#line default
#line hidden
#nullable disable
                                );
                                __builder6.CloseElement();
                                __builder6.AddMarkupContent(93, "\r\n                        ");
                                __builder6.OpenElement(94, "div");
                                __builder6.AddAttribute(95, "class", "ca-d-flex ca-d-center m-2");
                                __builder6.AddMarkupContent(96, "\r\n                            ");
                                __builder6.OpenComponent<MudBlazor.MudAvatar>(97);
                                __builder6.AddAttribute(98, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 65 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Shared\MainLayout.razor"
                                              Color.Primary

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(99, "Class", "ca-avatar-80");
                                __builder6.AddAttribute(100, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(101, 
#nullable restore
#line 65 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Shared\MainLayout.razor"
                                                                                   context.User.Identity.Name[0]

#line default
#line hidden
#nullable disable
                                    );
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(102, "\r\n                        ");
                                __builder6.CloseElement();
                                __builder6.AddMarkupContent(103, "\r\n                    ");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(104, "\r\n                    <div class=\"divider mt-2 ml-3 mr-3 \"></div>\r\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(105, "\r\n\r\n\r\n            ");
                        __builder4.AddMarkupContent(106, "<div class=\"d-flex justify-content-center align-items-center big-btn-PD\">\r\n                <a href=\"/pricing\" class=\"shine-button\">Купить</a>\r\n            </div>\r\n            ");
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(107);
                        __builder4.AddAttribute(108, "Policy", "Admin");
                        __builder4.AddAttribute(109, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder5) => {
                            __builder5.AddMarkupContent(110, "\r\n                    ");
                            __builder5.AddMarkupContent(111, "<div class=\"d-flex justify-content-center align-items-center mt-2\">\r\n                        <a href=\"/admin\" class=\"shine-button primary-button big-btn-PD\">Админ панель</a>\r\n                    </div>\r\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(112, "\r\n\r\n            <div class=\"divider  mb-2 ml-3 mr-3 \"></div>\r\n\r\n\r\n\r\n            ");
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(113);
                        __builder4.AddAttribute(114, "Href", "/");
                        __builder4.AddAttribute(115, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(116, "Главная");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(117, "\r\n            ");
                        __builder4.OpenComponent<MudBlazor.MudNavGroup>(118);
                        __builder4.AddAttribute(119, "Title", "Категории");
                        __builder4.AddAttribute(120, "Expanded", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 89 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Shared\MainLayout.razor"
                                                     true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(121, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(122, "\r\n");
#nullable restore
#line 90 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Shared\MainLayout.razor"
                 foreach (var category in Categories)
                {
                    string href = "/category/" + category.Id;

#line default
#line hidden
#nullable disable
                            __builder5.AddContent(123, "                ");
                            __builder5.OpenComponent<MudBlazor.MudNavLink>(124);
                            __builder5.AddAttribute(125, "Href", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 93 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Shared\MainLayout.razor"
                                   href

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(126, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(127, 
#nullable restore
#line 93 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Shared\MainLayout.razor"
                                          category.DisplayAlias

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(128, "\r\n");
#nullable restore
#line 94 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Shared\MainLayout.razor"
                }

#line default
#line hidden
#nullable disable
                            __builder5.AddMarkupContent(129, "                \r\n\r\n            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(130, "\r\n            ");
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(131);
                        __builder4.AddAttribute(132, "Href", "/about");
                        __builder4.AddAttribute(133, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(134, "О нас");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(135, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(136, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(137, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudMainContent>(138);
                __builder2.AddAttribute(139, "Class", "");
                __builder2.AddAttribute(140, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(141, "\r\n        ");
                    __builder3.OpenElement(142, "div");
                    __builder3.AddAttribute(143, "style", "margin-top:56px;");
                    __builder3.AddAttribute(144, "class", "d-flex");
                    __builder3.AddMarkupContent(145, "\r\n            ");
                    __builder3.AddContent(146, 
#nullable restore
#line 103 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(147, "\r\n        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(148, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(149, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(150, "\r\n\r\n");
            __builder.OpenComponent<MudBlazor.MudThemeProvider>(151);
            __builder.AddAttribute(152, "Theme", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.MudTheme>(
#nullable restore
#line 108 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Shared\MainLayout.razor"
                         SWPO

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(153, "\r\n");
            __builder.OpenComponent<MudBlazor.MudDialogProvider>(154);
            __builder.CloseComponent();
            __builder.AddMarkupContent(155, "\r\n");
            __builder.OpenComponent<MudBlazor.MudSnackbarProvider>(156);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 112 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Shared\MainLayout.razor"
      


    public AppSession Session { get; set; }
    public List<Category> Categories { get; set; }

    protected override void OnInitialized()
    {
        Session = SessionService.GetSession();

        Categories = dBContext.Categories.OrderBy(c => c.DisplayAlias).ToList();


    }


    public string HeaderBrand = "Sony World Photograpy Organization";
    public string HeaderToggleClass = "";
    MudTheme SWPO = new MudTheme()
    {
        Palette = new Palette()
        {
            Primary = "#9184EF",
            Secondary = "#4A5665",
            AppbarBackground = "#21272F",
            DrawerBackground = "#21272F",
            TextPrimary = "#ffffff",
            Divider = "#ffffff",
            PrimaryContrastText = "#ffffff",
            SecondaryContrastText = "rgba(255, 255, 255, 0.7);"

        },

        LayoutProperties = new LayoutProperties()
        {
            AppbarMinHeight = "0",
            DrawerWidthLeft = "260px",
            DrawerWidthRight = "300px",


        },

        ZIndex = new ZIndex()
        {

        },
        Typography = new Typography()
        {
        }

    };

    bool open = false;
    string rotate = "t-3";

    void ToggleDrawer()
    {
        open = !open;
        rotate = open ? "rotate-180 t-3" : "t-3";
        HeaderBrand = open ? "" : "Sony World Photograpy Organization";
        HeaderToggleClass = open ? "slide-out-bck-left" : "slide-in-fwd-left";
    }

    public async void LogOut()
    {
        Response result = await JSRuntimeService.InvokeScript("SendRequest", new { type = "post", url = "/api/user/logout", data = "", contentType = "application/json" });
        if (result!=null)
        {
            NavigationManager.NavigateTo("/", true);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EntityService entityService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SessionService SessionService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApplicationDBContext dBContext { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JSRuntimeService JSRuntimeService { get; set; }
    }
}
#pragma warning restore 1591
