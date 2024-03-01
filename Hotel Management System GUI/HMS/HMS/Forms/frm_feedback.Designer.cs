namespace Gui_hotelmanagementsystem.Forms
{
    partial class frm_feedback
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
            this.txtbox_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txtbox_feedback = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_addproduct
            // 
            this.lbl_addproduct.AutoSize = true;
            this.lbl_addproduct.BackColor = System.Drawing.Color.Black;
            this.lbl_addproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addproduct.ForeColor = System.Drawing.Color.White;
            this.lbl_addproduct.Location = new System.Drawing.Point(601, 267);
            this.lbl_addproduct.Name = "lbl_addproduct";
            this.lbl_addproduct.Size = new System.Drawing.Size(287, 37);
            this.lbl_addproduct.TabIndex = 43;
            this.lbl_addproduct.Text = "GIVE FEEDBACK";
            // 
            // lbl_hotelname
            // 
            this.lbl_hotelname.AutoSize = true;
            this.lbl_hotelname.BackColor = System.Drawing.Color.Black;
            this.lbl_hotelname.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hotelname.ForeColor = System.Drawing.Color.White;
            this.lbl_hotelname.Location = new System.Drawing.Point(413, 148);
            this.lbl_hotelname.Name = "lbl_hotelname";
            this.lbl_hotelname.Size = new System.Drawing.Size(660, 55);
            this.lbl_hotelname.TabIndex = 42;
            this.lbl_hotelname.Text = "THE GRAND OASIS HOTEL";
            // 
            // txtbox_name
            // 
            this.txtbox_name.Location = new System.Drawing.Point(742, 368);
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
            this.lbl_name.Location = new System.Drawing.Point(604, 366);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(122, 20);
            this.lbl_name.TabIndex = 44;
            this.lbl_name.Text = "Product Name";
            // 
            // txtbox_feedback
            // 
            this.txtbox_feedback.Location = new System.Drawing.Point(538, 430);
            this.txtbox_feedback.Multiline = true;
            this.txtbox_feedback.Name = "txtbox_feedback";
            this.txtbox_feedback.Size = new System.Drawing.Size(136, 20);
            this.txtbox_feedback.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(419, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Feedback";
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Black;
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(447, 511);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(79, 30);
            this.btn_exit.TabIndex = 49;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.Black;
            this.btn_submit.ForeColor = System.Drawing.Color.White;
            this.btn_submit.Location = new System.Drawing.Point(915, 511);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(79, 30);
            this.btn_submit.TabIndex = 48;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            this.btn_submit.MouseEnter += new System.EventHandler(this.btn_submit_MouseEnter);
            // 
            // frm_feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gui_hotelmanagementsystem.Properties.Resources.room1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txtbox_feedback);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_name);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_addproduct);
            this.Controls.Add(this.lbl_hotelname);
            this.DoubleBuffered = true;
            this.Name = "frm_feedback";
            this.Text = "frm_feedback";
            this.Load += new System.EventHandler(this.frm_feedback_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_addproduct;
        private System.Windows.Forms.Label lbl_hotelname;
        private System.Windows.Forms.TextBox txtbox_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txtbox_feedback;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_submit;
    }
}