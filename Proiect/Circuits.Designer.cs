﻿
namespace Proiect
{
    partial class Circuits
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_ExoticCircuitsMaldives = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(12, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(387, 429);
            this.dataGridView1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proiect.Properties.Resources.logi1;
            this.pictureBox1.InitialImage = global::Proiect.Properties.Resources.logi;
            this.pictureBox1.Location = new System.Drawing.Point(-88, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(448, 74);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btn_ExoticCircuitsMaldives
            // 
            this.btn_ExoticCircuitsMaldives.BackColor = System.Drawing.Color.Pink;
            this.btn_ExoticCircuitsMaldives.Location = new System.Drawing.Point(593, 505);
            this.btn_ExoticCircuitsMaldives.Name = "btn_ExoticCircuitsMaldives";
            this.btn_ExoticCircuitsMaldives.Size = new System.Drawing.Size(152, 47);
            this.btn_ExoticCircuitsMaldives.TabIndex = 21;
            this.btn_ExoticCircuitsMaldives.Text = "Checkout";
            this.btn_ExoticCircuitsMaldives.UseVisualStyleBackColor = false;
            // 
            // Circuits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(774, 564);
            this.Controls.Add(this.btn_ExoticCircuitsMaldives);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Circuits";
            this.Text = "Circuits";
            this.Load += new System.EventHandler(this.Circuits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_ExoticCircuitsMaldives;
    }
}