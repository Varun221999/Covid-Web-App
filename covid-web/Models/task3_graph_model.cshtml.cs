using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  
using Microsoft.AspNetCore.Mvc;  
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;
  
namespace program.Pages  
{  
    public class task3_graph_model : PageModel  
    {
        // Store the dates on which test data is recorded
        public List<string> dates { get; set; }
				
        public List<int>  list1 { get; set; }
				public List<int>  list2 { get; set; }
				public List<int>  list3 { get; set; }
				public List<int>  list4 { get; set; }
				public List<int>  list5 { get; set; }
				public List<int>  list6 { get; set; }


        public string Input { get; set; }
				public string Input2 { get; set; }
				public string Input3 { get; set; }
        
				public List<string> stateList { get; set; }
				
        public Exception EX { get; set; }
  
        // When the page is loaded
        public void OnGet(string input, string input2, string input3)  
        {
          Input = input;
					Input2 = input2;
					Input2 = input3;
					
					list1 = new List<int>();
					list2 = new List<int>();
					list3 = new List<int>();
					list4 = new List<int>();
					list5 = new List<int>();
					list6 = new List<int>();
					
					stateList = new List<string>();
					stateList.Add(input);
					stateList.Add(input2);
					stateList.Add(input3);
					
					dates = new List<string>();
          EX = null;
          
          try
          {
            // query retrieving data from US testing data table
            string sql1 = string.Format(@"
SELECT date, positiveIncrease, negativeIncrease
FROM us_states_covid19_daily
WHERE state LIKE '%{0}%'
ORDER BY date",
input);

            string sql2 = string.Format(@"
SELECT date, positiveIncrease, negativeIncrease
FROM us_states_covid19_daily
WHERE state LIKE '%{0}%'
ORDER BY date",
input2);

            string sql3 = string.Format(@"
SELECT date, positiveIncrease, negativeIncrease
FROM us_states_covid19_daily
WHERE state LIKE '%{0}%'
ORDER BY date",
input3);
          
            DataSet ds = DataAccessTier.DB.ExecuteNonScalarQuery(sql1);
            DataSet ds2 = DataAccessTier.DB.ExecuteNonScalarQuery(sql2);
            DataSet ds3 = DataAccessTier.DB.ExecuteNonScalarQuery(sql3);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
              string date = Convert.ToString(row["DATE"]);
              dates.Add(date);
             
						  int pIncrease = Convert.ToInt32(row["positiveIncrease"]);
							list1.Add(pIncrease); 
							 
							int nIncrease = Convert.ToInt32(row["negativeIncrease"]);
							list2.Add(nIncrease);
						}


            foreach (DataRow row in ds2.Tables[0].Rows)
            {
              string date = Convert.ToString(row["DATE"]);
              dates.Add(date);
             
						  int pIncrease = Convert.ToInt32(row["positiveIncrease"]);
							list3.Add(pIncrease); 
							 
							int nIncrease = Convert.ToInt32(row["negativeIncrease"]);
							list4.Add(nIncrease);
						}


            foreach (DataRow row in ds3.Tables[0].Rows)
            {
              string date = Convert.ToString(row["DATE"]);
              dates.Add(date);
             
						  int pIncrease = Convert.ToInt32(row["positiveIncrease"]);
							list5.Add(pIncrease); 
							 
							int nIncrease = Convert.ToInt32(row["negativeIncrease"]);
							list6.Add(nIncrease);
						}

						dates = dates.Distinct().ToList();
						
						int i;
						int count = dates.Count();
						int count1 = list1.Count();
						
						for(i = 0; i < (count - count1); i++)
						{
							list1 = list1.Prepend(0).ToList();
							list2 = list2.Prepend(0).ToList();
						}
						
												
						int count3 = list3.Count();
						
						for(i = 0; i < (count - count3); i++)
						{
							list3 = list3.Prepend(0).ToList();
							list4 = list4.Prepend(0).ToList();
						}
						
												
						int count5 = list5.Count();
						
						for(i = 0; i < (count - count5); i++)
						{
							list5 = list5.Prepend(0).ToList();
							list6 = list6.Prepend(0).ToList();
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