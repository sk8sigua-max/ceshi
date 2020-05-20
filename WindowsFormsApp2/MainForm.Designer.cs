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
            this.商品管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.厂商管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.基础信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.销售管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.员工管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.采购管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.厂商管理ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.采购管理ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.年度报表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.多图模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.横向柱状统计图模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.纵向柱状统计图模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.雷达表模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.扇形统计图模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbUserInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
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
            this.基础信息管理ToolStripMenuItem,
            this.采购管理ToolStripMenuItem,
            this.年度报表ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1364, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 豪车信息入库ToolStripMenuItem
            // 
            this.豪车信息入库ToolStripMenuItem.Name = "豪车信息入库ToolStripMenuItem";
            this.豪车信息入库ToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.豪车信息入库ToolStripMenuItem.Text = "豪车信息入库";
            this.豪车信息入库ToolStripMenuItem.Click += new System.EventHandler(this.豪车信息入库ToolStripMenuItem_Click);
            // 
            // 库存信息查询ToolStripMenuItem
            // 
            this.库存信息查询ToolStripMenuItem.Name = "库存信息查询ToolStripMenuItem";
            this.库存信息查询ToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.库存信息查询ToolStripMenuItem.Text = "库存信息浏览";
            this.库存信息查询ToolStripMenuItem.Click += new System.EventHandler(this.库存信息查询ToolStripMenuItem_Click);
            // 
            // 供商信息维护ToolStripMenuItem
            // 
            this.供商信息维护ToolStripMenuItem.Name = "供商信息维护ToolStripMenuItem";
            this.供商信息维护ToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.供商信息维护ToolStripMenuItem.Text = "豪车销售出库";
            this.供商信息维护ToolStripMenuItem.Click += new System.EventHandler(this.供商信息维护ToolStripMenuItem_Click);
            // 
            // 其他信息维护ToolStripMenuItem
            // 
            this.其他信息维护ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.商品管理ToolStripMenuItem,
            this.厂商管理ToolStripMenuItem});
            this.其他信息维护ToolStripMenuItem.Name = "其他信息维护ToolStripMenuItem";
            this.其他信息维护ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.其他信息维护ToolStripMenuItem.Text = "产品管理";
            this.其他信息维护ToolStripMenuItem.Click += new System.EventHandler(this.其他信息维护ToolStripMenuItem_Click);
            // 
            // 商品管理ToolStripMenuItem
            // 
            this.商品管理ToolStripMenuItem.Name = "商品管理ToolStripMenuItem";
            this.商品管理ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.商品管理ToolStripMenuItem.Text = "商品管理";
            this.商品管理ToolStripMenuItem.Click += new System.EventHandler(this.商品管理ToolStripMenuItem_Click);
            // 
            // 厂商管理ToolStripMenuItem
            // 
            this.厂商管理ToolStripMenuItem.Name = "厂商管理ToolStripMenuItem";
            this.厂商管理ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.厂商管理ToolStripMenuItem.Text = "厂商管理";
            this.厂商管理ToolStripMenuItem.Click += new System.EventHandler(this.厂商管理ToolStripMenuItem_Click);
            // 
            // 基础信息管理ToolStripMenuItem
            // 
            this.基础信息管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.销售管理ToolStripMenuItem,
            this.员工管理ToolStripMenuItem});
            this.基础信息管理ToolStripMenuItem.Name = "基础信息管理ToolStripMenuItem";
            this.基础信息管理ToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.基础信息管理ToolStripMenuItem.Text = "基础信息管理";
            // 
            // 销售管理ToolStripMenuItem
            // 
            this.销售管理ToolStripMenuItem.Name = "销售管理ToolStripMenuItem";
            this.销售管理ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.销售管理ToolStripMenuItem.Text = "销售管理";
            this.销售管理ToolStripMenuItem.Click += new System.EventHandler(this.销售管理ToolStripMenuItem_Click);
            // 
            // 员工管理ToolStripMenuItem
            // 
            this.员工管理ToolStripMenuItem.Name = "员工管理ToolStripMenuItem";
            this.员工管理ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.员工管理ToolStripMenuItem.Text = "员工管理";
            this.员工管理ToolStripMenuItem.Click += new System.EventHandler(this.员工管理ToolStripMenuItem_Click_1);
            // 
            // 采购管理ToolStripMenuItem
            // 
            this.采购管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.厂商管理ToolStripMenuItem1,
            this.采购管理ToolStripMenuItem1});
            this.采购管理ToolStripMenuItem.Name = "采购管理ToolStripMenuItem";
            this.采购管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.采购管理ToolStripMenuItem.Text = "采购管理";
            // 
            // 厂商管理ToolStripMenuItem1
            // 
            this.厂商管理ToolStripMenuItem1.Name = "厂商管理ToolStripMenuItem1";
            this.厂商管理ToolStripMenuItem1.Size = new System.Drawing.Size(144, 26);
            this.厂商管理ToolStripMenuItem1.Text = "厂商管理";
            this.厂商管理ToolStripMenuItem1.Click += new System.EventHandler(this.厂商管理ToolStripMenuItem1_Click);
            // 
            // 采购管理ToolStripMenuItem1
            // 
            this.采购管理ToolStripMenuItem1.Name = "采购管理ToolStripMenuItem1";
            this.采购管理ToolStripMenuItem1.Size = new System.Drawing.Size(144, 26);
            this.采购管理ToolStripMenuItem1.Text = "采购管理";
            this.采购管理ToolStripMenuItem1.Click += new System.EventHandler(this.采购管理ToolStripMenuItem1_Click);
            // 
            // 年度报表ToolStripMenuItem
            // 
            this.年度报表ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.多图模式ToolStripMenuItem,
            this.横向柱状统计图模式ToolStripMenuItem,
            this.纵向柱状统计图模式ToolStripMenuItem,
            this.雷达表模式ToolStripMenuItem,
            this.扇形统计图模式ToolStripMenuItem});
            this.年度报表ToolStripMenuItem.Name = "年度报表ToolStripMenuItem";
            this.年度报表ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.年度报表ToolStripMenuItem.Text = "年度报表";
            this.年度报表ToolStripMenuItem.Click += new System.EventHandler(this.年度报表ToolStripMenuItem_Click);
            // 
            // 多图模式ToolStripMenuItem
            // 
            this.多图模式ToolStripMenuItem.Name = "多图模式ToolStripMenuItem";
            this.多图模式ToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.多图模式ToolStripMenuItem.Text = "多图模式";
            this.多图模式ToolStripMenuItem.Click += new System.EventHandler(this.多图模式ToolStripMenuItem_Click);
            // 
            // 横向柱状统计图模式ToolStripMenuItem
            // 
            this.横向柱状统计图模式ToolStripMenuItem.Name = "横向柱状统计图模式ToolStripMenuItem";
            this.横向柱状统计图模式ToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.横向柱状统计图模式ToolStripMenuItem.Text = "横向柱状统计图模式";
            this.横向柱状统计图模式ToolStripMenuItem.Click += new System.EventHandler(this.横向柱状统计图模式ToolStripMenuItem_Click);
            // 
            // 纵向柱状统计图模式ToolStripMenuItem
            // 
            this.纵向柱状统计图模式ToolStripMenuItem.Name = "纵向柱状统计图模式ToolStripMenuItem";
            this.纵向柱状统计图模式ToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.纵向柱状统计图模式ToolStripMenuItem.Text = "纵向柱状统计图模式";
            this.纵向柱状统计图模式ToolStripMenuItem.Click += new System.EventHandler(this.纵向柱状统计图模式ToolStripMenuItem_Click);
            // 
            // 雷达表模式ToolStripMenuItem
            // 
            this.雷达表模式ToolStripMenuItem.Name = "雷达表模式ToolStripMenuItem";
            this.雷达表模式ToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.雷达表模式ToolStripMenuItem.Text = "雷达表模式";
            this.雷达表模式ToolStripMenuItem.Click += new System.EventHandler(this.雷达表模式ToolStripMenuItem_Click);
            // 
            // 扇形统计图模式ToolStripMenuItem
            // 
            this.扇形统计图模式ToolStripMenuItem.Name = "扇形统计图模式ToolStripMenuItem";
            this.扇形统计图模式ToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.扇形统计图模式ToolStripMenuItem.Text = "折线统计图模式";
            this.扇形统计图模式ToolStripMenuItem.Click += new System.EventHandler(this.扇形统计图模式ToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // lbUserInfo
            // 
            this.lbUserInfo.AutoSize = true;
            this.lbUserInfo.BackColor = System.Drawing.Color.White;
            this.lbUserInfo.Location = new System.Drawing.Point(895, 7);
            this.lbUserInfo.Name = "lbUserInfo";
            this.lbUserInfo.Size = new System.Drawing.Size(55, 15);
            this.lbUserInfo.TabIndex = 4;
            this.lbUserInfo.Text = "label1";
            this.lbUserInfo.Click += new System.EventHandler(this.lbUserInfo_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1364, 710);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // skinEngine1
            // 
            this.skinEngine1.@__DrawButtonFocusRectangle = true;
            this.skinEngine1.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1364, 738);
            this.Controls.Add(this.lbUserInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "豪车管理销售系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
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
        private System.Windows.Forms.ToolStripMenuItem 基础信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 销售管理ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 员工管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 商品管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 厂商管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 采购管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 厂商管理ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 采购管理ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 年度报表ToolStripMenuItem;
        private System.Windows.Forms.Label lbUserInfo;
        private System.Windows.Forms.ToolStripMenuItem 多图模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 横向柱状统计图模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 纵向柱状统计图模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 雷达表模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 扇形统计图模式ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}

