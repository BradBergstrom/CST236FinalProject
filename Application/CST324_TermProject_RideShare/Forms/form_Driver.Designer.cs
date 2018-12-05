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
            this.driverRequestDetails_tb = new System.Windows.Forms.TextBox();
            this.driverDetails_lb = new System.Windows.Forms.Label();
            this.driverUpdate_btn = new System.Windows.Forms.Button();
            this.driverEta_lb = new System.Windows.Forms.Label();
            this.driverETA_tb = new System.Windows.Forms.TextBox();
            this.driverSubmit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chooseRequest_btn
            // 
            this.chooseRequest_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.chooseRequest_btn.Location = new System.Drawing.Point(506, 81);
            this.chooseRequest_btn.Name = "chooseRequest_btn";
            this.chooseRequest_btn.Size = new System.Drawing.Size(241, 47);
            this.chooseRequest_btn.TabIndex = 5;
            this.chooseRequest_btn.Text = "Pickup Request";
            this.chooseRequest_btn.UseVisualStyleBackColor = true;
            this.chooseRequest_btn.Click += new System.EventHandler(this.chooseRequest_btn_Click);
            // 
            // requestAvailable_lb
            // 
            this.requestAvailable_lb.AutoSize = true;
            this.requestAvailable_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.requestAvailable_lb.Location = new System.Drawing.Point(53, 36);
            this.requestAvailable_lb.Name = "requestAvailable_lb";
            this.requestAvailable_lb.Size = new System.Drawing.Size(152, 20);
            this.requestAvailable_lb.TabIndex = 4;
            this.requestAvailable_lb.Text = "Requests Available";
            // 
            // driverRequest_lbox
            // 
            this.driverRequest_lbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.driverRequest_lbox.FormattingEnabled = true;
            this.driverRequest_lbox.ItemHeight = 20;
            this.driverRequest_lbox.Location = new System.Drawing.Point(58, 81);
            this.driverRequest_lbox.Name = "driverRequest_lbox";
            this.driverRequest_lbox.Size = new System.Drawing.Size(106, 264);
            this.driverRequest_lbox.TabIndex = 3;
            this.driverRequest_lbox.SelectedIndexChanged += new System.EventHandler(this.driverRequest_lbox_SelectedIndexChanged);
            // 
            // driverRequestDetails_tb
            // 
            this.driverRequestDetails_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.driverRequestDetails_tb.Location = new System.Drawing.Point(195, 81);
            this.driverRequestDetails_tb.Multiline = true;
            this.driverRequestDetails_tb.Name = "driverRequestDetails_tb";
            this.driverRequestDetails_tb.Size = new System.Drawing.Size(292, 268);
            this.driverRequestDetails_tb.TabIndex = 17;
            // 
            // driverDetails_lb
            // 
            this.driverDetails_lb.AutoSize = true;
            this.driverDetails_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.driverDetails_lb.Location = new System.Drawing.Point(300, 36);
            this.driverDetails_lb.Name = "driverDetails_lb";
            this.driverDetails_lb.Size = new System.Drawing.Size(62, 20);
            this.driverDetails_lb.TabIndex = 18;
            this.driverDetails_lb.Text = "Details";
            // 
            // driverUpdate_btn
            // 
            this.driverUpdate_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.driverUpdate_btn.Location = new System.Drawing.Point(58, 388);
            this.driverUpdate_btn.Name = "driverUpdate_btn";
            this.driverUpdate_btn.Size = new System.Drawing.Size(106, 29);
            this.driverUpdate_btn.TabIndex = 19;
            this.driverUpdate_btn.Text = "Update";
            this.driverUpdate_btn.UseVisualStyleBackColor = true;
            this.driverUpdate_btn.Click += new System.EventHandler(this.driverUpdate_btn_Click);
            // 
            // driverEta_lb
            // 
            this.driverEta_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.driverEta_lb.Location = new System.Drawing.Point(506, 135);
            this.driverEta_lb.Name = "driverEta_lb";
            this.driverEta_lb.Size = new System.Drawing.Size(53, 29);
            this.driverEta_lb.TabIndex = 20;
            this.driverEta_lb.Text = "ETA:";
            this.driverEta_lb.Visible = false;
            // 
            // driverETA_tb
            // 
            this.driverETA_tb.Location = new System.Drawing.Point(565, 135);
            this.driverETA_tb.Name = "driverETA_tb";
            this.driverETA_tb.Size = new System.Drawing.Size(182, 22);
            this.driverETA_tb.TabIndex = 21;
            this.driverETA_tb.Visible = false;
            // 
            // driverSubmit_btn
            // 
            this.driverSubmit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.driverSubmit_btn.Location = new System.Drawing.Point(565, 164);
            this.driverSubmit_btn.Name = "driverSubmit_btn";
            this.driverSubmit_btn.Size = new System.Drawing.Size(182, 34);
            this.driverSubmit_btn.TabIndex = 22;
            this.driverSubmit_btn.Text = "Submit";
            this.driverSubmit_btn.UseVisualStyleBackColor = true;
            this.driverSubmit_btn.Visible = false;
            this.driverSubmit_btn.Click += new System.EventHandler(this.driverSubmit_btn_Click);
            // 
            // form_Driver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.driverSubmit_btn);
            this.Controls.Add(this.driverETA_tb);
            this.Controls.Add(this.driverEta_lb);
            this.Controls.Add(this.driverUpdate_btn);
            this.Controls.Add(this.driverDetails_lb);
            this.Controls.Add(this.driverRequestDetails_tb);
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
        private System.Windows.Forms.TextBox driverRequestDetails_tb;
        private System.Windows.Forms.Label driverDetails_lb;
        private System.Windows.Forms.Button driverUpdate_btn;
        private System.Windows.Forms.Label driverEta_lb;
        private System.Windows.Forms.TextBox driverETA_tb;
        private System.Windows.Forms.Button driverSubmit_btn;
    }
}