namespace Clipstack
{
    partial class RootForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RootForm));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pullFromStackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearStackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Clipstack";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.takeClipboardToolStripMenuItem,
            this.pullFromStackToolStripMenuItem,
            this.clearStackToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(164, 114);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // takeClipboardToolStripMenuItem
            // 
            this.takeClipboardToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("takeClipboardToolStripMenuItem.Image")));
            this.takeClipboardToolStripMenuItem.Name = "takeClipboardToolStripMenuItem";
            this.takeClipboardToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.takeClipboardToolStripMenuItem.Text = "Take clipboard...";
            this.takeClipboardToolStripMenuItem.Click += new System.EventHandler(this.takeClipboardToolStripMenuItem_Click);
            // 
            // pullFromStackToolStripMenuItem
            // 
            this.pullFromStackToolStripMenuItem.Name = "pullFromStackToolStripMenuItem";
            this.pullFromStackToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.pullFromStackToolStripMenuItem.Text = "Pull from Stack...";
            // 
            // clearStackToolStripMenuItem
            // 
            this.clearStackToolStripMenuItem.Name = "clearStackToolStripMenuItem";
            this.clearStackToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.clearStackToolStripMenuItem.Text = "Clear Stack";
            this.clearStackToolStripMenuItem.Click += new System.EventHandler(this.clearStackToolStripMenuItem_Click);
            // 
            // RootForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RootForm";
            this.Opacity = 0D;
            this.ShowInTaskbar = false;
            this.Text = "RootForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pullFromStackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearStackToolStripMenuItem;
    }
}

