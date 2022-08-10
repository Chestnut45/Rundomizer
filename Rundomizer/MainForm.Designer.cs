namespace Rundomizer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GenerateRunButton = new System.Windows.Forms.Button();
            this.OrbListView = new System.Windows.Forms.ListView();
            this.OrbsLabel = new System.Windows.Forms.Label();
            this.RelicsLabel = new System.Windows.Forms.Label();
            this.RelicListView = new System.Windows.Forms.ListView();
            this.RunTypeLabel = new System.Windows.Forms.Label();
            this.RunTypeDropDown = new System.Windows.Forms.ComboBox();
            this.RunTypeDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GenerateRunButton
            // 
            this.GenerateRunButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.GenerateRunButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateRunButton.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GenerateRunButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GenerateRunButton.Location = new System.Drawing.Point(12, 415);
            this.GenerateRunButton.Name = "GenerateRunButton";
            this.GenerateRunButton.Size = new System.Drawing.Size(518, 68);
            this.GenerateRunButton.TabIndex = 4;
            this.GenerateRunButton.Text = "Generate Run!";
            this.GenerateRunButton.UseVisualStyleBackColor = false;
            this.GenerateRunButton.Click += new System.EventHandler(this.GenerateRunButton_Click);
            // 
            // OrbListView
            // 
            this.OrbListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.OrbListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrbListView.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OrbListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.OrbListView.HideSelection = true;
            this.OrbListView.Location = new System.Drawing.Point(12, 31);
            this.OrbListView.Name = "OrbListView";
            this.OrbListView.Size = new System.Drawing.Size(256, 326);
            this.OrbListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.OrbListView.TabIndex = 1;
            this.OrbListView.TabStop = false;
            this.OrbListView.UseCompatibleStateImageBehavior = false;
            this.OrbListView.View = System.Windows.Forms.View.SmallIcon;
            // 
            // OrbsLabel
            // 
            this.OrbsLabel.AutoSize = true;
            this.OrbsLabel.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OrbsLabel.Location = new System.Drawing.Point(12, 9);
            this.OrbsLabel.Name = "OrbsLabel";
            this.OrbsLabel.Size = new System.Drawing.Size(43, 19);
            this.OrbsLabel.TabIndex = 2;
            this.OrbsLabel.Text = "Orbs:";
            // 
            // RelicsLabel
            // 
            this.RelicsLabel.AutoSize = true;
            this.RelicsLabel.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RelicsLabel.Location = new System.Drawing.Point(274, 9);
            this.RelicsLabel.Name = "RelicsLabel";
            this.RelicsLabel.Size = new System.Drawing.Size(48, 19);
            this.RelicsLabel.TabIndex = 3;
            this.RelicsLabel.Text = "Relics:";
            // 
            // RelicListView
            // 
            this.RelicListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.RelicListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RelicListView.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RelicListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.RelicListView.HideSelection = true;
            this.RelicListView.Location = new System.Drawing.Point(274, 31);
            this.RelicListView.Name = "RelicListView";
            this.RelicListView.Size = new System.Drawing.Size(256, 326);
            this.RelicListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.RelicListView.TabIndex = 4;
            this.RelicListView.UseCompatibleStateImageBehavior = false;
            this.RelicListView.View = System.Windows.Forms.View.SmallIcon;
            // 
            // RunTypeLabel
            // 
            this.RunTypeLabel.AutoSize = true;
            this.RunTypeLabel.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RunTypeLabel.Location = new System.Drawing.Point(12, 360);
            this.RunTypeLabel.Name = "RunTypeLabel";
            this.RunTypeLabel.Size = new System.Drawing.Size(67, 19);
            this.RunTypeLabel.TabIndex = 6;
            this.RunTypeLabel.Text = "Run Type:";
            // 
            // RunTypeDropDown
            // 
            this.RunTypeDropDown.BackColor = System.Drawing.SystemColors.ControlDark;
            this.RunTypeDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RunTypeDropDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RunTypeDropDown.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RunTypeDropDown.FormattingEnabled = true;
            this.RunTypeDropDown.Items.AddRange(new object[] {
            "Standard Reshuffled",
            "Ol\' Reliable",
            "Oh Boy, Twins!",
            "Three\'s Company",
            "Let\'s Bounce!",
            "Why Are You Hitting Yourself?",
            "Stoned",
            "Phat Deck",
            "Over 9000",
            "Knife To A Gunfight",
            "Glass Cannon"});
            this.RunTypeDropDown.Location = new System.Drawing.Point(12, 382);
            this.RunTypeDropDown.Name = "RunTypeDropDown";
            this.RunTypeDropDown.Size = new System.Drawing.Size(221, 27);
            this.RunTypeDropDown.TabIndex = 7;
            this.RunTypeDropDown.SelectedIndexChanged += new System.EventHandler(this.RunTypeDropDown_SelectedIndexChanged);
            // 
            // RunTypeDescription
            // 
            this.RunTypeDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RunTypeDescription.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RunTypeDescription.Location = new System.Drawing.Point(239, 382);
            this.RunTypeDescription.Name = "RunTypeDescription";
            this.RunTypeDescription.Size = new System.Drawing.Size(291, 24);
            this.RunTypeDescription.TabIndex = 8;
            this.RunTypeDescription.Text = "RunTypeDescription";
            this.RunTypeDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(542, 495);
            this.Controls.Add(this.RunTypeDescription);
            this.Controls.Add(this.RunTypeDropDown);
            this.Controls.Add(this.RunTypeLabel);
            this.Controls.Add(this.RelicListView);
            this.Controls.Add(this.RelicsLabel);
            this.Controls.Add(this.OrbsLabel);
            this.Controls.Add(this.OrbListView);
            this.Controls.Add(this.GenerateRunButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Peglin Rundomizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button GenerateRunButton;
        private ListView OrbListView;
        private Label OrbsLabel;
        private Label RelicsLabel;
        private ListView RelicListView;
        private Label RunTypeLabel;
        private ComboBox RunTypeDropDown;
        private Label RunTypeDescription;
    }
}