using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clipstack
{
    public partial class RootForm : Form
    {
        private List<String> stack = new List<String>();
        private int labelMax = 35;
        private ToolStripMenuItem parentItem { get { return (ToolStripMenuItem)contextMenuStrip1.Items[1]; } }
        private ToolStripMenuItem clearStackItem { get { return (ToolStripMenuItem)contextMenuStrip1.Items[2]; } }

        public RootForm()
        {
            InitializeComponent();
            UpdateStripMenu();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void takeClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText()) AddToStack(Clipboard.GetText());
        }

        private void AddToStack(String str) {
            stack.Add(str);
            UpdateStripMenu();
        }

        private void UpdateStripMenu()
        {
            parentItem.DropDownItems.Clear();

            if (stack.Count > 0)
            {
                foreach(String str in stack)
                {
                    string strLabel = String.Concat(str.ToCharArray().Where(l => (int)l > 31));
                    ToolStripMenuItem item = new ToolStripMenuItem(strLabel.Length > labelMax ? string.Format("{0}...", strLabel.Substring(0, labelMax)) : strLabel);
                    item.ToolTipText = DateTime.Now.ToString("HH:mm:ss");

                    item.Click += new EventHandler(delegate(object s, EventArgs e)
                    {
                        string newCbString = stack[parentItem.DropDownItems.IndexOf((ToolStripItem)s)];
                        Clipboard.SetText(newCbString);
                        stack.Remove(newCbString);
                        UpdateStripMenu();
                    });

                    parentItem.DropDownItems.Add(item);
                }

                clearStackItem.Enabled = true;
            }
            else
            {
                ToolStripMenuItem item = new ToolStripMenuItem("Stack is empty");
                item.Enabled = false;
                parentItem.DropDownItems.Add(item);
                clearStackItem.Enabled = false;
            }
            
        }

        private void clearStackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stack.Clear();
            UpdateStripMenu();
        }
    }
}
