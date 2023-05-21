
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
            this.btn_HotDealsAnkara = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ankara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Ankara
            // 
            this.dataGridView_Ankara.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_Ankara.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Ankara.GridColor = System.Drawing.Color.White;
            this.dataGridView_Ankara.Location = new System.Drawing.Point(20, 100);
            this.dataGridView_Ankara.Name = "dataGridView_Ankara";
            this.dataGridView_Ankara.RowHeadersWidth = 51;
            this.dataGridView_Ankara.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Ankara.Size = new System.Drawing.Size(718, 158);
            this.dataGridView_Ankara.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proiect.Properties.Resources.logi1;
            this.pictureBox1.InitialImage = global::Proiect.Properties.Resources.logi;
            this.pictureBox1.Location = new System.Drawing.Point(-65, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(452, 74);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btn_HotDealsAnkara
            // 
            this.btn_HotDealsAnkara.BackColor = System.Drawing.Color.Pink;
            this.btn_HotDealsAnkara.Location = new System.Drawing.Point(559, 459);
            this.btn_HotDealsAnkara.Name = "btn_HotDealsAnkara";
            this.btn_HotDealsAnkara.Size = new System.Drawing.Size(179, 58);
            this.btn_HotDealsAnkara.TabIndex = 12;
            this.btn_HotDealsAnkara.Text = "Checkout";
            this.btn_HotDealsAnkara.UseVisualStyleBackColor = false;
            // 
            // HotDeals_Ankara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(779, 541);
            this.Controls.Add(this.btn_HotDealsAnkara);
            this.Controls.Add(this.dataGridView_Ankara);
            this.Controls.Add(this.pictureBox1);
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
        private System.Windows.Forms.Button btn_HotDealsAnkara;
    }
}