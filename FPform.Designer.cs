namespace Electricity_Billing_System
{
    partial class FPform
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
            this.components = new System.ComponentModel.Container();
            this.txtUserForgotP = new System.Windows.Forms.TextBox();
            this.txtUserFP = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVerify = new System.Windows.Forms.Button();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserForgotP
            // 
            this.txtUserForgotP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserForgotP.Location = new System.Drawing.Point(95, 268);
            this.txtUserForgotP.Name = "txtUserForgotP";
            this.txtUserForgotP.Size = new System.Drawing.Size(218, 15);
            this.txtUserForgotP.TabIndex = 1;
            // 
            // txtUserFP
            // 
            this.txtUserFP.AutoSize = true;
            this.txtUserFP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserFP.Location = new System.Drawing.Point(91, 229);
            this.txtUserFP.Name = "txtUserFP";
            this.txtUserFP.Size = new System.Drawing.Size(108, 23);
            this.txtUserFP.TabIndex = 2;
            this.txtUserFP.Text = "Username";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(96, 289);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 1);
            this.panel1.TabIndex = 3;
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnVerify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVerify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerify.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.Location = new System.Drawing.Point(95, 359);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(218, 45);
            this.btnVerify.TabIndex = 4;
            this.btnVerify.Text = "VERIFY";
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // pbClose
            // 
            this.pbClose.Image = global::Electricity_Billing_System.Properties.Resources._43431_close_button_clipart;
            this.pbClose.Location = new System.Drawing.Point(416, 1);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(30, 30);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 5;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pbClose.MouseHover += new System.EventHandler(this.pbClose_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Electricity_Billing_System.Properties.Resources.lock_vector_icon;
            this.pictureBox1.Location = new System.Drawing.Point(121, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FPform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(449, 452);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtUserFP);
            this.Controls.Add(this.txtUserForgotP);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FPform";
            this.Text = "FPform";
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUserForgotP;
        private System.Windows.Forms.Label txtUserFP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}