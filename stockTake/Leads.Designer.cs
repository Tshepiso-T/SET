namespace stockTake
{
    partial class Leads
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.chkWarm = new System.Windows.Forms.CheckBox();
            this.chkHot = new System.Windows.Forms.CheckBox();
            this.chkCold = new System.Windows.Forms.CheckBox();
            this.categoriesdgv = new Guna.UI.WinForms.GunaDataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPostal = new Guna.UI.WinForms.GunaTextBox();
            this.txtUnit = new Guna.UI.WinForms.GunaTextBox();
            this.txtEmail = new Guna.UI.WinForms.GunaTextBox();
            this.txtDirectContact = new Guna.UI.WinForms.GunaTextBox();
            this.txtAddress = new Guna.UI.WinForms.GunaTextBox();
            this.cmbRegion = new System.Windows.Forms.ComboBox();
            this.txtCompanyName = new Guna.UI.WinForms.GunaTextBox();
            this.txtIDN = new Guna.UI.WinForms.GunaTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.txtIDN);
            this.panel1.Controls.Add(this.txtCompanyName);
            this.panel1.Controls.Add(this.cmbRegion);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtDirectContact);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtUnit);
            this.panel1.Controls.Add(this.txtPostal);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.chkWarm);
            this.panel1.Controls.Add(this.chkHot);
            this.panel1.Controls.Add(this.chkCold);
            this.panel1.Controls.Add(this.categoriesdgv);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 754);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(45, 490);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "Select Categories";
            // 
            // chkWarm
            // 
            this.chkWarm.AutoSize = true;
            this.chkWarm.Location = new System.Drawing.Point(223, 525);
            this.chkWarm.Name = "chkWarm";
            this.chkWarm.Size = new System.Drawing.Size(65, 20);
            this.chkWarm.TabIndex = 21;
            this.chkWarm.Text = "Warm";
            this.chkWarm.UseVisualStyleBackColor = true;
            this.chkWarm.CheckedChanged += new System.EventHandler(this.chkWarm_CheckedChanged);
            // 
            // chkHot
            // 
            this.chkHot.AutoSize = true;
            this.chkHot.Location = new System.Drawing.Point(143, 525);
            this.chkHot.Name = "chkHot";
            this.chkHot.Size = new System.Drawing.Size(50, 20);
            this.chkHot.TabIndex = 20;
            this.chkHot.Text = "Hot";
            this.chkHot.UseVisualStyleBackColor = true;
            this.chkHot.CheckedChanged += new System.EventHandler(this.chkHot_CheckedChanged);
            // 
            // chkCold
            // 
            this.chkCold.AutoSize = true;
            this.chkCold.Location = new System.Drawing.Point(42, 525);
            this.chkCold.Name = "chkCold";
            this.chkCold.Size = new System.Drawing.Size(57, 20);
            this.chkCold.TabIndex = 19;
            this.chkCold.Text = "Cold";
            this.chkCold.UseVisualStyleBackColor = true;
            this.chkCold.CheckedChanged += new System.EventHandler(this.chkCold_CheckedChanged);
            // 
            // categoriesdgv
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.categoriesdgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.categoriesdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.categoriesdgv.BackgroundColor = System.Drawing.Color.White;
            this.categoriesdgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.categoriesdgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.categoriesdgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categoriesdgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.categoriesdgv.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.categoriesdgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.categoriesdgv.EnableHeadersVisualStyles = false;
            this.categoriesdgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.categoriesdgv.Location = new System.Drawing.Point(361, 53);
            this.categoriesdgv.Name = "categoriesdgv";
            this.categoriesdgv.RowHeadersVisible = false;
            this.categoriesdgv.RowHeadersWidth = 51;
            this.categoriesdgv.RowTemplate.Height = 24;
            this.categoriesdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.categoriesdgv.Size = new System.Drawing.Size(627, 663);
            this.categoriesdgv.TabIndex = 16;
            this.categoriesdgv.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.categoriesdgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.categoriesdgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.categoriesdgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.categoriesdgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.categoriesdgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.categoriesdgv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.categoriesdgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.categoriesdgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.categoriesdgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.categoriesdgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.categoriesdgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.categoriesdgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.categoriesdgv.ThemeStyle.HeaderStyle.Height = 30;
            this.categoriesdgv.ThemeStyle.ReadOnly = false;
            this.categoriesdgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.categoriesdgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.categoriesdgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.categoriesdgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.categoriesdgv.ThemeStyle.RowsStyle.Height = 24;
            this.categoriesdgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.categoriesdgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDelete.Location = new System.Drawing.Point(234, 596);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdate.Location = new System.Drawing.Point(149, 596);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAdd.Location = new System.Drawing.Point(49, 596);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(274, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Possible Customer";
            // 
            // txtPostal
            // 
            this.txtPostal.BaseColor = System.Drawing.Color.White;
            this.txtPostal.BorderColor = System.Drawing.Color.Silver;
            this.txtPostal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPostal.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPostal.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPostal.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPostal.Font = new System.Drawing.Font("Segoe UI Semilight", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtPostal.Location = new System.Drawing.Point(174, 325);
            this.txtPostal.Name = "txtPostal";
            this.txtPostal.PasswordChar = '\0';
            this.txtPostal.SelectedText = "";
            this.txtPostal.Size = new System.Drawing.Size(181, 40);
            this.txtPostal.TabIndex = 24;
            this.txtPostal.Text = "Postal Code";
            // 
            // txtUnit
            // 
            this.txtUnit.BaseColor = System.Drawing.Color.White;
            this.txtUnit.BorderColor = System.Drawing.Color.Silver;
            this.txtUnit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUnit.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUnit.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtUnit.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUnit.Font = new System.Drawing.Font("Segoe UI Semilight", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtUnit.Location = new System.Drawing.Point(10, 270);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.PasswordChar = '\0';
            this.txtUnit.SelectedText = "";
            this.txtUnit.Size = new System.Drawing.Size(346, 49);
            this.txtUnit.TabIndex = 29;
            this.txtUnit.Text = "Unit, Indurial, Apartment";
            // 
            // txtEmail
            // 
            this.txtEmail.BaseColor = System.Drawing.Color.White;
            this.txtEmail.BorderColor = System.Drawing.Color.Silver;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.FocusedBaseColor = System.Drawing.Color.White;
            this.txtEmail.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtEmail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtEmail.Location = new System.Drawing.Point(10, 147);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(345, 32);
            this.txtEmail.TabIndex = 39;
            this.txtEmail.Text = "Email";
            // 
            // txtDirectContact
            // 
            this.txtDirectContact.BaseColor = System.Drawing.Color.White;
            this.txtDirectContact.BorderColor = System.Drawing.Color.Silver;
            this.txtDirectContact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDirectContact.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDirectContact.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDirectContact.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDirectContact.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirectContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtDirectContact.Location = new System.Drawing.Point(10, 181);
            this.txtDirectContact.Name = "txtDirectContact";
            this.txtDirectContact.PasswordChar = '\0';
            this.txtDirectContact.SelectedText = "";
            this.txtDirectContact.Size = new System.Drawing.Size(346, 32);
            this.txtDirectContact.TabIndex = 38;
            this.txtDirectContact.Text = "Direct Contact";
            // 
            // txtAddress
            // 
            this.txtAddress.BaseColor = System.Drawing.Color.White;
            this.txtAddress.BorderColor = System.Drawing.Color.Silver;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAddress.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtAddress.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtAddress.Location = new System.Drawing.Point(10, 220);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(346, 44);
            this.txtAddress.TabIndex = 37;
            this.txtAddress.Text = "street";
            // 
            // cmbRegion
            // 
            this.cmbRegion.Font = new System.Drawing.Font("Segoe UI Semilight", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRegion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmbRegion.FormattingEnabled = true;
            this.cmbRegion.Items.AddRange(new object[] {
            "USA",
            "South Africa"});
            this.cmbRegion.Location = new System.Drawing.Point(10, 325);
            this.cmbRegion.Name = "cmbRegion";
            this.cmbRegion.Size = new System.Drawing.Size(141, 25);
            this.cmbRegion.TabIndex = 44;
            this.cmbRegion.Text = "Region/Country";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.BaseColor = System.Drawing.Color.White;
            this.txtCompanyName.BorderColor = System.Drawing.Color.Silver;
            this.txtCompanyName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCompanyName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCompanyName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCompanyName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCompanyName.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtCompanyName.Location = new System.Drawing.Point(11, 109);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.PasswordChar = '\0';
            this.txtCompanyName.SelectedText = "";
            this.txtCompanyName.Size = new System.Drawing.Size(345, 32);
            this.txtCompanyName.TabIndex = 45;
            this.txtCompanyName.Text = "Company Name";
            // 
            // txtIDN
            // 
            this.txtIDN.BaseColor = System.Drawing.Color.White;
            this.txtIDN.BorderColor = System.Drawing.Color.Silver;
            this.txtIDN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDN.FocusedBaseColor = System.Drawing.Color.White;
            this.txtIDN.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtIDN.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIDN.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtIDN.Location = new System.Drawing.Point(11, 71);
            this.txtIDN.Name = "txtIDN";
            this.txtIDN.PasswordChar = '\0';
            this.txtIDN.SelectedText = "";
            this.txtIDN.Size = new System.Drawing.Size(345, 32);
            this.txtIDN.TabIndex = 46;
            this.txtIDN.Text = "Company Number";
            // 
            // Leads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1005, 760);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Leads";
            this.Text = "Leads";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesdgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaDataGridView categoriesdgv;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkWarm;
        private System.Windows.Forms.CheckBox chkHot;
        private System.Windows.Forms.CheckBox chkCold;
        private Guna.UI.WinForms.GunaTextBox txtPostal;
        private Guna.UI.WinForms.GunaTextBox txtUnit;
        private Guna.UI.WinForms.GunaTextBox txtEmail;
        private Guna.UI.WinForms.GunaTextBox txtDirectContact;
        private Guna.UI.WinForms.GunaTextBox txtAddress;
        private System.Windows.Forms.ComboBox cmbRegion;
        private Guna.UI.WinForms.GunaTextBox txtCompanyName;
        private Guna.UI.WinForms.GunaTextBox txtIDN;
    }
}