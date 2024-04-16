using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM_Dental_Laboratory_and_Supplies.Global.UpdateCase
{
    public class CaseData
    {

        //update case form
        public DataTable Cases { get; set; }
        public string CaseId { get; set; }
        public string PatientName { get; set; }
        public string CaseTypeCode { get; set; }
        public string TimeCreated { get; set; }
        public string DateCreated { get; set; }
        public string Status { get; set; }
        public string Case { get; set; }
        public string Description { get; set; }
        public string DueTime { get; set; }
        public string DueDate { get; set; }
        public string Remarks { get; set; }
        public string Provided { get; set; }
        public string Username { get; set; }

        // Constructor to initialize Cases DataTable
        public CaseData()
        {
            Cases = new DataTable();

            // Define columns for the DataTable
            Cases.Columns.Add("CaseId", typeof(string));
            Cases.Columns.Add("PatientName", typeof(string));
            Cases.Columns.Add("CaseTypeCode", typeof(string));
            Cases.Columns.Add("TimeCreated", typeof(string));
            Cases.Columns.Add("DateCreated", typeof(string));
            Cases.Columns.Add("Status", typeof(string));
            Cases.Columns.Add("Case", typeof(string));
            Cases.Columns.Add("Description", typeof(string));
            Cases.Columns.Add("DueTime", typeof(string));
            Cases.Columns.Add("DueDate", typeof(string));
            Cases.Columns.Add("Remarks", typeof(string));
            Cases.Columns.Add("Provided", typeof(string));
            Cases.Columns.Add("Username", typeof(string));
        }


        // Method to delete a case by its ID
      
        public void PrintCasesData()
        {
            if (Cases != null && Cases.Rows.Count > 0)
            {
                Console.WriteLine("CaseData Contents:");
                foreach (DataRow row in Cases.Rows)
                {
                    Console.WriteLine($"CaseId: {row["CaseId"]}");
                    Console.WriteLine($"PatientName: {row["PatientName"]}");
                    Console.WriteLine($"CaseTypeCode: {row["CaseTypeCode"]}");
                    // Print other columns as needed
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("No cases data available.");
            }
        }

        public static implicit operator DataTable(CaseData v)
        {
            throw new NotImplementedException();
        }
    }

}
