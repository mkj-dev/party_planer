
namespace Planer_Przyjec
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fancyDecorations = new System.Windows.Forms.CheckBox();
            this.healthyOption = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalCost = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // fancyDecorations
            // 
            this.fancyDecorations.AutoSize = true;
            this.fancyDecorations.Checked = true;
            this.fancyDecorations.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fancyDecorations.Location = new System.Drawing.Point(25, 61);
            this.fancyDecorations.Name = "fancyDecorations";
            this.fancyDecorations.Size = new System.Drawing.Size(122, 19);
            this.fancyDecorations.TabIndex = 0;
            this.fancyDecorations.Text = "Fancy decorations";
            this.fancyDecorations.UseVisualStyleBackColor = true;
            this.fancyDecorations.CheckedChanged += new System.EventHandler(this.fancyDecorations_CheckedChanged);
            // 
            // healthyOption
            // 
            this.healthyOption.AutoSize = true;
            this.healthyOption.Location = new System.Drawing.Point(25, 92);
            this.healthyOption.Name = "healthyOption";
            this.healthyOption.Size = new System.Drawing.Size(105, 19);
            this.healthyOption.TabIndex = 1;
            this.healthyOption.Text = "Healthy option";
            this.healthyOption.UseVisualStyleBackColor = true;
            this.healthyOption.CheckedChanged += new System.EventHandler(this.healthyOption_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of people";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Price";
            // 
            // totalCost
            // 
            this.totalCost.Location = new System.Drawing.Point(69, 120);
            this.totalCost.Name = "totalCost";
            this.totalCost.Size = new System.Drawing.Size(100, 23);
            this.totalCost.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(25, 32);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 162);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.totalCost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.healthyOption);
            this.Controls.Add(this.fancyDecorations);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Party planer";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox fancyDecorations;
        private System.Windows.Forms.CheckBox healthyOption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox totalCost;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

