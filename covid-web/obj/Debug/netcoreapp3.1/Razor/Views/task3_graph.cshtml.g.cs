#pragma checksum "/home/codio/workspace/covid-web/Views/task3_graph.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbfbc8cf3ebcfcb7d345cbf7f17e4ffc6a444013"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(program.Pages.Views_task3_graph), @"mvc.1.0.razor-page", @"/Views/task3_graph.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbfbc8cf3ebcfcb7d345cbf7f17e4ffc6a444013", @"/Views/task3_graph.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65a87352ab55936b7625448d2e9155e1658af919", @"/Views/_ViewImports.cshtml")]
    public class Views_task3_graph : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/home/codio/workspace/covid-web/Views/task3_graph.cshtml"
    
  var date = Newtonsoft.Json.JsonConvert.SerializeObject(Model.dates);
  
	var pos1 = Newtonsoft.Json.JsonConvert.SerializeObject(Model.list1);
  var pos2 = Newtonsoft.Json.JsonConvert.SerializeObject(Model.list2);
  var pos3 = Newtonsoft.Json.JsonConvert.SerializeObject(Model.list3);
  var pos4 = Newtonsoft.Json.JsonConvert.SerializeObject(Model.list4);
  var pos5 = Newtonsoft.Json.JsonConvert.SerializeObject(Model.list5);
  var pos6 = Newtonsoft.Json.JsonConvert.SerializeObject(Model.list6);

	var states = Newtonsoft.Json.JsonConvert.SerializeObject(Model.stateList);

  ViewData["Title"] = "TASK 3 GRAPH";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>TASK 3 Graph</h2>  \n\n");
#nullable restore
#line 20 "/home/codio/workspace/covid-web/Views/task3_graph.cshtml"
  
   if (@Model.EX != null)
	 {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t   <br />\n\t\t <br />\n\t\t <h3>**ERROR: ");
#nullable restore
#line 25 "/home/codio/workspace/covid-web/Views/task3_graph.cshtml"
                 Write(Model.EX.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n\t\t <br />\n\t\t <hr />\n\t\t <br />\n\t\t <br />\n");
#nullable restore
#line 30 "/home/codio/workspace/covid-web/Views/task3_graph.cshtml"
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
#line 47 "/home/codio/workspace/covid-web/Views/task3_graph.cshtml"
           Write(Html.Raw(date));

#line default
#line hidden
#nullable disable
            WriteLiteral(",\n        datasets: [\n        {\n            label: \"State 1 Positive Increase\",  \n            data: ");
#nullable restore
#line 51 "/home/codio/workspace/covid-web/Views/task3_graph.cshtml"
             Write(Html.Raw(pos1));

#line default
#line hidden
#nullable disable
            WriteLiteral(",\n            borderColor: \"blue\",\n            pointBackgroundColor: \"blue\",\n\n            borderWidth: 1\n        },\n        {\n            label: \"State 1 Neagtive Increase\",  \n            data: ");
#nullable restore
#line 59 "/home/codio/workspace/covid-web/Views/task3_graph.cshtml"
             Write(Html.Raw(pos2));

#line default
#line hidden
#nullable disable
            WriteLiteral(",\n            borderColor: \"red\",\n            pointBackgroundColor: \"red\",\n\n            borderWidth: 1\n        },\n        {\n            label: \"State 2 Positive Increase\",  \n            data: ");
#nullable restore
#line 67 "/home/codio/workspace/covid-web/Views/task3_graph.cshtml"
             Write(Html.Raw(pos3));

#line default
#line hidden
#nullable disable
            WriteLiteral(",\n            borderColor: \"green\",\n            pointBackgroundColor: \"green\",\n\n            borderWidth: 1\n        },\n        {\n            label: \"State 2 Negative Increase\",  \n            data: ");
#nullable restore
#line 75 "/home/codio/workspace/covid-web/Views/task3_graph.cshtml"
             Write(Html.Raw(pos4));

#line default
#line hidden
#nullable disable
            WriteLiteral(",\n            borderColor: \"yellow\",\n            pointBackgroundColor: \"yellow\",\n\n            borderWidth: 1\n        },\n        {\n            label: \"State 3 Positive Increase\",  \n            data: ");
#nullable restore
#line 83 "/home/codio/workspace/covid-web/Views/task3_graph.cshtml"
             Write(Html.Raw(pos5));

#line default
#line hidden
#nullable disable
            WriteLiteral(",\n            borderColor: \"pink\",\n            pointBackgroundColor: \"pink\",\n\n            borderWidth: 1\n        },\n        {\n            label: \"State 3 Negative Increase\",  \n            data: ");
#nullable restore
#line 91 "/home/codio/workspace/covid-web/Views/task3_graph.cshtml"
             Write(Html.Raw(pos6));

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
            borderColor: ""black"",
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<task3_graph_model> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<task3_graph_model> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<task3_graph_model>)PageContext?.ViewData;
        public task3_graph_model Model => ViewData.Model;
    }
}
#pragma warning restore 1591
