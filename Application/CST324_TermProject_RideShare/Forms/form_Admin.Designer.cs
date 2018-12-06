namespace CST324_TermProject_RideShare
{
    partial class form_Admin
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
            this.listb_Users = new System.Windows.Forms.ListBox();
            this.listb_Requests = new System.Windows.Forms.ListBox();
            this.btn_Rider_Update = new System.Windows.Forms.Button();
            this.btn_Rider_Delete = new System.Windows.Forms.Button();
            this.btn_Rider_Add = new System.Windows.Forms.Button();
            this.btn_Requests_Add = new System.Windows.Forms.Button();
            this.btn_Requests_Delete = new System.Windows.Forms.Button();
            this.btn_Requests_Update = new System.Windows.Forms.Button();
            this.tb_Details_User = new System.Windows.Forms.TextBox();
            this.lb_List_Users = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_List_Requests = new System.Windows.Forms.Label();
            this.lb_Details_Requests = new System.Windows.Forms.Label();
            this.tb_Details_Requests = new System.Windows.Forms.TextBox();
            this.btn_Finish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listb_Users
            // 
            this.listb_Users.FormattingEnabled = true;
            this.listb_Users.Location = new System.Drawing.Point(9, 49);
            this.listb_Users.Margin = new System.Windows.Forms.Padding(2);
            this.listb_Users.Name = "listb_Users";
            this.listb_Users.Size = new System.Drawing.Size(153, 238);
            this.listb_Users.TabIndex = 0;
            this.listb_Users.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listb_Users_MouseClick);
            // 
            // listb_Requests
            // 
            this.listb_Requests.FormattingEnabled = true;
            this.listb_Requests.Location = new System.Drawing.Point(304, 49);
            this.listb_Requests.Margin = new System.Windows.Forms.Padding(2);
            this.listb_Requests.Name = "listb_Requests";
            this.listb_Requests.Size = new System.Drawing.Size(153, 238);
            this.listb_Requests.TabIndex = 2;
            this.listb_Requests.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listb_Requests_MouseClick);
            // 
            // btn_Rider_Update
            // 
            this.btn_Rider_Update.Location = new System.Drawing.Point(9, 292);
            this.btn_Rider_Update.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Rider_Update.Name = "btn_Rider_Update";
            this.btn_Rider_Update.Size = new System.Drawing.Size(58, 19);
            this.btn_Rider_Update.TabIndex = 3;
            this.btn_Rider_Update.Text = "Update";
            this.btn_Rider_Update.UseVisualStyleBackColor = true;
            this.btn_Rider_Update.Click += new System.EventHandler(this.btn_Rider_Update_Click);
            // 
            // btn_Rider_Delete
            // 
            this.btn_Rider_Delete.Location = new System.Drawing.Point(114, 291);
            this.btn_Rider_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Rider_Delete.Name = "btn_Rider_Delete";
            this.btn_Rider_Delete.Size = new System.Drawing.Size(46, 19);
            this.btn_Rider_Delete.TabIndex = 4;
            this.btn_Rider_Delete.Text = "Delete";
            this.btn_Rider_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Rider_Add
            // 
            this.btn_Rider_Add.Location = new System.Drawing.Point(71, 292);
            this.btn_Rider_Add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Rider_Add.Name = "btn_Rider_Add";
            this.btn_Rider_Add.Size = new System.Drawing.Size(38, 19);
            this.btn_Rider_Add.TabIndex = 5;
            this.btn_Rider_Add.Text = "Add";
            this.btn_Rider_Add.UseVisualStyleBackColor = true;
            this.btn_Rider_Add.Click += new System.EventHandler(this.btn_Rider_Add_Click);
            // 
            // btn_Requests_Add
            // 
            this.btn_Requests_Add.Location = new System.Drawing.Point(368, 292);
            this.btn_Requests_Add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Requests_Add.Name = "btn_Requests_Add";
            this.btn_Requests_Add.Size = new System.Drawing.Size(38, 19);
            this.btn_Requests_Add.TabIndex = 11;
            this.btn_Requests_Add.Text = "Add";
            this.btn_Requests_Add.UseVisualStyleBackColor = true;
            // 
            // btn_Requests_Delete
            // 
            this.btn_Requests_Delete.Location = new System.Drawing.Point(410, 292);
            this.btn_Requests_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Requests_Delete.Name = "btn_Requests_Delete";
            this.btn_Requests_Delete.Size = new System.Drawing.Size(46, 19);
            this.btn_Requests_Delete.TabIndex = 10;
            this.btn_Requests_Delete.Text = "Delete";
            this.btn_Requests_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Requests_Update
            // 
            this.btn_Requests_Update.Location = new System.Drawing.Point(305, 292);
            this.btn_Requests_Update.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Requests_Update.Name = "btn_Requests_Update";
            this.btn_Requests_Update.Size = new System.Drawing.Size(58, 19);
            this.btn_Requests_Update.TabIndex = 9;
            this.btn_Requests_Update.Text = "Update";
            this.btn_Requests_Update.UseVisualStyleBackColor = true;
            // 
            // tb_Details_User
            // 
            this.tb_Details_User.Location = new System.Drawing.Point(166, 49);
            this.tb_Details_User.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Details_User.Multiline = true;
            this.tb_Details_User.Name = "tb_Details_User";
            this.tb_Details_User.ReadOnly = true;
            this.tb_Details_User.Size = new System.Drawing.Size(122, 238);
            this.tb_Details_User.TabIndex = 12;
            // 
            // lb_List_Users
            // 
            this.lb_List_Users.AutoSize = true;
            this.lb_List_Users.Location = new System.Drawing.Point(10, 30);
            this.lb_List_Users.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_List_Users.Name = "lb_List_Users";
            this.lb_List_Users.Size = new System.Drawing.Size(65, 13);
            this.lb_List_Users.TabIndex = 13;
            this.lb_List_Users.Text = "List of Users";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Details of Selected User";
            // 
            // lb_List_Requests
            // 
            this.lb_List_Requests.AutoSize = true;
            this.lb_List_Requests.Location = new System.Drawing.Point(302, 30);
            this.lb_List_Requests.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_List_Requests.Name = "lb_List_Requests";
            this.lb_List_Requests.Size = new System.Drawing.Size(83, 13);
            this.lb_List_Requests.TabIndex = 15;
            this.lb_List_Requests.Text = "List of Requests";
            // 
            // lb_Details_Requests
            // 
            this.lb_Details_Requests.AutoSize = true;
            this.lb_Details_Requests.Location = new System.Drawing.Point(459, 32);
            this.lb_Details_Requests.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Details_Requests.Name = "lb_Details_Requests";
            this.lb_Details_Requests.Size = new System.Drawing.Size(139, 13);
            this.lb_Details_Requests.TabIndex = 17;
            this.lb_Details_Requests.Text = "Details of Selected Request";
            // 
            // tb_Details_Requests
            // 
            this.tb_Details_Requests.Location = new System.Drawing.Point(461, 49);
            this.tb_Details_Requests.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Details_Requests.Multiline = true;
            this.tb_Details_Requests.Name = "tb_Details_Requests";
            this.tb_Details_Requests.ReadOnly = true;
            this.tb_Details_Requests.Size = new System.Drawing.Size(122, 238);
            this.tb_Details_Requests.TabIndex = 16;
            // 
            // btn_Finish
            // 
            this.btn_Finish.Location = new System.Drawing.Point(539, 337);
            this.btn_Finish.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Finish.Name = "btn_Finish";
            this.btn_Finish.Size = new System.Drawing.Size(56, 19);
            this.btn_Finish.TabIndex = 18;
            this.btn_Finish.Text = "Finish";
            this.btn_Finish.UseVisualStyleBackColor = true;
            this.btn_Finish.Click += new System.EventHandler(this.btn_Finish_Click);
            // 
            // form_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Finish);
            this.Controls.Add(this.lb_Details_Requests);
            this.Controls.Add(this.tb_Details_Requests);
            this.Controls.Add(this.lb_List_Requests);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_List_Users);
            this.Controls.Add(this.tb_Details_User);
            this.Controls.Add(this.btn_Requests_Add);
            this.Controls.Add(this.btn_Requests_Delete);
            this.Controls.Add(this.btn_Requests_Update);
            this.Controls.Add(this.btn_Rider_Add);
            this.Controls.Add(this.btn_Rider_Delete);
            this.Controls.Add(this.btn_Rider_Update);
            this.Controls.Add(this.listb_Requests);
            this.Controls.Add(this.listb_Users);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "form_Admin";
            this.Text = "form_Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listb_Users;
        private System.Windows.Forms.ListBox listb_Requests;
        private System.Windows.Forms.Button btn_Rider_Update;
        private System.Windows.Forms.Button btn_Rider_Delete;
        private System.Windows.Forms.Button btn_Rider_Add;
        private System.Windows.Forms.Button btn_Requests_Add;
        private System.Windows.Forms.Button btn_Requests_Delete;
        private System.Windows.Forms.Button btn_Requests_Update;
        private System.Windows.Forms.TextBox tb_Details_User;
        private System.Windows.Forms.Label lb_List_Users;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_List_Requests;
        private System.Windows.Forms.Label lb_Details_Requests;
        private System.Windows.Forms.TextBox tb_Details_Requests;
        private System.Windows.Forms.Button btn_Finish;
    }
}