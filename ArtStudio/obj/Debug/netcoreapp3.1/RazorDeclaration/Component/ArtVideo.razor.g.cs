#pragma checksum "C:\Users\pervi\source\repos\ArtStudio\ArtStudio\Component\ArtVideo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0340786ef36ad3fda13abb79ed80143cac67e75e"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ArtStudio.Component
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\pervi\source\repos\ArtStudio\ArtStudio\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pervi\source\repos\ArtStudio\ArtStudio\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pervi\source\repos\ArtStudio\ArtStudio\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\pervi\source\repos\ArtStudio\ArtStudio\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\pervi\source\repos\ArtStudio\ArtStudio\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\pervi\source\repos\ArtStudio\ArtStudio\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\pervi\source\repos\ArtStudio\ArtStudio\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\pervi\source\repos\ArtStudio\ArtStudio\_Imports.razor"
using ArtStudio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\pervi\source\repos\ArtStudio\ArtStudio\_Imports.razor"
using ArtStudio.Shared;

#line default
#line hidden
#nullable disable
    public partial class ArtVideo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\pervi\source\repos\ArtStudio\ArtStudio\Component\ArtVideo.razor"
       
    [Parameter]
    public string Src { get; set; }  
    [Parameter]
    public string BgClass { get; set; }
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
        BgClass = "backGround_blockInner";
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591