namespace My_website
{
    partial class InvoiceForm
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
            this.BackToOrderButton = new System.Windows.Forms.Button();
            this.objPricelabelInfo = new System.Windows.Forms.Label();
            this.totalLabelInfo = new System.Windows.Forms.Label();
            this.objectPriceLabel = new System.Windows.Forms.Label();
            this.totalUnitsPriceLabel = new System.Windows.Forms.Label();
            this.vatLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.vatLabelInfo = new System.Windows.Forms.Label();
            this.depositLabel = new System.Windows.Forms.Label();
            this.depositLabelInfo = new System.Windows.Forms.Label();
            this.customShapeLabelInfo = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.unitsTextBox = new System.Windows.Forms.TextBox();
            this.lefttopay = new System.Windows.Forms.Label();
            this.Left2pay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackToOrderButton
            // 
            this.BackToOrderButton.Location = new System.Drawing.Point(15, 259);
            this.BackToOrderButton.Name = "BackToOrderButton";
            this.BackToOrderButton.Size = new System.Drawing.Size(75, 23);
            this.BackToOrderButton.TabIndex = 1;
            this.BackToOrderButton.Text = "Order More";
            this.BackToOrderButton.UseVisualStyleBackColor = true;
            this.BackToOrderButton.Click += new System.EventHandler(this.BackToOrderButton_Click);
            // 
            // objPricelabelInfo
            // 
            this.objPricelabelInfo.AutoSize = true;
            this.objPricelabelInfo.Location = new System.Drawing.Point(244, 15);
            this.objPricelabelInfo.Name = "objPricelabelInfo";
            this.objPricelabelInfo.Size = new System.Drawing.Size(53, 13);
            this.objPricelabelInfo.TabIndex = 2;
            this.objPricelabelInfo.Text = "Unit Price";
            // 
            // totalLabelInfo
            // 
            this.totalLabelInfo.AutoSize = true;
            this.totalLabelInfo.Location = new System.Drawing.Point(400, 15);
            this.totalLabelInfo.Name = "totalLabelInfo";
            this.totalLabelInfo.Size = new System.Drawing.Size(31, 13);
            this.totalLabelInfo.TabIndex = 3;
            this.totalLabelInfo.Text = "Total";
            // 
            // objectPriceLabel
            // 
            this.objectPriceLabel.AutoSize = true;
            this.objectPriceLabel.Location = new System.Drawing.Point(244, 69);
            this.objectPriceLabel.Name = "objectPriceLabel";
            this.objectPriceLabel.Size = new System.Drawing.Size(60, 13);
            this.objectPriceLabel.TabIndex = 4;
            this.objectPriceLabel.Text = "objectPrice";
            // 
            // totalUnitsPriceLabel
            // 
            this.totalUnitsPriceLabel.AutoSize = true;
            this.totalUnitsPriceLabel.Location = new System.Drawing.Point(400, 69);
            this.totalUnitsPriceLabel.Name = "totalUnitsPriceLabel";
            this.totalUnitsPriceLabel.Size = new System.Drawing.Size(13, 13);
            this.totalUnitsPriceLabel.TabIndex = 5;
            this.totalUnitsPriceLabel.Text = "£";
            // 
            // vatLabel
            // 
            this.vatLabel.AutoSize = true;
            this.vatLabel.Location = new System.Drawing.Point(400, 130);
            this.vatLabel.Name = "vatLabel";
            this.vatLabel.Size = new System.Drawing.Size(13, 13);
            this.vatLabel.TabIndex = 6;
            this.vatLabel.Text = "£";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(400, 185);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(13, 13);
            this.totalLabel.TabIndex = 7;
            this.totalLabel.Text = "£";
            this.totalLabel.Click += new System.EventHandler(this.totalLabel_Click);
            // 
            // vatLabelInfo
            // 
            this.vatLabelInfo.AutoSize = true;
            this.vatLabelInfo.Location = new System.Drawing.Point(12, 130);
            this.vatLabelInfo.Name = "vatLabelInfo";
            this.vatLabelInfo.Size = new System.Drawing.Size(65, 13);
            this.vatLabelInfo.TabIndex = 8;
            this.vatLabelInfo.Text = "VAT @ 20%";
            // 
            // depositLabel
            // 
            this.depositLabel.AutoSize = true;
            this.depositLabel.Location = new System.Drawing.Point(129, 185);
            this.depositLabel.Name = "depositLabel";
            this.depositLabel.Size = new System.Drawing.Size(13, 13);
            this.depositLabel.TabIndex = 9;
            this.depositLabel.Text = "£";
            // 
            // depositLabelInfo
            // 
            this.depositLabelInfo.AutoSize = true;
            this.depositLabelInfo.Location = new System.Drawing.Point(12, 185);
            this.depositLabelInfo.Name = "depositLabelInfo";
            this.depositLabelInfo.Size = new System.Drawing.Size(43, 13);
            this.depositLabelInfo.TabIndex = 10;
            this.depositLabelInfo.Text = "Deposit";
            // 
            // customShapeLabelInfo
            // 
            this.customShapeLabelInfo.AutoSize = true;
            this.customShapeLabelInfo.Location = new System.Drawing.Point(12, 69);
            this.customShapeLabelInfo.Name = "customShapeLabelInfo";
            this.customShapeLabelInfo.Size = new System.Drawing.Size(109, 13);
            this.customShapeLabelInfo.TabIndex = 11;
            this.customShapeLabelInfo.Text = "Number of Computers";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // unitsTextBox
            // 
            this.unitsTextBox.Location = new System.Drawing.Point(127, 66);
            this.unitsTextBox.Name = "unitsTextBox";
            this.unitsTextBox.Size = new System.Drawing.Size(100, 20);
            this.unitsTextBox.TabIndex = 13;
            this.unitsTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lefttopay
            // 
            this.lefttopay.AutoSize = true;
            this.lefttopay.Location = new System.Drawing.Point(258, 226);
            this.lefttopay.Name = "lefttopay";
            this.lefttopay.Size = new System.Drawing.Size(57, 13);
            this.lefttopay.TabIndex = 14;
            this.lefttopay.Text = "Left to pay";
            this.lefttopay.Click += new System.EventHandler(this.lefttopay_Click);
            // 
            // Left2pay
            // 
            this.Left2pay.AutoSize = true;
            this.Left2pay.Location = new System.Drawing.Point(12, 226);
            this.Left2pay.Name = "Left2pay";
            this.Left2pay.Size = new System.Drawing.Size(57, 13);
            this.Left2pay.TabIndex = 15;
            this.Left2pay.Text = "Left to pay";
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 294);
            this.Controls.Add(this.Left2pay);
            this.Controls.Add(this.lefttopay);
            this.Controls.Add(this.unitsTextBox);
            this.Controls.Add(this.customShapeLabelInfo);
            this.Controls.Add(this.depositLabelInfo);
            this.Controls.Add(this.depositLabel);
            this.Controls.Add(this.vatLabelInfo);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.vatLabel);
            this.Controls.Add(this.totalUnitsPriceLabel);
            this.Controls.Add(this.objectPriceLabel);
            this.Controls.Add(this.totalLabelInfo);
            this.Controls.Add(this.objPricelabelInfo);
            this.Controls.Add(this.BackToOrderButton);
            this.Name = "InvoiceForm";
            this.Text = "Invoice Form";
            this.Load += new System.EventHandler(this.InvoiceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BackToOrderButton;
        private System.Windows.Forms.Label objPricelabelInfo;
        private System.Windows.Forms.Label totalLabelInfo;
        private System.Windows.Forms.Label objectPriceLabel;
        private System.Windows.Forms.Label totalUnitsPriceLabel;
        private System.Windows.Forms.Label vatLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label vatLabelInfo;
        private System.Windows.Forms.Label depositLabel;
        private System.Windows.Forms.Label depositLabelInfo;
        private System.Windows.Forms.Label customShapeLabelInfo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox unitsTextBox;
        private System.Windows.Forms.Label lefttopay;
        private System.Windows.Forms.Label Left2pay;
    }
}