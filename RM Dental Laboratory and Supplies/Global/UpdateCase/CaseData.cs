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
    }

}
