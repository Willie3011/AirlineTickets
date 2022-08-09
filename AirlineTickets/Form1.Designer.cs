
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
            this.gbPersonalInfo = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpBook = new System.Windows.Forms.TabPage();
            this.tpReview = new System.Windows.Forms.TabPage();
            this.tpCheckout = new System.Windows.Forms.TabPage();
            this.lblHeading = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPersonalInfo
            // 
            this.gbPersonalInfo.Location = new System.Drawing.Point(6, 101);
            this.gbPersonalInfo.Name = "gbPersonalInfo";
            this.gbPersonalInfo.Size = new System.Drawing.Size(386, 100);
            this.gbPersonalInfo.TabIndex = 0;
            this.gbPersonalInfo.TabStop = false;
            this.gbPersonalInfo.Text = "Personal Information";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpBook);
            this.tabControl1.Controls.Add(this.tpCheckout);
            this.tabControl1.Controls.Add(this.tpReview);
            this.tabControl1.Location = new System.Drawing.Point(4, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1161, 795);
            this.tabControl1.TabIndex = 1;
            // 
            // tpBook
            // 
            this.tpBook.Controls.Add(this.lblHeading);
            this.tpBook.Controls.Add(this.gbPersonalInfo);
            this.tpBook.Location = new System.Drawing.Point(4, 25);
            this.tpBook.Name = "tpBook";
            this.tpBook.Padding = new System.Windows.Forms.Padding(3);
            this.tpBook.Size = new System.Drawing.Size(1153, 766);
            this.tpBook.TabIndex = 0;
            this.tpBook.Text = "Book ";
            this.tpBook.UseVisualStyleBackColor = true;
            // 
            // tpReview
            // 
            this.tpReview.Location = new System.Drawing.Point(4, 25);
            this.tpReview.Name = "tpReview";
            this.tpReview.Padding = new System.Windows.Forms.Padding(3);
            this.tpReview.Size = new System.Drawing.Size(1153, 766);
            this.tpReview.TabIndex = 1;
            this.tpReview.Text = "Review";
            this.tpReview.UseVisualStyleBackColor = true;
            // 
            // tpCheckout
            // 
            this.tpCheckout.Location = new System.Drawing.Point(4, 25);
            this.tpCheckout.Name = "tpCheckout";
            this.tpCheckout.Size = new System.Drawing.Size(1153, 766);
            this.tpCheckout.TabIndex = 2;
            this.tpCheckout.Text = "Checkout";
            this.tpCheckout.UseVisualStyleBackColor = true;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.Navy;
            this.lblHeading.Location = new System.Drawing.Point(343, 3);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(388, 41);
            this.lblHeading.TabIndex = 1;
            this.lblHeading.Text = "Vanderbjilpark Airline";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 800);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Airline Tickets";
            this.tabControl1.ResumeLayout(false);
            this.tpBook.ResumeLayout(false);
            this.tpBook.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPersonalInfo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpBook;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.TabPage tpCheckout;
        private System.Windows.Forms.TabPage tpReview;
    }
}

