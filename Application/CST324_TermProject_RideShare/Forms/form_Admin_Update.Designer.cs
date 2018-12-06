namespace CST324_TermProject_RideShare.Forms
{
    partial class form_Admin_Update
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
            this.listb_User_Update = new System.Windows.Forms.ListBox();
            this.lb_listb_update = new System.Windows.Forms.Label();
            this.lb_tb_UpdateTo = new System.Windows.Forms.Label();
            this.tb_UpdateTo = new System.Windows.Forms.TextBox();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.btn_Finish = new System.Windows.Forms.Button();
            this.tb_userdata = new System.Windows.Forms.TextBox();
            this.lb_userdata = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listb_User_Update
            // 
            this.listb_User_Update.FormattingEnabled = true;
            this.listb_User_Update.Items.AddRange(new object[] {
            "UserID",
            "Location",
            "RiderID",
            "DriverID"});
            this.listb_User_Update.Location = new System.Drawing.Point(17, 176);
            this.listb_User_Update.Name = "listb_User_Update";
            this.listb_User_Update.Size = new System.Drawing.Size(112, 95);
            this.listb_User_Update.TabIndex = 0;
            this.listb_User_Update.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listb_User_Update_MouseClick);
            // 
            // lb_listb_update
            // 
            this.lb_listb_update.AutoSize = true;
            this.lb_listb_update.Location = new System.Drawing.Point(14, 158);
            this.lb_listb_update.Name = "lb_listb_update";
            this.lb_listb_update.Size = new System.Drawing.Size(87, 13);
            this.lb_listb_update.TabIndex = 1;
            this.lb_listb_update.Text = "What To Update";
            // 
            // lb_tb_UpdateTo
            // 
            this.lb_tb_UpdateTo.AutoSize = true;
            this.lb_tb_UpdateTo.Location = new System.Drawing.Point(136, 176);
            this.lb_tb_UpdateTo.Name = "lb_tb_UpdateTo";
            this.lb_tb_UpdateTo.Size = new System.Drawing.Size(61, 13);
            this.lb_tb_UpdateTo.TabIndex = 2;
            this.lb_tb_UpdateTo.Text = "Update To:";
            // 
            // tb_UpdateTo
            // 
            this.tb_UpdateTo.Location = new System.Drawing.Point(139, 193);
            this.tb_UpdateTo.Name = "tb_UpdateTo";
            this.tb_UpdateTo.Size = new System.Drawing.Size(227, 20);
            this.tb_UpdateTo.TabIndex = 3;
            // 
            // btn_Apply
            // 
            this.btn_Apply.Location = new System.Drawing.Point(252, 250);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(114, 23);
            this.btn_Apply.TabIndex = 4;
            this.btn_Apply.Text = "Apply Update";
            this.btn_Apply.UseVisualStyleBackColor = true;
            this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
            // 
            // btn_Finish
            // 
            this.btn_Finish.Location = new System.Drawing.Point(171, 250);
            this.btn_Finish.Name = "btn_Finish";
            this.btn_Finish.Size = new System.Drawing.Size(75, 23);
            this.btn_Finish.TabIndex = 5;
            this.btn_Finish.Text = "Finish";
            this.btn_Finish.UseVisualStyleBackColor = true;
            this.btn_Finish.Click += new System.EventHandler(this.btn_Finish_Click);
            // 
            // tb_userdata
            // 
            this.tb_userdata.Location = new System.Drawing.Point(17, 29);
            this.tb_userdata.Multiline = true;
            this.tb_userdata.Name = "tb_userdata";
            this.tb_userdata.ReadOnly = true;
            this.tb_userdata.Size = new System.Drawing.Size(340, 126);
            this.tb_userdata.TabIndex = 6;
            // 
            // lb_userdata
            // 
            this.lb_userdata.AutoSize = true;
            this.lb_userdata.Location = new System.Drawing.Point(17, 13);
            this.lb_userdata.Name = "lb_userdata";
            this.lb_userdata.Size = new System.Drawing.Size(55, 13);
            this.lb_userdata.TabIndex = 7;
            this.lb_userdata.Text = "User Data";
            // 
            // form_Admin_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 289);
            this.Controls.Add(this.lb_userdata);
            this.Controls.Add(this.tb_userdata);
            this.Controls.Add(this.btn_Finish);
            this.Controls.Add(this.btn_Apply);
            this.Controls.Add(this.tb_UpdateTo);
            this.Controls.Add(this.lb_tb_UpdateTo);
            this.Controls.Add(this.lb_listb_update);
            this.Controls.Add(this.listb_User_Update);
            this.Name = "form_Admin_Update";
            this.Text = "form_Admin_Update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listb_User_Update;
        private System.Windows.Forms.Label lb_listb_update;
        private System.Windows.Forms.Label lb_tb_UpdateTo;
        private System.Windows.Forms.TextBox tb_UpdateTo;
        private System.Windows.Forms.Button btn_Apply;
        private System.Windows.Forms.Button btn_Finish;
        private System.Windows.Forms.TextBox tb_userdata;
        private System.Windows.Forms.Label lb_userdata;
    }
}