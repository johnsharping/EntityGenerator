using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dapper;
using System.IO;


namespace 根据数据库生成实体
{
    public partial class frmMain : Form
    {
        SqlConnection conn = new SqlConnection();

        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.leaf;
            this.Text = "Sql Server数据库生成实体     By JohnSharping     " + Properties.Resources.Version;

            txt服务器.Text = ".";
            txt数据库.Text = "test";
            txt用户名.Text = "sa";
            txt密码.Text = "password";
            txtNameSpace.Text = "Entity";
            chk生成Contrib属性.Checked = true;
        }
        private void btn测试连接_Click(object sender, EventArgs e)
        {

            //Data Source=(local);Initial Catalog=PM;Persist Security Info=True;User ID=sa;Password=office2016
            SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                conn.Open();
                MessageBox.Show("连接成功!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }

        private string ConnectionString
        {
            get
            {
                string connStr = "Data Source=" + txt服务器.Text.Trim() + ";";
                connStr += "Initial Catalog=" + txt数据库.Text + ";";
                connStr += "User ID=" + txt用户名.Text.Trim() + ";";
                connStr += "Password =" + txt密码.Text.Trim() + "";
                return connStr;
            }
        }

        private void btn获取表_Click(object sender, EventArgs e)
        {
            chkList表.Items.Clear();
            try
            {
                conn.ConnectionString = ConnectionString;
                IEnumerable<dynamic> tabs = conn.Query("SELECT Name FROM SysObjects Where XType='U' ORDER BY Name");
                foreach (var item in tabs)
                {
                    chkList表.Items.Add(item.Name);
                }
                chk表全选.Checked = true;
                for (int i = 0; i < chkList表.Items.Count; i++)
                {
                    chkList表.SetItemChecked(i, true);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chk表全选_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < chkList表.Items.Count; i++)
            {
                chkList表.SetItemChecked(i, true);
            }
        }

        private void btn生成实体_Click(object sender, EventArgs e)
        {
            if (txtNameSpace.Text.Trim() == "")
            {
                MessageBox.Show("命名空间不允许为空!");
                return;
            }

            if (chkList表.SelectedItem != null)
            {
                txtCode.Text = GenerateClassCode(chkList表.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("请选中一个表,注意:选中,而不是勾选!");
            }
        }
        private void btn保存实体_Click(object sender, EventArgs e)
        {
            if (txtNameSpace.Text.Trim() == "")
            {
                MessageBox.Show("命名空间不允许为空!");
                return;
            }

            string foldPath = "";
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择类文件保存路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foldPath = dialog.SelectedPath;
            }
            if (foldPath != "")
            {
                panel1.Visible = true;
                panel1.Refresh();
                foreach (var item in chkList表.CheckedItems)
                {
                    File.WriteAllText(foldPath + "\\" + item + ".cs", GenerateClassCode(item.ToString()), Encoding.UTF8);
                }
                panel1.Visible = false;
                if (MessageBox.Show("生成完毕!\n" + foldPath, "是否打开所在文件夹?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("Explorer.exe", foldPath);
                }
            }
        }

        public IEnumerable<dynamic> QueryData(string sql)
        {
            var xx = conn.Query(sql);
            return xx;
        }

        public string 生成类(string tabName)
        {
            StringBuilder s = new StringBuilder();
            s.Append("//代码生成工具 By JohnSharping\r\n//" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\r\n");
            s.Append("namespace ").Append(txtNameSpace.Text.Trim()).Append("\r\n");//命名空间
            s.Append("{\r\n");
            s.Append("\t");
            s.Append(txtUsing.Text.Trim().Replace("\n", "\r\n\t"));//生成using
            if (chk生成Contrib属性.Checked)
            {
                s.Append("\r\n\tusing Dapper.Contrib.Extensions;");
            }
            s.Append("\r\n\r\n");
            s.Append("\tpublic class " + tabName + "\r\n");//类名
            s.Append("\t{\r\n");

            return s.ToString();
        }
        public string 生成属性(string tabName)
        {
            StringBuilder s = new StringBuilder();
            string sql = @" SELECT  (case when a.colorder=1 then d.name else null end) 表名,  
                        a.colorder 字段序号,a.name 字段名,
                        (case when COLUMNPROPERTY( a.id,a.name,'IsIdentity')=1 then '√'else '' end) 标识, 
                        (case when (SELECT count(*) FROM sysobjects  
                        WHERE (name in (SELECT name FROM sysindexes  
                        WHERE (id = a.id) AND (indid in  
                        (SELECT indid FROM sysindexkeys  
                        WHERE (id = a.id) AND (colid in  
                        (SELECT colid FROM syscolumns WHERE (id = a.id) AND (name = a.name)))))))  
                        AND (xtype = 'PK'))>0 then '√' else '' end) 主键,b.name 类型,a.length 占用字节数,  
                        COLUMNPROPERTY(a.id,a.name,'PRECISION') as 长度,  
                        isnull(COLUMNPROPERTY(a.id,a.name,'Scale'),0) as 小数位数,(case when a.isnullable=1 then '√'else '' end) 允许空,  
                        isnull(e.text,'') 默认值,isnull(g.[value], ' ') AS [说明]
                        FROM  syscolumns a 
                        left join systypes b on a.xtype=b.xusertype  
                        inner join sysobjects d on a.id=d.id and d.xtype='U' and d.name<>'dtproperties' 
                        left join syscomments e on a.cdefault=e.id  
                        left join sys.extended_properties g on a.id=g.major_id AND a.colid=g.minor_id
                        left join sys.extended_properties f on d.id=f.class and f.minor_id=0
                        where b.name is not null
                        and d.name='" + tabName + @"' --如果只查询指定表,加上此条件
                        order by a.id,a.colorder  
                         ";

            var Cols = QueryData(sql);

            foreach (var col in Cols)
            {
                if (chk生成Contrib属性.Checked)//如果选中则处理Contrib属性
                {
                    if (col.主键 == "√")//处理主键
                    {
                        if (col.标识 == "√")//处理自增列
                        {
                            s.Append("\t\t[Key]\r\n");
                        }
                        else
                        {
                            s.Append("\t\t[ExplicitKey]\r\n");
                        }
                    }
                }
                string attrType = Sql2Csharp.SqlTypeString2CsharpTypeString(col.类型);
                s.Append("\t\tpublic " + attrType);
                if (col.允许空 == "√" && attrType != "String" && attrType != "Object")//处理可空
                {
                    s.Append("?");
                }
                s.Append(" " + col.字段名);
                s.Append(" { get; set; }\r\n");
            }

            return s.ToString();
        }

        public string GenerateClassCode(string tabName)
        {
            StringBuilder s = new StringBuilder();
            s.Append(生成类(tabName));
            s.Append(生成属性(tabName));
            s.Append("\t}\r\n}\r\n");
            return s.ToString();
        }

        private void btn说明_Click(object sender, EventArgs e)
        {
            var form = new frmAbout();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }
    }
}
