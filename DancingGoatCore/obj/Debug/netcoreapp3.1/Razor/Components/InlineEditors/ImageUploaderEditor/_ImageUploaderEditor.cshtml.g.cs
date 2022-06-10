#pragma checksum "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Components\InlineEditors\ImageUploaderEditor\_ImageUploaderEditor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc72cbb3a78f96b90a8e1377cb613b5369eb7d47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Components_InlineEditors_ImageUploaderEditor__ImageUploaderEditor), @"mvc.1.0.view", @"/Components/InlineEditors/ImageUploaderEditor/_ImageUploaderEditor.cshtml")]
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
#line 1 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Components\InlineEditors\ImageUploaderEditor\_ImageUploaderEditor.cshtml"
using DancingGoat.InlineEditors;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc72cbb3a78f96b90a8e1377cb613b5369eb7d47", @"/Components/InlineEditors/ImageUploaderEditor/_ImageUploaderEditor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3dd21c4f465e83903a12d676a1dd0c01e2783b2", @"/Components/_ViewImports.cshtml")]
    #nullable restore
    public class Components_InlineEditors_ImageUploaderEditor__ImageUploaderEditor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ImageUploaderEditorViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Components\InlineEditors\ImageUploaderEditor\_ImageUploaderEditor.cshtml"
  
    string GetContainerClass()
    {
        if (Model.HasImage)
        {
            return "uploader-container";
        }

        return Model.UseAbsolutePosition ? "uploader-empty-container absolute" : "uploader-empty-container";
    }

    string GetMessagePositionClass()
    {
        switch (Model.MessagePosition)
        {
            case PanelPositionEnum.Bottom:
                return "bottom";

            case PanelPositionEnum.Top:
                return "top";

            default:
                return "center";
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 32 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Components\InlineEditors\ImageUploaderEditor\_ImageUploaderEditor.cshtml"
 using (Html.Kentico().BeginInlineEditor("image-uploader-editor",
                                         Model.PropertyName,
                                         new{
                                             @class = "image-uploader-editor",
                                             data_url = Model.DataUrl,
                                             data_file_type = Model.ImageType == ImageTypeEnum.MediaFile ? "media" : "attachment"
                                             }
                                         )
       )
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=\"", 1233, "\"", 1261, 1);
#nullable restore
#line 42 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Components\InlineEditors\ImageUploaderEditor\_ImageUploaderEditor.cshtml"
WriteAttributeValue("", 1241, GetContainerClass(), 1241, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"uploader\">\r\n            <div");
            BeginWriteAttribute("class", " class=\"", 1313, "\"", 1358, 2);
            WriteAttributeValue("", 1321, "dz-message", 1321, 10, true);
#nullable restore
#line 44 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Components\InlineEditors\ImageUploaderEditor\_ImageUploaderEditor.cshtml"
WriteAttributeValue(" ", 1331, GetMessagePositionClass(), 1332, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <i class=\"icon-arrow-up-line\"></i>\r\n                <div>\r\n                    ");
#nullable restore
#line 47 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Components\InlineEditors\ImageUploaderEditor\_ImageUploaderEditor.cshtml"
                Write(Model.ImageType == ImageTypeEnum.MediaFile ? 
                        HtmlLocalizer["Drop image to <a class=\"dz-clickable\">upload</a> or <a class=\"dialog-link\">browse</a> media library"] : 
                        HtmlLocalizer["Drop image here or <a class=\"dz-clickable\">click</a> to browse"]
                     );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 55 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Components\InlineEditors\ImageUploaderEditor\_ImageUploaderEditor.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ImageUploaderEditorViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
