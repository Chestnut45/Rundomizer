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
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // GenerateRunButton
            // 
            this.GenerateRunButton.Location = new System.Drawing.Point(12, 343);
            this.GenerateRunButton.Name = "GenerateRunButton";
            this.GenerateRunButton.Size = new System.Drawing.Size(518, 68);
            this.GenerateRunButton.TabIndex = 0;
            this.GenerateRunButton.Text = "Generate Run!";
            this.GenerateRunButton.UseVisualStyleBackColor = true;
            this.GenerateRunButton.Click += new System.EventHandler(this.GenerateRunButton_Click);
            // 
            // OrbListView
            // 
            this.OrbListView.Location = new System.Drawing.Point(12, 27);
            this.OrbListView.Name = "OrbListView";
            this.OrbListView.Size = new System.Drawing.Size(256, 310);
            this.OrbListView.TabIndex = 1;
            this.OrbListView.UseCompatibleStateImageBehavior = false;
            this.OrbListView.View = System.Windows.Forms.View.SmallIcon;
            // 
            // OrbsLabel
            // 
            this.OrbsLabel.AutoSize = true;
            this.OrbsLabel.Location = new System.Drawing.Point(12, 9);
            this.OrbsLabel.Name = "OrbsLabel";
            this.OrbsLabel.Size = new System.Drawing.Size(35, 15);
            this.OrbsLabel.TabIndex = 2;
            this.OrbsLabel.Text = "Orbs:";
            // 
            // RelicsLabel
            // 
            this.RelicsLabel.AutoSize = true;
            this.RelicsLabel.Location = new System.Drawing.Point(274, 9);
            this.RelicsLabel.Name = "RelicsLabel";
            this.RelicsLabel.Size = new System.Drawing.Size(40, 15);
            this.RelicsLabel.TabIndex = 3;
            this.RelicsLabel.Text = "Relics:";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(274, 27);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(256, 310);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.SmallIcon;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 423);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.RelicsLabel);
            this.Controls.Add(this.OrbsLabel);
            this.Controls.Add(this.OrbListView);
            this.Controls.Add(this.GenerateRunButton);
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
        private ListView listView1;
    }
}