﻿namespace Proiect
{
    partial class ExoticCircuits_Dubai
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
            this.btn_ExoticCircuitsDubai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.Color.White;
            this.dataGridView.Location = new System.Drawing.Point(25, 154);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(957, 194);
            this.dataGridView.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proiect.Properties.Resources.logi1;
            this.pictureBox1.InitialImage = global::Proiect.Properties.Resources.logi;
            this.pictureBox1.Location = new System.Drawing.Point(-93, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(603, 80);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btn_ExoticCircuitsDubai
            // 
            this.btn_ExoticCircuitsDubai.BackColor = System.Drawing.Color.Pink;
            this.btn_ExoticCircuitsDubai.Location = new System.Drawing.Point(780, 586);
            this.btn_ExoticCircuitsDubai.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ExoticCircuitsDubai.Name = "btn_ExoticCircuitsDubai";
            this.btn_ExoticCircuitsDubai.Size = new System.Drawing.Size(203, 58);
            this.btn_ExoticCircuitsDubai.TabIndex = 18;
            this.btn_ExoticCircuitsDubai.Text = "Checkout";
            this.btn_ExoticCircuitsDubai.UseVisualStyleBackColor = false;
            this.btn_ExoticCircuitsDubai.Click += new System.EventHandler(this.btn_ExoticCircuitsDubai_Click);
            // 
            // ExoticCircuits_Dubai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1039, 666);
            this.Controls.Add(this.btn_ExoticCircuitsDubai);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ExoticCircuits_Dubai";
            this.Text = "ExoticCircuits Dubai";
            this.Load += new System.EventHandler(this.ExoticCircuits_Dubai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_ExoticCircuitsDubai;
    }
}