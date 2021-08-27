namespace Lab7ControlTask
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
            this.MaxValue = new System.Windows.Forms.TextBox();
            this.resText = new System.Windows.Forms.TextBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MaxValue
            // 
            this.MaxValue.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaxValue.Location = new System.Drawing.Point(106, 131);
            this.MaxValue.Name = "MaxValue";
            this.MaxValue.Size = new System.Drawing.Size(107, 20);
            this.MaxValue.TabIndex = 0;
            // 
            // resText
            // 
            this.resText.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resText.Location = new System.Drawing.Point(144, 44);
            this.resText.Name = "resText";
            this.resText.Size = new System.Drawing.Size(153, 23);
            this.resText.TabIndex = 1;
            // 
            // GoButton
            // 
            this.GoButton.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoButton.ForeColor = System.Drawing.Color.Black;
            this.GoButton.Location = new System.Drawing.Point(15, 44);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(94, 23);
            this.GoButton.TabIndex = 2;
            this.GoButton.Text = "Рассчитать";
            this.GoButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Max result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(508, 272);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.resText);
            this.Controls.Add(this.MaxValue);
            this.ForeColor = System.Drawing.Color.Honeydew;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Lab 7 Final";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MaxValue;
        private System.Windows.Forms.TextBox resText;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.Label label2;
    }
}

