#pragma checksum "C:\Users\avtar\Desktop\sem 3\mainframe\GeorgianComputers-master\GeorgianComputers-master\Views\Shop\Browse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4efab6a09c3138903327cdf838d7dfb06ffa5275"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Browse), @"mvc.1.0.view", @"/Views/Shop/Browse.cshtml")]
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
#line 1 "C:\Users\avtar\Desktop\sem 3\mainframe\GeorgianComputers-master\GeorgianComputers-master\Views\_ViewImports.cshtml"
using GeorgianComputers;

#line default
#line hidden
#line 2 "C:\Users\avtar\Desktop\sem 3\mainframe\GeorgianComputers-master\GeorgianComputers-master\Views\_ViewImports.cshtml"
using GeorgianComputers.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4efab6a09c3138903327cdf838d7dfb06ffa5275", @"/Views/Shop/Browse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f34524f94331e4341127539333c3c7a791ddcf97", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Browse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GeorgianComputers.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#line 3 "C:\Users\avtar\Desktop\sem 3\mainframe\GeorgianComputers-master\GeorgianComputers-master\Views\Shop\Browse.cshtml"
  
    ViewData["Title"] = "our product collection";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            WriteLiteral("\r\n<h1>Shop from our ");
#line 8 "C:\Users\avtar\Desktop\sem 3\mainframe\GeorgianComputers-master\GeorgianComputers-master\Views\Shop\Browse.cshtml"
             Write(ViewBag.Category);

#line default
#line hidden
            WriteLiteral("</h1>\r\n\r\n<section>\r\n    <div class=\"row\">\r\n");
#line 12 "C:\Users\avtar\Desktop\sem 3\mainframe\GeorgianComputers-master\GeorgianComputers-master\Views\Shop\Browse.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            WriteLiteral("            <div class=\"col-sm-6 col-lg-4 mb-3\">\r\n                <div class=\"card mb-3 text-center h-100\">\r\n                    <div class=\"card-body\" >\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4efab6a09c3138903327cdf838d7dfb06ffa52754777", async() => {
#line 17 "C:\Users\avtar\Desktop\sem 3\mainframe\GeorgianComputers-master\GeorgianComputers-master\Views\Shop\Browse.cshtml"
                                                                                                       Write(item.Name);

#line default
#line hidden
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-product", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 17 "C:\Users\avtar\Desktop\sem 3\mainframe\GeorgianComputers-master\GeorgianComputers-master\Views\Shop\Browse.cshtml"
                                                                                    WriteLiteral(item.Name);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["product"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-product", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["product"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <h5> ");
#line 18 "C:\Users\avtar\Desktop\sem 3\mainframe\GeorgianComputers-master\GeorgianComputers-master\Views\Shop\Browse.cshtml"
                        Write(String.Format("{0:c}", item.Price));

#line default
#line hidden
            WriteLiteral(" </h5>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#line 22 "C:\Users\avtar\Desktop\sem 3\mainframe\GeorgianComputers-master\GeorgianComputers-master\Views\Shop\Browse.cshtml"
        }

#line default
#line hidden
            WriteLiteral("    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GeorgianComputers.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
