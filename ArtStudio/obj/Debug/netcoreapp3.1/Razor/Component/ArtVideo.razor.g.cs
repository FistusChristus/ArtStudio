#pragma checksum "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Component\ArtVideo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "916c80a08bc69fc2d66d7ac797897a0f27a78e68"
// <auto-generated/>
#pragma warning disable 1591
namespace ArtStudio.Component
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
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
    public partial class ArtVideo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", 
#nullable restore
#line 2 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Component\ArtVideo.razor"
             ContainerClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(2, "style", "width:" + (
#nullable restore
#line 2 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Component\ArtVideo.razor"
                                           Width

#line default
#line hidden
#nullable disable
            ) + ";" + " height:" + (
#nullable restore
#line 2 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Component\ArtVideo.razor"
                                                          Height

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "video");
            __builder.AddAttribute(5, "muted", 
#nullable restore
#line 3 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Component\ArtVideo.razor"
                   Muted

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(6, "src", 
#nullable restore
#line 3 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Component\ArtVideo.razor"
                                Src

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(7, "type", 
#nullable restore
#line 3 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Component\ArtVideo.razor"
                                            Type

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(8, "autoplay", 
#nullable restore
#line 3 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Component\ArtVideo.razor"
                                                             Autoplay

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(9, "loop", 
#nullable restore
#line 3 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Component\ArtVideo.razor"
                                                                              Loop

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(10, "controls", 
#nullable restore
#line 3 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Component\ArtVideo.razor"
                                                                                               Controls

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 3 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Component\ArtVideo.razor"
                                                                                                                  Class

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "id", 
#nullable restore
#line 3 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Component\ArtVideo.razor"
                                                                                                                              Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Component\ArtVideo.razor"
       
    [Parameter]
    public string Src { get; set; }
    [Parameter]
    public string ContainerClass { get; set; }
    [Parameter]
    public string Type { get; set; }
    [Parameter]
    public string Controls { get; set; }
    [Parameter]
    public string Muted { get; set; }
    [Parameter]
    public string Loop { get; set; }
    [Parameter]
    public string Autoplay { get; set; }
    [Parameter]
    public string Class { get; set; }
    [Parameter]
    public string Width { get; set; }
    [Parameter]
    public string Height { get; set; }
    [Parameter]
    public string Id { get; set; }

    public ArtVideo()
    {
        Src = "/video/SimpleClip.mp4";
        Type = "video/mp4; codecs=&quot;avc1.42E01E, mp4a.40.2&quot;";
        Muted = "muted";
        Autoplay = "autoplay";
        Loop = "loop";
        Controls = "controls";
        ContainerClass = "backGround_blockInner";
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
