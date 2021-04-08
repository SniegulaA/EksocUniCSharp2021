
namespace Sniegula.SellsManager.UIForms
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBoxTrader = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.numericUpDownSelledItemsGreaterThan = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSelledNumberLessThen = new System.Windows.Forms.TextBox();
            this.checkBoxSelledNumberGreaterThan = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSelledItemsGreaterThan)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(240, 33);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(489, 329);
            this.listBox1.TabIndex = 1;
            // 
            // textBoxTrader
            // 
            this.textBoxTrader.Location = new System.Drawing.Point(26, 107);
            this.textBoxTrader.Name = "textBoxTrader";
            this.textBoxTrader.Size = new System.Drawing.Size(176, 20);
            this.textBoxTrader.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Handlowiec";
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(26, 46);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(176, 23);
            this.buttonFilter.TabIndex = 4;
            this.buttonFilter.Text = "Filtruj";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // numericUpDownSelledItemsGreaterThan
            // 
            this.numericUpDownSelledItemsGreaterThan.Location = new System.Drawing.Point(26, 178);
            this.numericUpDownSelledItemsGreaterThan.Name = "numericUpDownSelledItemsGreaterThan";
            this.numericUpDownSelledItemsGreaterThan.Size = new System.Drawing.Size(135, 20);
            this.numericUpDownSelledItemsGreaterThan.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sprzedano sztuk więcej niż";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sprzedano sztuk mniej niż";
            // 
            // textBoxSelledNumberLessThen
            // 
            this.textBoxSelledNumberLessThen.Location = new System.Drawing.Point(26, 240);
            this.textBoxSelledNumberLessThen.Name = "textBoxSelledNumberLessThen";
            this.textBoxSelledNumberLessThen.Size = new System.Drawing.Size(173, 20);
            this.textBoxSelledNumberLessThen.TabIndex = 9;
            // 
            // checkBoxSelledNumberGreaterThan
            // 
            this.checkBoxSelledNumberGreaterThan.AutoSize = true;
            this.checkBoxSelledNumberGreaterThan.Location = new System.Drawing.Point(184, 184);
            this.checkBoxSelledNumberGreaterThan.Name = "checkBoxSelledNumberGreaterThan";
            this.checkBoxSelledNumberGreaterThan.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSelledNumberGreaterThan.TabIndex = 10;
            this.checkBoxSelledNumberGreaterThan.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxSelledNumberGreaterThan);
            this.Controls.Add(this.textBoxSelledNumberLessThen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownSelledItemsGreaterThan);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTrader);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSelledItemsGreaterThan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxTrader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.NumericUpDown numericUpDownSelledItemsGreaterThan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSelledNumberLessThen;
        private System.Windows.Forms.CheckBox checkBoxSelledNumberGreaterThan;
    }
}

