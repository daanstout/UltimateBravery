namespace UltimateBravery {
    partial class UltimateBraveryForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.bannerPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.rollBraveryButton = new System.Windows.Forms.Button();
            this.rollPanel = new System.Windows.Forms.Panel();
            this.guaranteeBootsCheckbox = new System.Windows.Forms.CheckBox();
            this.preventDuplicateItemsCheckbox = new System.Windows.Forms.CheckBox();
            this.useBlacklistCheckbox = new System.Windows.Forms.CheckBox();
            this.championComboBox = new System.Windows.Forms.ComboBox();
            this.guaranteeFlashCheckbox = new System.Windows.Forms.CheckBox();
            this.maxRFirstCheckbox = new System.Windows.Forms.CheckBox();
            this.bannerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bannerPanel
            // 
            this.bannerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bannerPanel.Controls.Add(this.closeButton);
            this.bannerPanel.Location = new System.Drawing.Point(0, 0);
            this.bannerPanel.Name = "bannerPanel";
            this.bannerPanel.Size = new System.Drawing.Size(800, 25);
            this.bannerPanel.TabIndex = 0;
            this.bannerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.BannerPanel_Paint);
            this.bannerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BannerPanel_MouseDown);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Red;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(775, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 25);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // rollBraveryButton
            // 
            this.rollBraveryButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rollBraveryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rollBraveryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollBraveryButton.ForeColor = System.Drawing.Color.White;
            this.rollBraveryButton.Location = new System.Drawing.Point(700, 50);
            this.rollBraveryButton.Name = "rollBraveryButton";
            this.rollBraveryButton.Size = new System.Drawing.Size(75, 50);
            this.rollBraveryButton.TabIndex = 1;
            this.rollBraveryButton.Text = "Roll for Bravery";
            this.rollBraveryButton.UseVisualStyleBackColor = true;
            this.rollBraveryButton.Click += new System.EventHandler(this.RollBraveryButton_Click);
            // 
            // rollPanel
            // 
            this.rollPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rollPanel.Location = new System.Drawing.Point(13, 50);
            this.rollPanel.Name = "rollPanel";
            this.rollPanel.Size = new System.Drawing.Size(650, 300);
            this.rollPanel.TabIndex = 2;
            this.rollPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.RollPanel_Paint);
            // 
            // guaranteeBootsCheckbox
            // 
            this.guaranteeBootsCheckbox.AutoSize = true;
            this.guaranteeBootsCheckbox.Checked = true;
            this.guaranteeBootsCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.guaranteeBootsCheckbox.ForeColor = System.Drawing.Color.White;
            this.guaranteeBootsCheckbox.Location = new System.Drawing.Point(680, 107);
            this.guaranteeBootsCheckbox.Name = "guaranteeBootsCheckbox";
            this.guaranteeBootsCheckbox.Size = new System.Drawing.Size(106, 17);
            this.guaranteeBootsCheckbox.TabIndex = 3;
            this.guaranteeBootsCheckbox.Text = "Guarantee Boots";
            this.guaranteeBootsCheckbox.UseVisualStyleBackColor = true;
            // 
            // preventDuplicateItemsCheckbox
            // 
            this.preventDuplicateItemsCheckbox.AutoSize = true;
            this.preventDuplicateItemsCheckbox.Checked = true;
            this.preventDuplicateItemsCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.preventDuplicateItemsCheckbox.ForeColor = System.Drawing.Color.White;
            this.preventDuplicateItemsCheckbox.Location = new System.Drawing.Point(680, 176);
            this.preventDuplicateItemsCheckbox.Name = "preventDuplicateItemsCheckbox";
            this.preventDuplicateItemsCheckbox.Size = new System.Drawing.Size(116, 17);
            this.preventDuplicateItemsCheckbox.TabIndex = 4;
            this.preventDuplicateItemsCheckbox.Text = "Prevent Duplicates";
            this.preventDuplicateItemsCheckbox.UseVisualStyleBackColor = true;
            // 
            // useBlacklistCheckbox
            // 
            this.useBlacklistCheckbox.AutoSize = true;
            this.useBlacklistCheckbox.Checked = true;
            this.useBlacklistCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useBlacklistCheckbox.ForeColor = System.Drawing.Color.White;
            this.useBlacklistCheckbox.Location = new System.Drawing.Point(680, 153);
            this.useBlacklistCheckbox.Name = "useBlacklistCheckbox";
            this.useBlacklistCheckbox.Size = new System.Drawing.Size(92, 17);
            this.useBlacklistCheckbox.TabIndex = 5;
            this.useBlacklistCheckbox.Text = "Use Blacklists";
            this.useBlacklistCheckbox.UseVisualStyleBackColor = true;
            // 
            // championComboBox
            // 
            this.championComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.championComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.championComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.championComboBox.ForeColor = System.Drawing.Color.White;
            this.championComboBox.FormattingEnabled = true;
            this.championComboBox.Location = new System.Drawing.Point(680, 222);
            this.championComboBox.Name = "championComboBox";
            this.championComboBox.Size = new System.Drawing.Size(116, 21);
            this.championComboBox.TabIndex = 6;
            // 
            // guaranteeFlashCheckbox
            // 
            this.guaranteeFlashCheckbox.AutoSize = true;
            this.guaranteeFlashCheckbox.Checked = true;
            this.guaranteeFlashCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.guaranteeFlashCheckbox.ForeColor = System.Drawing.Color.White;
            this.guaranteeFlashCheckbox.Location = new System.Drawing.Point(680, 130);
            this.guaranteeFlashCheckbox.Name = "guaranteeFlashCheckbox";
            this.guaranteeFlashCheckbox.Size = new System.Drawing.Size(104, 17);
            this.guaranteeFlashCheckbox.TabIndex = 7;
            this.guaranteeFlashCheckbox.Text = "Guarantee Flash";
            this.guaranteeFlashCheckbox.UseVisualStyleBackColor = true;
            // 
            // maxRFirstCheckbox
            // 
            this.maxRFirstCheckbox.AutoSize = true;
            this.maxRFirstCheckbox.Checked = true;
            this.maxRFirstCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.maxRFirstCheckbox.ForeColor = System.Drawing.Color.White;
            this.maxRFirstCheckbox.Location = new System.Drawing.Point(680, 199);
            this.maxRFirstCheckbox.Name = "maxRFirstCheckbox";
            this.maxRFirstCheckbox.Size = new System.Drawing.Size(79, 17);
            this.maxRFirstCheckbox.TabIndex = 8;
            this.maxRFirstCheckbox.Text = "Max R First";
            this.maxRFirstCheckbox.UseVisualStyleBackColor = true;
            // 
            // UltimateBraveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(800, 375);
            this.Controls.Add(this.maxRFirstCheckbox);
            this.Controls.Add(this.preventDuplicateItemsCheckbox);
            this.Controls.Add(this.guaranteeFlashCheckbox);
            this.Controls.Add(this.championComboBox);
            this.Controls.Add(this.useBlacklistCheckbox);
            this.Controls.Add(this.guaranteeBootsCheckbox);
            this.Controls.Add(this.rollPanel);
            this.Controls.Add(this.rollBraveryButton);
            this.Controls.Add(this.bannerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UltimateBraveryForm";
            this.Text = "Form1";
            this.bannerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel bannerPanel;
        private System.Windows.Forms.Button rollBraveryButton;
        private System.Windows.Forms.Panel rollPanel;
        private System.Windows.Forms.CheckBox guaranteeBootsCheckbox;
        private System.Windows.Forms.CheckBox preventDuplicateItemsCheckbox;
        private System.Windows.Forms.CheckBox useBlacklistCheckbox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ComboBox championComboBox;
        private System.Windows.Forms.CheckBox guaranteeFlashCheckbox;
        private System.Windows.Forms.CheckBox maxRFirstCheckbox;
    }
}

