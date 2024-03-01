namespace Gui_hotelmanagementsystem
{
    partial class frm_loginoptions
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
            this.lbl_loginoptions = new System.Windows.Forms.Label();
            this.lbl_hotelname = new System.Windows.Forms.Label();
            this.btn_signup = new System.Windows.Forms.Button();
            this.btn_signin = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_loginoptions
            // 
            this.lbl_loginoptions.AutoSize = true;
            this.lbl_loginoptions.BackColor = System.Drawing.Color.Black;
            this.lbl_loginoptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loginoptions.ForeColor = System.Drawing.Color.White;
            this.lbl_loginoptions.Location = new System.Drawing.Point(545, 205);
            this.lbl_loginoptions.Name = "lbl_loginoptions";
            this.lbl_loginoptions.Size = new System.Drawing.Size(283, 37);
            this.lbl_loginoptions.TabIndex = 20;
            this.lbl_loginoptions.Text = "LOGIN OPTIONS";
            // 
            // lbl_hotelname
            // 
            this.lbl_hotelname.AutoSize = true;
            this.lbl_hotelname.BackColor = System.Drawing.Color.Black;
            this.lbl_hotelname.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hotelname.ForeColor = System.Drawing.Color.White;
            this.lbl_hotelname.Location = new System.Drawing.Point(341, 104);
            this.lbl_hotelname.Name = "lbl_hotelname";
            this.lbl_hotelname.Size = new System.Drawing.Size(660, 55);
            this.lbl_hotelname.TabIndex = 19;
            this.lbl_hotelname.Text = "THE GRAND OASIS HOTEL";
            // 
            // btn_signup
            // 
            this.btn_signup.BackColor = System.Drawing.Color.LightGray;
            this.btn_signup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_signup.Location = new System.Drawing.Point(644, 286);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(109, 52);
            this.btn_signup.TabIndex = 21;
            this.btn_signup.Text = "SIGN UP";
            this.btn_signup.UseVisualStyleBackColor = false;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // btn_signin
            // 
            this.btn_signin.BackColor = System.Drawing.Color.LightGray;
            this.btn_signin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_signin.Location = new System.Drawing.Point(644, 387);
            this.btn_signin.Name = "btn_signin";
            this.btn_signin.Size = new System.Drawing.Size(109, 52);
            this.btn_signin.TabIndex = 22;
            this.btn_signin.Text = "SIGN IN";
            this.btn_signin.UseVisualStyleBackColor = false;
            this.btn_signin.Click += new System.EventHandler(this.btn_signin_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.LightGray;
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_exit.Location = new System.Drawing.Point(644, 491);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(109, 52);
            this.btn_exit.TabIndex = 23;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // frm_loginoptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gui_hotelmanagementsystem.Properties.Resources.room1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_signin);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.lbl_loginoptions);
            this.Controls.Add(this.lbl_hotelname);
            this.DoubleBuffered = true;
            this.Name = "frm_loginoptions";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frm_loginoptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_loginoptions;
        private System.Windows.Forms.Label lbl_hotelname;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.Button btn_signin;
        private System.Windows.Forms.Button btn_exit;
    }
}