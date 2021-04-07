#pragma checksum "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29b2a6b82e5bbef591a760abd91697c98c1a703b"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ArtStudio.Pages
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
#line 2 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Pages\Index.razor"
using ArtStudio.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Pages\Index.razor"
using ArtStudio.Component;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Pages\Index.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Pages\Index.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Pages\Index.razor"
using ArtStudio.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Pages\Index.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Pages\Index.razor"
using ArtStudio.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Pages\Index.razor"
      
    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    public List<Resource> ResourcesList = new List<Resource>();
    public AppSession session = null;
    [Inject] private IDialogService DialogService { get; set; }

    protected override void OnInitialized()
    {
        session = sessionService.GetSession();
        var photosList = dBContext.Photos.Include(r => r.Category).Where(r => r.Enabled).ToList();
        ResourcesList.AddRange(photosList);
    }
    public Color SetColor(Resource resource)
    {
        Color result = Color.Default;
        if (session != null)
        {
            bool isInCart = dBContext.UserCartContents.Any(c => c.ApplicationUserId == session.Id.ToString() && c.ResourceId == resource.Id && c.Enabled);

            result = isInCart ? Color.Primary : Color.Default;
        }
        return result;

    }

    public async void ToggleInCart(Resource resource)
    {
        if (session == null)
            navigationManager.NavigateTo("login");
        else
        {
            bool isInCart = dBContext.UserCartContents.Any(c => c.ApplicationUserId == session.Id.ToString() && c.ResourceId == resource.Id);


            if (isInCart)
            {
                var result = entityService.DeleteInCart(session.Id, resource.Id);
                var mb = await DialogService.ShowMessageBox("Товар удален с корзины", "", yesText: "Просмотреть корзину", cancelText: "Ок");
                if (mb != null)
                    navigationManager.NavigateTo("/cart");
            }
            else
            {
                var result = entityService.AddToCart(session.Id, resource.Id);
                if (result)
                {
                    var mb = await DialogService.ShowMessageBox("Товар добавлен в корзину", "", yesText: "Просмотреть корзину", cancelText: "Ок");
                    if (mb !=null)
                        navigationManager.NavigateTo("/cart");
                }
            }

            int index = ResourcesList.IndexOf(resource);
            ResourcesList.Remove(resource);
            ResourcesList.Insert(index, resource);
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EntityService entityService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SessionService sessionService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpContextAccessor context { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApplicationDBContext dBContext { get; set; }
    }
}
#pragma warning restore 1591
