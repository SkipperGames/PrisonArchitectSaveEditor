namespace PrisonArchitectSaveEditor
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.b_unsuppress = new System.Windows.Forms.Button();
            this.b_repair = new System.Windows.Forms.Button();
            this.b_carpenters = new System.Windows.Forms.Button();
            this.b_traits = new System.Windows.Forms.Button();
            this.b_reputation = new System.Windows.Forms.Button();
            this.b_armtazers = new System.Windows.Forms.Button();
            this.b_rechargetazers = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.b_gangmembers = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_reoffend = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(412, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.saveAsToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.menuToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 22);
            this.toolStripMenuItem2.Text = "Open";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.toolStripMenuItem3.Size = new System.Drawing.Size(177, 22);
            this.toolStripMenuItem3.Text = "Save";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // b_unsuppress
            // 
            this.b_unsuppress.Location = new System.Drawing.Point(3, 3);
            this.b_unsuppress.Name = "b_unsuppress";
            this.b_unsuppress.Size = new System.Drawing.Size(188, 23);
            this.b_unsuppress.TabIndex = 1;
            this.b_unsuppress.Text = "Unsuppress prisoners";
            this.b_unsuppress.UseVisualStyleBackColor = true;
            this.b_unsuppress.Click += new System.EventHandler(this.b_unsuppress_Click);
            // 
            // b_repair
            // 
            this.b_repair.Location = new System.Drawing.Point(3, 177);
            this.b_repair.Name = "b_repair";
            this.b_repair.Size = new System.Drawing.Size(188, 23);
            this.b_repair.TabIndex = 7;
            this.b_repair.Text = "Repair damaged objects";
            this.b_repair.UseVisualStyleBackColor = true;
            this.b_repair.Click += new System.EventHandler(this.b_repair_Click);
            // 
            // b_carpenters
            // 
            this.b_carpenters.Location = new System.Drawing.Point(3, 148);
            this.b_carpenters.Name = "b_carpenters";
            this.b_carpenters.Size = new System.Drawing.Size(188, 23);
            this.b_carpenters.TabIndex = 6;
            this.b_carpenters.Text = "All prisoners are carpenters";
            this.b_carpenters.UseVisualStyleBackColor = true;
            this.b_carpenters.Click += new System.EventHandler(this.b_carpenters_Click);
            // 
            // b_traits
            // 
            this.b_traits.Location = new System.Drawing.Point(3, 119);
            this.b_traits.Name = "b_traits";
            this.b_traits.Size = new System.Drawing.Size(188, 23);
            this.b_traits.TabIndex = 5;
            this.b_traits.Text = "No prisoner traits";
            this.b_traits.UseVisualStyleBackColor = true;
            this.b_traits.Click += new System.EventHandler(this.b_traits_Click);
            // 
            // b_reputation
            // 
            this.b_reputation.Location = new System.Drawing.Point(3, 90);
            this.b_reputation.Name = "b_reputation";
            this.b_reputation.Size = new System.Drawing.Size(188, 23);
            this.b_reputation.TabIndex = 4;
            this.b_reputation.Text = "No prisoner reputation";
            this.b_reputation.UseVisualStyleBackColor = true;
            this.b_reputation.Click += new System.EventHandler(this.b_reputation_Click);
            // 
            // b_armtazers
            // 
            this.b_armtazers.Location = new System.Drawing.Point(3, 61);
            this.b_armtazers.Name = "b_armtazers";
            this.b_armtazers.Size = new System.Drawing.Size(188, 23);
            this.b_armtazers.TabIndex = 3;
            this.b_armtazers.Text = "Arm all guards with tazers";
            this.b_armtazers.UseVisualStyleBackColor = true;
            this.b_armtazers.Click += new System.EventHandler(this.b_armtazers_Click);
            // 
            // b_rechargetazers
            // 
            this.b_rechargetazers.Location = new System.Drawing.Point(3, 32);
            this.b_rechargetazers.Name = "b_rechargetazers";
            this.b_rechargetazers.Size = new System.Drawing.Size(188, 23);
            this.b_rechargetazers.TabIndex = 2;
            this.b_rechargetazers.Text = "Recharge tazers";
            this.b_rechargetazers.UseVisualStyleBackColor = true;
            this.b_rechargetazers.Click += new System.EventHandler(this.b_rechargetazers_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 326);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(412, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // b_gangmembers
            // 
            this.b_gangmembers.Location = new System.Drawing.Point(3, 206);
            this.b_gangmembers.Name = "b_gangmembers";
            this.b_gangmembers.Size = new System.Drawing.Size(188, 23);
            this.b_gangmembers.TabIndex = 8;
            this.b_gangmembers.Text = "Revoke gang memberships";
            this.b_gangmembers.UseVisualStyleBackColor = true;
            this.b_gangmembers.Click += new System.EventHandler(this.b_gangmembers_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vScrollBar1.Location = new System.Drawing.Point(234, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(18, 295);
            this.vScrollBar1.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.b_reoffend);
            this.panel1.Controls.Add(this.vScrollBar1);
            this.panel1.Controls.Add(this.b_unsuppress);
            this.panel1.Controls.Add(this.b_gangmembers);
            this.panel1.Controls.Add(this.b_rechargetazers);
            this.panel1.Controls.Add(this.b_repair);
            this.panel1.Controls.Add(this.b_armtazers);
            this.panel1.Controls.Add(this.b_reputation);
            this.panel1.Controls.Add(this.b_carpenters);
            this.panel1.Controls.Add(this.b_traits);
            this.panel1.Location = new System.Drawing.Point(148, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 295);
            this.panel1.TabIndex = 10;
            // 
            // b_reoffend
            // 
            this.b_reoffend.Location = new System.Drawing.Point(4, 236);
            this.b_reoffend.Name = "b_reoffend";
            this.b_reoffend.Size = new System.Drawing.Size(187, 23);
            this.b_reoffend.TabIndex = 10;
            this.b_reoffend.Text = "Set reoffending chance to zero";
            this.b_reoffend.UseVisualStyleBackColor = true;
            this.b_reoffend.Click += new System.EventHandler(this.b_reoffend_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(412, 348);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Form1";
            this.Text = "Prison Architect Save Editor";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Button b_unsuppress;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.Button b_rechargetazers;
        private System.Windows.Forms.Button b_armtazers;
        private System.Windows.Forms.Button b_reputation;
        private System.Windows.Forms.Button b_traits;
        private System.Windows.Forms.Button b_carpenters;
        private System.Windows.Forms.Button b_repair;
        private System.Windows.Forms.Button b_gangmembers;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_reoffend;
    }
}

