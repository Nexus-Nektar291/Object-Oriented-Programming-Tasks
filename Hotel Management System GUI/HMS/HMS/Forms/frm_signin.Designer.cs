namespace Gui_hotelmanagementsystem
{
    partial class frm_signin
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
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_success = new System.Windows.Forms.Label();
            this.lbl_signin = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.txtbox_role = new System.Windows.Forms.TextBox();
            this.lbl_role = new System.Windows.Forms.Label();
            this.txtbox_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_hotelname = new System.Windows.Forms.Label();
            this.txtbox_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Black;
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(390, 495);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(79, 30);
            this.btn_exit.TabIndex = 31;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_success
            // 
            this.lbl_success.AutoSize = true;
            this.lbl_success.BackColor = System.Drawing.Color.Black;
            this.lbl_success.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_success.ForeColor = System.Drawing.Color.White;
            this.lbl_success.Location = new System.Drawing.Point(639, 559);
            this.lbl_success.Name = "lbl_success";
            this.lbl_success.Size = new System.Drawing.Size(92, 31);
            this.lbl_success.TabIndex = 30;
            this.lbl_success.Text = "label1";
            this.lbl_success.Visible = false;
            // 
            // lbl_signin
            // 
            this.lbl_signin.AutoSize = true;
            this.lbl_signin.BackColor = System.Drawing.Color.Black;
            this.lbl_signin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_signin.ForeColor = System.Drawing.Color.White;
            this.lbl_signin.Location = new System.Drawing.Point(548, 240);
            this.lbl_signin.Name = "lbl_signin";
            this.lbl_signin.Size = new System.Drawing.Size(244, 37);
            this.lbl_signin.TabIndex = 29;
            this.lbl_signin.Text = "SIGN IN USER";
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.Black;
            this.btn_submit.ForeColor = System.Drawing.Color.White;
            this.btn_submit.Location = new System.Drawing.Point(858, 495);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(79, 30);
            this.btn_submit.TabIndex = 28;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            this.btn_submit.MouseEnter += new System.EventHandler(this.btn_submit_MouseEnter);
            // 
            // txtbox_role
            // 
            this.txtbox_role.Location = new System.Drawing.Point(645, 420);
            this.txtbox_role.Name = "txtbox_role";
            this.txtbox_role.Size = new System.Drawing.Size(136, 20);
            this.txtbox_role.TabIndex = 27;
            this.txtbox_role.Text = "Admin/User";
            // 
            // lbl_role
            // 
            this.lbl_role.AutoSize = true;
            this.lbl_role.BackColor = System.Drawing.Color.Transparent;
            this.lbl_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_role.ForeColor = System.Drawing.Color.Black;
            this.lbl_role.Location = new System.Drawing.Point(567, 420);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(51, 20);
            this.lbl_role.TabIndex = 26;
            this.lbl_role.Text = "Role ";
            // 
            // txtbox_password
            // 
            this.txtbox_password.Location = new System.Drawing.Point(645, 375);
            this.txtbox_password.Name = "txtbox_password";
            this.txtbox_password.Size = new System.Drawing.Size(136, 20);
            this.txtbox_password.TabIndex = 25;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.Black;
            this.lbl_password.Location = new System.Drawing.Point(535, 375);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(86, 20);
            this.lbl_password.TabIndex = 24;
            this.lbl_password.Text = "Password";
            // 
            // lbl_hotelname
            // 
            this.lbl_hotelname.AutoSize = true;
            this.lbl_hotelname.BackColor = System.Drawing.Color.Black;
            this.lbl_hotelname.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hotelname.ForeColor = System.Drawing.Color.White;
            this.lbl_hotelname.Location = new System.Drawing.Point(380, 129);
            this.lbl_hotelname.Name = "lbl_hotelname";
            this.lbl_hotelname.Size = new System.Drawing.Size(660, 55);
            this.lbl_hotelname.TabIndex = 23;
            this.lbl_hotelname.Text = "THE GRAND OASIS HOTEL";
            // 
            // txtbox_name
            // 
            this.txtbox_name.Location = new System.Drawing.Point(645, 335);
            this.txtbox_name.Name = "txtbox_name";
            this.txtbox_name.Size = new System.Drawing.Size(136, 20);
            this.txtbox_name.TabIndex = 22;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.Black;
            this.lbl_name.Location = new System.Drawing.Point(562, 335);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(55, 20);
            this.lbl_name.TabIndex = 21;
            this.lbl_name.Text = "Name";
            // 
            // frm_signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gui_hotelmanagementsystem.Properties.Resources.room1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 749);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lbl_success);
            this.Controls.Add(this.lbl_signin);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txtbox_role);
            this.Controls.Add(this.lbl_role);
            this.Controls.Add(this.txtbox_password);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_hotelname);
            this.Controls.Add(this.txtbox_name);
            this.Controls.Add(this.lbl_name);
            this.DoubleBuffered = true;
            this.Name = "frm_signin";
            this.Text = "Sign_in_form";
            this.Load += new System.EventHandler(this.frm_signin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_success;
        private System.Windows.Forms.Label lbl_signin;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.TextBox txtbox_role;
        private System.Windows.Forms.Label lbl_role;
        private System.Windows.Forms.TextBox txtbox_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_hotelname;
        private System.Windows.Forms.TextBox txtbox_name;
        private System.Windows.Forms.Label lbl_name;
    }
}