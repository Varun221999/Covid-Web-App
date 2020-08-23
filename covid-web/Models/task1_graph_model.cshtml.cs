using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  
using Microsoft.AspNetCore.Mvc;  
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;
  
namespace program.Pages  
{  
    public class task1_graph_model : PageModel  
    {


        public List<int> dateCensus { get; set; } 


        public List<int> pop { get; set; }


				public string Input { get; set; }


        public Exception EX { get; set; }
  
        // When the page is loaded
        public void OnGet(string input)  
        {

          dateCensus = new List<int>();
          pop = new List<int>();
          Input = input;
          EX = null;
          
          try
          {
					
					if (input == null)
						{
							//
							// there's no page argument, perhaps user surfed to the page directly?  
							// In this case, nothing to do.
							//
						}
					else 
					{
						            // query retrieving data from US testing data table
            string sql; 
						input = input.Replace("'", "''");
						sql = string.Format(@"
  SELECT year, population
  FROM census
  WHERE state LIKE '%{0}%'
  ORDER BY Year;
	", input);
          
            DataSet ds = DataAccessTier.DB.ExecuteNonScalarQuery(sql);

							foreach (DataRow row in ds.Tables[0].Rows)
							{
								Models.StateCensus s = new Models.StateCensus();
                
								s.StateName = input;
								s.Year = Convert.ToInt32(row["year"]);
								s.Population = Convert.ToInt32(row["population"]);

								dateCensus.Add(s.Year);
								pop.Add(s.Population);
								
							}
						
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