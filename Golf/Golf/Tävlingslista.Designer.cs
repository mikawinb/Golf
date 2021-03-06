﻿namespace Golf
{
    partial class Tävlingslista
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.reg_button = new System.Windows.Forms.Button();
            this.anm_button = new System.Windows.Forms.Button();
            this.res_button = new System.Windows.Forms.Button();
            this.lag_button = new System.Windows.Forms.Button();
            this.rem_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(761, 359);
            this.dataGridView.TabIndex = 2;
            // 
            // reg_button
            // 
            this.reg_button.Location = new System.Drawing.Point(12, 377);
            this.reg_button.Name = "reg_button";
            this.reg_button.Size = new System.Drawing.Size(114, 23);
            this.reg_button.TabIndex = 3;
            this.reg_button.Text = "Registrera tävling";
            this.reg_button.UseVisualStyleBackColor = true;
            this.reg_button.Click += new System.EventHandler(this.reg_button_Click);
            // 
            // anm_button
            // 
            this.anm_button.Location = new System.Drawing.Point(262, 377);
            this.anm_button.Name = "anm_button";
            this.anm_button.Size = new System.Drawing.Size(114, 23);
            this.anm_button.TabIndex = 4;
            this.anm_button.Text = "Anmäl deltagare";
            this.anm_button.UseVisualStyleBackColor = true;
            this.anm_button.Click += new System.EventHandler(this.anm_button_Click);
            // 
            // res_button
            // 
            this.res_button.Location = new System.Drawing.Point(539, 377);
            this.res_button.Name = "res_button";
            this.res_button.Size = new System.Drawing.Size(114, 23);
            this.res_button.TabIndex = 5;
            this.res_button.Text = "Resultat";
            this.res_button.UseVisualStyleBackColor = true;
            this.res_button.Click += new System.EventHandler(this.res_button_Click);
            // 
            // lag_button
            // 
            this.lag_button.Location = new System.Drawing.Point(659, 377);
            this.lag_button.Name = "lag_button";
            this.lag_button.Size = new System.Drawing.Size(114, 23);
            this.lag_button.TabIndex = 6;
            this.lag_button.Text = "Lag";
            this.lag_button.UseVisualStyleBackColor = true;
            this.lag_button.Click += new System.EventHandler(this.lag_button_Click);
            // 
            // rem_button
            // 
            this.rem_button.Location = new System.Drawing.Point(132, 377);
            this.rem_button.Name = "rem_button";
            this.rem_button.Size = new System.Drawing.Size(104, 23);
            this.rem_button.TabIndex = 7;
            this.rem_button.Text = "Ta bort tävling";
            this.rem_button.UseVisualStyleBackColor = true;
            this.rem_button.Click += new System.EventHandler(this.rem_button_Click);
            // 
            // Tävlingslista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 407);
            this.Controls.Add(this.rem_button);
            this.Controls.Add(this.lag_button);
            this.Controls.Add(this.res_button);
            this.Controls.Add(this.anm_button);
            this.Controls.Add(this.reg_button);
            this.Controls.Add(this.dataGridView);
            this.Name = "Tävlingslista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tävlingslista";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button reg_button;
        private System.Windows.Forms.Button anm_button;
        private System.Windows.Forms.Button res_button;
        private System.Windows.Forms.Button lag_button;
        private System.Windows.Forms.Button rem_button;
    }
}