#pragma checksum "C:\Users\Gia Nhung\Documents\GitHub\autotest\WebApp\BlazorApp1\Pages\ProjectDetailPage\EditFunction.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4470cf82bcd67e075ab7cf14bf6963fb005c2d68"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Pages.ProjectDetailPage
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Gia Nhung\Documents\GitHub\autotest\WebApp\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gia Nhung\Documents\GitHub\autotest\WebApp\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Gia Nhung\Documents\GitHub\autotest\WebApp\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Gia Nhung\Documents\GitHub\autotest\WebApp\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Gia Nhung\Documents\GitHub\autotest\WebApp\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Gia Nhung\Documents\GitHub\autotest\WebApp\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Gia Nhung\Documents\GitHub\autotest\WebApp\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Gia Nhung\Documents\GitHub\autotest\WebApp\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Gia Nhung\Documents\GitHub\autotest\WebApp\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Gia Nhung\Documents\GitHub\autotest\WebApp\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Gia Nhung\Documents\GitHub\autotest\WebApp\BlazorApp1\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Gia Nhung\Documents\GitHub\autotest\WebApp\BlazorApp1\_Imports.razor"
using Blazorise.RichTextEdit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Gia Nhung\Documents\GitHub\autotest\WebApp\BlazorApp1\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Gia Nhung\Documents\GitHub\autotest\WebApp\BlazorApp1\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Gia Nhung\Documents\GitHub\autotest\WebApp\BlazorApp1\Pages\ProjectDetailPage\EditFunction.razor"
using BlazorApp1.Services.Interface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gia Nhung\Documents\GitHub\autotest\WebApp\BlazorApp1\Pages\ProjectDetailPage\EditFunction.razor"
using BlazorApp1.Models;

#line default
#line hidden
#nullable disable
    public partial class EditFunction : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "simple-form");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "form-group");
            __builder.AddMarkupContent(4, "<label for=\"movie-name\">Function Name</label>\r\n        ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "text");
            __builder.AddAttribute(7, "class", "form-control");
            __builder.AddAttribute(8, "id", "project-name");
            __builder.AddAttribute(9, "style", "min-width:500px");
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "C:\Users\Gia Nhung\Documents\GitHub\autotest\WebApp\BlazorApp1\Pages\ProjectDetailPage\EditFunction.razor"
                       function.FunctionName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => function.FunctionName = __value, function.FunctionName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\r\n    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "form-group");
            __builder.AddMarkupContent(15, "<label for=\"year\">Link</label>\r\n        ");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "type", "text");
            __builder.AddAttribute(18, "class", "form-control");
            __builder.AddAttribute(19, "id", "project-link");
            __builder.AddAttribute(20, "style", "min-width:500px");
            __builder.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\Gia Nhung\Documents\GitHub\autotest\WebApp\BlazorApp1\Pages\ProjectDetailPage\EditFunction.razor"
                       function.Milestones

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => function.Milestones = __value, function.Milestones));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\r\n    ");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\Gia Nhung\Documents\GitHub\autotest\WebApp\BlazorApp1\Pages\ProjectDetailPage\EditFunction.razor"
                      SaveFunction

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "class", "btn btn-primary");
            __builder.AddAttribute(27, "style", "margin:5px;");
            __builder.AddContent(28, "Submit");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\Gia Nhung\Documents\GitHub\autotest\WebApp\BlazorApp1\Pages\ProjectDetailPage\EditFunction.razor"
                      Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "class", "btn btn-secondary");
            __builder.AddAttribute(33, "style", "margin:5px;");
            __builder.AddContent(34, "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\Gia Nhung\Documents\GitHub\autotest\WebApp\BlazorApp1\Pages\ProjectDetailPage\EditFunction.razor"
       

    [CascadingParameter] BlazoredModalInstance ModalInstance { get; set; }
    [Parameter] public BlazorApp1.Models.ProjectDetail function { get; set; }


    protected override async Task OnInitializedAsync()
    {

    }

    async void SaveFunction()
    {
        function.ModifiedDate = DateTime.UtcNow;
        try
        {
            await _service.UpdateFunction(function);
            await ModalInstance.CloseAsync(ModalResult.Ok<BlazorApp1.Models.ProjectDetail>(function));
        }
        catch
        {
            await JsRuntime.InvokeVoidAsync("Error", "Something when wrong");
        }

    }

    async void Cancel()
    {
        await ModalInstance.CancelAsync();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProjectDetailService _service { get; set; }
    }
}
#pragma warning restore 1591
