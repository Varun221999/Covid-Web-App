#pragma checksum "/home/codio/workspace/covid-web/Views/StateInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5c9333332a60c5ad3cdb5993fddc527df686e81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(program.Pages.Views_StateInfo), @"mvc.1.0.razor-page", @"/Views/StateInfo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5c9333332a60c5ad3cdb5993fddc527df686e81", @"/Views/StateInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65a87352ab55936b7625448d2e9155e1658af919", @"/Views/_ViewImports.cshtml")]
    public class Views_StateInfo : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/home/codio/workspace/covid-web/Views/StateInfo.cshtml"
  
  ViewData["Title"] = "State Information";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>State Information</h2>  \n\n<br />\nYour search string: \"");
#nullable restore
#line 10 "/home/codio/workspace/covid-web/Views/StateInfo.cshtml"
                Write(Model.Input);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\n<br />\n# of states found: ");
#nullable restore
#line 12 "/home/codio/workspace/covid-web/Views/StateInfo.cshtml"
              Write(Model.StateList.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<br />\n<br />\n");
#nullable restore
#line 15 "/home/codio/workspace/covid-web/Views/StateInfo.cshtml"
  
   if (@Model.EX != null)
	 {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t <h3>**ERROR: ");
#nullable restore
#line 18 "/home/codio/workspace/covid-web/Views/StateInfo.cshtml"
                 Write(Model.EX.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n\t\t <br />\n\t\t <hr />\n\t\t <br />\n\t\t <br />\n");
#nullable restore
#line 23 "/home/codio/workspace/covid-web/Views/StateInfo.cshtml"
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
                Year
            </th>  
            <th>  
                Population
            </th>  
        </tr>  
    </thead>  
    <tbody>  
");
#nullable restore
#line 41 "/home/codio/workspace/covid-web/Views/StateInfo.cshtml"
         foreach (var item in Model.StateList)  
        {  

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>  \n                <td>  \n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 45 "/home/codio/workspace/covid-web/Views/StateInfo.cshtml"
                                   Write(item.StateName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>  \n                <td>  \n                    ");
#nullable restore
#line 48 "/home/codio/workspace/covid-web/Views/StateInfo.cshtml"
               Write(item.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td> \n\t\t\t\t\t\t\t\t<td>  \n                    ");
#nullable restore
#line 51 "/home/codio/workspace/covid-web/Views/StateInfo.cshtml"
               Write(item.Population);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td> \n            </tr>  \n");
#nullable restore
#line 54 "/home/codio/workspace/covid-web/Views/StateInfo.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StateInfoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StateInfoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StateInfoModel>)PageContext?.ViewData;
        public StateInfoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591