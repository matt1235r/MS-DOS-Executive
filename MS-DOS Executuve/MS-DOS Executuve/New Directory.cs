using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS_DOS_Executuve
{
    public partial class New_Directory : Form
    {
        MainWindow parent;
        public New_Directory(MainWindow parentArg)
        {
            parent = parentArg;
            
            InitializeComponent();
            this.ActiveControl = folderName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parent.createFolder(parent.filepath + "//" + folderName.Text);
            parent.OpenFolder(parent.filepath);
            this.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (panel1.BorderStyle == BorderStyle.FixedSingle)
            {
                int thickness = 3;//it's up to you
                int halfThickness = thickness / 2;
                using (Pen p = new Pen(Color.Blue, thickness))
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                              halfThickness,
                                                              panel1.ClientSize.Width - thickness,
                                                              panel1.ClientSize.Height - thickness));
                }
            }
        }


        private void New_Directory_Paint(object sender, PaintEventArgs e)
        {
            int thickness = 1;//it's up to you
            int halfThickness = thickness / 2;
            using (Pen p = new Pen(Color.Black, thickness))
            {
                e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                          halfThickness,
                                                          this.ClientSize.Width - thickness,
                                                          this.ClientSize.Height - thickness));
            }
        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            cancelButton.BackgroundImage = Properties.Resources.Cancel;
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            cancelButton.BackgroundImage = Properties.Resources.Cancel_Focus;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
