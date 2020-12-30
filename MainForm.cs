using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildFromCallFunctionFromMainForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Func1()
        {
            MessageBox.Show("主窗体方法1被调用");
        }
        private void Func2(string msg)
        {
            MessageBox.Show(msg,"主窗体方法2被调用");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChildForm dlg=new ChildForm();
            dlg.Action = Func1;
            dlg.Action2 = Func2;
            dlg.ShowDialog();
        }
    }
}
