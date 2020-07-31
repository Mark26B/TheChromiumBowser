namespace TheChromiumBowser
{
    partial class Browser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browser));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripGoButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripAddressBar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonBack = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonForward = new System.Windows.Forms.ToolStripButton();
            this.toolStripReload = new System.Windows.Forms.ToolStripButton();
            this.BrowserTabs = new System.Windows.Forms.TabControl();
            this.BrowserScreen = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolStripButtonAddTab = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.BrowserTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripGoButton,
            this.toolStripAddressBar,
            this.toolStripButtonBack,
            this.toolStripButtonForward,
            this.toolStripReload,
            this.toolStripButtonAddTab});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(971, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripGoButton
            // 
            this.toolStripGoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripGoButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripGoButton.Image")));
            this.toolStripGoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripGoButton.Name = "toolStripGoButton";
            this.toolStripGoButton.Size = new System.Drawing.Size(29, 28);
            this.toolStripGoButton.Text = "Go";
            this.toolStripGoButton.Click += new System.EventHandler(this.toolStripGoButton_Click);
            // 
            // toolStripAddressBar
            // 
            this.toolStripAddressBar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripAddressBar.Name = "toolStripAddressBar";
            this.toolStripAddressBar.Size = new System.Drawing.Size(400, 31);
            this.toolStripAddressBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripAddressBar_KeyDown);
            // 
            // toolStripButtonBack
            // 
            this.toolStripButtonBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBack.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBack.Image")));
            this.toolStripButtonBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBack.Name = "toolStripButtonBack";
            this.toolStripButtonBack.Size = new System.Drawing.Size(29, 28);
            this.toolStripButtonBack.Text = "Back";
            this.toolStripButtonBack.Click += new System.EventHandler(this.toolStripButtonBack_Click);
            // 
            // toolStripButtonForward
            // 
            this.toolStripButtonForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonForward.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonForward.Image")));
            this.toolStripButtonForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonForward.Name = "toolStripButtonForward";
            this.toolStripButtonForward.Size = new System.Drawing.Size(29, 28);
            this.toolStripButtonForward.Text = "Forward";
            this.toolStripButtonForward.Click += new System.EventHandler(this.toolStripButtonForward_Click);
            // 
            // toolStripReload
            // 
            this.toolStripReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripReload.Image = ((System.Drawing.Image)(resources.GetObject("toolStripReload.Image")));
            this.toolStripReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripReload.Name = "toolStripReload";
            this.toolStripReload.Size = new System.Drawing.Size(29, 28);
            this.toolStripReload.Text = "Refresh";
            this.toolStripReload.Click += new System.EventHandler(this.toolStripReload_Click);
            // 
            // BrowserTabs
            // 
            this.BrowserTabs.Controls.Add(this.BrowserScreen);
            this.BrowserTabs.Controls.Add(this.tabPage2);
            this.BrowserTabs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BrowserTabs.Location = new System.Drawing.Point(0, 103);
            this.BrowserTabs.Name = "BrowserTabs";
            this.BrowserTabs.SelectedIndex = 0;
            this.BrowserTabs.Size = new System.Drawing.Size(971, 433);
            this.BrowserTabs.TabIndex = 1;
            // 
            // BrowserScreen
            // 
            this.BrowserScreen.Location = new System.Drawing.Point(4, 25);
            this.BrowserScreen.Name = "BrowserScreen";
            this.BrowserScreen.Padding = new System.Windows.Forms.Padding(3);
            this.BrowserScreen.Size = new System.Drawing.Size(963, 404);
            this.BrowserScreen.TabIndex = 0;
            this.BrowserScreen.Text = "tabPage1";
            this.BrowserScreen.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(963, 404);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // toolStripButtonAddTab
            // 
            this.toolStripButtonAddTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddTab.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddTab.Image")));
            this.toolStripButtonAddTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddTab.Name = "toolStripButtonAddTab";
            this.toolStripButtonAddTab.Size = new System.Drawing.Size(29, 28);
            this.toolStripButtonAddTab.Text = "Add Tab";
            this.toolStripButtonAddTab.Click += new System.EventHandler(this.toolStripButtonAddTab_Click);
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 536);
            this.Controls.Add(this.BrowserTabs);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Browser";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.BrowserTabs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripGoButton;
        private System.Windows.Forms.ToolStripTextBox toolStripAddressBar;
        private System.Windows.Forms.ToolStripButton toolStripButtonBack;
        private System.Windows.Forms.ToolStripButton toolStripButtonForward;
        private System.Windows.Forms.ToolStripButton toolStripReload;
        private System.Windows.Forms.TabControl BrowserTabs;
        private System.Windows.Forms.TabPage BrowserScreen;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddTab;
    }
}

