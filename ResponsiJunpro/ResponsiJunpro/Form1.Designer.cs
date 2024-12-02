namespace ResponsiJunpro
{
    partial class Form1
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
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblSelectedEmp = new System.Windows.Forms.Label();
            this.lblNone = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rbHR = new System.Windows.Forms.RadioButton();
            this.rbENG = new System.Windows.Forms.RadioButton();
            this.rbDEV = new System.Windows.Forms.RadioButton();
            this.rbPM = new System.Windows.Forms.RadioButton();
            this.rbFin = new System.Windows.Forms.RadioButton();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Location = new System.Drawing.Point(65, 43);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(37, 13);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "LOGO";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(65, 94);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(91, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nama Karyawan :";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(65, 131);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(86, 13);
            this.lblDepartment.TabIndex = 2;
            this.lblDepartment.Text = "Dep. Karyawan :";
            // 
            // lblSelectedEmp
            // 
            this.lblSelectedEmp.AutoSize = true;
            this.lblSelectedEmp.Location = new System.Drawing.Point(65, 170);
            this.lblSelectedEmp.Name = "lblSelectedEmp";
            this.lblSelectedEmp.Size = new System.Drawing.Size(95, 13);
            this.lblSelectedEmp.TabIndex = 3;
            this.lblSelectedEmp.Text = "Karyawan Terplih :";
            // 
            // lblNone
            // 
            this.lblNone.AutoSize = true;
            this.lblNone.Location = new System.Drawing.Point(166, 170);
            this.lblNone.Name = "lblNone";
            this.lblNone.Size = new System.Drawing.Size(33, 13);
            this.lblNone.TabIndex = 4;
            this.lblNone.Text = "None";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(504, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID Departemen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(504, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "HR: HR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(505, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ENG: Engineer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(505, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "DEV: Developer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(504, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "PM: Product Manager";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(504, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "FIN: Finance";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(162, 91);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(172, 20);
            this.tbName.TabIndex = 11;
            // 
            // rbHR
            // 
            this.rbHR.AutoSize = true;
            this.rbHR.Location = new System.Drawing.Point(158, 130);
            this.rbHR.Name = "rbHR";
            this.rbHR.Size = new System.Drawing.Size(41, 17);
            this.rbHR.TabIndex = 12;
            this.rbHR.TabStop = true;
            this.rbHR.Text = "HR";
            this.rbHR.UseVisualStyleBackColor = true;
            // 
            // rbENG
            // 
            this.rbENG.AutoSize = true;
            this.rbENG.Location = new System.Drawing.Point(205, 131);
            this.rbENG.Name = "rbENG";
            this.rbENG.Size = new System.Drawing.Size(48, 17);
            this.rbENG.TabIndex = 13;
            this.rbENG.TabStop = true;
            this.rbENG.Text = "ENG";
            this.rbENG.UseVisualStyleBackColor = true;
            // 
            // rbDEV
            // 
            this.rbDEV.AutoSize = true;
            this.rbDEV.Location = new System.Drawing.Point(259, 131);
            this.rbDEV.Name = "rbDEV";
            this.rbDEV.Size = new System.Drawing.Size(47, 17);
            this.rbDEV.TabIndex = 14;
            this.rbDEV.TabStop = true;
            this.rbDEV.Text = "DEV";
            this.rbDEV.UseVisualStyleBackColor = true;
            // 
            // rbPM
            // 
            this.rbPM.AutoSize = true;
            this.rbPM.Location = new System.Drawing.Point(312, 131);
            this.rbPM.Name = "rbPM";
            this.rbPM.Size = new System.Drawing.Size(41, 17);
            this.rbPM.TabIndex = 15;
            this.rbPM.TabStop = true;
            this.rbPM.Text = "PM";
            this.rbPM.UseVisualStyleBackColor = true;
            this.rbPM.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rbFin
            // 
            this.rbFin.AutoSize = true;
            this.rbFin.Location = new System.Drawing.Point(359, 131);
            this.rbFin.Name = "rbFin";
            this.rbFin.Size = new System.Drawing.Size(42, 17);
            this.rbFin.TabIndex = 16;
            this.rbFin.TabStop = true;
            this.rbFin.Text = "FIN";
            this.rbFin.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(169, 214);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(93, 31);
            this.btnInsert.TabIndex = 17;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(325, 214);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(93, 31);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Edit";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(479, 214);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 31);
            this.button3.TabIndex = 19;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.rbFin);
            this.Controls.Add(this.rbPM);
            this.Controls.Add(this.rbDEV);
            this.Controls.Add(this.rbENG);
            this.Controls.Add(this.rbHR);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNone);
            this.Controls.Add(this.lblSelectedEmp);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblLogo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblSelectedEmp;
        private System.Windows.Forms.Label lblNone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.RadioButton rbHR;
        private System.Windows.Forms.RadioButton rbENG;
        private System.Windows.Forms.RadioButton rbDEV;
        private System.Windows.Forms.RadioButton rbPM;
        private System.Windows.Forms.RadioButton rbFin;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnUpdate;
    }
}

