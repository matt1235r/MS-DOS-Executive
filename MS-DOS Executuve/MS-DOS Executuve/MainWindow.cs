using ComponentOwl.BetterListView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;

using System.Windows.Forms;

namespace MS_DOS_Executuve
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            menuStrip1.Renderer = new MyRenderer();
            menuStrip1.Dock = DockStyle.Bottom;
        }

        private class MyRenderer : ToolStripProfessionalRenderer
        {
            protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
            {
                Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
                Color c = e.Item.Selected ? Color.CadetBlue : Color.Yellow;
                using (SolidBrush brush = new SolidBrush(c))
                    e.Graphics.FillRectangle(brush, rc);
            }
        }

        public string filepath;

        private void Form1_Load(object sender, EventArgs e)
        {
            
            OpenFolder(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
        }

        public void OpenFolder(string dest)
        {
            folderView.Items.Clear();
            menuStrip2.Items.Clear();
            filepath = dest;
            DirectoryInfo d = new DirectoryInfo(filepath);

            string previousparts = "";
            foreach (string part in d.FullName.Split('\\'))
            {
                if (part != "")
                {
                    previousparts = previousparts + "" + part + "/";
                    ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(part);
                    toolStripMenuItem.Tag = previousparts;
                    toolStripMenuItem.ToolTipText = previousparts;
                    menuStrip2.Items.Add(toolStripMenuItem);

                    toolStripMenuItem = new ToolStripMenuItem("/");
                    toolStripMenuItem.Enabled = false;
                    menuStrip2.Items.Add(toolStripMenuItem);
                }


            }
            folderView.BeginUpdate();
            try
            {
                foreach (var folder in d.GetDirectories())
                {
                    ListViewItem listViewItem = new ListViewItem(folder.Name.ToUpper());
                    listViewItem.Tag = folder.FullName;
                    listViewItem.Font = new Font(folderView.Font, FontStyle.Italic);
                    listViewItem.ForeColor = Color.DarkBlue;
                    folderView.Items.Add(listViewItem);
                }

                foreach (var file in d.GetFiles())
                {
                    ListViewItem listViewItem = new ListViewItem(file.Name.ToUpper());
                    listViewItem.Tag = file.FullName;
                    folderView.Items.Add(listViewItem);
                }

                folderView.EndUpdate();
                if (folderView.SelectedItems.Count == 0 && folderView.Items.Count >  0)
                {
                    folderView.Items[0].Selected = true;
                }
            }
            catch (Exception e)
            {

                ListViewItem listViewItem = new ListViewItem("ERROR ACCESSING FOLDER - " + e.Message);
                listViewItem.Tag = "error";
                listViewItem.Font = new Font(folderView.Font, FontStyle.Italic);
                
                listViewItem.ForeColor = Color.Red;
                folderView.Items.Add(listViewItem);
                folderView.EndUpdate();
            }


            
        }

        private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            MessageBox.Show("hello");
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            OpenFolder(e.ClickedItem.Tag.ToString());
        }

        private void folderView_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem selected = folderView.SelectedItems[0];

            FileAttributes attr = File.GetAttributes(selected.Tag.ToString());

            //detect whether its a directory or file
            if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                OpenFolder(selected.Tag.ToString());
            }
               
            else
            {
                Process.Start(selected.Tag.ToString());
            }
                
        }

        private void folderView_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ListViewItem selected = folderView.SelectedItems[0];

                FileAttributes attr = File.GetAttributes(selected.Tag.ToString());
                
                //detect whether its a directory or file
                if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    OpenFolder(selected.Tag.ToString());
                }

                else
                {
                    Process.Start(selected.Tag.ToString());
                }
            }
            else if (e.KeyCode == Keys.Back)
            {
                if(new DirectoryInfo(filepath).Parent != null)
                {
                    OpenFolder(new DirectoryInfo(filepath).Parent.FullName);
                }

            }
            
        }

        private void createDirecotryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            New_Directory exit_Session = new New_Directory(this);

            exit_Session.ShowDialog();
        }

        private void endSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Exit_Session exit_Session = new Exit_Session();

            exit_Session.Location = new Point(ClientSize.Width / 2 - exit_Session.Size.Width / 2, ClientSize.Height / 2 - exit_Session.Size.Height / 2);
            //panel.Size = new Size(489, 185);

            //exit_Session.Size = new Size(593, 158);
            //Exit_Session exit_Session = new Exit_Session();
            
            //exit_Session.Dock = DockStyle.Fill;
            Controls.Add(exit_Session);

            exit_Session.BringToFront();
            
        }


        //Window Modules

        public void createFolder(string path)
        {
            Directory.CreateDirectory(path);
        }
    }
}
