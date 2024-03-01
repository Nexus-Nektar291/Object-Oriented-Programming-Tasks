namespace Gui_hotelmanagementsystem
{
    partial class frm_addproduct
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
            this.lbl_addproduct = new System.Windows.Forms.Label();
            this.lbl_hotelname = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.txtbox_price = new System.Windows.Forms.TextBox();
            this.lbl_role = new System.Windows.Forms.Label();
            this.txtbox_type = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txtbox_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_success = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_addproduct
            // 
            this.lbl_addproduct.AutoSize = true;
            this.lbl_addproduct.BackColor = System.Drawing.Color.Black;
            this.lbl_addproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addproduct.ForeColor = System.Drawing.Color.White;
            this.lbl_addproduct.Location = new System.Drawing.Point(618, 241);
            this.lbl_addproduct.Name = "lbl_addproduct";
            this.lbl_addproduct.Size = new System.Drawing.Size(262, 37);
            this.lbl_addproduct.TabIndex = 20;
            this.lbl_addproduct.Text = "ADD PRODUCT";
            // 
            // lbl_hotelname
            // 
            this.lbl_hotelname.AutoSize = true;
            this.lbl_hotelname.BackColor = System.Drawing.Color.Black;
            this.lbl_hotelname.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hotelname.ForeColor = System.Drawing.Color.White;
            this.lbl_hotelname.Location = new System.Drawing.Point(450, 130);
            this.lbl_hotelname.Name = "lbl_hotelname";
            this.lbl_hotelname.Size = new System.Drawing.Size(660, 55);
            this.lbl_hotelname.TabIndex = 19;
            this.lbl_hotelname.Text = "THE GRAND OASIS HOTEL";
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Black;
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(460, 504);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(79, 30);
            this.btn_exit.TabIndex = 39;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.Black;
            this.btn_submit.ForeColor = System.Drawing.Color.White;
            this.btn_submit.Location = new System.Drawing.Point(928, 504);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(79, 30);
            this.btn_submit.TabIndex = 38;
            this.btn_submit.Text = "Add";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            this.btn_submit.MouseEnter += new System.EventHandler(this.btn_submit_MouseLeave);
            // 
            // txtbox_price
            // 
            this.txtbox_price.Location = new System.Drawing.Point(715, 429);
            this.txtbox_price.Name = "txtbox_price";
            this.txtbox_price.Size = new System.Drawing.Size(136, 20);
            this.txtbox_price.TabIndex = 37;
            this.txtbox_price.TextChanged += new System.EventHandler(this.txtbox_role_TextChanged);
            // 
            // lbl_role
            // 
            this.lbl_role.AutoSize = true;
            this.lbl_role.BackColor = System.Drawing.Color.Transparent;
            this.lbl_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_role.ForeColor = System.Drawing.Color.Black;
            this.lbl_role.Location = new System.Drawing.Point(575, 427);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(116, 20);
            this.lbl_role.TabIndex = 36;
            this.lbl_role.Text = "Product Price";
            // 
            // txtbox_type
            // 
            this.txtbox_type.Location = new System.Drawing.Point(715, 384);
            this.txtbox_type.Name = "txtbox_type";
            this.txtbox_type.Size = new System.Drawing.Size(136, 20);
            this.txtbox_type.TabIndex = 35;
            this.txtbox_type.Text = "Drink/Food";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.Black;
            this.lbl_password.Location = new System.Drawing.Point(577, 382);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(114, 20);
            this.lbl_password.TabIndex = 34;
            this.lbl_password.Text = "Product Type";
            // 
            // txtbox_name
            // 
            this.txtbox_name.Location = new System.Drawing.Point(715, 344);
            this.txtbox_name.Name = "txtbox_name";
            this.txtbox_name.Size = new System.Drawing.Size(136, 20);
            this.txtbox_name.TabIndex = 33;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.Black;
            this.lbl_name.Location = new System.Drawing.Point(577, 342);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(122, 20);
            this.lbl_name.TabIndex = 32;
            this.lbl_name.Text = "Product Name";
            // 
            // lbl_success
            // 
            this.lbl_success.AutoSize = true;
            this.lbl_success.BackColor = System.Drawing.Color.Transparent;
            this.lbl_success.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_success.ForeColor = System.Drawing.Color.Red;
            this.lbl_success.Location = new System.Drawing.Point(577, 605);
            this.lbl_success.Name = "lbl_success";
            this.lbl_success.Size = new System.Drawing.Size(60, 24);
            this.lbl_success.TabIndex = 40;
            this.lbl_success.Text = "label1";
            this.lbl_success.Visible = false;
            // 
            // frm_addproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gui_hotelmanagementsystem.Properties.Resources.room1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.lbl_success);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txtbox_price);
            this.Controls.Add(this.lbl_role);
            this.Controls.Add(this.txtbox_type);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.txtbox_name);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_addproduct);
            this.Controls.Add(this.lbl_hotelname);
            this.DoubleBuffered = true;
            this.Name = "frm_addproduct";
            this.Text = "add_product_form";
            this.Load += new System.EventHandler(this.add_product_form_Load);
            this.MouseEnter += new System.EventHandler(this.btn_submit_MouseEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_addproduct;
        private System.Windows.Forms.Label lbl_hotelname;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.TextBox txtbox_price;
        private System.Windows.Forms.Label lbl_role;
        private System.Windows.Forms.TextBox txtbox_type;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txtbox_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_success;
    }
}