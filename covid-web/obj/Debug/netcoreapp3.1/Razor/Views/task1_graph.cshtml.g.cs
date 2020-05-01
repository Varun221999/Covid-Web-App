#pragma checksum "/home/codio/workspace/covid-web/Views/task1_graph.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f26cf87d8487fb6abc05afa8b44b6d5eb62d4fc7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(program.Pages.Views_task1_graph), @"mvc.1.0.razor-page", @"/Views/task1_graph.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f26cf87d8487fb6abc05afa8b44b6d5eb62d4fc7", @"/Views/task1_graph.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65a87352ab55936b7625448d2e9155e1658af919", @"/Views/_ViewImports.cshtml")]
    public class Views_task1_graph : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/home/codio/workspace/covid-web/Views/task1_graph.cshtml"
    
  var date = Newtonsoft.Json.JsonConvert.SerializeObject(Model.dateCensus);
  var population = Newtonsoft.Json.JsonConvert.SerializeObject(Model.pop);


  ViewData["Title"] = "Census Data";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Census Data Graph</h2>  \n\n<br />\nRaw data: ");
#nullable restore
#line 14 "/home/codio/workspace/covid-web/Views/task1_graph.cshtml"
     Write(Html.Raw(date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<br />\nRaw data: ");
#nullable restore
#line 16 "/home/codio/workspace/covid-web/Views/task1_graph.cshtml"
     Write(Html.Raw(population));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<br />\n\n");
#nullable restore
#line 19 "/home/codio/workspace/covid-web/Views/task1_graph.cshtml"
  
   if (@Model.EX != null)
	 {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t   <br />\n\t\t <br />\n\t\t <h3>**ERROR: ");
#nullable restore
#line 24 "/home/codio/workspace/covid-web/Views/task1_graph.cshtml"
                 Write(Model.EX.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n\t\t <br />\n\t\t <hr />\n\t\t <br />\n\t\t <br />\n");
#nullable restore
#line 29 "/home/codio/workspace/covid-web/Views/task1_graph.cshtml"
	 }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""box-body"">  
  <div class=""chart-container"">  
     <canvas id=""myChart""></canvas>  
  </div>  
</div>  

<script src=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.7.3/Chart.bundle.min.js""></script>
<script src=""https://cdn.jsdelivr.net/npm/chartjs-plugin-datalabels@0.7.0""></script>

<script>
var ctx = document.getElementById(""myChart"");
var myChart = new Chart(ctx, {
    type: 'line',
    data: {
        labels: ");
#nullable restore
#line 46 "/home/codio/workspace/covid-web/Views/task1_graph.cshtml"
           Write(Html.Raw(date));

#line default
#line hidden
#nullable disable
            WriteLiteral(",\n        datasets: [\n        {\n            label: \"population\",  \n            data: ");
#nullable restore
#line 50 "/home/codio/workspace/covid-web/Views/task1_graph.cshtml"
             Write(Html.Raw(population));

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
            borderColor: ""blue"",
            pointBackgroundColor: ""black"",

            borderWidth: 1
        }
       ]
    },
    options: {
        scales: {
            yAxes: [{
                ticks: {
                    beginAtZero:true
                }
            }]
        }
    }
});

</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<task1_graph_model> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<task1_graph_model> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<task1_graph_model>)PageContext?.ViewData;
        public task1_graph_model Model => ViewData.Model;
    }
}
#pragma warning restore 1591