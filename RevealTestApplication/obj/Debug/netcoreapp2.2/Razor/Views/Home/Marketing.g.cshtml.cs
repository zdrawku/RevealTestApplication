#pragma checksum "D:\RevealTestApplication\RevealTestApplication\Views\Home\Marketing.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12524cd831b7f4f5624bc0493002ab296fe67df2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Marketing), @"mvc.1.0.view", @"/Views/Home/Marketing.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Marketing.cshtml", typeof(AspNetCore.Views_Home_Marketing))]
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
#line 1 "D:\RevealTestApplication\RevealTestApplication\Views\_ViewImports.cshtml"
using RevealTestApplication;

#line default
#line hidden
#line 2 "D:\RevealTestApplication\RevealTestApplication\Views\_ViewImports.cshtml"
using RevealTestApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12524cd831b7f4f5624bc0493002ab296fe67df2", @"/Views/Home/Marketing.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd689cea8b54e5a47dcb25dda2a2c212bc377306", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Marketing : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\RevealTestApplication\RevealTestApplication\Views\Home\Marketing.cshtml"
  
    ViewData["Title"] = "Marketing";

#line default
#line hidden
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(72, 807, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        WebFont.load({
            custom: {
                families: ['Roboto-Regular', 'Roboto-Bold', 'Roboto-Light', 'Roboto-Medium'],
                urls: ['/css/site.css']
            },
            active: function () {
                var dashboardId = ""Marketing.rdash"";
                var revealSettings = new $.ig.RevealSettings(dashboardId);

                $.ig.RevealUtility.loadDashboard(dashboardId, function (dashboard) {
                    revealSettings.dashboard = dashboard;
                    var revealView = new $.ig.RevealView(""#revealView"", revealSettings);
                }, function (error) {
                    //Process any error that might occur here
                });
            },
        });
    </script>
");
                EndContext();
            }
            );
            BeginContext(882, 82, true);
            WriteLiteral("\r\n<section>\r\n    <div id=\"revealView\" style=\"height:800px;\"></div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
