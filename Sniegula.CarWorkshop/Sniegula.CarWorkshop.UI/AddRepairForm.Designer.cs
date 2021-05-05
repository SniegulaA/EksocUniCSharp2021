
namespace Sniegula.CarWorkshop.UI
{
    partial class AddRepairForm
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
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.comboBoxMechanic = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddRepair = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRegistration = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownRepairTime = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRepairTime)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxBrand
            // 
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.Location = new System.Drawing.Point(118, 32);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(233, 21);
            this.comboBoxBrand.TabIndex = 0;
            this.comboBoxBrand.SelectedIndexChanged += new System.EventHandler(this.comboBoxBrand_SelectedIndexChanged);
            // 
            // comboBoxMechanic
            // 
            this.comboBoxMechanic.FormattingEnabled = true;
            this.comboBoxMechanic.Location = new System.Drawing.Point(118, 87);
            this.comboBoxMechanic.Name = "comboBoxMechanic";
            this.comboBoxMechanic.Size = new System.Drawing.Size(233, 21);
            this.comboBoxMechanic.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mechanik";
            // 
            // buttonAddRepair
            // 
            this.buttonAddRepair.Location = new System.Drawing.Point(117, 304);
            this.buttonAddRepair.Name = "buttonAddRepair";
            this.buttonAddRepair.Size = new System.Drawing.Size(234, 23);
            this.buttonAddRepair.TabIndex = 4;
            this.buttonAddRepair.Text = "Dodaj";
            this.buttonAddRepair.UseVisualStyleBackColor = true;
            this.buttonAddRepair.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(118, 136);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data naprawy";
            // 
            // textBoxRegistration
            // 
            this.textBoxRegistration.Location = new System.Drawing.Point(118, 188);
            this.textBoxRegistration.Name = "textBoxRegistration";
            this.textBoxRegistration.Size = new System.Drawing.Size(233, 20);
            this.textBoxRegistration.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Numer rejestracyjny";
            // 
            // numericUpDownRepairTime
            // 
            this.numericUpDownRepairTime.Location = new System.Drawing.Point(117, 241);
            this.numericUpDownRepairTime.Name = "numericUpDownRepairTime";
            this.numericUpDownRepairTime.Size = new System.Drawing.Size(233, 20);
            this.numericUpDownRepairTime.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Czas naprawy";
            // 
            // AddRepairForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownRepairTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxRegistration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonAddRepair);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxMechanic);
            this.Controls.Add(this.comboBoxBrand);
            this.Name = "AddRepairForm";
            this.Text = "AddRepairForm";
            this.Load += new System.EventHandler(this.AddRepairForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRepairTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxBrand;
        private System.Windows.Forms.ComboBox comboBoxMechanic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddRepair;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRegistration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownRepairTime;
        private System.Windows.Forms.Label label5;
    }
}