#pragma checksum "/home/codio/workspace/covid-web/Views/ActionsTaken.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d21695b58bca633e6467fc1bdd0c5d2e36b5977"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(program.Pages.Views_ActionsTaken), @"mvc.1.0.razor-page", @"/Views/ActionsTaken.cshtml")]
namespace program.Pages
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
#line 1 "/home/codio/workspace/covid-web/Views/_ViewImports.cshtml"
using program;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d21695b58bca633e6467fc1bdd0c5d2e36b5977", @"/Views/ActionsTaken.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65a87352ab55936b7625448d2e9155e1658af919", @"/Views/_ViewImports.cshtml")]
    public class Views_ActionsTaken : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/home/codio/workspace/covid-web/Views/ActionsTaken.cshtml"
  
  ViewData["Title"] = "World News";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>World News</h2>  \n\n<br />\n");
#nullable restore
#line 10 "/home/codio/workspace/covid-web/Views/ActionsTaken.cshtml"
  
   if (@Model.EX != null)
	 {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t <h3>**ERROR: ");
#nullable restore
#line 13 "/home/codio/workspace/covid-web/Views/ActionsTaken.cshtml"
                 Write(Model.EX.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n\t\t <br />\n\t\t <hr />\n\t\t <br />\n\t\t <br />\n");
#nullable restore
#line 18 "/home/codio/workspace/covid-web/Views/ActionsTaken.cshtml"
	 }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table"">  
    <thead>  
        <tr>   
            <th>  
                State
            </th>  
						<th>  
                Date
            </th>  
            <th>  
                News
            </th>  
        </tr>  
    </thead>  
    <tbody>  
");
#nullable restore
#line 36 "/home/codio/workspace/covid-web/Views/ActionsTaken.cshtml"
         foreach (var item in Model.NewsList)  
        {  

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>  \n                <td>  \n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 40 "/home/codio/workspace/covid-web/Views/ActionsTaken.cshtml"
                                   Write(item.StateName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>  \n                <td>  \n                    ");
#nullable restore
#line 43 "/home/codio/workspace/covid-web/Views/ActionsTaken.cshtml"
               Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td> \n\t\t\t\t\t\t\t\t<td>  \n                    ");
#nullable restore
#line 46 "/home/codio/workspace/covid-web/Views/ActionsTaken.cshtml"
               Write(item.News);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td> \n            </tr>  \n");
#nullable restore
#line 49 "/home/codio/workspace/covid-web/Views/ActionsTaken.cshtml"
        }  

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>  \n</table> \n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ActionsTaken> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ActionsTaken> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ActionsTaken>)PageContext?.ViewData;
        public ActionsTaken Model => ViewData.Model;
    }
}
#pragma warning restore 1591
