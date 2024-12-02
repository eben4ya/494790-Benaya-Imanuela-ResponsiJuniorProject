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
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvDataTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Location = new System.Drawing.Point(87, 53);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(44, 16);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "LOGO";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(87, 116);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(112, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nama Karyawan :";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(87, 161);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(104, 16);
            this.lblDepartment.TabIndex = 2;
            this.lblDepartment.Text = "Dep. Karyawan :";
            // 
            // lblSelectedEmp
            // 
            this.lblSelectedEmp.AutoSize = true;
            this.lblSelectedEmp.Location = new System.Drawing.Point(87, 209);
            this.lblSelectedEmp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedEmp.Name = "lblSelectedEmp";
            this.lblSelectedEmp.Size = new System.Drawing.Size(117, 16);
            this.lblSelectedEmp.TabIndex = 3;
            this.lblSelectedEmp.Text = "Karyawan Terplih :";
            // 
            // lblNone
            // 
            this.lblNone.AutoSize = true;
            this.lblNone.Location = new System.Drawing.Point(221, 209);
            this.lblNone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNone.Name = "lblNone";
            this.lblNone.Size = new System.Drawing.Size(40, 16);
            this.lblNone.TabIndex = 4;
            this.lblNone.Text = "None";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(784, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID Departemen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(784, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "HR: HR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(785, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "ENG: Engineer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(785, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "DEV: Developer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(784, 185);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "PM: Product Manager";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(784, 214);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "FIN: Finance";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(216, 112);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(228, 22);
            this.tbName.TabIndex = 11;
            // 
            // rbHR
            // 
            this.rbHR.AutoSize = true;
            this.rbHR.Location = new System.Drawing.Point(211, 160);
            this.rbHR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbHR.Name = "rbHR";
            this.rbHR.Size = new System.Drawing.Size(48, 20);
            this.rbHR.TabIndex = 12;
            this.rbHR.TabStop = true;
            this.rbHR.Text = "HR";
            this.rbHR.UseVisualStyleBackColor = true;
            // 
            // rbENG
            // 
            this.rbENG.AutoSize = true;
            this.rbENG.Location = new System.Drawing.Point(273, 161);
            this.rbENG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbENG.Name = "rbENG";
            this.rbENG.Size = new System.Drawing.Size(57, 20);
            this.rbENG.TabIndex = 13;
            this.rbENG.TabStop = true;
            this.rbENG.Text = "ENG";
            this.rbENG.UseVisualStyleBackColor = true;
            // 
            // rbDEV
            // 
            this.rbDEV.AutoSize = true;
            this.rbDEV.Location = new System.Drawing.Point(345, 161);
            this.rbDEV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbDEV.Name = "rbDEV";
            this.rbDEV.Size = new System.Drawing.Size(56, 20);
            this.rbDEV.TabIndex = 14;
            this.rbDEV.TabStop = true;
            this.rbDEV.Text = "DEV";
            this.rbDEV.UseVisualStyleBackColor = true;
            // 
            // rbPM
            // 
            this.rbPM.AutoSize = true;
            this.rbPM.Location = new System.Drawing.Point(416, 161);
            this.rbPM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbPM.Name = "rbPM";
            this.rbPM.Size = new System.Drawing.Size(48, 20);
            this.rbPM.TabIndex = 15;
            this.rbPM.TabStop = true;
            this.rbPM.Text = "PM";
            this.rbPM.UseVisualStyleBackColor = true;
            this.rbPM.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rbFin
            // 
            this.rbFin.AutoSize = true;
            this.rbFin.Location = new System.Drawing.Point(479, 161);
            this.rbFin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbFin.Name = "rbFin";
            this.rbFin.Size = new System.Drawing.Size(49, 20);
            this.rbFin.TabIndex = 16;
            this.rbFin.TabStop = true;
            this.rbFin.Text = "FIN";
            this.rbFin.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(225, 263);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(124, 38);
            this.btnInsert.TabIndex = 17;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(433, 263);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(124, 38);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Edit";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(639, 263);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 38);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvDataTable
            // 
            this.dgvDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataTable.Location = new System.Drawing.Point(91, 327);
            this.dgvDataTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDataTable.Name = "dgvDataTable";
            this.dgvDataTable.RowHeadersWidth = 51;
            this.dgvDataTable.Size = new System.Drawing.Size(847, 185);
            this.dgvDataTable.TabIndex = 20;
            this.dgvDataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataTable_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dgvDataTable);
            this.Controls.Add(this.btnDelete);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataTable)).EndInit();
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
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvDataTable;
    }
}

