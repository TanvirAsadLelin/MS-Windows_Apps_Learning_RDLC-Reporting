using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDLC_ReporitngWith_Parameters_WindowsFormsApp
{
    public partial class StudentsInfoForm : Form
    {
        public StudentsInfoForm()
        {
            InitializeComponent();
        }

        private void StudentsInfoForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentsInfoDataSet.StudentsInfo_Tbl' table. You can move, or remove it, as needed.
            this.studentsInfo_TblTableAdapter.Fill(this.studentsInfoDataSet.StudentsInfo_Tbl);

            this.reportViewerStudentsInfo.RefreshReport();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            this.studentsInfo_TblTableAdapter.FillByGender(this.studentsInfoDataSet.StudentsInfo_Tbl, comboBoxGender.SelectedItem.ToString());

            this.reportViewerStudentsInfo.RefreshReport();
        }

        private void btnLoadByName_Click(object sender, EventArgs e)
        {
            this.studentsInfo_TblTableAdapter.FillByName(this.studentsInfoDataSet.StudentsInfo_Tbl, textBoxName.Text);

            this.reportViewerStudentsInfo.RefreshReport();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.studentsInfo_TblTableAdapter.Fill(this.studentsInfoDataSet.StudentsInfo_Tbl);

            this.reportViewerStudentsInfo.RefreshReport();

            textBoxName.Clear();
            comboBoxGender.SelectedItem = null;
        }

        private void btnBoth_Click(object sender, EventArgs e)
        {
            if(comboBoxGender.SelectedItem != null && textBoxName.Text != "")
            {
                this.studentsInfo_TblTableAdapter.FillByGenderName(this.studentsInfoDataSet.StudentsInfo_Tbl, textBoxName.Text, comboBoxGender.SelectedItem.ToString());

                this.reportViewerStudentsInfo.RefreshReport();
            }
            else if (comboBoxGender.SelectedItem != null)
            {
                this.studentsInfo_TblTableAdapter.FillByGender(this.studentsInfoDataSet.StudentsInfo_Tbl, comboBoxGender.SelectedItem.ToString());

                this.reportViewerStudentsInfo.RefreshReport();
            }
            else if (textBoxName.Text != "")
            {
                this.studentsInfo_TblTableAdapter.FillByName(this.studentsInfoDataSet.StudentsInfo_Tbl, textBoxName.Text);

                this.reportViewerStudentsInfo.RefreshReport();
            }
            else
            {
                MessageBox.Show("Please select gender or fill name for load data", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLoadById_Click(object sender, EventArgs e)
        {
            this.studentsInfo_TblTableAdapter.FillById(this.studentsInfoDataSet.StudentsInfo_Tbl, int.Parse(textBoxId.Text));

            this.reportViewerStudentsInfo.RefreshReport();
        }
    }
}
