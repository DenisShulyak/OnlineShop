#pragma checksum "C:\Users\ШулякД\source\repos\OnlineShop\OnlineShop\Views\Admin\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fc5425a31349111819a98bbeba338935fd82432"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Create), @"mvc.1.0.view", @"/Views/Admin/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fc5425a31349111819a98bbeba338935fd82432", @"/Views/Admin/Create.cshtml")]
    public class Views_Admin_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineShop.Domans.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ШулякД\source\repos\OnlineShop\OnlineShop\Views\Admin\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>User</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""PhoneNumber"" class=""control-label""></label>
                <input asp-for=""PhoneNumber"" class=""form-control"" />
                <span asp-validation-for=""PhoneNumber"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""VerificationCode"" class=""control-label""></label>
                <input asp-for=""VerificationCode"" class=""form-control"" />
                <span asp-validation-for=""VerificationCode"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""FullName"" class=""control-label""></label>
                <input asp-for=""FullName"" class=""form-control"" />
                <span asp-validation-for=""Ful");
            WriteLiteral(@"lName"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""NotificationDeviceId"" class=""control-label""></label>
                <input asp-for=""NotificationDeviceId"" class=""form-control"" />
                <span asp-validation-for=""NotificationDeviceId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CreationDate"" class=""control-label""></label>
                <input asp-for=""CreationDate"" class=""form-control"" />
                <span asp-validation-for=""CreationDate"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""DeletedDate"" class=""control-label""></label>
                <input asp-for=""DeletedDate"" class=""form-control"" />
                <span asp-validation-for=""DeletedDate"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""subm");
            WriteLiteral("it\" value=\"Create\" class=\"btn btn-primary\" />\r\n            </div>\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 57 "C:\Users\ШулякД\source\repos\OnlineShop\OnlineShop\Views\Admin\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineShop.Domans.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
