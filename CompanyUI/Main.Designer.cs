
namespace CompanyUI
{
    partial class Main
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
            this.btnMakeDep = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDepCount = new System.Windows.Forms.Label();
            this.cboDeparts = new System.Windows.Forms.ComboBox();
            this.lblStatstiv = new System.Windows.Forms.Label();
            this.cboEmpleys = new System.Windows.Forms.ComboBox();
            this.lblEmplys = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHireEmp = new System.Windows.Forms.Button();
            this.btnFire = new System.Windows.Forms.Button();
            this.btnCloseDep = new System.Windows.Forms.Button();
            this.btnMakeVac = new System.Windows.Forms.Button();
            this.cboVacancy = new System.Windows.Forms.ComboBox();
            this.lblVac = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDeleteVac = new System.Windows.Forms.Button();
            this.PanelSpecificInf = new System.Windows.Forms.Panel();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblSkills = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblFamilyName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dfg = new System.Windows.Forms.Label();
            this.PanelSpecificInf.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMakeDep
            // 
            this.btnMakeDep.Location = new System.Drawing.Point(582, 79);
            this.btnMakeDep.Name = "btnMakeDep";
            this.btnMakeDep.Size = new System.Drawing.Size(150, 23);
            this.btnMakeDep.TabIndex = 0;
            this.btnMakeDep.Text = "Open Department";
            this.btnMakeDep.UseVisualStyleBackColor = true;
            this.btnMakeDep.Click += new System.EventHandler(this.btnMakeDep_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Amount Department:";
            // 
            // lblDepCount
            // 
            this.lblDepCount.AutoSize = true;
            this.lblDepCount.Location = new System.Drawing.Point(182, 83);
            this.lblDepCount.Name = "lblDepCount";
            this.lblDepCount.Size = new System.Drawing.Size(13, 15);
            this.lblDepCount.TabIndex = 2;
            this.lblDepCount.Text = "0";
            // 
            // cboDeparts
            // 
            this.cboDeparts.FormattingEnabled = true;
            this.cboDeparts.Location = new System.Drawing.Point(43, 102);
            this.cboDeparts.Name = "cboDeparts";
            this.cboDeparts.Size = new System.Drawing.Size(152, 23);
            this.cboDeparts.TabIndex = 3;
            this.cboDeparts.SelectedValueChanged += new System.EventHandler(this.cboDeparts_SelectedValueChanged);
            // 
            // lblStatstiv
            // 
            this.lblStatstiv.AutoSize = true;
            this.lblStatstiv.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatstiv.Location = new System.Drawing.Point(267, 20);
            this.lblStatstiv.Name = "lblStatstiv";
            this.lblStatstiv.Size = new System.Drawing.Size(247, 25);
            this.lblStatstiv.TabIndex = 4;
            this.lblStatstiv.Text = "Common company statistics";
            // 
            // cboEmpleys
            // 
            this.cboEmpleys.FormattingEnabled = true;
            this.cboEmpleys.Location = new System.Drawing.Point(43, 169);
            this.cboEmpleys.Name = "cboEmpleys";
            this.cboEmpleys.Size = new System.Drawing.Size(152, 23);
            this.cboEmpleys.TabIndex = 7;
            this.cboEmpleys.SelectedValueChanged += new System.EventHandler(this.cboEmpleys_SelectedValueChanged);
            // 
            // lblEmplys
            // 
            this.lblEmplys.AutoSize = true;
            this.lblEmplys.Location = new System.Drawing.Point(182, 150);
            this.lblEmplys.Name = "lblEmplys";
            this.lblEmplys.Size = new System.Drawing.Size(13, 15);
            this.lblEmplys.TabIndex = 6;
            this.lblEmplys.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Amount Employees";
            // 
            // btnHireEmp
            // 
            this.btnHireEmp.Location = new System.Drawing.Point(582, 156);
            this.btnHireEmp.Name = "btnHireEmp";
            this.btnHireEmp.Size = new System.Drawing.Size(150, 23);
            this.btnHireEmp.TabIndex = 8;
            this.btnHireEmp.Text = "Hire employee";
            this.btnHireEmp.UseVisualStyleBackColor = true;
            this.btnHireEmp.Click += new System.EventHandler(this.btnHireEmp_Click);
            // 
            // btnFire
            // 
            this.btnFire.Location = new System.Drawing.Point(582, 185);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(150, 23);
            this.btnFire.TabIndex = 9;
            this.btnFire.Text = "Fire employee";
            this.btnFire.UseVisualStyleBackColor = true;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // btnCloseDep
            // 
            this.btnCloseDep.Location = new System.Drawing.Point(582, 108);
            this.btnCloseDep.Name = "btnCloseDep";
            this.btnCloseDep.Size = new System.Drawing.Size(150, 23);
            this.btnCloseDep.TabIndex = 10;
            this.btnCloseDep.Text = "Close Department";
            this.btnCloseDep.UseVisualStyleBackColor = true;
            this.btnCloseDep.Click += new System.EventHandler(this.btnCloseDep_Click);
            // 
            // btnMakeVac
            // 
            this.btnMakeVac.Location = new System.Drawing.Point(582, 228);
            this.btnMakeVac.Name = "btnMakeVac";
            this.btnMakeVac.Size = new System.Drawing.Size(150, 23);
            this.btnMakeVac.TabIndex = 11;
            this.btnMakeVac.Text = "Make vacancy";
            this.btnMakeVac.UseVisualStyleBackColor = true;
            this.btnMakeVac.Click += new System.EventHandler(this.btnMakeVac_Click);
            // 
            // cboVacancy
            // 
            this.cboVacancy.FormattingEnabled = true;
            this.cboVacancy.Location = new System.Drawing.Point(43, 229);
            this.cboVacancy.Name = "cboVacancy";
            this.cboVacancy.Size = new System.Drawing.Size(152, 23);
            this.cboVacancy.TabIndex = 14;
            this.cboVacancy.SelectedValueChanged += new System.EventHandler(this.cboVacancy_SelectedValueChanged);
            // 
            // lblVac
            // 
            this.lblVac.AutoSize = true;
            this.lblVac.Location = new System.Drawing.Point(182, 208);
            this.lblVac.Name = "lblVac";
            this.lblVac.Size = new System.Drawing.Size(13, 15);
            this.lblVac.TabIndex = 13;
            this.lblVac.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Amount Vacancy";
            // 
            // btnDeleteVac
            // 
            this.btnDeleteVac.Location = new System.Drawing.Point(582, 257);
            this.btnDeleteVac.Name = "btnDeleteVac";
            this.btnDeleteVac.Size = new System.Drawing.Size(150, 23);
            this.btnDeleteVac.TabIndex = 15;
            this.btnDeleteVac.Text = "Delete vacancy";
            this.btnDeleteVac.UseVisualStyleBackColor = true;
            this.btnDeleteVac.Click += new System.EventHandler(this.btnDeleteVac_Click);
            // 
            // PanelSpecificInf
            // 
            this.PanelSpecificInf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelSpecificInf.Controls.Add(this.lblPosition);
            this.PanelSpecificInf.Controls.Add(this.lblSkills);
            this.PanelSpecificInf.Controls.Add(this.lblSalary);
            this.PanelSpecificInf.Controls.Add(this.lblBirthDate);
            this.PanelSpecificInf.Controls.Add(this.lblFamilyName);
            this.PanelSpecificInf.Controls.Add(this.lblName);
            this.PanelSpecificInf.Controls.Add(this.label8);
            this.PanelSpecificInf.Controls.Add(this.label7);
            this.PanelSpecificInf.Controls.Add(this.label6);
            this.PanelSpecificInf.Controls.Add(this.label5);
            this.PanelSpecificInf.Controls.Add(this.label2);
            this.PanelSpecificInf.Controls.Add(this.dfg);
            this.PanelSpecificInf.Location = new System.Drawing.Point(250, 102);
            this.PanelSpecificInf.Name = "PanelSpecificInf";
            this.PanelSpecificInf.Size = new System.Drawing.Size(286, 215);
            this.PanelSpecificInf.TabIndex = 16;
            this.PanelSpecificInf.Visible = false;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(166, 163);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(13, 15);
            this.lblPosition.TabIndex = 17;
            this.lblPosition.Text = "0";
            // 
            // lblSkills
            // 
            this.lblSkills.AutoSize = true;
            this.lblSkills.Location = new System.Drawing.Point(166, 135);
            this.lblSkills.Name = "lblSkills";
            this.lblSkills.Size = new System.Drawing.Size(13, 15);
            this.lblSkills.TabIndex = 17;
            this.lblSkills.Text = "0";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(166, 106);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(13, 15);
            this.lblSalary.TabIndex = 17;
            this.lblSalary.Text = "0";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(166, 81);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(13, 15);
            this.lblBirthDate.TabIndex = 17;
            this.lblBirthDate.Text = "0";
            // 
            // lblFamilyName
            // 
            this.lblFamilyName.AutoSize = true;
            this.lblFamilyName.Location = new System.Drawing.Point(166, 50);
            this.lblFamilyName.Name = "lblFamilyName";
            this.lblFamilyName.Size = new System.Drawing.Size(13, 15);
            this.lblFamilyName.TabIndex = 7;
            this.lblFamilyName.Text = "0";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(166, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(13, 15);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Position:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Skills:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Salary:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Birth date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Family name:";
            // 
            // dfg
            // 
            this.dfg.AutoSize = true;
            this.dfg.Location = new System.Drawing.Point(26, 22);
            this.dfg.Name = "dfg";
            this.dfg.Size = new System.Drawing.Size(42, 15);
            this.dfg.TabIndex = 0;
            this.dfg.Text = "Name:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelSpecificInf);
            this.Controls.Add(this.btnDeleteVac);
            this.Controls.Add(this.cboVacancy);
            this.Controls.Add(this.lblVac);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMakeVac);
            this.Controls.Add(this.btnCloseDep);
            this.Controls.Add(this.btnFire);
            this.Controls.Add(this.btnHireEmp);
            this.Controls.Add(this.cboEmpleys);
            this.Controls.Add(this.lblEmplys);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblStatstiv);
            this.Controls.Add(this.cboDeparts);
            this.Controls.Add(this.lblDepCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMakeDep);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.PanelSpecificInf.ResumeLayout(false);
            this.PanelSpecificInf.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMakeDep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDepCount;
        private System.Windows.Forms.ComboBox cboDeparts;
        private System.Windows.Forms.Label lblStatstiv;
        private System.Windows.Forms.ComboBox cboEmpleys;
        private System.Windows.Forms.Label lblEmplys;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHireEmp;
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.Button btnCloseDep;
        private System.Windows.Forms.Button btnMakeVac;
        private System.Windows.Forms.ComboBox cboVacancy;
        private System.Windows.Forms.Label lblVac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeleteVac;
        private System.Windows.Forms.Panel PanelSpecificInf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dfg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblSkills;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblFamilyName;
    }
}