namespace ChristmasTree
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelSnowDrift = new System.Windows.Forms.Panel();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.littleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.snowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topMostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picTree = new System.Windows.Forms.PictureBox();
            this.panelSnowDrift.SuspendLayout();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTree)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSnowDrift
            // 
            this.panelSnowDrift.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.panelSnowDrift.BackColor = System.Drawing.Color.Transparent;
            this.panelSnowDrift.BackgroundImage = global::ChristmasTree.Properties.Resources.SnowDrift;
            this.panelSnowDrift.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelSnowDrift.ContextMenuStrip = this.contextMenu;
            this.panelSnowDrift.Controls.Add(this.picTree);
            this.panelSnowDrift.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSnowDrift.Location = new System.Drawing.Point(0, 0);
            this.panelSnowDrift.Margin = new System.Windows.Forms.Padding(0);
            this.panelSnowDrift.MaximumSize = new System.Drawing.Size(390, 390);
            this.panelSnowDrift.MinimumSize = new System.Drawing.Size(130, 130);
            this.panelSnowDrift.Name = "panelSnowDrift";
            this.panelSnowDrift.Padding = new System.Windows.Forms.Padding(0, 200, 0, 0);
            this.panelSnowDrift.Size = new System.Drawing.Size(260, 260);
            this.panelSnowDrift.TabIndex = 2;
            this.panelSnowDrift.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSnowDrift_MouseDown);
            this.panelSnowDrift.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelSnowDrift_MouseMove);
            this.panelSnowDrift.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelSnowDrift_MouseUp);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sizeToolStripMenuItem,
            this.snowToolStripMenuItem,
            this.topMostToolStripMenuItem,
            this.aboutProgramToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(150, 114);
            // 
            // sizeToolStripMenuItem
            // 
            this.sizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.littleToolStripMenuItem,
            this.smallToolStripMenuItem,
            this.normalToolStripMenuItem,
            this.bigToolStripMenuItem,
            this.largeToolStripMenuItem});
            this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            this.sizeToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.sizeToolStripMenuItem.Text = "Размер";
            // 
            // littleToolStripMenuItem
            // 
            this.littleToolStripMenuItem.Name = "littleToolStripMenuItem";
            this.littleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.littleToolStripMenuItem.Tag = "50";
            this.littleToolStripMenuItem.Text = "Крошечная";
            this.littleToolStripMenuItem.Click += new System.EventHandler(this.littleToolStripMenuItem_Click);
            // 
            // smallToolStripMenuItem
            // 
            this.smallToolStripMenuItem.Name = "smallToolStripMenuItem";
            this.smallToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.smallToolStripMenuItem.Tag = "75";
            this.smallToolStripMenuItem.Text = "Маленькая";
            this.smallToolStripMenuItem.Click += new System.EventHandler(this.smallToolStripMenuItem_Click);
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.normalToolStripMenuItem.Tag = "100";
            this.normalToolStripMenuItem.Text = "Нормальная";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // bigToolStripMenuItem
            // 
            this.bigToolStripMenuItem.Name = "bigToolStripMenuItem";
            this.bigToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bigToolStripMenuItem.Tag = "125";
            this.bigToolStripMenuItem.Text = "Большая";
            this.bigToolStripMenuItem.Click += new System.EventHandler(this.bigToolStripMenuItem_Click);
            // 
            // largeToolStripMenuItem
            // 
            this.largeToolStripMenuItem.Name = "largeToolStripMenuItem";
            this.largeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.largeToolStripMenuItem.Tag = "150";
            this.largeToolStripMenuItem.Text = "Огромная";
            this.largeToolStripMenuItem.Click += new System.EventHandler(this.largeToolStripMenuItem_Click);
            // 
            // snowToolStripMenuItem
            // 
            this.snowToolStripMenuItem.Checked = true;
            this.snowToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.snowToolStripMenuItem.Name = "snowToolStripMenuItem";
            this.snowToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.snowToolStripMenuItem.Text = "Снег";
            this.snowToolStripMenuItem.Click += new System.EventHandler(this.snowToolStripMenuItem_Click);
            // 
            // topMostToolStripMenuItem
            // 
            this.topMostToolStripMenuItem.Checked = true;
            this.topMostToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.topMostToolStripMenuItem.Name = "topMostToolStripMenuItem";
            this.topMostToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.topMostToolStripMenuItem.Text = "Поверх окон";
            this.topMostToolStripMenuItem.Click += new System.EventHandler(this.topMostToolStripMenuItem_Click);
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aboutProgramToolStripMenuItem.Text = "О программе";
            this.aboutProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutProgramToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.closeToolStripMenuItem.Text = "Закрыть";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // picTree
            // 
            this.picTree.BackColor = System.Drawing.Color.Transparent;
            this.picTree.Image = global::ChristmasTree.Properties.Resources.Tree;
            this.picTree.Location = new System.Drawing.Point(40, 12);
            this.picTree.Margin = new System.Windows.Forms.Padding(0);
            this.picTree.MaximumSize = new System.Drawing.Size(270, 330);
            this.picTree.MinimumSize = new System.Drawing.Size(90, 110);
            this.picTree.Name = "picTree";
            this.picTree.Size = new System.Drawing.Size(180, 220);
            this.picTree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTree.TabIndex = 1;
            this.picTree.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(260, 260);
            this.Controls.Add(this.panelSnowDrift);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(390, 390);
            this.MinimumSize = new System.Drawing.Size(130, 130);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChristmasTree";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panelSnowDrift.ResumeLayout(false);
            this.contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTree)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picTree;
        private System.Windows.Forms.Panel panelSnowDrift;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem sizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem littleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem largeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem snowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topMostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

