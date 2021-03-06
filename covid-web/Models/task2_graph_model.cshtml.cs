using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  
using Microsoft.AspNetCore.Mvc;  
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;
  
namespace program.Pages  
{  
    public class task2_graph_model : PageModel  
    {

        public List<string> dates { get; set; }
				
        public List<int> hospitalized { get; set; } 
                
        public List<int> deaths { get; set; }

        public string Input { get; set; }
        
        public Exception EX { get; set; }
  

        public void OnGet(string input)  
        {
          dates = new List<string>();
          hospitalized = new List<int>();
          deaths = new List<int>();
          Input = input;
          EX = null;
          
          try
          {
            // query retrieving data from US testing data table
            string sql = string.Format(@"
SELECT date, hospitalized, death
FROM us_states_covid19_daily
WHERE state LIKE '%{0}%'
ORDER BY date",
input);
          
            DataSet ds = DataAccessTier.DB.ExecuteNonScalarQuery(sql);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
              string date = Convert.ToString(row["DATE"]);
              dates.Add(date);

              
              string hospl = Convert.ToString(row["hospitalized"]);

							int hospINT = (hospl=="")?0:Convert.ToInt32(hospl);
              
              hospitalized.Add(hospINT);
                            
              int death = Convert.ToInt32(row["death"]);
              deaths.Add(death);

            }
		      }
		      catch(Exception ex)
		      {
            EX = ex;
		      }
		      finally
		      { 
            // nothing at the moment, the data access tier cleans up after itself
          } 
        }  
        
    }//class
}//namespace