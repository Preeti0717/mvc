#pragma checksum "D:\WebApplication1\Views\Event\CreateEvent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "480ffffda2e207419575a5d3a92f1a47c9d264fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_CreateEvent), @"mvc.1.0.view", @"/Views/Event/CreateEvent.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"480ffffda2e207419575a5d3a92f1a47c9d264fa", @"/Views/Event/CreateEvent.cshtml")]
    public class Views_Event_CreateEvent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.EventModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <br />\r\n    <h3>Create Event</h3>\r\n    <hr />\r\n");
#nullable restore
#line 8 "D:\WebApplication1\Views\Event\CreateEvent.cshtml"
     if (ViewBag.IsSuccess)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""alert alert-success alert-dismissible fade show"" role=""alert"">
            <strong>Congratulations!</strong> You have successfully created a new event.
            <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
                <span aria-hidden=""true"">&times;</span>
            </button>
        </div>
");
#nullable restore
#line 16 "D:\WebApplication1\Views\Event\CreateEvent.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<form method=\"post\" asp-action=\"GetEvents\" asp-controller=\"Event\">\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 21 "D:\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.LabelFor(m => m.Title, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 22 "D:\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.TextBoxFor(m => m.Title, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 23 "D:\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.ValidationMessageFor(m => m.Title, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 27 "D:\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.LabelFor(m => m.Email, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 28 "D:\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.TextBoxFor(m => m.Email, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 29 "D:\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.ValidationMessageFor(m => m.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n\r\n        ");
#nullable restore
#line 34 "D:\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.LabelFor(m => m.Date, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 35 "D:\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.TextBoxFor(m => m.Date, String.Format("0:dd/MM/yyyy"), new { @class = "form-control", type = "Date" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 36 "D:\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.ValidationMessageFor(m => m.Date, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 40 "D:\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.LabelFor(m => m.Location, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 41 "D:\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.TextBoxFor(m => m.Location, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 42 "D:\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.ValidationMessageFor(m => m.Location, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 46 "D:\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.LabelFor(m => m.Starttime, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 47 "D:\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.TextBoxFor(m => m.Starttime, new { @class = "form-control", type = "Time" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 48 "D:\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.ValidationMessageFor(m => m.Starttime, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 52 "D:\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.LabelFor(m => m.Type, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 53 "D:\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.DropDownList("Type", new List<SelectListItem> {
                new SelectListItem {Text="Public"},
                new SelectListItem {Text="Private"}
                }, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 60 "D:\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.LabelFor(m => m.Duration, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 61 "D:\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.DropDownList("Duration", new List<SelectListItem> {
                new SelectListItem {Text="1"},
                new SelectListItem {Text="2"},
                new SelectListItem {Text="3"},
                new SelectListItem {Text="4"}
                }, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 70 "D:\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.LabelFor(model => model.Invitations, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 71 "D:\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.EditorFor(model => model.Invitations, new { htmlAttributes = new { @class = "form-control", placeholder = "Write emails separated by comma" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 72 "D:\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.ValidationMessageFor(model => model.Invitations, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 76 "D:\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.LabelFor(m => m.Description, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 77 "D:\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.TextAreaFor(m => m.Description, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 78 "D:\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.ValidationMessageFor(m => m.Details, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 82 "D:\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.LabelFor(m => m.Details, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 83 "D:\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.TextAreaFor(m => m.Details, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 84 "D:\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.ValidationMessageFor(m => m.Details, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <button class=\"btn btn-primary\" type=\"submit\"> Add Event</button>\r\n    </div>\r\n</form>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Models.EventModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
