#pragma checksum "C:\Users\lamapost0001\desktop\pierre.solution\pierre\Views\Flavors\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc7644c304c656ac46999e89b55997ce370f8daa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flavors_Edit), @"mvc.1.0.view", @"/Views/Flavors/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Flavors/Edit.cshtml", typeof(AspNetCore.Views_Flavors_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc7644c304c656ac46999e89b55997ce370f8daa", @"/Views/Flavors/Edit.cshtml")]
    public class Views_Flavors_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pierre.Models.Flavor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\lamapost0001\desktop\pierre.solution\pierre\Views\Flavors\Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(62, 25, true);
            WriteLiteral("\r\n<h4>Edit this Flavor:  ");
            EndContext();
            BeginContext(88, 36, false);
#line 7 "C:\Users\lamapost0001\desktop\pierre.solution\pierre\Views\Flavors\Edit.cshtml"
                  Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(124, 10, true);
            WriteLiteral(":</h4>\r\n\r\n");
            EndContext();
#line 9 "C:\Users\lamapost0001\desktop\pierre.solution\pierre\Views\Flavors\Edit.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
            BeginContext(167, 39, false);
#line 11 "C:\Users\lamapost0001\desktop\pierre.solution\pierre\Views\Flavors\Edit.cshtml"
Write(Html.HiddenFor(model => model.FlavorId));

#line default
#line hidden
            EndContext();
            BeginContext(213, 34, false);
#line 13 "C:\Users\lamapost0001\desktop\pierre.solution\pierre\Views\Flavors\Edit.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(252, 35, false);
#line 14 "C:\Users\lamapost0001\desktop\pierre.solution\pierre\Views\Flavors\Edit.cshtml"
Write(Html.EditorFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(289, 40, true);
            WriteLiteral("  <input type=\"submit\" value=\"Save\" />\r\n");
            EndContext();
#line 16 "C:\Users\lamapost0001\desktop\pierre.solution\pierre\Views\Flavors\Edit.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pierre.Models.Flavor> Html { get; private set; }
    }
}
#pragma warning restore 1591
