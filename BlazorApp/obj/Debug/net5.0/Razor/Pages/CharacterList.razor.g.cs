#pragma checksum "C:\Users\dell\Desktop\New folder\Assignment5\BlazorApp\Pages\CharacterList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e37d2db3adb2c997015128827867673d029dd27"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\dell\Desktop\New folder\Assignment5\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dell\Desktop\New folder\Assignment5\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dell\Desktop\New folder\Assignment5\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dell\Desktop\New folder\Assignment5\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dell\Desktop\New folder\Assignment5\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dell\Desktop\New folder\Assignment5\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\dell\Desktop\New folder\Assignment5\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\dell\Desktop\New folder\Assignment5\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\dell\Desktop\New folder\Assignment5\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\dell\Desktop\New folder\Assignment5\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CharacterList")]
    public partial class CharacterList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>CharacterList</h3>\r\n");
            __builder.OpenElement(1, "ul");
#nullable restore
#line 6 "C:\Users\dell\Desktop\New folder\Assignment5\BlazorApp\Pages\CharacterList.razor"
     foreach (var CharacterList in characters)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "li");
            __builder.AddContent(3, 
#nullable restore
#line 8 "C:\Users\dell\Desktop\New folder\Assignment5\BlazorApp\Pages\CharacterList.razor"
             CharacterList.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 9 "C:\Users\dell\Desktop\New folder\Assignment5\BlazorApp\Pages\CharacterList.razor"
        
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\dell\Desktop\New folder\Assignment5\BlazorApp\Pages\CharacterList.razor"
       
private List<CharacterList>characters=new();

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
