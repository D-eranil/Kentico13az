#pragma checksum "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Components\Widgets\CardWidget\_CardWidget.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fad7acc359cf91fb298497a5630df6d8c46423bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Components_Widgets_CardWidget__CardWidget), @"mvc.1.0.view", @"/Components/Widgets/CardWidget/_CardWidget.cshtml")]
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
#line 1 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Components\Widgets\CardWidget\_CardWidget.cshtml"
using DancingGoat.InlineEditors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Components\Widgets\CardWidget\_CardWidget.cshtml"
using DancingGoat.Widgets;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fad7acc359cf91fb298497a5630df6d8c46423bb", @"/Components/Widgets/CardWidget/_CardWidget.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3dd21c4f465e83903a12d676a1dd0c01e2783b2", @"/Components/_ViewImports.cshtml")]
    #nullable restore
    public class Components_Widgets_CardWidget__CardWidget : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DancingGoat.Widgets.CardWidgetViewModel>
    #nullable disable
    {
        private global::AspNetCore.Components_Widgets_CardWidget__CardWidget.__Generated__ImageUploaderViewComponentTagHelper __ImageUploaderViewComponentTagHelper;
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Components/InlineEditors/TextEditor/_TextEditor.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Components\Widgets\CardWidget\_CardWidget.cshtml"
  
    string styleAttribute = null;
    if (!string.IsNullOrEmpty(Model.ImagePath))
    {
        styleAttribute = $"style=\"background-image: url('{Url.Content(Model.ImagePath)}');\"";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Components\Widgets\CardWidget\_CardWidget.cshtml"
 if (Context.Kentico().PageBuilder().EditMode)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:image-uploader", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fad7acc359cf91fb298497a5630df6d8c46423bb5658", async() => {
            }
            );
            __ImageUploaderViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Components_Widgets_CardWidget__CardWidget.__Generated__ImageUploaderViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__ImageUploaderViewComponentTagHelper);
#nullable restore
#line 16 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Components\Widgets\CardWidget\_CardWidget.cshtml"
__ImageUploaderViewComponentTagHelper.imageType = ImageTypeEnum.MediaFile;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("image-type", __ImageUploaderViewComponentTagHelper.imageType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 16 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Components\Widgets\CardWidget\_CardWidget.cshtml"
                                                                WriteLiteral(nameof(CardWidgetProperties.Image));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __ImageUploaderViewComponentTagHelper.propertyName = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("property-name", __ImageUploaderViewComponentTagHelper.propertyName, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 17 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Components\Widgets\CardWidget\_CardWidget.cshtml"
__ImageUploaderViewComponentTagHelper.hasImage = (Model.ImagePath != null);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("has-image", __ImageUploaderViewComponentTagHelper.hasImage, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 17 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Components\Widgets\CardWidget\_CardWidget.cshtml"
__ImageUploaderViewComponentTagHelper.messagePosition = PanelPositionEnum.Top;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("message-position", __ImageUploaderViewComponentTagHelper.messagePosition, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 18 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Components\Widgets\CardWidget\_CardWidget.cshtml"
__ImageUploaderViewComponentTagHelper.useAbsolutePosition = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("use-absolute-position", __ImageUploaderViewComponentTagHelper.useAbsolutePosition, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 19 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Components\Widgets\CardWidget\_CardWidget.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card-body\">\r\n    <section class=\"card-section\" ");
#nullable restore
#line 21 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Components\Widgets\CardWidget\_CardWidget.cshtml"
                             Write(Html.Raw(styleAttribute));

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n        <div class=\"card-text\">\r\n");
#nullable restore
#line 23 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Components\Widgets\CardWidget\_CardWidget.cshtml"
             if (Context.Kentico().PageBuilder().EditMode)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fad7acc359cf91fb298497a5630df6d8c46423bb10093", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 26 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Components\Widgets\CardWidget\_CardWidget.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = new TextEditorViewModel
                                {
                                    PropertyName = nameof(CardWidgetProperties.Text),
                                    Text = Model.Text,
                                };

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 31 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Components\Widgets\CardWidget\_CardWidget.cshtml"
            }
            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Components\Widgets\CardWidget\_CardWidget.cshtml"
           Write(Model.Text);

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\inetpub\wwwroot\Kentico13az\DancingGoatCore\Components\Widgets\CardWidget\_CardWidget.cshtml"
                           
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </section>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DancingGoat.Widgets.CardWidgetViewModel> Html { get; private set; } = default!;
        #nullable disable
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:image-uploader")]
        public class __Generated__ImageUploaderViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__ImageUploaderViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public System.String propertyName { get; set; }
            public System.Boolean hasImage { get; set; }
            public DancingGoat.InlineEditors.ImageTypeEnum imageType { get; set; }
            public System.Boolean useAbsolutePosition { get; set; }
            public DancingGoat.InlineEditors.PanelPositionEnum messagePosition { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("ImageUploader", ProcessInvokeAsyncArgs(__context));
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
            private Dictionary<string, object> ProcessInvokeAsyncArgs(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context)
            {
                Dictionary<string, object> args = new Dictionary<string, object>();
                if (__context.AllAttributes.ContainsName("property-name"))
                {
                    args[nameof(propertyName)] = propertyName;
                }
                if (__context.AllAttributes.ContainsName("has-image"))
                {
                    args[nameof(hasImage)] = hasImage;
                }
                if (__context.AllAttributes.ContainsName("image-type"))
                {
                    args[nameof(imageType)] = imageType;
                }
                if (__context.AllAttributes.ContainsName("use-absolute-position"))
                {
                    args[nameof(useAbsolutePosition)] = useAbsolutePosition;
                }
                if (__context.AllAttributes.ContainsName("message-position"))
                {
                    args[nameof(messagePosition)] = messagePosition;
                }
                return args;
            }
        }
    }
}
#pragma warning restore 1591
