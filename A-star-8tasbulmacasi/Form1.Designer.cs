namespace A_star_8tasbulmacasi
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
            this.textstart00 = new System.Windows.Forms.TextBox();
            this.textstart01 = new System.Windows.Forms.TextBox();
            this.textstart02 = new System.Windows.Forms.TextBox();
            this.textstart10 = new System.Windows.Forms.TextBox();
            this.textstart11 = new System.Windows.Forms.TextBox();
            this.textstart12 = new System.Windows.Forms.TextBox();
            this.textstart20 = new System.Windows.Forms.TextBox();
            this.textstart21 = new System.Windows.Forms.TextBox();
            this.textstart22 = new System.Windows.Forms.TextBox();
            this.buttonsolve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textstart00
            // 
            this.textstart00.Location = new System.Drawing.Point(80, 74);
            this.textstart00.Multiline = true;
            this.textstart00.Name = "textstart00";
            this.textstart00.Size = new System.Drawing.Size(100, 46);
            this.textstart00.TabIndex = 0;
            this.textstart00.TextChanged += new System.EventHandler(this.textstart00_TextChanged);
            // 
            // textstart01
            // 
            this.textstart01.Location = new System.Drawing.Point(215, 74);
            this.textstart01.Multiline = true;
            this.textstart01.Name = "textstart01";
            this.textstart01.Size = new System.Drawing.Size(100, 46);
            this.textstart01.TabIndex = 1;
            // 
            // textstart02
            // 
            this.textstart02.Location = new System.Drawing.Point(346, 74);
            this.textstart02.Multiline = true;
            this.textstart02.Name = "textstart02";
            this.textstart02.Size = new System.Drawing.Size(100, 46);
            this.textstart02.TabIndex = 2;
            // 
            // textstart10
            // 
            this.textstart10.Location = new System.Drawing.Point(80, 138);
            this.textstart10.Multiline = true;
            this.textstart10.Name = "textstart10";
            this.textstart10.Size = new System.Drawing.Size(100, 46);
            this.textstart10.TabIndex = 3;
            // 
            // textstart11
            // 
            this.textstart11.Location = new System.Drawing.Point(215, 138);
            this.textstart11.Multiline = true;
            this.textstart11.Name = "textstart11";
            this.textstart11.Size = new System.Drawing.Size(100, 46);
            this.textstart11.TabIndex = 4;
            // 
            // textstart12
            // 
            this.textstart12.Location = new System.Drawing.Point(346, 138);
            this.textstart12.Multiline = true;
            this.textstart12.Name = "textstart12";
            this.textstart12.Size = new System.Drawing.Size(100, 46);
            this.textstart12.TabIndex = 5;
            // 
            // textstart20
            // 
            this.textstart20.Location = new System.Drawing.Point(80, 206);
            this.textstart20.Multiline = true;
            this.textstart20.Name = "textstart20";
            this.textstart20.Size = new System.Drawing.Size(100, 43);
            this.textstart20.TabIndex = 6;
            // 
            // textstart21
            // 
            this.textstart21.Location = new System.Drawing.Point(215, 206);
            this.textstart21.Multiline = true;
            this.textstart21.Name = "textstart21";
            this.textstart21.Size = new System.Drawing.Size(100, 43);
            this.textstart21.TabIndex = 7;
            // 
            // textstart22
            // 
            this.textstart22.Location = new System.Drawing.Point(346, 206);
            this.textstart22.Multiline = true;
            this.textstart22.Name = "textstart22";
            this.textstart22.Size = new System.Drawing.Size(100, 43);
            this.textstart22.TabIndex = 8;
            // 
            // buttonsolve
            // 
            this.buttonsolve.Location = new System.Drawing.Point(230, 303);
            this.buttonsolve.Name = "buttonsolve";
            this.buttonsolve.Size = new System.Drawing.Size(75, 23);
            this.buttonsolve.TabIndex = 9;
            this.buttonsolve.Text = "solve";
            this.buttonsolve.UseVisualStyleBackColor = true;
            this.buttonsolve.Click += new System.EventHandler(this.buttonsolve_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonsolve);
            this.Controls.Add(this.textstart22);
            this.Controls.Add(this.textstart21);
            this.Controls.Add(this.textstart20);
            this.Controls.Add(this.textstart12);
            this.Controls.Add(this.textstart11);
            this.Controls.Add(this.textstart10);
            this.Controls.Add(this.textstart02);
            this.Controls.Add(this.textstart01);
            this.Controls.Add(this.textstart00);
            this.Name = "Form1";
            this.Text = "8 tas bulmacasi solver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textstart00;
        private System.Windows.Forms.TextBox textstart01;
        private System.Windows.Forms.TextBox textstart02;
        private System.Windows.Forms.TextBox textstart10;
        private System.Windows.Forms.TextBox textstart11;
        private System.Windows.Forms.TextBox textstart12;
        private System.Windows.Forms.TextBox textstart20;
        private System.Windows.Forms.TextBox textstart21;
        private System.Windows.Forms.TextBox textstart22;
        private System.Windows.Forms.Button buttonsolve;
    }
}

