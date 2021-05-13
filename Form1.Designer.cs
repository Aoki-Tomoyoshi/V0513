
namespace V0513
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mybutton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mybutton1
            // 
            this.mybutton1.Location = new System.Drawing.Point(0, 0);
            this.mybutton1.Name = "mybutton1";
            this.mybutton1.Size = new System.Drawing.Size(130, 72);
            this.mybutton1.TabIndex = 0;
            this.mybutton1.Text = "button1";
            this.mybutton1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.mybutton1.UseVisualStyleBackColor = true;
            this.mybutton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mybutton1);
            this.ForeColor = System.Drawing.Color.LightSalmon;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mybutton1;
    }
}

