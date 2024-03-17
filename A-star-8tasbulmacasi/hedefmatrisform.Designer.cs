using System;

namespace A_star_8tasbulmacasi
{
    partial class hedefmatrisform
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
            this.txtHedef00 = new System.Windows.Forms.TextBox();
            this.txtHedef01 = new System.Windows.Forms.TextBox();
            this.txtHedef02 = new System.Windows.Forms.TextBox();
            this.txtHedef10 = new System.Windows.Forms.TextBox();
            this.txtHedef11 = new System.Windows.Forms.TextBox();
            this.txtHedef12 = new System.Windows.Forms.TextBox();
            this.txtHedef20 = new System.Windows.Forms.TextBox();
            this.txtHedef21 = new System.Windows.Forms.TextBox();
            this.txtHedef22 = new System.Windows.Forms.TextBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHedef00
            // 
            this.txtHedef00.Location = new System.Drawing.Point(64, 56);
            this.txtHedef00.Multiline = true;
            this.txtHedef00.Name = "txtHedef00";
            this.txtHedef00.Size = new System.Drawing.Size(100, 51);
            this.txtHedef00.TabIndex = 0;
            // 
            // txtHedef01
            // 
            this.txtHedef01.Location = new System.Drawing.Point(193, 56);
            this.txtHedef01.Multiline = true;
            this.txtHedef01.Name = "txtHedef01";
            this.txtHedef01.Size = new System.Drawing.Size(100, 51);
            this.txtHedef01.TabIndex = 1;
            // 
            // txtHedef02
            // 
            this.txtHedef02.Location = new System.Drawing.Point(323, 56);
            this.txtHedef02.Multiline = true;
            this.txtHedef02.Name = "txtHedef02";
            this.txtHedef02.Size = new System.Drawing.Size(100, 51);
            this.txtHedef02.TabIndex = 2;
            // 
            // txtHedef10
            // 
            this.txtHedef10.Location = new System.Drawing.Point(64, 130);
            this.txtHedef10.Multiline = true;
            this.txtHedef10.Name = "txtHedef10";
            this.txtHedef10.Size = new System.Drawing.Size(100, 44);
            this.txtHedef10.TabIndex = 3;
            // 
            // txtHedef11
            // 
            this.txtHedef11.Location = new System.Drawing.Point(193, 130);
            this.txtHedef11.Multiline = true;
            this.txtHedef11.Name = "txtHedef11";
            this.txtHedef11.Size = new System.Drawing.Size(100, 44);
            this.txtHedef11.TabIndex = 4;
            // 
            // txtHedef12
            // 
            this.txtHedef12.Location = new System.Drawing.Point(323, 130);
            this.txtHedef12.Multiline = true;
            this.txtHedef12.Name = "txtHedef12";
            this.txtHedef12.Size = new System.Drawing.Size(100, 44);
            this.txtHedef12.TabIndex = 5;
            // 
            // txtHedef20
            // 
            this.txtHedef20.Location = new System.Drawing.Point(64, 198);
            this.txtHedef20.Multiline = true;
            this.txtHedef20.Name = "txtHedef20";
            this.txtHedef20.Size = new System.Drawing.Size(100, 50);
            this.txtHedef20.TabIndex = 6;
            // 
            // txtHedef21
            // 
            this.txtHedef21.Location = new System.Drawing.Point(193, 198);
            this.txtHedef21.Multiline = true;
            this.txtHedef21.Name = "txtHedef21";
            this.txtHedef21.Size = new System.Drawing.Size(100, 50);
            this.txtHedef21.TabIndex = 7;
            // 
            // txtHedef22
            // 
            this.txtHedef22.Location = new System.Drawing.Point(323, 198);
            this.txtHedef22.Multiline = true;
            this.txtHedef22.Name = "txtHedef22";
            this.txtHedef22.Size = new System.Drawing.Size(100, 50);
            this.txtHedef22.TabIndex = 8;
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(208, 296);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(75, 23);
            this.btnkaydet.TabIndex = 9;
            this.btnkaydet.Text = "kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click_1);
            // 
            // hedefmatrisform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.txtHedef22);
            this.Controls.Add(this.txtHedef21);
            this.Controls.Add(this.txtHedef20);
            this.Controls.Add(this.txtHedef12);
            this.Controls.Add(this.txtHedef11);
            this.Controls.Add(this.txtHedef10);
            this.Controls.Add(this.txtHedef02);
            this.Controls.Add(this.txtHedef01);
            this.Controls.Add(this.txtHedef00);
            this.Name = "hedefmatrisform";
            this.Text = "hedefmatrisform";
            this.Load += new System.EventHandler(this.hedefmatrisform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void hedefmatrisform_Load(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.TextBox txtHedef00;
        private System.Windows.Forms.TextBox txtHedef01;
        private System.Windows.Forms.TextBox txtHedef02;
        private System.Windows.Forms.TextBox txtHedef10;
        private System.Windows.Forms.TextBox txtHedef11;
        private System.Windows.Forms.TextBox txtHedef12;
        private System.Windows.Forms.TextBox txtHedef20;
        private System.Windows.Forms.TextBox txtHedef21;
        private System.Windows.Forms.TextBox txtHedef22;
        private System.Windows.Forms.Button btnkaydet;
    }
}