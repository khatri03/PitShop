#pragma checksum "D:\Sohail\TempProjects\Microservices\PitShopTutorial\PitShop\PitShop.Web\Views\WorkshopManagement\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11f7e7dff949cfc7d7bb1386a5f8dc837a72eb77"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WorkshopManagement_Details), @"mvc.1.0.view", @"/Views/WorkshopManagement/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11f7e7dff949cfc7d7bb1386a5f8dc837a72eb77", @"/Views/WorkshopManagement/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9943035425b52967abfda4961eb9ab82561cb0fc", @"/Views/_ViewImports.cshtml")]
    public class Views_WorkshopManagement_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PitShop.Web.ViewModels.WorkshopManagementDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("BackButton"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "WorkshopManagement", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("CompleteButton"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Finish", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Sohail\TempProjects\Microservices\PitShopTutorial\PitShop\PitShop.Web\Views\WorkshopManagement\Details.cshtml"
  
    ViewData["Title"] = "Planning Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3 id=\"PageTitle\">Workshop Management - details</h3>\r\n\r\n<table class=\"table\">\r\n    <tbody>\r\n        <tr>\r\n            <td width=\"150\">Date :</td>\r\n            <td><b>");
#nullable restore
#line 12 "D:\Sohail\TempProjects\Microservices\PitShopTutorial\PitShop\PitShop.Web\Views\WorkshopManagement\Details.cshtml"
              Write(Model.Date.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n        </tr>\r\n        <tr>\r\n            <td width=\"150\">Status :</td>\r\n            <td id=\"JobStatus\"><b>");
#nullable restore
#line 16 "D:\Sohail\TempProjects\Microservices\PitShopTutorial\PitShop\PitShop.Web\Views\WorkshopManagement\Details.cshtml"
                             Write(Model.MaintenanceJob.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n        </tr>\r\n        <tr>\r\n            <td width=\"150\">Start time :</td>\r\n            <td><b>");
#nullable restore
#line 20 "D:\Sohail\TempProjects\Microservices\PitShopTutorial\PitShop\PitShop.Web\Views\WorkshopManagement\Details.cshtml"
              Write(Model.MaintenanceJob.StartTime.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n        </tr>\r\n        <tr>\r\n            <td width=\"150\">End time :</td>\r\n            <td><b>");
#nullable restore
#line 24 "D:\Sohail\TempProjects\Microservices\PitShopTutorial\PitShop\PitShop.Web\Views\WorkshopManagement\Details.cshtml"
              Write(Model.MaintenanceJob.EndTime.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n        </tr>\r\n        <tr>\r\n            <td width=\"150\">Description :</td>\r\n            <td><b>");
#nullable restore
#line 28 "D:\Sohail\TempProjects\Microservices\PitShopTutorial\PitShop\PitShop.Web\Views\WorkshopManagement\Details.cshtml"
              Write(Model.MaintenanceJob.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n        </tr>\r\n        <tr>\r\n            <td width=\"150\">Vehicle :</td>\r\n            <td><b><a");
            BeginWriteAttribute("href", " href=\'", 1017, "\'", 1137, 1);
#nullable restore
#line 32 "D:\Sohail\TempProjects\Microservices\PitShopTutorial\PitShop\PitShop.Web\Views\WorkshopManagement\Details.cshtml"
WriteAttributeValue("", 1024, Url.Action("Details", "VehicleManagement", new { licenseNumber = Model.MaintenanceJob.Vehicle.LicenseNumber }), 1024, 113, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 32 "D:\Sohail\TempProjects\Microservices\PitShopTutorial\PitShop\PitShop.Web\Views\WorkshopManagement\Details.cshtml"
                                                                                                                                          Write(Model.MaintenanceJob.Vehicle.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 32 "D:\Sohail\TempProjects\Microservices\PitShopTutorial\PitShop\PitShop.Web\Views\WorkshopManagement\Details.cshtml"
                                                                                                                                                                              Write(Model.MaintenanceJob.Vehicle.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral(" [");
#nullable restore
#line 32 "D:\Sohail\TempProjects\Microservices\PitShopTutorial\PitShop\PitShop.Web\Views\WorkshopManagement\Details.cshtml"
                                                                                                                                                                                                                  Write(Model.MaintenanceJob.Vehicle.LicenseNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("]</a></b></td>\r\n        </tr>\r\n        <tr>\r\n            <td width=\"150\">Owner :</td>\r\n            <td><b><a");
            BeginWriteAttribute("href", " href=\'", 1362, "\'", 1470, 1);
#nullable restore
#line 36 "D:\Sohail\TempProjects\Microservices\PitShopTutorial\PitShop\PitShop.Web\Views\WorkshopManagement\Details.cshtml"
WriteAttributeValue("", 1369, Url.Action("Details", "CustomerManagement", new { id = Model.MaintenanceJob.Customer.CustomerId }), 1369, 101, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 36 "D:\Sohail\TempProjects\Microservices\PitShopTutorial\PitShop\PitShop.Web\Views\WorkshopManagement\Details.cshtml"
                                                                                                                              Write(Model.MaintenanceJob.Customer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" [");
#nullable restore
#line 36 "D:\Sohail\TempProjects\Microservices\PitShopTutorial\PitShop\PitShop.Web\Views\WorkshopManagement\Details.cshtml"
                                                                                                                                                                   Write(Model.MaintenanceJob.Customer.TelephoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("]</a></b></td>\r\n        </tr>\r\n");
#nullable restore
#line 38 "D:\Sohail\TempProjects\Microservices\PitShopTutorial\PitShop\PitShop.Web\Views\WorkshopManagement\Details.cshtml"
         if (Model.MaintenanceJob.Status != "Planned")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td width=\"150\">Actual Start time :</td>\r\n                <td><b>");
#nullable restore
#line 42 "D:\Sohail\TempProjects\Microservices\PitShopTutorial\PitShop\PitShop.Web\Views\WorkshopManagement\Details.cshtml"
                  Write(Model.MaintenanceJob.ActualStartTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n            </tr>\r\n            <tr>\r\n                <td width=\"150\">Actual End time :</td>\r\n                <td><b>");
#nullable restore
#line 46 "D:\Sohail\TempProjects\Microservices\PitShopTutorial\PitShop\PitShop.Web\Views\WorkshopManagement\Details.cshtml"
                  Write(Model.MaintenanceJob.ActualEndTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n            </tr>\r\n            <tr>\r\n                <td width=\"150\">Mechanic notes :</td>\r\n                <td><b>");
#nullable restore
#line 50 "D:\Sohail\TempProjects\Microservices\PitShopTutorial\PitShop\PitShop.Web\Views\WorkshopManagement\Details.cshtml"
                  Write(Model.MaintenanceJob.Notes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n            </tr>\r\n");
#nullable restore
#line 52 "D:\Sohail\TempProjects\Microservices\PitShopTutorial\PitShop\PitShop.Web\Views\WorkshopManagement\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<span>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11f7e7dff949cfc7d7bb1386a5f8dc837a72eb7712828", async() => {
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
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-planningDate", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "D:\Sohail\TempProjects\Microservices\PitShopTutorial\PitShop\PitShop.Web\Views\WorkshopManagement\Details.cshtml"
                                                                                            WriteLiteral(Model.Date.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["planningDate"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-planningDate", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["planningDate"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</span>\r\n");
#nullable restore
#line 56 "D:\Sohail\TempProjects\Microservices\PitShopTutorial\PitShop\PitShop.Web\Views\WorkshopManagement\Details.cshtml"
 if (Model.MaintenanceJob.Status != "Completed")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11f7e7dff949cfc7d7bb1386a5f8dc837a72eb7715795", async() => {
                WriteLiteral("Complete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-planningDate", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "D:\Sohail\TempProjects\Microservices\PitShopTutorial\PitShop\PitShop.Web\Views\WorkshopManagement\Details.cshtml"
                                                                                                     WriteLiteral(Model.Date.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["planningDate"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-planningDate", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["planningDate"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "D:\Sohail\TempProjects\Microservices\PitShopTutorial\PitShop\PitShop.Web\Views\WorkshopManagement\Details.cshtml"
                                                                                                                                                          WriteLiteral(Model.MaintenanceJob.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["jobId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-jobId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["jobId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</span>\r\n");
#nullable restore
#line 59 "D:\Sohail\TempProjects\Microservices\PitShopTutorial\PitShop\PitShop.Web\Views\WorkshopManagement\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PitShop.Web.ViewModels.WorkshopManagementDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
