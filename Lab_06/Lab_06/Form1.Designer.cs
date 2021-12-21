namespace Lab_06
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
            this.label1 = new System.Windows.Forms.Label();
            this.OrderIDTextbox = new System.Windows.Forms.TextBox();
            this.OrderCOmbo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Current_BalanceLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.User_IDTextbox = new System.Windows.Forms.TextBox();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.AddressTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.UserIDTextbox = new System.Windows.Forms.TextBox();
            this.shirtTextbox = new System.Windows.Forms.TextBox();
            this.PantTextbox = new System.Windows.Forms.TextBox();
            this.SuitTextbox = new System.Windows.Forms.TextBox();
            this.BedsheetTextbox = new System.Windows.Forms.TextBox();
            this.shirtCombo = new System.Windows.Forms.ComboBox();
            this.PantCombo = new System.Windows.Forms.ComboBox();
            this.SuitCOmbo = new System.Windows.Forms.ComboBox();
            this.BedsheetCombo = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.IDTextbox = new System.Windows.Forms.TextBox();
            this.LaundryListBox = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order ID";
            // 
            // OrderIDTextbox
            // 
            this.OrderIDTextbox.Location = new System.Drawing.Point(85, 21);
            this.OrderIDTextbox.Name = "OrderIDTextbox";
            this.OrderIDTextbox.Size = new System.Drawing.Size(100, 22);
            this.OrderIDTextbox.TabIndex = 1;
            // 
            // OrderCOmbo
            // 
            this.OrderCOmbo.FormattingEnabled = true;
            this.OrderCOmbo.Items.AddRange(new object[] {
            "Processing ",
            "Pending ",
            "Delivered"});
            this.OrderCOmbo.Location = new System.Drawing.Point(203, 21);
            this.OrderCOmbo.Name = "OrderCOmbo";
            this.OrderCOmbo.Size = new System.Drawing.Size(121, 24);
            this.OrderCOmbo.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(354, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Set Status ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Set_StatusOnClick);
            // 
            // Current_BalanceLabel
            // 
            this.Current_BalanceLabel.AutoSize = true;
            this.Current_BalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Current_BalanceLabel.ForeColor = System.Drawing.Color.Red;
            this.Current_BalanceLabel.Location = new System.Drawing.Point(15, 67);
            this.Current_BalanceLabel.Name = "Current_BalanceLabel";
            this.Current_BalanceLabel.Size = new System.Drawing.Size(129, 18);
            this.Current_BalanceLabel.TabIndex = 4;
            this.Current_BalanceLabel.Text = "Current Balance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(650, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "User ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(650, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(650, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Address";
            // 
            // User_IDTextbox
            // 
            this.User_IDTextbox.Location = new System.Drawing.Point(741, 24);
            this.User_IDTextbox.Name = "User_IDTextbox";
            this.User_IDTextbox.Size = new System.Drawing.Size(100, 22);
            this.User_IDTextbox.TabIndex = 8;
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(741, 66);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(100, 22);
            this.NameTextbox.TabIndex = 9;
            // 
            // AddressTextbox
            // 
            this.AddressTextbox.Location = new System.Drawing.Point(741, 115);
            this.AddressTextbox.Name = "AddressTextbox";
            this.AddressTextbox.Size = new System.Drawing.Size(100, 22);
            this.AddressTextbox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(994, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "User ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(994, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Shirt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(994, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Pants";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(994, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Suits";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(994, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Bed-sheet";
            // 
            // UserIDTextbox
            // 
            this.UserIDTextbox.Location = new System.Drawing.Point(1112, 18);
            this.UserIDTextbox.Name = "UserIDTextbox";
            this.UserIDTextbox.Size = new System.Drawing.Size(100, 22);
            this.UserIDTextbox.TabIndex = 16;
            // 
            // shirtTextbox
            // 
            this.shirtTextbox.Location = new System.Drawing.Point(1112, 72);
            this.shirtTextbox.Name = "shirtTextbox";
            this.shirtTextbox.Size = new System.Drawing.Size(100, 22);
            this.shirtTextbox.TabIndex = 17;
            // 
            // PantTextbox
            // 
            this.PantTextbox.Location = new System.Drawing.Point(1112, 121);
            this.PantTextbox.Name = "PantTextbox";
            this.PantTextbox.Size = new System.Drawing.Size(100, 22);
            this.PantTextbox.TabIndex = 18;
            // 
            // SuitTextbox
            // 
            this.SuitTextbox.Location = new System.Drawing.Point(1112, 170);
            this.SuitTextbox.Name = "SuitTextbox";
            this.SuitTextbox.Size = new System.Drawing.Size(100, 22);
            this.SuitTextbox.TabIndex = 19;
            // 
            // BedsheetTextbox
            // 
            this.BedsheetTextbox.Location = new System.Drawing.Point(1112, 224);
            this.BedsheetTextbox.Name = "BedsheetTextbox";
            this.BedsheetTextbox.Size = new System.Drawing.Size(100, 22);
            this.BedsheetTextbox.TabIndex = 20;
            // 
            // shirtCombo
            // 
            this.shirtCombo.FormattingEnabled = true;
            this.shirtCombo.Items.AddRange(new object[] {
            "Wash",
            "Iron",
            "Both"});
            this.shirtCombo.Location = new System.Drawing.Point(1282, 72);
            this.shirtCombo.Name = "shirtCombo";
            this.shirtCombo.Size = new System.Drawing.Size(121, 24);
            this.shirtCombo.TabIndex = 21;
            // 
            // PantCombo
            // 
            this.PantCombo.FormattingEnabled = true;
            this.PantCombo.Items.AddRange(new object[] {
            "Wash",
            "Iron",
            "both"});
            this.PantCombo.Location = new System.Drawing.Point(1282, 121);
            this.PantCombo.Name = "PantCombo";
            this.PantCombo.Size = new System.Drawing.Size(121, 24);
            this.PantCombo.TabIndex = 22;
            // 
            // SuitCOmbo
            // 
            this.SuitCOmbo.FormattingEnabled = true;
            this.SuitCOmbo.Items.AddRange(new object[] {
            "Wash",
            "Iron",
            "both"});
            this.SuitCOmbo.Location = new System.Drawing.Point(1282, 173);
            this.SuitCOmbo.Name = "SuitCOmbo";
            this.SuitCOmbo.Size = new System.Drawing.Size(121, 24);
            this.SuitCOmbo.TabIndex = 23;
            // 
            // BedsheetCombo
            // 
            this.BedsheetCombo.FormattingEnabled = true;
            this.BedsheetCombo.Items.AddRange(new object[] {
            "Wash",
            "Iron",
            "Both"});
            this.BedsheetCombo.Location = new System.Drawing.Point(1282, 224);
            this.BedsheetCombo.Name = "BedsheetCombo";
            this.BedsheetCombo.Size = new System.Drawing.Size(121, 24);
            this.BedsheetCombo.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(1020, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 34);
            this.button2.TabIndex = 25;
            this.button2.Text = "Place Order";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.PlaceOrderOnClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 399);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Order ID";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.Red;
            this.statusLabel.Location = new System.Drawing.Point(18, 449);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(50, 16);
            this.statusLabel.TabIndex = 27;
            this.statusLabel.Text = "Status";
            this.statusLabel.Click += new System.EventHandler(this.label12_Click);
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLabel.ForeColor = System.Drawing.Color.Red;
            this.AmountLabel.Location = new System.Drawing.Point(15, 489);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(58, 16);
            this.AmountLabel.TabIndex = 28;
            this.AmountLabel.Text = "Amount";
            // 
            // IDTextbox
            // 
            this.IDTextbox.Location = new System.Drawing.Point(128, 399);
            this.IDTextbox.Name = "IDTextbox";
            this.IDTextbox.Size = new System.Drawing.Size(100, 22);
            this.IDTextbox.TabIndex = 29;
            // 
            // LaundryListBox
            // 
            this.LaundryListBox.FormattingEnabled = true;
            this.LaundryListBox.ItemHeight = 16;
            this.LaundryListBox.Location = new System.Drawing.Point(354, 399);
            this.LaundryListBox.Name = "LaundryListBox";
            this.LaundryListBox.Size = new System.Drawing.Size(673, 324);
            this.LaundryListBox.TabIndex = 30;
            this.LaundryListBox.SelectedIndexChanged += new System.EventHandler(this.LaundryListBox_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(1050, 435);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 16);
            this.label14.TabIndex = 31;
            this.label14.Text = "Name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(1050, 477);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 16);
            this.label15.TabIndex = 32;
            this.label15.Text = "Address";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Location = new System.Drawing.Point(622, 196);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 123);
            this.button3.TabIndex = 33;
            this.button3.Text = "Create Account";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.CreateAccountOnClick);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.Location = new System.Drawing.Point(128, 563);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(179, 123);
            this.button4.TabIndex = 34;
            this.button4.Text = "See Order Details";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(1282, 317);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 34);
            this.button5.TabIndex = 35;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Clear1OnClick);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Red;
            this.button6.Location = new System.Drawing.Point(790, 240);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(121, 34);
            this.button6.TabIndex = 36;
            this.button6.Text = "Clear";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Clear2OnClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1551, 767);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.LaundryListBox);
            this.Controls.Add(this.IDTextbox);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BedsheetCombo);
            this.Controls.Add(this.SuitCOmbo);
            this.Controls.Add(this.PantCombo);
            this.Controls.Add(this.shirtCombo);
            this.Controls.Add(this.BedsheetTextbox);
            this.Controls.Add(this.SuitTextbox);
            this.Controls.Add(this.PantTextbox);
            this.Controls.Add(this.shirtTextbox);
            this.Controls.Add(this.UserIDTextbox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AddressTextbox);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.User_IDTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Current_BalanceLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OrderCOmbo);
            this.Controls.Add(this.OrderIDTextbox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OrderIDTextbox;
        private System.Windows.Forms.ComboBox OrderCOmbo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Current_BalanceLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox User_IDTextbox;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.TextBox AddressTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox UserIDTextbox;
        private System.Windows.Forms.TextBox shirtTextbox;
        private System.Windows.Forms.TextBox PantTextbox;
        private System.Windows.Forms.TextBox SuitTextbox;
        private System.Windows.Forms.TextBox BedsheetTextbox;
        private System.Windows.Forms.ComboBox shirtCombo;
        private System.Windows.Forms.ComboBox PantCombo;
        private System.Windows.Forms.ComboBox SuitCOmbo;
        private System.Windows.Forms.ComboBox BedsheetCombo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.TextBox IDTextbox;
        private System.Windows.Forms.ListBox LaundryListBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

