using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TrelloApp
{
    partial class ManagerioMainWindow
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
            this.MondayGB = new System.Windows.Forms.GroupBox();
            this.TuesdayGB = new System.Windows.Forms.GroupBox();
            this.FridayGB = new System.Windows.Forms.GroupBox();
            this.SaturdayGB = new System.Windows.Forms.GroupBox();
            this.SundayGB = new System.Windows.Forms.GroupBox();
            this.ThursdayGB = new System.Windows.Forms.GroupBox();
            this.WednesdayGB = new System.Windows.Forms.GroupBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MondayGB
            // 
            this.MondayGB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MondayGB.AutoSize = true;
            this.MondayGB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MondayGB.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MondayGB.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.MondayGB.Location = new System.Drawing.Point(22, 71);
            this.MondayGB.MinimumSize = new System.Drawing.Size(180, 90);
            this.MondayGB.Name = "MondayGB";
            this.MondayGB.Size = new System.Drawing.Size(180, 90);
            this.MondayGB.TabIndex = 1;
            this.MondayGB.TabStop = false;
            this.MondayGB.Text = "Monday";
            // 
            // TuesdayGB
            // 
            this.TuesdayGB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TuesdayGB.AutoSize = true;
            this.TuesdayGB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TuesdayGB.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TuesdayGB.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.TuesdayGB.Location = new System.Drawing.Point(208, 71);
            this.TuesdayGB.MinimumSize = new System.Drawing.Size(180, 90);
            this.TuesdayGB.Name = "TuesdayGB";
            this.TuesdayGB.Size = new System.Drawing.Size(180, 90);
            this.TuesdayGB.TabIndex = 2;
            this.TuesdayGB.TabStop = false;
            this.TuesdayGB.Text = "Tuesday";
            // 
            // FridayGB
            // 
            this.FridayGB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FridayGB.AutoSize = true;
            this.FridayGB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FridayGB.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FridayGB.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.FridayGB.Location = new System.Drawing.Point(766, 71);
            this.FridayGB.MinimumSize = new System.Drawing.Size(180, 90);
            this.FridayGB.Name = "FridayGB";
            this.FridayGB.Size = new System.Drawing.Size(180, 90);
            this.FridayGB.TabIndex = 5;
            this.FridayGB.TabStop = false;
            this.FridayGB.Text = "Friday";
            // 
            // SaturdayGB
            // 
            this.SaturdayGB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SaturdayGB.AutoSize = true;
            this.SaturdayGB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaturdayGB.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaturdayGB.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.SaturdayGB.Location = new System.Drawing.Point(1138, 71);
            this.SaturdayGB.MinimumSize = new System.Drawing.Size(180, 90);
            this.SaturdayGB.Name = "SaturdayGB";
            this.SaturdayGB.Size = new System.Drawing.Size(180, 90);
            this.SaturdayGB.TabIndex = 6;
            this.SaturdayGB.TabStop = false;
            this.SaturdayGB.Text = "Saturday";
            // 
            // SundayGB
            // 
            this.SundayGB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SundayGB.AutoSize = true;
            this.SundayGB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SundayGB.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SundayGB.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.SundayGB.Location = new System.Drawing.Point(952, 71);
            this.SundayGB.MinimumSize = new System.Drawing.Size(180, 90);
            this.SundayGB.Name = "SundayGB";
            this.SundayGB.Size = new System.Drawing.Size(180, 90);
            this.SundayGB.TabIndex = 7;
            this.SundayGB.TabStop = false;
            this.SundayGB.Text = "Sunday";
            // 
            // ThursdayGB
            // 
            this.ThursdayGB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ThursdayGB.AutoSize = true;
            this.ThursdayGB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ThursdayGB.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThursdayGB.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.ThursdayGB.Location = new System.Drawing.Point(580, 71);
            this.ThursdayGB.MinimumSize = new System.Drawing.Size(180, 90);
            this.ThursdayGB.Name = "ThursdayGB";
            this.ThursdayGB.Size = new System.Drawing.Size(180, 90);
            this.ThursdayGB.TabIndex = 4;
            this.ThursdayGB.TabStop = false;
            this.ThursdayGB.Text = "Thursday";
            // 
            // WednesdayGB
            // 
            this.WednesdayGB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WednesdayGB.AutoSize = true;
            this.WednesdayGB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.WednesdayGB.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WednesdayGB.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.WednesdayGB.Location = new System.Drawing.Point(394, 71);
            this.WednesdayGB.MinimumSize = new System.Drawing.Size(180, 90);
            this.WednesdayGB.Name = "WednesdayGB";
            this.WednesdayGB.Size = new System.Drawing.Size(180, 90);
            this.WednesdayGB.TabIndex = 3;
            this.WednesdayGB.TabStop = false;
            this.WednesdayGB.Text = "Wednesday";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Montserrat", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(14, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(383, 66);
            this.TitleLabel.TabIndex = 8;
            this.TitleLabel.Text = "MANAGERIO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(391, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(614, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "With this application, your task management becomes easy peasy lemon squeezy ^_^";
            // 
            // ManagerioMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1346, 400);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.SundayGB);
            this.Controls.Add(this.SaturdayGB);
            this.Controls.Add(this.FridayGB);
            this.Controls.Add(this.ThursdayGB);
            this.Controls.Add(this.WednesdayGB);
            this.Controls.Add(this.TuesdayGB);
            this.Controls.Add(this.MondayGB);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ManagerioMainWindow";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Managerio";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public GroupBox MondayGB;
        public GroupBox TuesdayGB;
        public GroupBox FridayGB;
        public GroupBox SaturdayGB;
        public GroupBox SundayGB;
        public GroupBox ThursdayGB;
        public GroupBox WednesdayGB;
        private Label TitleLabel;
        private Label label1;
    }
}

