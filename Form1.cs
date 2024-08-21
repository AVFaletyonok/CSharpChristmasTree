using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChristmasTree
{
    public partial class Form1 : Form
    {
        const string LogPath = "TheChristmasTreeLog.dat";
        const int FormWidth = 260, FormHeight = 260;
        const int PicTreeWidth = 180, PicTreeHeight = 220;
        const int PicTreeLocationX = 40, PicTreeLocationY = 12;
        private Scales AppScale;
        private Point oldTreePosition;
        private Point startCursorPosition;
        private Point deltaPositions;
        private Point startTreeLocation;
        private Point treeRootLocation;
        private bool isDragging;
        SnowForm snowForm;

        public Form1()
        {
            InitializeComponent();
            
            snowForm = new SnowForm();
            snowForm.Show();
        }

        private void ReadLog()
        {
            startTreeLocation = new Point(0, 0);
            AppScale = Scales.Normal;
            
            if (File.Exists(LogPath))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(LogPath, FileMode.OpenOrCreate)))
                {
                    while(reader.BaseStream.Position != reader.BaseStream.Length)
                    {
                        startTreeLocation.X = reader.ReadInt32();
                        startTreeLocation.Y = reader.ReadInt32();
                        AppScale = (Scales)reader.ReadInt32();
                    }
                }
            }
            foreach (ToolStripMenuItem item in sizeToolStripMenuItem.DropDownItems)
                if (item.Tag.ToString() == ((int)AppScale).ToString())
                    item.Checked = true;

            if (startTreeLocation.X != 0 && startTreeLocation.Y != 0)
                this.Location = startTreeLocation;

            treeRootLocation = new Point(this.Location.X + this.Width / 2, this.Location.Y + this.Height);
            ChangeSizeOfTree();
        }

        private void ChangeSizeOfTree()
        {
            this.Location = new Point(treeRootLocation.X - FormWidth * (int)AppScale / 200, treeRootLocation.Y - FormHeight * (int)AppScale / 100);
            this.ClientSize = new Size(FormWidth * (int)AppScale / 100, FormHeight * (int)AppScale / 100);
            this.picTree.Size = new Size(PicTreeWidth * (int)AppScale / 100, PicTreeHeight * (int)AppScale / 100);
            this.picTree.Location = new Point(PicTreeLocationX * (int)AppScale / 100, PicTreeLocationY * (int)AppScale / 100);
            treeRootLocation = new Point(this.Location.X + this.Width / 2, this.Location.Y + this.Height);
        }

        private void WriteLog()
        {
            startTreeLocation = this.Location;

            using (BinaryWriter writer =  new BinaryWriter(new FileStream(LogPath, FileMode.Create)))
            {
                writer.Write(startTreeLocation.X);
                writer.Write(startTreeLocation.Y);
                writer.Write((int)AppScale);
            }
            File.SetAttributes(LogPath, FileAttributes.Hidden);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            WriteLog();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            ReadLog();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            snowForm.Close();
            snowForm.Dispose();

            this.Close();
            this.Dispose();
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Happy New Year!\n\nProgram TheCristmasTree created by Faletyonock Alexander.\nDecember 2023 year.");
        }

        private void snowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (snowForm.Created && snowForm.Visible)
            {
                snowForm.Hide();
                snowToolStripMenuItem.Checked = false;
            }
            else if (snowForm.Created && !snowForm.Visible)
            {
                snowForm.Show();
                snowToolStripMenuItem.Checked = true;
            }
            else
            {
                snowForm = new SnowForm();
                snowForm.Show();
                snowToolStripMenuItem.Checked = true;
            }
        }

        private void topMostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.TopMost)
            {
                this.TopMost = false;
                topMostToolStripMenuItem.Checked = false;
                snowForm.TopMost = false;
            }
            else
            {
                this.TopMost = true;
                topMostToolStripMenuItem.Checked = true;
                snowForm.TopMost = true;
            }
        }

        #region Change Scale of the Tree
        private void littleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppScale = Scales.Little;
            foreach (ToolStripMenuItem item in sizeToolStripMenuItem.DropDownItems)
                item.Checked = false;
            littleToolStripMenuItem.Checked = true;
            ChangeSizeOfTree();
        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppScale = Scales.Small;
            foreach (ToolStripMenuItem item in sizeToolStripMenuItem.DropDownItems)
                item.Checked = false;
            smallToolStripMenuItem.Checked = true;
            ChangeSizeOfTree();
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppScale = Scales.Normal;
            foreach (ToolStripMenuItem item in sizeToolStripMenuItem.DropDownItems)
                item.Checked = false;
            normalToolStripMenuItem.Checked = true;
            ChangeSizeOfTree();
        }

        private void bigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppScale = Scales.Big;
            foreach (ToolStripMenuItem item in sizeToolStripMenuItem.DropDownItems)
                item.Checked = false;
            bigToolStripMenuItem.Checked = true;
            ChangeSizeOfTree();
        }

        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppScale = Scales.Large;
            foreach (ToolStripMenuItem item in sizeToolStripMenuItem.DropDownItems)
                item.Checked = false;
            largeToolStripMenuItem.Checked = true;
            ChangeSizeOfTree();
        }
        #endregion

        #region Mouse DragAndDrop
        private void panelSnowDrift_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                oldTreePosition = this.Location;
                startCursorPosition = Cursor.Position;
            }
        }

        private void panelSnowDrift_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && isDragging)
            {
                deltaPositions = Point.Subtract(Cursor.Position, new Size(startCursorPosition));
                this.Location = Point.Add(oldTreePosition, new Size(deltaPositions));
            }
        }

        private void panelSnowDrift_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
                treeRootLocation = new Point(this.Location.X + this.Width / 2, this.Location.Y + this.Height);
            }
        }
        #endregion
    }
}
