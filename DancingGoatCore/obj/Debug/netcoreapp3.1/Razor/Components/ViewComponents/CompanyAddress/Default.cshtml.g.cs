#pragma checksum "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Components\ViewComponents\CompanyAddress\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2f084d2542e8bd2da89ac293c431dc574ba5f08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Components_ViewComponents_CompanyAddress_Default), @"mvc.1.0.view", @"/Components/ViewComponents/CompanyAddress/Default.cshtml")]
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
#line 1 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Components\_ViewImports.cshtml"
using DancingGoat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Components\_ViewImports.cshtml"
using CMS.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Components\_ViewImports.cshtml"
using Kentico.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Components\_ViewImports.cshtml"
using Kentico.Content.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Components\_ViewImports.cshtml"
using Kentico.PageBuilder.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Components\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Components\ViewComponents\CompanyAddress\Default.cshtml"
using System.Web;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2f084d2542e8bd2da89ac293c431dc574ba5f08", @"/Components/ViewComponents/CompanyAddress/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3dd21c4f465e83903a12d676a1dd0c01e2783b2", @"/Components/_ViewImports.cshtml")]
    #nullable restore
    public class Components_ViewComponents_CompanyAddress_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DancingGoat.Models.ContactViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<address>\r\n    ");
#nullable restore
#line 6 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Components\ViewComponents\CompanyAddress\Default.cshtml"
Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 108, "\"", 167, 2);
            WriteAttributeValue("", 115, "mailto:", 115, 7, true);
#nullable restore
#line 7 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Components\ViewComponents\CompanyAddress\Default.cshtml"
WriteAttributeValue("", 122, HttpUtility.HtmlAttributeEncode(Model.Email), 122, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 7 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Components\ViewComponents\CompanyAddress\Default.cshtml"
                                                              Write(HttpUtility.HtmlEncode(Model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><br />\r\n    ");
#nullable restore
#line 8 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Components\ViewComponents\CompanyAddress\Default.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br /><br />\r\n    ");
#nullable restore
#line 9 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Components\ViewComponents\CompanyAddress\Default.cshtml"
Write(Model.Street);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 9 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Components\ViewComponents\CompanyAddress\Default.cshtml"
             Write(Model.City);

#line default
#line hidden
#nullable disable
            WriteLiteral(",<br />\r\n    ");
#nullable restore
#line 10 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Components\ViewComponents\CompanyAddress\Default.cshtml"
Write(Model.StateCode);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 10 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Components\ViewComponents\CompanyAddress\Default.cshtml"
                Write(Model.ZIP);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 10 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Components\ViewComponents\CompanyAddress\Default.cshtml"
                            Write(Model.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</address>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DancingGoat.Models.ContactViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
