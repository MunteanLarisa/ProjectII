﻿namespace Proiect
{
    partial class ExoticCircuits_BoraBora
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_ExoticCircuitBoraBora = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.Color.White;
            this.dataGridView.Location = new System.Drawing.Point(10, 119);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(734, 170);
            this.dataGridView.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proiect.Properties.Resources.logi1;
            this.pictureBox1.InitialImage = global::Proiect.Properties.Resources.logi;
            this.pictureBox1.Location = new System.Drawing.Point(-79, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(452, 74);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btn_ExoticCircuitBoraBora
            // 
            this.btn_ExoticCircuitBoraBora.BackColor = System.Drawing.Color.Pink;
            this.btn_ExoticCircuitBoraBora.Location = new System.Drawing.Point(585, 476);
            this.btn_ExoticCircuitBoraBora.Name = "btn_ExoticCircuitBoraBora";
            this.btn_ExoticCircuitBoraBora.Size = new System.Drawing.Size(152, 47);
            this.btn_ExoticCircuitBoraBora.TabIndex = 14;
            this.btn_ExoticCircuitBoraBora.Text = "Checkout";
            this.btn_ExoticCircuitBoraBora.UseVisualStyleBackColor = false;
            // 
            // ExoticCircuits_BoraBora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(779, 541);
            this.Controls.Add(this.btn_ExoticCircuitBoraBora);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ExoticCircuits_BoraBora";
            this.Text = "ExoticCircuits_BoraBora";
            this.Load += new System.EventHandler(this.ExoticCircuits_BoraBora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_ExoticCircuitBoraBora;
    }
}