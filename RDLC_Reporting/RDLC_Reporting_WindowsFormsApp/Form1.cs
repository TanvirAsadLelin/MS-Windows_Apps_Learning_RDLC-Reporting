using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace RDLC_Reporting_WindowsFormsApp
{
    public partial class Form1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBConnectionstrings"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }
    }
}
