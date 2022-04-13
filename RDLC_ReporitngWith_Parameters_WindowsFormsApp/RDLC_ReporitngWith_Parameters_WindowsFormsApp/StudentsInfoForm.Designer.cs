namespace RDLC_ReporitngWith_Parameters_WindowsFormsApp
{
    partial class StudentsInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewerStudentsInfo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnLoadByName = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.studentsInfoTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsInfoDataSet = new RDLC_ReporitngWith_Parameters_WindowsFormsApp.StudentsInfoDataSet();
            this.studentsInfo_TblTableAdapter = new RDLC_ReporitngWith_Parameters_WindowsFormsApp.StudentsInfoDataSetTableAdapters.StudentsInfo_TblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.studentsInfoTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsInfoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerStudentsInfo
            // 
            reportDataSource7.Name = "StudentsInfoDataSet";
            reportDataSource7.Value = this.studentsInfoTblBindingSource;
            this.reportViewerStudentsInfo.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewerStudentsInfo.LocalReport.ReportEmbeddedResource = "RDLC_ReporitngWith_Parameters_WindowsFormsApp.StudentsInfoReport.rdlc";
            this.reportViewerStudentsInfo.Location = new System.Drawing.Point(0, 171);
            this.reportViewerStudentsInfo.Name = "reportViewerStudentsInfo";
            this.reportViewerStudentsInfo.ServerReport.BearerToken = null;
            this.reportViewerStudentsInfo.Size = new System.Drawing.Size(880, 425);
            this.reportViewerStudentsInfo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gender: ";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxGender.Location = new System.Drawing.Point(107, 20);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(149, 34);
            this.comboBoxGender.TabIndex = 2;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(316, 20);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(207, 34);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load By Gender";
            this.btnLoad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnLoadByName
            // 
            this.btnLoadByName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadByName.Location = new System.Drawing.Point(316, 83);
            this.btnLoadByName.Name = "btnLoadByName";
            this.btnLoadByName.Size = new System.Drawing.Size(184, 34);
            this.btnLoadByName.TabIndex = 6;
            this.btnLoadByName.Text = "Load By Name";
            this.btnLoadByName.UseVisualStyleBackColor = true;
            this.btnLoadByName.Click += new System.EventHandler(this.btnLoadByName_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name: ";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(107, 84);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(149, 34);
            this.textBoxName.TabIndex = 7;
            // 
            // studentsInfoTblBindingSource
            // 
            this.studentsInfoTblBindingSource.DataMember = "StudentsInfo_Tbl";
            this.studentsInfoTblBindingSource.DataSource = this.studentsInfoDataSet;
            // 
            // studentsInfoDataSet
            // 
            this.studentsInfoDataSet.DataSetName = "StudentsInfoDataSet";
            this.studentsInfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsInfo_TblTableAdapter
            // 
            this.studentsInfo_TblTableAdapter.ClearBeforeFill = true;
            // 
            // StudentsInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 595);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.btnLoadByName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewerStudentsInfo);
            this.Name = "StudentsInfoForm";
            this.Text = "Students Info Report";
            this.Load += new System.EventHandler(this.StudentsInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentsInfoTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsInfoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerStudentsInfo;
        private StudentsInfoDataSet studentsInfoDataSet;
        private System.Windows.Forms.BindingSource studentsInfoTblBindingSource;
        private StudentsInfoDataSetTableAdapters.StudentsInfo_TblTableAdapter studentsInfo_TblTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnLoadByName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
    }
}

