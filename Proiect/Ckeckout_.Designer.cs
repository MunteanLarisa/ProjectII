namespace Proiect
{
    partial class Ckeckout_
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
            this.textBox_firstName = new System.Windows.Forms.TextBox();
            this.firstname = new System.Windows.Forms.Label();
            this.Send = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_lastName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_firstName
            // 
            this.textBox_firstName.Location = new System.Drawing.Point(149, 89);
            this.textBox_firstName.Name = "textBox_firstName";
            this.textBox_firstName.Size = new System.Drawing.Size(100, 22);
            this.textBox_firstName.TabIndex = 0;
            // 
            // firstname
            // 
            this.firstname.AutoSize = true;
            this.firstname.Location = new System.Drawing.Point(61, 92);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(72, 17);
            this.firstname.TabIndex = 1;
            this.firstname.Text = "FirstName";
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(637, 371);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 28);
            this.Send.TabIndex = 2;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(149, 201);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(100, 22);
            this.textBox_email.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "LastName";
            // 
            // textBox_lastName
            // 
            this.textBox_lastName.Location = new System.Drawing.Point(149, 144);
            this.textBox_lastName.Name = "textBox_lastName";
            this.textBox_lastName.Size = new System.Drawing.Size(100, 22);
            this.textBox_lastName.TabIndex = 5;
            // 
            // Ckeckout_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_lastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.textBox_firstName);
            this.Name = "Ckeckout_";
            this.Text = "Ckeckout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_firstName;
        private System.Windows.Forms.Label firstname;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_lastName;
    }
}