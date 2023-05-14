
namespace Proiect
{
    partial class HotDeals_Ankara
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
            this.dataGridView_Ankara = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ankara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Ankara
            // 
            this.dataGridView_Ankara.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_Ankara.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Ankara.GridColor = System.Drawing.Color.White;
            this.dataGridView_Ankara.Location = new System.Drawing.Point(13, 144);
            this.dataGridView_Ankara.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_Ankara.Name = "dataGridView_Ankara";
            this.dataGridView_Ankara.RowHeadersWidth = 51;
            this.dataGridView_Ankara.Size = new System.Drawing.Size(495, 499);
            this.dataGridView_Ankara.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proiect.Properties.Resources.logi1;
            this.pictureBox1.InitialImage = global::Proiect.Properties.Resources.logi;
            this.pictureBox1.Location = new System.Drawing.Point(-94, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(602, 91);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // HotDeals_Ankara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1025, 688);
            this.Controls.Add(this.dataGridView_Ankara);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HotDeals_Ankara";
            this.Text = "HotDeals";
            this.Load += new System.EventHandler(this.HotDeals_Ankara_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ankara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView_Ankara;
    }
}