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
            this.button1 = new System.Windows.Forms.Button();
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
            this.listb_Users.ItemHeight = 16;
            this.listb_Users.Location = new System.Drawing.Point(12, 60);
            this.listb_Users.Name = "listb_Users";
            this.listb_Users.Size = new System.Drawing.Size(203, 292);
            this.listb_Users.TabIndex = 0;
            this.listb_Users.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listb_Users_MouseClick);
            this.listb_Users.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listb_Users_MouseDoubleClick);
            // 
            // listb_Requests
            // 
            this.listb_Requests.FormattingEnabled = true;
            this.listb_Requests.ItemHeight = 16;
            this.listb_Requests.Location = new System.Drawing.Point(406, 60);
            this.listb_Requests.Name = "listb_Requests";
            this.listb_Requests.Size = new System.Drawing.Size(203, 292);
            this.listb_Requests.TabIndex = 2;
            this.listb_Requests.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listb_Requests_MouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_Rider_Delete
            // 
            this.btn_Rider_Delete.Location = new System.Drawing.Point(152, 358);
            this.btn_Rider_Delete.Name = "btn_Rider_Delete";
            this.btn_Rider_Delete.Size = new System.Drawing.Size(62, 23);
            this.btn_Rider_Delete.TabIndex = 4;
            this.btn_Rider_Delete.Text = "Delete";
            this.btn_Rider_Delete.UseVisualStyleBackColor = true;
            this.btn_Rider_Delete.Click += new System.EventHandler(this.btn_Rider_Delete_Click);
            // 
            // btn_Rider_Add
            // 
            this.btn_Rider_Add.Location = new System.Drawing.Point(95, 359);
            this.btn_Rider_Add.Name = "btn_Rider_Add";
            this.btn_Rider_Add.Size = new System.Drawing.Size(51, 23);
            this.btn_Rider_Add.TabIndex = 5;
            this.btn_Rider_Add.Text = "Add";
            this.btn_Rider_Add.UseVisualStyleBackColor = true;
            // 
            // btn_Requests_Add
            // 
            this.btn_Requests_Add.Location = new System.Drawing.Point(490, 360);
            this.btn_Requests_Add.Name = "btn_Requests_Add";
            this.btn_Requests_Add.Size = new System.Drawing.Size(51, 23);
            this.btn_Requests_Add.TabIndex = 11;
            this.btn_Requests_Add.Text = "Add";
            this.btn_Requests_Add.UseVisualStyleBackColor = true;
            // 
            // btn_Requests_Delete
            // 
            this.btn_Requests_Delete.Location = new System.Drawing.Point(547, 359);
            this.btn_Requests_Delete.Name = "btn_Requests_Delete";
            this.btn_Requests_Delete.Size = new System.Drawing.Size(62, 23);
            this.btn_Requests_Delete.TabIndex = 10;
            this.btn_Requests_Delete.Text = "Delete";
            this.btn_Requests_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Requests_Update
            // 
            this.btn_Requests_Update.Location = new System.Drawing.Point(407, 360);
            this.btn_Requests_Update.Name = "btn_Requests_Update";
            this.btn_Requests_Update.Size = new System.Drawing.Size(77, 23);
            this.btn_Requests_Update.TabIndex = 9;
            this.btn_Requests_Update.Text = "Update";
            this.btn_Requests_Update.UseVisualStyleBackColor = true;
            // 
            // tb_Details_User
            // 
            this.tb_Details_User.Location = new System.Drawing.Point(221, 60);
            this.tb_Details_User.Multiline = true;
            this.tb_Details_User.Name = "tb_Details_User";
            this.tb_Details_User.Size = new System.Drawing.Size(162, 292);
            this.tb_Details_User.TabIndex = 12;
            // 
            // lb_List_Users
            // 
            this.lb_List_Users.AutoSize = true;
            this.lb_List_Users.Location = new System.Drawing.Point(13, 37);
            this.lb_List_Users.Name = "lb_List_Users";
            this.lb_List_Users.Size = new System.Drawing.Size(87, 17);
            this.lb_List_Users.TabIndex = 13;
            this.lb_List_Users.Text = "List of Users";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Details of Selected User";
            // 
            // lb_List_Requests
            // 
            this.lb_List_Requests.AutoSize = true;
            this.lb_List_Requests.Location = new System.Drawing.Point(403, 37);
            this.lb_List_Requests.Name = "lb_List_Requests";
            this.lb_List_Requests.Size = new System.Drawing.Size(110, 17);
            this.lb_List_Requests.TabIndex = 15;
            this.lb_List_Requests.Text = "List of Requests";
            // 
            // lb_Details_Requests
            // 
            this.lb_Details_Requests.AutoSize = true;
            this.lb_Details_Requests.Location = new System.Drawing.Point(612, 40);
            this.lb_Details_Requests.Name = "lb_Details_Requests";
            this.lb_Details_Requests.Size = new System.Drawing.Size(183, 17);
            this.lb_Details_Requests.TabIndex = 17;
            this.lb_Details_Requests.Text = "Details of Selected Request";
            // 
            // tb_Details_Requests
            // 
            this.tb_Details_Requests.Location = new System.Drawing.Point(615, 60);
            this.tb_Details_Requests.Multiline = true;
            this.tb_Details_Requests.Name = "tb_Details_Requests";
            this.tb_Details_Requests.Size = new System.Drawing.Size(162, 292);
            this.tb_Details_Requests.TabIndex = 16;
            // 
            // btn_Finish
            // 
            this.btn_Finish.Location = new System.Drawing.Point(719, 415);
            this.btn_Finish.Name = "btn_Finish";
            this.btn_Finish.Size = new System.Drawing.Size(75, 23);
            this.btn_Finish.TabIndex = 18;
            this.btn_Finish.Text = "Finish";
            this.btn_Finish.UseVisualStyleBackColor = true;
            // 

            // form_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);

            this.Name = "form_Admin";
            this.Text = "form_Admin";
            this.ResumeLayout(false);

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
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listb_Requests);
            this.Controls.Add(this.listb_Users);
            this.Name = "form_Admin";
            this.Text = "form_Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

            
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "form_Admin";
        }

        #endregion

        private System.Windows.Forms.ListBox listb_Users;
        private System.Windows.Forms.ListBox listb_Requests;
        private System.Windows.Forms.Button button1;
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