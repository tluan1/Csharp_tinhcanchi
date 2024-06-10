namespace Csharp_tinhcanchi
{
    partial class Form1
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
            this.txtnam = new System.Windows.Forms.TextBox();
            this.txtketqua = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblnam = new System.Windows.Forms.Label();
            this.lbsketqua = new System.Windows.Forms.Label();
            this.btntinh = new System.Windows.Forms.Button();
            this.lbs = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtnam
            // 
            this.txtnam.Location = new System.Drawing.Point(173, 86);
            this.txtnam.Name = "txtnam";
            this.txtnam.Size = new System.Drawing.Size(100, 20);
            this.txtnam.TabIndex = 0;
            // 
            // txtketqua
            // 
            this.txtketqua.Location = new System.Drawing.Point(173, 145);
            this.txtketqua.Name = "txtketqua";
            this.txtketqua.Size = new System.Drawing.Size(100, 20);
            this.txtketqua.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "CHƯƠNG TRÌNH TÍNH CAN CHI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-111, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 23);
            this.label2.TabIndex = 3;
            // 
            // lblnam
            // 
            this.lblnam.AutoSize = true;
            this.lblnam.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnam.Location = new System.Drawing.Point(86, 83);
            this.lblnam.Name = "lblnam";
            this.lblnam.Size = new System.Drawing.Size(49, 23);
            this.lblnam.TabIndex = 4;
            this.lblnam.Text = "Năm";
            // 
            // lbsketqua
            // 
            this.lbsketqua.AutoSize = true;
            this.lbsketqua.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsketqua.Location = new System.Drawing.Point(86, 142);
            this.lbsketqua.Name = "lbsketqua";
            this.lbsketqua.Size = new System.Drawing.Size(75, 23);
            this.lbsketqua.TabIndex = 5;
            this.lbsketqua.Text = "Kết quả";
            // 
            // btntinh
            // 
            this.btntinh.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntinh.Location = new System.Drawing.Point(173, 201);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(100, 37);
            this.btntinh.TabIndex = 6;
            this.btntinh.Text = "Tính";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // lbs
            // 
            this.lbs.FormattingEnabled = true;
            this.lbs.Location = new System.Drawing.Point(430, 78);
            this.lbs.Name = "lbs";
            this.lbs.Size = new System.Drawing.Size(248, 160);
            this.lbs.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(913, 450);
            this.Controls.Add(this.lbs);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.lbsketqua);
            this.Controls.Add(this.lblnam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtketqua);
            this.Controls.Add(this.txtnam);
            this.Name = "Form1";
            this.Text = "Năm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnam;
        private System.Windows.Forms.TextBox txtketqua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblnam;
        private System.Windows.Forms.Label lbsketqua;
        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.ListBox lbs;
    }
}

