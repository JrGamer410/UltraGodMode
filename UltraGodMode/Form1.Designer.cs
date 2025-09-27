namespace UltraGodMode
{
    partial class Form1
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
            this.godModeItems = new System.Windows.Forms.ListView();
            this.launchButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // godModeItems
            // 
            this.godModeItems.FullRowSelect = true;
            this.godModeItems.HideSelection = false;
            this.godModeItems.Location = new System.Drawing.Point(12, 12);
            this.godModeItems.Name = "godModeItems";
            this.godModeItems.Size = new System.Drawing.Size(776, 405);
            this.godModeItems.TabIndex = 0;
            this.godModeItems.UseCompatibleStateImageBehavior = false;
            this.godModeItems.View = System.Windows.Forms.View.Details;
            this.godModeItems.SelectedIndexChanged += new System.EventHandler(this.godModeItems_SelectedIndexChanged);
            // 
            // launchButton
            // 
            this.launchButton.Location = new System.Drawing.Point(713, 423);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(75, 23);
            this.launchButton.TabIndex = 1;
            this.launchButton.Text = "Launch";
            this.launchButton.UseVisualStyleBackColor = true;
            this.launchButton.Click += new System.EventHandler(this.launchButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 423);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.launchButton);
            this.Controls.Add(this.godModeItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UltraGodMode by Sean-e/JrGamer410";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView godModeItems;
        private System.Windows.Forms.Button launchButton;
        private System.Windows.Forms.Button exitButton;
    }
}

