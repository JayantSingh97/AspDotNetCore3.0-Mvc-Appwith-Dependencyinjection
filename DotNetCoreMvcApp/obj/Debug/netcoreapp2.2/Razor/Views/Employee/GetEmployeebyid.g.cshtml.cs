#pragma checksum "C:\Users\ADMOBS\source\repos\DotNetCoreMvcApp\Views\Employee\GetEmployeebyid.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d85fec766a2239e87c78efd879b8976ad3886e91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_GetEmployeebyid), @"mvc.1.0.view", @"/Views/Employee/GetEmployeebyid.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/GetEmployeebyid.cshtml", typeof(AspNetCore.Views_Employee_GetEmployeebyid))]
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
#line 1 "C:\Users\ADMOBS\source\repos\DotNetCoreMvcApp\Views\_ViewImports.cshtml"
using DotNetCoreMvcApp;

#line default
#line hidden
#line 2 "C:\Users\ADMOBS\source\repos\DotNetCoreMvcApp\Views\_ViewImports.cshtml"
using DotNetCoreMvcApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d85fec766a2239e87c78efd879b8976ad3886e91", @"/Views/Employee/GetEmployeebyid.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06017a04a81e7d1ab41b3a4de91e9a7f4c472739", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_GetEmployeebyid : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DotNetCoreMvcApp.Models.EmployeeModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EmployeeBoard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn  btn-sm btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ADMOBS\source\repos\DotNetCoreMvcApp\Views\Employee\GetEmployeebyid.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(91, 87, true);
            WriteLiteral("\r\n\r\n<div style=\"border:2px solid whitesmoke;text-align:center;padding:20px;\">\r\n    <h4>");
            EndContext();
            BeginContext(179, 15, false);
#line 9 "C:\Users\ADMOBS\source\repos\DotNetCoreMvcApp\Views\Employee\GetEmployeebyid.cshtml"
   Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(194, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(196, 14, false);
#line 9 "C:\Users\ADMOBS\source\repos\DotNetCoreMvcApp\Views\Employee\GetEmployeebyid.cshtml"
                    Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(210, 120, true);
            WriteLiteral("  information.</h4>\r\n    <hr />\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            <img class=\"card-img-top\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 330, "\"", 364, 1);
#line 13 "C:\Users\ADMOBS\source\repos\DotNetCoreMvcApp\Views\Employee\GetEmployeebyid.cshtml"
WriteAttributeValue("", 336, Model.ProfileUrl.ToString(), 336, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(365, 168, true);
            WriteLiteral(" alt=\"Card image cap\" style=\"width: 203px; height: 209px;\" />\r\n        </div>\r\n    </div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(534, 46, false);
#line 19 "C:\Users\ADMOBS\source\repos\DotNetCoreMvcApp\Views\Employee\GetEmployeebyid.cshtml"
       Write(Html.DisplayNameFor(model => model.EmployeeId));

#line default
#line hidden
            EndContext();
            BeginContext(580, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(641, 42, false);
#line 22 "C:\Users\ADMOBS\source\repos\DotNetCoreMvcApp\Views\Employee\GetEmployeebyid.cshtml"
       Write(Html.DisplayFor(model => model.EmployeeId));

#line default
#line hidden
            EndContext();
            BeginContext(683, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(744, 45, false);
#line 25 "C:\Users\ADMOBS\source\repos\DotNetCoreMvcApp\Views\Employee\GetEmployeebyid.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(789, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(850, 41, false);
#line 28 "C:\Users\ADMOBS\source\repos\DotNetCoreMvcApp\Views\Employee\GetEmployeebyid.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(891, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(952, 44, false);
#line 31 "C:\Users\ADMOBS\source\repos\DotNetCoreMvcApp\Views\Employee\GetEmployeebyid.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(996, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1057, 40, false);
#line 34 "C:\Users\ADMOBS\source\repos\DotNetCoreMvcApp\Views\Employee\GetEmployeebyid.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1097, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1158, 39, false);
#line 37 "C:\Users\ADMOBS\source\repos\DotNetCoreMvcApp\Views\Employee\GetEmployeebyid.cshtml"
       Write(Html.DisplayNameFor(model => model.DOB));

#line default
#line hidden
            EndContext();
            BeginContext(1197, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1258, 35, false);
#line 40 "C:\Users\ADMOBS\source\repos\DotNetCoreMvcApp\Views\Employee\GetEmployeebyid.cshtml"
       Write(Html.DisplayFor(model => model.DOB));

#line default
#line hidden
            EndContext();
            BeginContext(1293, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1354, 43, false);
#line 43 "C:\Users\ADMOBS\source\repos\DotNetCoreMvcApp\Views\Employee\GetEmployeebyid.cshtml"
       Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
            EndContext();
            BeginContext(1397, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1458, 39, false);
#line 46 "C:\Users\ADMOBS\source\repos\DotNetCoreMvcApp\Views\Employee\GetEmployeebyid.cshtml"
       Write(Html.DisplayFor(model => model.Country));

#line default
#line hidden
            EndContext();
            BeginContext(1497, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1558, 46, false);
#line 49 "C:\Users\ADMOBS\source\repos\DotNetCoreMvcApp\Views\Employee\GetEmployeebyid.cshtml"
       Write(Html.DisplayNameFor(model => model.Department));

#line default
#line hidden
            EndContext();
            BeginContext(1604, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1665, 42, false);
#line 52 "C:\Users\ADMOBS\source\repos\DotNetCoreMvcApp\Views\Employee\GetEmployeebyid.cshtml"
       Write(Html.DisplayFor(model => model.Department));

#line default
#line hidden
            EndContext();
            BeginContext(1707, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1768, 41, false);
#line 55 "C:\Users\ADMOBS\source\repos\DotNetCoreMvcApp\Views\Employee\GetEmployeebyid.cshtml"
       Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1809, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1870, 37, false);
#line 58 "C:\Users\ADMOBS\source\repos\DotNetCoreMvcApp\Views\Employee\GetEmployeebyid.cshtml"
       Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1907, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1968, 46, false);
#line 61 "C:\Users\ADMOBS\source\repos\DotNetCoreMvcApp\Views\Employee\GetEmployeebyid.cshtml"
       Write(Html.DisplayNameFor(model => model.ProfileUrl));

#line default
#line hidden
            EndContext();
            BeginContext(2014, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2075, 42, false);
#line 64 "C:\Users\ADMOBS\source\repos\DotNetCoreMvcApp\Views\Employee\GetEmployeebyid.cshtml"
       Write(Html.DisplayFor(model => model.ProfileUrl));

#line default
#line hidden
            EndContext();
            BeginContext(2117, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2178, 41, false);
#line 67 "C:\Users\ADMOBS\source\repos\DotNetCoreMvcApp\Views\Employee\GetEmployeebyid.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2219, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2280, 37, false);
#line 70 "C:\Users\ADMOBS\source\repos\DotNetCoreMvcApp\Views\Employee\GetEmployeebyid.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2317, 59, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <hr />\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(2376, 116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d85fec766a2239e87c78efd879b8976ad3886e9113366", async() => {
                BeginContext(2443, 45, true);
                WriteLiteral("<span class=\"fa fa-home\"></span>Cancel Action");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2492, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(2503, 131, false);
#line 76 "C:\Users\ADMOBS\source\repos\DotNetCoreMvcApp\Views\Employee\GetEmployeebyid.cshtml"
   Write(Html.ActionLink("Edit Employee ", "EditEmployee", new { id = Model.EmployeeId }, new { @class = "btn btn-sm btn-outline-success" }));

#line default
#line hidden
            EndContext();
            BeginContext(2634, 28, true);
            WriteLiteral("\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DotNetCoreMvcApp.Models.EmployeeModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
