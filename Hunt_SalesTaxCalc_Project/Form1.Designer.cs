namespace Hunt_SalesTaxCalc_Project
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
            this.BBTitle = new System.Windows.Forms.Label();
            this.BasePriceTxt = new System.Windows.Forms.Label();
            this.sBasePriceTxtBox = new System.Windows.Forms.TextBox();
            this.WarrantyTxt = new System.Windows.Forms.Label();
            this.StateSoldTxt = new System.Windows.Forms.Label();
            this.sStateCombo = new System.Windows.Forms.ComboBox();
            this.CalcButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.TotCostTxt = new System.Windows.Forms.Label();
            this.sFinalPrice = new System.Windows.Forms.Label();
            this.sWarrantyCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BBTitle
            // 
            this.BBTitle.AutoSize = true;
            this.BBTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BBTitle.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBTitle.Location = new System.Drawing.Point(12, 9);
            this.BBTitle.Name = "BBTitle";
            this.BBTitle.Size = new System.Drawing.Size(387, 23);
            this.BBTitle.TabIndex = 0;
            this.BBTitle.Text = "Billy Bob\'s Vehicle Sales Tax Calculator";
            // 
            // BasePriceTxt
            // 
            this.BasePriceTxt.AutoSize = true;
            this.BasePriceTxt.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasePriceTxt.Location = new System.Drawing.Point(21, 63);
            this.BasePriceTxt.Name = "BasePriceTxt";
            this.BasePriceTxt.Size = new System.Drawing.Size(139, 20);
            this.BasePriceTxt.TabIndex = 1;
            this.BasePriceTxt.Text = "Vehicle Base Price";
            // 
            // sBasePriceTxtBox
            // 
            this.sBasePriceTxtBox.Location = new System.Drawing.Point(166, 63);
            this.sBasePriceTxtBox.Name = "sBasePriceTxtBox";
            this.sBasePriceTxtBox.Size = new System.Drawing.Size(100, 20);
            this.sBasePriceTxtBox.TabIndex = 2;
            // 
            // WarrantyTxt
            // 
            this.WarrantyTxt.AutoSize = true;
            this.WarrantyTxt.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarrantyTxt.Location = new System.Drawing.Point(12, 92);
            this.WarrantyTxt.Name = "WarrantyTxt";
            this.WarrantyTxt.Size = new System.Drawing.Size(148, 20);
            this.WarrantyTxt.TabIndex = 3;
            this.WarrantyTxt.Text = "Extended Warranty";
            // 
            // StateSoldTxt
            // 
            this.StateSoldTxt.AutoSize = true;
            this.StateSoldTxt.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateSoldTxt.Location = new System.Drawing.Point(76, 123);
            this.StateSoldTxt.Name = "StateSoldTxt";
            this.StateSoldTxt.Size = new System.Drawing.Size(84, 20);
            this.StateSoldTxt.TabIndex = 5;
            this.StateSoldTxt.Text = "State Sold";
            // 
            // sStateCombo
            // 
            this.sStateCombo.FormattingEnabled = true;
            this.sStateCombo.Items.AddRange(new object[] {
            "WA",
            "OR"});
            this.sStateCombo.Location = new System.Drawing.Point(167, 121);
            this.sStateCombo.Name = "sStateCombo";
            this.sStateCombo.Size = new System.Drawing.Size(47, 21);
            this.sStateCombo.TabIndex = 6;
            this.sStateCombo.Text = "WA";
            // 
            // CalcButton
            // 
            this.CalcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcButton.Location = new System.Drawing.Point(324, 224);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(75, 23);
            this.CalcButton.TabIndex = 7;
            this.CalcButton.Text = "Calculate";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(324, 60);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(325, 89);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 9;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // TotCostTxt
            // 
            this.TotCostTxt.AutoSize = true;
            this.TotCostTxt.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotCostTxt.Location = new System.Drawing.Point(32, 172);
            this.TotCostTxt.Name = "TotCostTxt";
            this.TotCostTxt.Size = new System.Drawing.Size(159, 20);
            this.TotCostTxt.TabIndex = 10;
            this.TotCostTxt.Text = "Total Vehicle Cost Is:";
            // 
            // sFinalPrice
            // 
            this.sFinalPrice.AutoSize = true;
            this.sFinalPrice.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sFinalPrice.Location = new System.Drawing.Point(32, 201);
            this.sFinalPrice.Name = "sFinalPrice";
            this.sFinalPrice.Size = new System.Drawing.Size(21, 23);
            this.sFinalPrice.TabIndex = 11;
            this.sFinalPrice.Text = "0";
            // 
            // sWarrantyCombo
            // 
            this.sWarrantyCombo.FormattingEnabled = true;
            this.sWarrantyCombo.Items.AddRange(new object[] {
            "One Year",
            "Two Years",
            "Three Years"});
            this.sWarrantyCombo.Location = new System.Drawing.Point(166, 92);
            this.sWarrantyCombo.Name = "sWarrantyCombo";
            this.sWarrantyCombo.Size = new System.Drawing.Size(100, 21);
            this.sWarrantyCombo.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(412, 259);
            this.Controls.Add(this.sWarrantyCombo);
            this.Controls.Add(this.sFinalPrice);
            this.Controls.Add(this.TotCostTxt);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.sStateCombo);
            this.Controls.Add(this.StateSoldTxt);
            this.Controls.Add(this.WarrantyTxt);
            this.Controls.Add(this.sBasePriceTxtBox);
            this.Controls.Add(this.BasePriceTxt);
            this.Controls.Add(this.BBTitle);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Billy Bob\'s Vehicle Sales Tax Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BBTitle;
        private System.Windows.Forms.Label BasePriceTxt;
        private System.Windows.Forms.TextBox sBasePriceTxtBox;
        private System.Windows.Forms.Label WarrantyTxt;
        private System.Windows.Forms.Label StateSoldTxt;
        private System.Windows.Forms.ComboBox sStateCombo;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label TotCostTxt;
        private System.Windows.Forms.Label sFinalPrice;
        private System.Windows.Forms.ComboBox sWarrantyCombo;
    }
}

