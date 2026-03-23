namespace HelloWorld
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnGreet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(148, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "What\'s your name?";
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.Lavender;
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(106, 142);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(344, 28);
            this.tbName.TabIndex = 1;
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // btnGreet
            // 
            this.btnGreet.BackColor = System.Drawing.Color.BlueViolet;
            this.btnGreet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGreet.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.btnGreet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGreet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGreet.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGreet.Location = new System.Drawing.Point(205, 204);
            this.btnGreet.Name = "btnGreet";
            this.btnGreet.Size = new System.Drawing.Size(146, 35);
            this.btnGreet.TabIndex = 2;
            this.btnGreet.Text = "Greet Me";
            this.btnGreet.UseVisualStyleBackColor = false;
            this.btnGreet.Click += new System.EventHandler(this.btnGreet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(572, 326);
            this.Controls.Add(this.btnGreet);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "What\'s you name?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnGreet;
    }
}

