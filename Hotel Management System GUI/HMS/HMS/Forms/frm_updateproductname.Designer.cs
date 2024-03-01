namespace Gui_hotelmanagementsystem.Forms
{
    partial class frm_updateproductname
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
            this.lbl_hotelname = new System.Windows.Forms.Label();
            this.lbl_addproduct = new System.Windows.Forms.Label();
            this.txtbox_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txtbox_newname = new System.Windows.Forms.TextBox();
            this.lbl_newname = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.lbl_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_hotelname
            // 
            this.lbl_hotelname.AutoSize = true;
            this.lbl_hotelname.BackColor = System.Drawing.Color.Black;
            this.lbl_hotelname.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hotelname.ForeColor = System.Drawing.Color.White;
            this.lbl_hotelname.Location = new System.Drawing.Point(460, 182);
            this.lbl_hotelname.Name = "lbl_hotelname";
            this.lbl_hotelname.Size = new System.Drawing.Size(660, 55);
            this.lbl_hotelname.TabIndex = 41;
            this.lbl_hotelname.Text = "THE GRAND OASIS HOTEL";
            // 
            // lbl_addproduct
            // 
            this.lbl_addproduct.AutoSize = true;
            this.lbl_addproduct.BackColor = System.Drawing.Color.Black;
            this.lbl_addproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addproduct.ForeColor = System.Drawing.Color.White;
            this.lbl_addproduct.Location = new System.Drawing.Point(564, 284);
            this.lbl_addproduct.Name = "lbl_addproduct";
            this.lbl_addproduct.Size = new System.Drawing.Size(434, 37);
            this.lbl_addproduct.TabIndex = 42;
            this.lbl_addproduct.Text = "UPDATE PROUDCT NAME";
            // 
            // txtbox_name
            // 
            this.txtbox_name.Location = new System.Drawing.Point(768, 375);
            this.txtbox_name.Name = "txtbox_name";
            this.txtbox_name.Size = new System.Drawing.Size(136, 20);
            this.txtbox_name.TabIndex = 45;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.Black;
            this.lbl_name.Location = new System.Drawing.Point(612, 375);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(128, 20);
            this.lbl_name.TabIndex = 44;
            this.lbl_name.Text = "Previous Name";
            // 
            // txtbox_newname
            // 
            this.txtbox_newname.Location = new System.Drawing.Point(768, 425);
            this.txtbox_newname.Name = "txtbox_newname";
            this.txtbox_newname.Size = new System.Drawing.Size(136, 20);
            this.txtbox_newname.TabIndex = 47;
            // 
            // lbl_newname
            // 
            this.lbl_newname.AutoSize = true;
            this.lbl_newname.BackColor = System.Drawing.Color.Transparent;
            this.lbl_newname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_newname.ForeColor = System.Drawing.Color.Black;
            this.lbl_newname.Location = new System.Drawing.Point(646, 425);
            this.lbl_newname.Name = "lbl_newname";
            this.lbl_newname.Size = new System.Drawing.Size(94, 20);
            this.lbl_newname.TabIndex = 46;
            this.lbl_newname.Text = "New Name";
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Black;
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(479, 518);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(79, 30);
            this.btn_exit.TabIndex = 51;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.Black;
            this.btn_submit.ForeColor = System.Drawing.Color.White;
            this.btn_submit.Location = new System.Drawing.Point(947, 518);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(79, 30);
            this.btn_submit.TabIndex = 50;
            this.btn_submit.Text = "Update";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.BackColor = System.Drawing.Color.Black;
            this.lbl_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error.ForeColor = System.Drawing.Color.White;
            this.lbl_error.Location = new System.Drawing.Point(576, 593);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(388, 29);
            this.lbl_error.TabIndex = 52;
            this.lbl_error.Text = "No Product Exits For This Name";
            this.lbl_error.Visible = false;
            // 
            // frm_updateproductname
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gui_hotelmanagementsystem.Properties.Resources.room1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txtbox_newname);
            this.Controls.Add(this.lbl_newname);
            this.Controls.Add(this.txtbox_name);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_addproduct);
            this.Controls.Add(this.lbl_hotelname);
            this.DoubleBuffered = true;
            this.Name = "frm_updateproductname";
            this.Text = "update_productname_form";
            this.Load += new System.EventHandler(this.frm_updateproductname_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_hotelname;
        private System.Windows.Forms.Label lbl_addproduct;
        private System.Windows.Forms.TextBox txtbox_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txtbox_newname;
        private System.Windows.Forms.Label lbl_newname;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label lbl_error;
    }
}