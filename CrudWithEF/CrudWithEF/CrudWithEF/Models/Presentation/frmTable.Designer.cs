
namespace CrudWithEF.Models.Presentation
{
    partial class frmTable
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
            this.tlpTable = new System.Windows.Forms.TableLayoutPanel();
            this.pButtons = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pInputs = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.tlpTable.SuspendLayout();
            this.pButtons.SuspendLayout();
            this.pInputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpTable
            // 
            this.tlpTable.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tlpTable.ColumnCount = 1;
            this.tlpTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTable.Controls.Add(this.pButtons, 0, 1);
            this.tlpTable.Controls.Add(this.pInputs, 0, 0);
            this.tlpTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTable.Location = new System.Drawing.Point(0, 0);
            this.tlpTable.Name = "tlpTable";
            this.tlpTable.RowCount = 2;
            this.tlpTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.63801F));
            this.tlpTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.36199F));
            this.tlpTable.Size = new System.Drawing.Size(456, 211);
            this.tlpTable.TabIndex = 0;
            // 
            // pButtons
            // 
            this.pButtons.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pButtons.Controls.Add(this.btnExit);
            this.pButtons.Controls.Add(this.btnSave);
            this.pButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pButtons.Location = new System.Drawing.Point(3, 169);
            this.pButtons.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.pButtons.Name = "pButtons";
            this.pButtons.Size = new System.Drawing.Size(450, 39);
            this.pButtons.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(151, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 26);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(232, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 26);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pInputs
            // 
            this.pInputs.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pInputs.Controls.Add(this.dtpBirth);
            this.pInputs.Controls.Add(this.txtEmail);
            this.pInputs.Controls.Add(this.txtName);
            this.pInputs.Controls.Add(this.lblBirthdate);
            this.pInputs.Controls.Add(this.lblEmail);
            this.pInputs.Controls.Add(this.lblName);
            this.pInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pInputs.Location = new System.Drawing.Point(3, 3);
            this.pInputs.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.pInputs.Name = "pInputs";
            this.pInputs.Size = new System.Drawing.Size(450, 164);
            this.pInputs.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(80, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(73, 75);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 15);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email:";
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthdate.Location = new System.Drawing.Point(52, 110);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(70, 15);
            this.lblBirthdate.TabIndex = 2;
            this.lblBirthdate.Text = "Birthdate";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(128, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(240, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(128, 72);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(240, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // dtpBirth
            // 
            this.dtpBirth.Location = new System.Drawing.Point(128, 107);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(240, 20);
            this.dtpBirth.TabIndex = 5;
            // 
            // frmTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 211);
            this.Controls.Add(this.tlpTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos para la tabla";
            this.tlpTable.ResumeLayout(false);
            this.pButtons.ResumeLayout(false);
            this.pInputs.ResumeLayout(false);
            this.pInputs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpTable;
        private System.Windows.Forms.Panel pButtons;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pInputs;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
    }
}