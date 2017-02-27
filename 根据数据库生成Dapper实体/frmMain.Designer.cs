namespace 根据数据库生成实体
{
    partial class frmMain
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
            this.txt数据库 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt用户名 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt密码 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt服务器 = new System.Windows.Forms.TextBox();
            this.btn测试连接 = new System.Windows.Forms.Button();
            this.btn获取表 = new System.Windows.Forms.Button();
            this.btn生成实体 = new System.Windows.Forms.Button();
            this.btn保存实体 = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk生成Contrib属性 = new System.Windows.Forms.CheckBox();
            this.txtUsing = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNameSpace = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chk表全选 = new System.Windows.Forms.CheckBox();
            this.chkList表 = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblProcess = new System.Windows.Forms.Label();
            this.btn说明 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt数据库
            // 
            this.txt数据库.Location = new System.Drawing.Point(62, 106);
            this.txt数据库.Name = "txt数据库";
            this.txt数据库.Size = new System.Drawing.Size(285, 21);
            this.txt数据库.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "数据库";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "用户名";
            // 
            // txt用户名
            // 
            this.txt用户名.Location = new System.Drawing.Point(62, 42);
            this.txt用户名.Name = "txt用户名";
            this.txt用户名.Size = new System.Drawing.Size(285, 21);
            this.txt用户名.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "密  码";
            // 
            // txt密码
            // 
            this.txt密码.Location = new System.Drawing.Point(62, 74);
            this.txt密码.Name = "txt密码";
            this.txt密码.Size = new System.Drawing.Size(285, 21);
            this.txt密码.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "服务器";
            // 
            // txt服务器
            // 
            this.txt服务器.Location = new System.Drawing.Point(62, 10);
            this.txt服务器.Name = "txt服务器";
            this.txt服务器.Size = new System.Drawing.Size(285, 21);
            this.txt服务器.TabIndex = 1;
            // 
            // btn测试连接
            // 
            this.btn测试连接.Location = new System.Drawing.Point(17, 142);
            this.btn测试连接.Name = "btn测试连接";
            this.btn测试连接.Size = new System.Drawing.Size(68, 23);
            this.btn测试连接.TabIndex = 5;
            this.btn测试连接.Text = "测试连接";
            this.btn测试连接.UseVisualStyleBackColor = true;
            this.btn测试连接.Click += new System.EventHandler(this.btn测试连接_Click);
            // 
            // btn获取表
            // 
            this.btn获取表.Location = new System.Drawing.Point(101, 142);
            this.btn获取表.Name = "btn获取表";
            this.btn获取表.Size = new System.Drawing.Size(78, 23);
            this.btn获取表.TabIndex = 6;
            this.btn获取表.Text = "获取表信息";
            this.btn获取表.UseVisualStyleBackColor = true;
            this.btn获取表.Click += new System.EventHandler(this.btn获取表_Click);
            // 
            // btn生成实体
            // 
            this.btn生成实体.Location = new System.Drawing.Point(195, 142);
            this.btn生成实体.Name = "btn生成实体";
            this.btn生成实体.Size = new System.Drawing.Size(68, 23);
            this.btn生成实体.TabIndex = 7;
            this.btn生成实体.Text = "生成实体";
            this.btn生成实体.UseVisualStyleBackColor = true;
            this.btn生成实体.Click += new System.EventHandler(this.btn生成实体_Click);
            // 
            // btn保存实体
            // 
            this.btn保存实体.Location = new System.Drawing.Point(279, 142);
            this.btn保存实体.Name = "btn保存实体";
            this.btn保存实体.Size = new System.Drawing.Size(68, 23);
            this.btn保存实体.TabIndex = 8;
            this.btn保存实体.Text = "保存实体";
            this.btn保存实体.UseVisualStyleBackColor = true;
            this.btn保存实体.Click += new System.EventHandler(this.btn保存实体_Click);
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCode.Location = new System.Drawing.Point(353, 10);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(742, 750);
            this.txtCode.TabIndex = 20;
            this.txtCode.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn说明);
            this.groupBox1.Controls.Add(this.chk生成Contrib属性);
            this.groupBox1.Controls.Add(this.txtUsing);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNameSpace);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(9, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 195);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设置";
            // 
            // chk生成Contrib属性
            // 
            this.chk生成Contrib属性.AutoSize = true;
            this.chk生成Contrib属性.Location = new System.Drawing.Point(66, 165);
            this.chk生成Contrib属性.Name = "chk生成Contrib属性";
            this.chk生成Contrib属性.Size = new System.Drawing.Size(156, 16);
            this.chk生成Contrib属性.TabIndex = 17;
            this.chk生成Contrib属性.Text = "生成Dapper.Contrib属性";
            this.chk生成Contrib属性.UseVisualStyleBackColor = true;
            // 
            // txtUsing
            // 
            this.txtUsing.Location = new System.Drawing.Point(66, 57);
            this.txtUsing.Name = "txtUsing";
            this.txtUsing.Size = new System.Drawing.Size(262, 88);
            this.txtUsing.TabIndex = 16;
            this.txtUsing.Text = "using System;\nusing System.Collections.Generic;";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 160;
            this.label6.Text = "using";
            // 
            // txtNameSpace
            // 
            this.txtNameSpace.Location = new System.Drawing.Point(66, 18);
            this.txtNameSpace.Name = "txtNameSpace";
            this.txtNameSpace.Size = new System.Drawing.Size(262, 21);
            this.txtNameSpace.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "命名空间";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chk表全选);
            this.groupBox2.Controls.Add(this.chkList表);
            this.groupBox2.Location = new System.Drawing.Point(9, 388);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 381);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "表";
            // 
            // chk表全选
            // 
            this.chk表全选.AutoSize = true;
            this.chk表全选.Location = new System.Drawing.Point(7, 20);
            this.chk表全选.Name = "chk表全选";
            this.chk表全选.Size = new System.Drawing.Size(48, 16);
            this.chk表全选.TabIndex = 18;
            this.chk表全选.Text = "全选";
            this.chk表全选.UseVisualStyleBackColor = true;
            this.chk表全选.CheckedChanged += new System.EventHandler(this.chk表全选_CheckedChanged);
            // 
            // chkList表
            // 
            this.chkList表.FormattingEnabled = true;
            this.chkList表.Location = new System.Drawing.Point(6, 48);
            this.chkList表.Name = "chkList表";
            this.chkList表.Size = new System.Drawing.Size(322, 324);
            this.chkList表.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.lblProcess);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 771);
            this.panel1.TabIndex = 16;
            this.panel1.Visible = false;
            // 
            // lblProcess
            // 
            this.lblProcess.AutoSize = true;
            this.lblProcess.BackColor = System.Drawing.Color.Transparent;
            this.lblProcess.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblProcess.Location = new System.Drawing.Point(359, 98);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(390, 29);
            this.lblProcess.TabIndex = 0;
            this.lblProcess.Text = "正在生成代码，请稍候。。。";
            // 
            // btn说明
            // 
            this.btn说明.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn说明.Location = new System.Drawing.Point(228, 161);
            this.btn说明.Name = "btn说明";
            this.btn说明.Size = new System.Drawing.Size(40, 23);
            this.btn说明.TabIndex = 161;
            this.btn说明.Text = "说明";
            this.btn说明.UseVisualStyleBackColor = true;
            this.btn说明.Click += new System.EventHandler(this.btn说明_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1105, 771);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.btn保存实体);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn生成实体);
            this.Controls.Add(this.btn获取表);
            this.Controls.Add(this.btn测试连接);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt服务器);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt密码);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt用户名);
            this.Controls.Add(this.txt数据库);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt数据库;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt用户名;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt密码;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt服务器;
        private System.Windows.Forms.Button btn测试连接;
        private System.Windows.Forms.Button btn获取表;
        private System.Windows.Forms.Button btn生成实体;
        private System.Windows.Forms.Button btn保存实体;
        private System.Windows.Forms.RichTextBox txtCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtUsing;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNameSpace;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chk生成Contrib属性;
        private System.Windows.Forms.CheckedListBox chkList表;
        private System.Windows.Forms.CheckBox chk表全选;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.Button btn说明;
    }
}

