namespace CST324_TermProject_RideShare
{
    partial class form_Driver
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
            this.chooseRequest_btn = new System.Windows.Forms.Button();
            this.requestAvailable_lb = new System.Windows.Forms.Label();
            this.driverRequest_lbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // chooseRequest_btn
            // 
            this.chooseRequest_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.chooseRequest_btn.Location = new System.Drawing.Point(506, 81);
            this.chooseRequest_btn.Name = "chooseRequest_btn";
            this.chooseRequest_btn.Size = new System.Drawing.Size(241, 47);
            this.chooseRequest_btn.TabIndex = 5;
            this.chooseRequest_btn.Text = "Pickup Rider";
            this.chooseRequest_btn.UseVisualStyleBackColor = true;
            // 
            // requestAvailable_lb
            // 
            this.requestAvailable_lb.AutoSize = true;
            this.requestAvailable_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.requestAvailable_lb.Location = new System.Drawing.Point(53, 36);
            this.requestAvailable_lb.Name = "requestAvailable_lb";
            this.requestAvailable_lb.Size = new System.Drawing.Size(179, 25);
            this.requestAvailable_lb.TabIndex = 4;
            this.requestAvailable_lb.Text = "Requests Available";
            // 
            // driverRequest_lbox
            // 
            this.driverRequest_lbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.driverRequest_lbox.FormattingEnabled = true;
            this.driverRequest_lbox.ItemHeight = 22;
            this.driverRequest_lbox.Location = new System.Drawing.Point(58, 81);
            this.driverRequest_lbox.Name = "driverRequest_lbox";
            this.driverRequest_lbox.Size = new System.Drawing.Size(371, 334);
            this.driverRequest_lbox.TabIndex = 3;
            // 
            // form_Driver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chooseRequest_btn);
            this.Controls.Add(this.requestAvailable_lb);
            this.Controls.Add(this.driverRequest_lbox);
            this.Name = "form_Driver";
            this.Text = "form_Driver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chooseRequest_btn;
        private System.Windows.Forms.Label requestAvailable_lb;
        private System.Windows.Forms.ListBox driverRequest_lbox;
    }
}