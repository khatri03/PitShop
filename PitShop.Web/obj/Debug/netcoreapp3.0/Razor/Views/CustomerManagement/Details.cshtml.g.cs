#pragma checksum "D:\Sohail\TempProjects\Microservices\PitShopTutorial\PitShop\PitShop.Web\Views\CustomerManagement\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2763d0aaeaf3ec573774c561895162a4f0c1e337"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CustomerManagement_Details), @"mvc.1.0.view", @"/Views/CustomerManagement/Details.cshtml")]
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
#nullable restore
#line 1 "D:\Sohail\TempProjects\Microservices\PitShopTutorial\PitShop\PitShop.Web\Views\_ViewImports.cshtml"
using PitShop.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Sohail\TempProjects\Microservices\PitShopTutorial\PitShop\PitShop.Web\Views\_ViewImports.cshtml"
using PitShop.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2763d0aaeaf3ec573774c561895162a4f0c1e337", @"/Views/CustomerManagement/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9943035425b52967abfda4961eb9ab82561cb0fc", @"/Views/_ViewImports.cshtml")]
    public class Views_CustomerManagement_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PitShop.Web.ViewModels.CustomerManagementDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("BackButton"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CustomerManagement", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#nullable restore
#line 2 "D:\Sohail\TempProjects\Microservices\PitShopTutorial\PitShop\PitShop.Web\Views\CustomerManagement\Details.cshtml"
  
    ViewData["Title"] = "Customer Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3 id=\"PageTitle\">Customer Management - details</h3>\r\n\r\n<table class=\"table\">\r\n    <tbody>\r\n        <tr>\r\n            <td width=\"150\">Name :</td>\r\n            <td><b>");
#nullable restore
#line 11 "D:\Sohail\TempProjects\Microservices\PitShopTutorial\PitShop\PitShop.Web\Views\CustomerManagement\Details.cshtml"
              Write(Model.Customer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n        </tr>\r\n        <tr>\r\n            <td width=\"150\">Address :</td>\r\n            <td><b>");
#nullable restore
#line 15 "D:\Sohail\TempProjects\Microservices\PitShopTutorial\PitShop\PitShop.Web\Views\CustomerManagement\Details.cshtml"
              Write(Model.Customer.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n        </tr>\r\n        <tr>\r\n            <td width=\"150\">City :</td>\r\n            <td><b>");
#nullable restore
#line 19 "D:\Sohail\TempProjects\Microservices\PitShopTutorial\PitShop\PitShop.Web\Views\CustomerManagement\Details.cshtml"
              Write(Model.Customer.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n        </tr>\r\n        <tr>\r\n            <td width=\"150\">Postalcode :</td>\r\n            <td><b>");
#nullable restore
#line 23 "D:\Sohail\TempProjects\Microservices\PitShopTutorial\PitShop\PitShop.Web\Views\CustomerManagement\Details.cshtml"
              Write(Model.Customer.PostalCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n        </tr>\r\n        <tr>\r\n            <td width=\"150\">Telephonenumber :</td>\r\n            <td><b>");
#nullable restore
#line 27 "D:\Sohail\TempProjects\Microservices\PitShopTutorial\PitShop\PitShop.Web\Views\CustomerManagement\Details.cshtml"
              Write(Model.Customer.TelephoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n        </tr>\r\n        <tr>\r\n            <td width=\"150\">Emailaddress :</td>\r\n            <td><b>");
#nullable restore
#line 31 "D:\Sohail\TempProjects\Microservices\PitShopTutorial\PitShop\PitShop.Web\Views\CustomerManagement\Details.cshtml"
              Write(Model.Customer.EmailAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n        </tr>\r\n");
#nullable restore
#line 33 "D:\Sohail\TempProjects\Microservices\PitShopTutorial\PitShop\PitShop.Web\Views\CustomerManagement\Details.cshtml"
         if (Model.Customer.LoyaltyLevel.HasValue)
        {
            string imagePath = $"/images/{Model.Customer.LoyaltyLevel}.png";

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td width=\"150\">LoyaltyLevel :</td>\r\n                <td><img");
            BeginWriteAttribute("src", " src=\"", 1223, "\"", 1239, 1);
#nullable restore
#line 38 "D:\Sohail\TempProjects\Microservices\PitShopTutorial\PitShop\PitShop.Web\Views\CustomerManagement\Details.cshtml"
WriteAttributeValue("", 1229, imagePath, 1229, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n            </tr>\r\n");
#nullable restore
#line 40 "D:\Sohail\TempProjects\Microservices\PitShopTutorial\PitShop\PitShop.Web\Views\CustomerManagement\Details.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<span>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2763d0aaeaf3ec573774c561895162a4f0c1e3378400", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</span>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PitShop.Web.ViewModels.CustomerManagementDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
