#pragma checksum "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Views\Contacts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c0b241a7df2937603ab020e2fa4d28b45734ab0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contacts_Index), @"mvc.1.0.view", @"/Views/Contacts/Index.cshtml")]
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
#line 1 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Views\_ViewImports.cshtml"
using DancingGoat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Views\_ViewImports.cshtml"
using CMS.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Views\_ViewImports.cshtml"
using Kentico.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Views\_ViewImports.cshtml"
using Kentico.Content.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Views\_ViewImports.cshtml"
using Kentico.PageBuilder.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c0b241a7df2937603ab020e2fa4d28b45734ab0", @"/Views/Contacts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88d8fa80da67568a3e522497460b5cdcd2065f73", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Contacts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DancingGoat.Models.ContactsIndexViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_GoogleMaps", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("area-identifier", "ContactUs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::DancingGoat.Helpers.EmailTagHelper __DancingGoat_Helpers_EmailTagHelper;
        private global::Kentico.Content.Web.Mvc.EditableAreaTagHelper __Kentico_Content_Web_Mvc_EditableAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Views\Contacts\Index.cshtml"
  
    ViewBag.Title = HtmlLocalizer["Contacts"].Value;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1c0b241a7df2937603ab020e2fa4d28b45734ab05060", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n<div class=\"contacts-page\">\r\n    <div class=\"col-md-12\">\r\n        <div class=\"col-md-6\">\r\n            <h2 class=\"contact-title\">");
#nullable restore
#line 14 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Views\Contacts\Index.cshtml"
                                 Write(HtmlLocalizer["Roastery"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <ul class=\"contact-info\">\r\n                <li>");
#nullable restore
#line 16 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Views\Contacts\Index.cshtml"
               Write(Model.CompanyContact.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("email", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1c0b241a7df2937603ab020e2fa4d28b45734ab07058", async() => {
            }
            );
            __DancingGoat_Helpers_EmailTagHelper = CreateTagHelper<global::DancingGoat.Helpers.EmailTagHelper>();
            __tagHelperExecutionContext.Add(__DancingGoat_Helpers_EmailTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 18 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Views\Contacts\Index.cshtml"
                        WriteLiteral(Model.CompanyContact.Email);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __DancingGoat_Helpers_EmailTagHelper.Address = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("address", __DancingGoat_Helpers_EmailTagHelper.Address, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </li>\r\n                <li>\r\n                    <a href=\"javascript:void(0)\" data-address=\"");
#nullable restore
#line 21 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Views\Contacts\Index.cshtml"
                                                          Write(Model.CompanyContact.City);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 21 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Views\Contacts\Index.cshtml"
                                                                                      Write(Model.CompanyContact.Street);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"js-scroll-to-map\">\r\n                        ");
#nullable restore
#line 22 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Views\Contacts\Index.cshtml"
                   Write(Model.CompanyContact.Street);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 22 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Views\Contacts\Index.cshtml"
                                                Write(Model.CompanyContact.City);

#line default
#line hidden
#nullable disable
            WriteLiteral(",<br />\r\n                        ");
#nullable restore
#line 23 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Views\Contacts\Index.cshtml"
                   Write(Model.CompanyContact.ZIP);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 23 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Views\Contacts\Index.cshtml"
                                              Write(Model.CompanyContact.CountryCode);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 23 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Views\Contacts\Index.cshtml"
                                                                                 Write(Model.CompanyContact.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    </a>\r\n                </li>\r\n            </ul>\r\n        </div>\r\n\r\n        <div class=\"col-md-6\">\r\n            <h2>");
#nullable restore
#line 30 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Views\Contacts\Index.cshtml"
           Write(HtmlLocalizer["Send us a message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n            <div id=\"message-form\" class=\"contact-us-form\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("editable-area", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1c0b241a7df2937603ab020e2fa4d28b45734ab011187", async() => {
            }
            );
            __Kentico_Content_Web_Mvc_EditableAreaTagHelper = CreateTagHelper<global::Kentico.Content.Web.Mvc.EditableAreaTagHelper>();
            __tagHelperExecutionContext.Add(__Kentico_Content_Web_Mvc_EditableAreaTagHelper);
            __Kentico_Content_Web_Mvc_EditableAreaTagHelper.AreaIdentifier = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 33 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Views\Contacts\Index.cshtml"
__Kentico_Content_Web_Mvc_EditableAreaTagHelper.AreaOptionsAllowedWidgets = new[] { SystemComponentIdentifiers.FORM_WIDGET_IDENTIFIER };

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("area-options-allowed-widgets", __Kentico_Content_Web_Mvc_EditableAreaTagHelper.AreaOptionsAllowedWidgets, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row\"><h2>");
#nullable restore
#line 38 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Views\Contacts\Index.cshtml"
                    Write(HtmlLocalizer["Our cafes"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2></div>\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 40 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Views\Contacts\Index.cshtml"
         foreach (var cafe in @Model.CompanyCafes)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-6 col-lg-3\">\r\n                <div class=\"cafe-tile cursor-hand js-scroll-to-map\" data-address=\"");
#nullable restore
#line 43 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Views\Contacts\Index.cshtml"
                                                                             Write(cafe.City);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 43 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Views\Contacts\Index.cshtml"
                                                                                         Write(cafe.Street);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                    <div class=\"cafe-tile-content\">\r\n                        <h3 class=\"cafe-tile-name\">");
#nullable restore
#line 45 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Views\Contacts\Index.cshtml"
                                              Write(cafe.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <address class=\"cafe-tile-address\">\r\n                            <a href=\"javascript:void(0)\" class=\"cafe-tile-address-anchor\">\r\n                                ");
#nullable restore
#line 48 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Views\Contacts\Index.cshtml"
                           Write(cafe.Street);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 48 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Views\Contacts\Index.cshtml"
                                         Write(cafe.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                                ");
#nullable restore
#line 49 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Views\Contacts\Index.cshtml"
                           Write(cafe.ZIP);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 49 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Views\Contacts\Index.cshtml"
                                      Write(cafe.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 49 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Views\Contacts\Index.cshtml"
                                                     Write(cafe.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </a>\r\n                        </address>\r\n                        <p class=\"cafe-tile-phone\">");
#nullable restore
#line 52 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Views\Contacts\Index.cshtml"
                                              Write(cafe.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 56 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Views\Contacts\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n    <h2 class=\"map-title\">");
#nullable restore
#line 59 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Views\Contacts\Index.cshtml"
                     Write(HtmlLocalizer["Drop in"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <div class=\"map js-map\"></div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHtmlLocalizer<SharedResources> HtmlLocalizer { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DancingGoat.Models.ContactsIndexViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
