namespace WindowsFormsApp2
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.豪车信息入库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.库存信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.供商信息维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.其他信息维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.基础信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.销售管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbUserInfo = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.员工管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.豪车信息入库ToolStripMenuItem,
            this.库存信息查询ToolStripMenuItem,
            this.供商信息维护ToolStripMenuItem,
            this.其他信息维护ToolStripMenuItem,
            this.基础信息管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(978, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 豪车信息入库ToolStripMenuItem
            // 
            this.豪车信息入库ToolStripMenuItem.Name = "豪车信息入库ToolStripMenuItem";
            this.豪车信息入库ToolStripMenuItem.Size = new System.Drawing.Size(130, 28);
            this.豪车信息入库ToolStripMenuItem.Text = "豪车信息入库";
            this.豪车信息入库ToolStripMenuItem.Click += new System.EventHandler(this.豪车信息入库ToolStripMenuItem_Click);
            // 
            // 库存信息查询ToolStripMenuItem
            // 
            this.库存信息查询ToolStripMenuItem.Name = "库存信息查询ToolStripMenuItem";
            this.库存信息查询ToolStripMenuItem.Size = new System.Drawing.Size(130, 28);
            this.库存信息查询ToolStripMenuItem.Text = "库存信息查询";
            this.库存信息查询ToolStripMenuItem.Click += new System.EventHandler(this.库存信息查询ToolStripMenuItem_Click);
            // 
            // 供商信息维护ToolStripMenuItem
            // 
            this.供商信息维护ToolStripMenuItem.Name = "供商信息维护ToolStripMenuItem";
            this.供商信息维护ToolStripMenuItem.Size = new System.Drawing.Size(130, 28);
            this.供商信息维护ToolStripMenuItem.Text = "豪车销售出库";
            this.供商信息维护ToolStripMenuItem.Click += new System.EventHandler(this.供商信息维护ToolStripMenuItem_Click);
            // 
            // 其他信息维护ToolStripMenuItem
            // 
            this.其他信息维护ToolStripMenuItem.Name = "其他信息维护ToolStripMenuItem";
            this.其他信息维护ToolStripMenuItem.Size = new System.Drawing.Size(130, 28);
            this.其他信息维护ToolStripMenuItem.Text = "其他信息维护";
            // 
            // 基础信息管理ToolStripMenuItem
            // 
            this.基础信息管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.销售管理ToolStripMenuItem,
            this.员工管理ToolStripMenuItem});
            this.基础信息管理ToolStripMenuItem.Name = "基础信息管理ToolStripMenuItem";
            this.基础信息管理ToolStripMenuItem.Size = new System.Drawing.Size(130, 28);
            this.基础信息管理ToolStripMenuItem.Text = "基础信息管理";
            // 
            // 销售管理ToolStripMenuItem
            // 
            this.销售管理ToolStripMenuItem.Name = "销售管理ToolStripMenuItem";
            this.销售管理ToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.销售管理ToolStripMenuItem.Text = "销售管理";
            this.销售管理ToolStripMenuItem.Click += new System.EventHandler(this.销售管理ToolStripMenuItem_Click);
            // 
            // lbUserInfo
            // 
            this.lbUserInfo.AutoSize = true;
            this.lbUserInfo.BackColor = System.Drawing.Color.Transparent;
            this.lbUserInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbUserInfo.Location = new System.Drawing.Point(735, 9);
            this.lbUserInfo.Name = "lbUserInfo";
            this.lbUserInfo.Size = new System.Drawing.Size(62, 18);
            this.lbUserInfo.TabIndex = 2;
            this.lbUserInfo.Text = "label1";
            this.lbUserInfo.Click += new System.EventHandler(this.lbUserInfo_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // 员工管理ToolStripMenuItem
            // 
            this.员工管理ToolStripMenuItem.Name = "员工管理ToolStripMenuItem";
            this.员工管理ToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.员工管理ToolStripMenuItem.Text = "员工管理";
            this.员工管理ToolStripMenuItem.Click += new System.EventHandler(this.员工管理ToolStripMenuItem_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.lbUserInfo);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "豪车管理销售系统";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 豪车信息入库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 库存信息查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 供商信息维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 其他信息维护ToolStripMenuItem;
        private System.Windows.Forms.Label lbUserInfo;
        private System.Windows.Forms.ToolStripMenuItem 基础信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 销售管理ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 员工管理ToolStripMenuItem;
    }
}

