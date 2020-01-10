using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevComponents.DotNetBar;
using process;

namespace test1
{
    public partial class Form1 : DevComponents.DotNetBar.Office2007Form
    {
        public Form1()
        {

            this.EnableGlass = false;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        public int Sumdata(int a, int b)
        {
            return a + b;

        }
        private void buttonX1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("这只是一个测试");
            // DataProcess dp = new DataProcess(); dll中方法为静态方法所以无需先实例化
            int s = DataProcess.SumData(10, 20);

            MessageBox.Show(s.ToString());



            //方法一：调用非静态方法需要实例化类
            /*proc cs = new proc();
            int tep=cs.Sumd(15, 25);*/

            //方法二：静态方法调用则不需要先实例化
            int tep = proc.Sumd(15, 25);

            MessageBox.Show(tep.ToString());
            int ssu= Sumdata(25,25);
        }
    }
}
