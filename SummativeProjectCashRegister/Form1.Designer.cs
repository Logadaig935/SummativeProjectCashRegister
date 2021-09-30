namespace SummativeProjectCashRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sealTextBox = new System.Windows.Forms.TextBox();
            this.kingsTextBox = new System.Windows.Forms.TextBox();
            this.eggTextBox = new System.Windows.Forms.TextBox();
            this.geoCalcButton = new System.Windows.Forms.Button();
            this.sealLabel = new System.Windows.Forms.Label();
            this.kingsLabel = new System.Windows.Forms.Label();
            this.eggLabel = new System.Windows.Forms.Label();
            this.printerTextLabel = new System.Windows.Forms.Label();
            this.subTotalText = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.changeCalcButton = new System.Windows.Forms.Button();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.changeLabel = new System.Windows.Forms.Label();
            this.printerButton = new System.Windows.Forms.Button();
            this.changeTextLabel = new System.Windows.Forms.Label();
            this.subTotalTextLabel = new System.Windows.Forms.Label();
            this.taxTextLabel = new System.Windows.Forms.Label();
            this.totalTextlabel = new System.Windows.Forms.Label();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sealTextBox
            // 
            this.sealTextBox.Location = new System.Drawing.Point(168, 32);
            this.sealTextBox.Name = "sealTextBox";
            this.sealTextBox.Size = new System.Drawing.Size(134, 26);
            this.sealTextBox.TabIndex = 0;
            this.sealTextBox.TextChanged += new System.EventHandler(this.sealTextBox_TextChanged);
            // 
            // kingsTextBox
            // 
            this.kingsTextBox.Location = new System.Drawing.Point(168, 79);
            this.kingsTextBox.Name = "kingsTextBox";
            this.kingsTextBox.Size = new System.Drawing.Size(134, 26);
            this.kingsTextBox.TabIndex = 1;
            // 
            // eggTextBox
            // 
            this.eggTextBox.Location = new System.Drawing.Point(168, 126);
            this.eggTextBox.Name = "eggTextBox";
            this.eggTextBox.Size = new System.Drawing.Size(134, 26);
            this.eggTextBox.TabIndex = 2;
            // 
            // geoCalcButton
            // 
            this.geoCalcButton.Location = new System.Drawing.Point(17, 166);
            this.geoCalcButton.Name = "geoCalcButton";
            this.geoCalcButton.Size = new System.Drawing.Size(285, 36);
            this.geoCalcButton.TabIndex = 3;
            this.geoCalcButton.Text = "Calculate Geo";
            this.geoCalcButton.UseVisualStyleBackColor = true;
            this.geoCalcButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // sealLabel
            // 
            this.sealLabel.BackColor = System.Drawing.Color.Transparent;
            this.sealLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sealLabel.ForeColor = System.Drawing.Color.MistyRose;
            this.sealLabel.Location = new System.Drawing.Point(13, 32);
            this.sealLabel.Name = "sealLabel";
            this.sealLabel.Size = new System.Drawing.Size(149, 26);
            this.sealLabel.TabIndex = 4;
            this.sealLabel.Text = "Hallownest Seal";
            // 
            // kingsLabel
            // 
            this.kingsLabel.BackColor = System.Drawing.Color.Transparent;
            this.kingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kingsLabel.ForeColor = System.Drawing.Color.MistyRose;
            this.kingsLabel.Location = new System.Drawing.Point(13, 82);
            this.kingsLabel.Name = "kingsLabel";
            this.kingsLabel.Size = new System.Drawing.Size(149, 26);
            this.kingsLabel.TabIndex = 5;
            this.kingsLabel.Text = "King\'s Idol";
            // 
            // eggLabel
            // 
            this.eggLabel.BackColor = System.Drawing.Color.Transparent;
            this.eggLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eggLabel.ForeColor = System.Drawing.Color.MistyRose;
            this.eggLabel.Location = new System.Drawing.Point(13, 129);
            this.eggLabel.Name = "eggLabel";
            this.eggLabel.Size = new System.Drawing.Size(149, 26);
            this.eggLabel.TabIndex = 6;
            this.eggLabel.Text = "Arcane Egg";
            // 
            // printerTextLabel
            // 
            this.printerTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.printerTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printerTextLabel.ForeColor = System.Drawing.Color.MistyRose;
            this.printerTextLabel.Location = new System.Drawing.Point(553, 32);
            this.printerTextLabel.Name = "printerTextLabel";
            this.printerTextLabel.Size = new System.Drawing.Size(398, 474);
            this.printerTextLabel.TabIndex = 7;
            this.printerTextLabel.Text = "Waiting for Order...";
            // 
            // subTotalText
            // 
            this.subTotalText.BackColor = System.Drawing.Color.Transparent;
            this.subTotalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalText.ForeColor = System.Drawing.Color.MistyRose;
            this.subTotalText.Location = new System.Drawing.Point(168, 224);
            this.subTotalText.Name = "subTotalText";
            this.subTotalText.Size = new System.Drawing.Size(134, 26);
            this.subTotalText.TabIndex = 8;
            // 
            // taxLabel
            // 
            this.taxLabel.BackColor = System.Drawing.Color.Transparent;
            this.taxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.ForeColor = System.Drawing.Color.MistyRose;
            this.taxLabel.Location = new System.Drawing.Point(168, 266);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(134, 26);
            this.taxLabel.TabIndex = 9;
            // 
            // totalLabel
            // 
            this.totalLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.MistyRose;
            this.totalLabel.Location = new System.Drawing.Point(168, 311);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(134, 26);
            this.totalLabel.TabIndex = 10;
            // 
            // changeCalcButton
            // 
            this.changeCalcButton.Location = new System.Drawing.Point(17, 416);
            this.changeCalcButton.Name = "changeCalcButton";
            this.changeCalcButton.Size = new System.Drawing.Size(285, 36);
            this.changeCalcButton.TabIndex = 11;
            this.changeCalcButton.Text = "Calculate Change";
            this.changeCalcButton.UseVisualStyleBackColor = true;
            this.changeCalcButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.BackColor = System.Drawing.Color.Transparent;
            this.tenderedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.ForeColor = System.Drawing.Color.MistyRose;
            this.tenderedLabel.Location = new System.Drawing.Point(13, 375);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(149, 26);
            this.tenderedLabel.TabIndex = 12;
            this.tenderedLabel.Text = "Tendered";
            // 
            // tenderedInput
            // 
            this.tenderedInput.Location = new System.Drawing.Point(168, 375);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(134, 26);
            this.tenderedInput.TabIndex = 13;
            // 
            // changeLabel
            // 
            this.changeLabel.BackColor = System.Drawing.Color.Transparent;
            this.changeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.ForeColor = System.Drawing.Color.MistyRose;
            this.changeLabel.Location = new System.Drawing.Point(168, 480);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(134, 26);
            this.changeLabel.TabIndex = 14;
            // 
            // printerButton
            // 
            this.printerButton.Location = new System.Drawing.Point(17, 543);
            this.printerButton.Name = "printerButton";
            this.printerButton.Size = new System.Drawing.Size(285, 36);
            this.printerButton.TabIndex = 15;
            this.printerButton.Text = "Print Receipt";
            this.printerButton.UseVisualStyleBackColor = true;
            this.printerButton.Click += new System.EventHandler(this.printerButton_Click);
            // 
            // changeTextLabel
            // 
            this.changeTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.changeTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeTextLabel.ForeColor = System.Drawing.Color.MistyRose;
            this.changeTextLabel.Location = new System.Drawing.Point(13, 480);
            this.changeTextLabel.Name = "changeTextLabel";
            this.changeTextLabel.Size = new System.Drawing.Size(149, 26);
            this.changeTextLabel.TabIndex = 16;
            this.changeTextLabel.Text = "Change";
            // 
            // subTotalTextLabel
            // 
            this.subTotalTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.subTotalTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalTextLabel.ForeColor = System.Drawing.Color.MistyRose;
            this.subTotalTextLabel.Location = new System.Drawing.Point(13, 224);
            this.subTotalTextLabel.Name = "subTotalTextLabel";
            this.subTotalTextLabel.Size = new System.Drawing.Size(149, 26);
            this.subTotalTextLabel.TabIndex = 17;
            this.subTotalTextLabel.Text = "Sub Total";
            // 
            // taxTextLabel
            // 
            this.taxTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.taxTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxTextLabel.ForeColor = System.Drawing.Color.MistyRose;
            this.taxTextLabel.Location = new System.Drawing.Point(13, 266);
            this.taxTextLabel.Name = "taxTextLabel";
            this.taxTextLabel.Size = new System.Drawing.Size(149, 26);
            this.taxTextLabel.TabIndex = 18;
            this.taxTextLabel.Text = "Tax";
            // 
            // totalTextlabel
            // 
            this.totalTextlabel.BackColor = System.Drawing.Color.Transparent;
            this.totalTextlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTextlabel.ForeColor = System.Drawing.Color.MistyRose;
            this.totalTextlabel.Location = new System.Drawing.Point(13, 311);
            this.totalTextlabel.Name = "totalTextlabel";
            this.totalTextlabel.Size = new System.Drawing.Size(149, 26);
            this.totalTextlabel.TabIndex = 19;
            this.totalTextlabel.Text = "Total";
            // 
            // newOrderButton
            // 
            this.newOrderButton.Location = new System.Drawing.Point(609, 543);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(285, 36);
            this.newOrderButton.TabIndex = 20;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SummativeProjectCashRegister.Properties.Resources.Vibin;
            this.ClientSize = new System.Drawing.Size(977, 645);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.totalTextlabel);
            this.Controls.Add(this.taxTextLabel);
            this.Controls.Add(this.subTotalTextLabel);
            this.Controls.Add(this.changeTextLabel);
            this.Controls.Add(this.printerButton);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.changeCalcButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subTotalText);
            this.Controls.Add(this.printerTextLabel);
            this.Controls.Add(this.eggLabel);
            this.Controls.Add(this.kingsLabel);
            this.Controls.Add(this.sealLabel);
            this.Controls.Add(this.geoCalcButton);
            this.Controls.Add(this.eggTextBox);
            this.Controls.Add(this.kingsTextBox);
            this.Controls.Add(this.sealTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Lemm\'s Relic Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sealTextBox;
        private System.Windows.Forms.TextBox kingsTextBox;
        private System.Windows.Forms.TextBox eggTextBox;
        private System.Windows.Forms.Button geoCalcButton;
        private System.Windows.Forms.Label sealLabel;
        private System.Windows.Forms.Label kingsLabel;
        private System.Windows.Forms.Label eggLabel;
        private System.Windows.Forms.Label printerTextLabel;
        private System.Windows.Forms.Label subTotalText;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button changeCalcButton;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button printerButton;
        private System.Windows.Forms.Label changeTextLabel;
        private System.Windows.Forms.Label subTotalTextLabel;
        private System.Windows.Forms.Label taxTextLabel;
        private System.Windows.Forms.Label totalTextlabel;
        private System.Windows.Forms.Button newOrderButton;
    }
}

