using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

public class DentistsData
{
    public DataTable Dentists { get; set; }
    public int DentistId { get; set; }
    public string FullName { get; set; }
    public string Address { get; set; }
    public string ContactNumber { get; set; }
    public string Email { get; set; }

 

}

