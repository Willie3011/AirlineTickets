
namespace AirlineTickets
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
            this.gbPersonalInfo = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpBook = new System.Windows.Forms.TabPage();
            this.tpReview = new System.Windows.Forms.TabPage();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbDepature = new System.Windows.Forms.ComboBox();
            this.gbDepature = new System.Windows.Forms.GroupBox();
            this.gbDestination = new System.Windows.Forms.GroupBox();
            this.cbDestination = new System.Windows.Forms.ComboBox();
            this.gbTickets = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbOne = new System.Windows.Forms.RadioButton();
            this.rbTwo = new System.Windows.Forms.RadioButton();
            this.rbThree = new System.Windows.Forms.RadioButton();
            this.rbFour = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.tpCheckout = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbPersonalInfo.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpBook.SuspendLayout();
            this.tpReview.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbDepature.SuspendLayout();
            this.gbDestination.SuspendLayout();
            this.gbTickets.SuspendLayout();
            this.tpCheckout.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPersonalInfo
            // 
            this.gbPersonalInfo.Controls.Add(this.txtEmail);
            this.gbPersonalInfo.Controls.Add(this.label2);
            this.gbPersonalInfo.Controls.Add(this.lblLastName);
            this.gbPersonalInfo.Controls.Add(this.txtLastName);
            this.gbPersonalInfo.Controls.Add(this.txtFirstName);
            this.gbPersonalInfo.Controls.Add(this.lblFirstName);
            this.gbPersonalInfo.Location = new System.Drawing.Point(8, 126);
            this.gbPersonalInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPersonalInfo.Name = "gbPersonalInfo";
            this.gbPersonalInfo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPersonalInfo.Size = new System.Drawing.Size(482, 239);
            this.gbPersonalInfo.TabIndex = 0;
            this.gbPersonalInfo.TabStop = false;
            this.gbPersonalInfo.Text = "Personal Information";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpBook);
            this.tabControl1.Controls.Add(this.tpCheckout);
            this.tabControl1.Controls.Add(this.tpReview);
            this.tabControl1.Location = new System.Drawing.Point(5, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1451, 826);
            this.tabControl1.TabIndex = 1;
            // 
            // tpBook
            // 
            this.tpBook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpBook.BackgroundImage")));
            this.tpBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpBook.Controls.Add(this.button1);
            this.tpBook.Controls.Add(this.groupBox1);
            this.tpBook.Controls.Add(this.lblHeading);
            this.tpBook.Controls.Add(this.gbPersonalInfo);
            this.tpBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tpBook.Location = new System.Drawing.Point(4, 29);
            this.tpBook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpBook.Name = "tpBook";
            this.tpBook.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpBook.Size = new System.Drawing.Size(1443, 793);
            this.tpBook.TabIndex = 0;
            this.tpBook.Text = "Book ";
            this.tpBook.UseVisualStyleBackColor = true;
            // 
            // tpReview
            // 
            this.tpReview.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpReview.BackgroundImage")));
            this.tpReview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpReview.Controls.Add(this.label4);
            this.tpReview.Controls.Add(this.listBox1);
            this.tpReview.Location = new System.Drawing.Point(4, 29);
            this.tpReview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpReview.Name = "tpReview";
            this.tpReview.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpReview.Size = new System.Drawing.Size(1443, 793);
            this.tpReview.TabIndex = 1;
            this.tpReview.Text = "Review";
            this.tpReview.UseVisualStyleBackColor = true;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.Navy;
            this.lblHeading.Location = new System.Drawing.Point(351, 4);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(575, 60);
            this.lblHeading.TabIndex = 1;
            this.lblHeading.Text = "Vanderbjilpark Airline";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(9, 73);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(85, 18);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(100, 61);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(155, 30);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(100, 114);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(155, 30);
            this.txtLastName.TabIndex = 2;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(9, 126);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(84, 18);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email Address:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(122, 169);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(177, 30);
            this.txtEmail.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbTickets);
            this.groupBox1.Controls.Add(this.gbDestination);
            this.groupBox1.Controls.Add(this.gbDepature);
            this.groupBox1.Location = new System.Drawing.Point(8, 400);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 239);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Booking Details";
            // 
            // cbDepature
            // 
            this.cbDepature.FormattingEnabled = true;
            this.cbDepature.Items.AddRange(new object[] {
            "Bloemfontein",
            "Johannesburg",
            "Cape Town",
            "George",
            "Kimberly",
            "Margate",
            "Sishen"});
            this.cbDepature.Location = new System.Drawing.Point(6, 29);
            this.cbDepature.Name = "cbDepature";
            this.cbDepature.Size = new System.Drawing.Size(186, 26);
            this.cbDepature.TabIndex = 1;
            // 
            // gbDepature
            // 
            this.gbDepature.Controls.Add(this.cbDepature);
            this.gbDepature.Location = new System.Drawing.Point(6, 44);
            this.gbDepature.Name = "gbDepature";
            this.gbDepature.Size = new System.Drawing.Size(200, 79);
            this.gbDepature.TabIndex = 2;
            this.gbDepature.TabStop = false;
            this.gbDepature.Text = "DEPATURE";
            // 
            // gbDestination
            // 
            this.gbDestination.Controls.Add(this.cbDestination);
            this.gbDestination.Location = new System.Drawing.Point(273, 44);
            this.gbDestination.Name = "gbDestination";
            this.gbDestination.Size = new System.Drawing.Size(200, 79);
            this.gbDestination.TabIndex = 3;
            this.gbDestination.TabStop = false;
            this.gbDestination.Text = "DESTINATION";
            // 
            // cbDestination
            // 
            this.cbDestination.FormattingEnabled = true;
            this.cbDestination.Items.AddRange(new object[] {
            "Bloemfontein",
            "Johannesburg",
            "Cape Town",
            "George",
            "Kimberly",
            "Margate",
            "Sishen"});
            this.cbDestination.Location = new System.Drawing.Point(6, 29);
            this.cbDestination.Name = "cbDestination";
            this.cbDestination.Size = new System.Drawing.Size(186, 26);
            this.cbDestination.TabIndex = 1;
            // 
            // gbTickets
            // 
            this.gbTickets.Controls.Add(this.rbFour);
            this.gbTickets.Controls.Add(this.rbThree);
            this.gbTickets.Controls.Add(this.rbTwo);
            this.gbTickets.Controls.Add(this.rbOne);
            this.gbTickets.Controls.Add(this.label1);
            this.gbTickets.Location = new System.Drawing.Point(6, 139);
            this.gbTickets.Name = "gbTickets";
            this.gbTickets.Size = new System.Drawing.Size(200, 94);
            this.gbTickets.TabIndex = 4;
            this.gbTickets.TabStop = false;
            this.gbTickets.Text = "Tickets";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Tickets:";
            // 
            // rbOne
            // 
            this.rbOne.AutoSize = true;
            this.rbOne.Location = new System.Drawing.Point(9, 52);
            this.rbOne.Name = "rbOne";
            this.rbOne.Size = new System.Drawing.Size(37, 22);
            this.rbOne.TabIndex = 1;
            this.rbOne.TabStop = true;
            this.rbOne.Text = "1";
            this.rbOne.UseVisualStyleBackColor = true;
            // 
            // rbTwo
            // 
            this.rbTwo.AutoSize = true;
            this.rbTwo.Location = new System.Drawing.Point(52, 52);
            this.rbTwo.Name = "rbTwo";
            this.rbTwo.Size = new System.Drawing.Size(37, 22);
            this.rbTwo.TabIndex = 2;
            this.rbTwo.TabStop = true;
            this.rbTwo.Text = "2";
            this.rbTwo.UseVisualStyleBackColor = true;
            // 
            // rbThree
            // 
            this.rbThree.AutoSize = true;
            this.rbThree.Location = new System.Drawing.Point(101, 52);
            this.rbThree.Name = "rbThree";
            this.rbThree.Size = new System.Drawing.Size(37, 22);
            this.rbThree.TabIndex = 3;
            this.rbThree.TabStop = true;
            this.rbThree.Text = "3";
            this.rbThree.UseVisualStyleBackColor = true;
            // 
            // rbFour
            // 
            this.rbFour.AutoSize = true;
            this.rbFour.Location = new System.Drawing.Point(144, 52);
            this.rbFour.Name = "rbFour";
            this.rbFour.Size = new System.Drawing.Size(37, 22);
            this.rbFour.TabIndex = 4;
            this.rbFour.TabStop = true;
            this.rbFour.Text = "4";
            this.rbFour.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(102)))), ((int)(((byte)(164)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button1.Location = new System.Drawing.Point(20, 697);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(318, 56);
            this.button1.TabIndex = 3;
            this.button1.Text = "Book";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tpCheckout
            // 
            this.tpCheckout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpCheckout.BackgroundImage")));
            this.tpCheckout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpCheckout.Controls.Add(this.label3);
            this.tpCheckout.Location = new System.Drawing.Point(4, 29);
            this.tpCheckout.Margin = new System.Windows.Forms.Padding(4);
            this.tpCheckout.Name = "tpCheckout";
            this.tpCheckout.Size = new System.Drawing.Size(1443, 793);
            this.tpCheckout.TabIndex = 2;
            this.tpCheckout.Text = "Checkout";
            this.tpCheckout.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(7, 134);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(753, 564);
            this.listBox1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(336, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(575, 60);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vanderbjilpark Airline";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(336, 4);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(575, 60);
            this.label4.TabIndex = 2;
            this.label4.Text = "Vanderbjilpark Airline";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 832);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Airline Tickets";
            this.gbPersonalInfo.ResumeLayout(false);
            this.gbPersonalInfo.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpBook.ResumeLayout(false);
            this.tpBook.PerformLayout();
            this.tpReview.ResumeLayout(false);
            this.tpReview.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gbDepature.ResumeLayout(false);
            this.gbDestination.ResumeLayout(false);
            this.gbTickets.ResumeLayout(false);
            this.gbTickets.PerformLayout();
            this.tpCheckout.ResumeLayout(false);
            this.tpCheckout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPersonalInfo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpBook;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.TabPage tpReview;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbDepature;
        private System.Windows.Forms.ComboBox cbDepature;
        private System.Windows.Forms.GroupBox gbTickets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDestination;
        private System.Windows.Forms.ComboBox cbDestination;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbFour;
        private System.Windows.Forms.RadioButton rbThree;
        private System.Windows.Forms.RadioButton rbTwo;
        private System.Windows.Forms.RadioButton rbOne;
        private System.Windows.Forms.TabPage tpCheckout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
    }
}

