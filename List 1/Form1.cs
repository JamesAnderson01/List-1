using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_1
{
    public partial class Form1 : Form
    {
        void printNums(List<int> ns)
        {
            foreach (int i in ns)
            {
                richTextBox1.AppendText(i + ",");
            }
            richTextBox1.AppendText("\n================\n");
        }
        public Form1()
        {
            InitializeComponent();
            List<int> nums = new List<int>();
            nums.Add(3);
            nums.Add(5);
            nums.Add(3);
            printNums(nums);
            richTextBox1.AppendText("\n================\n");
            nums.Remove(3);
            printNums(nums);
            List<int> ints = new List<int>();
            ints.Add(1);
            ints.Add(2);
            ints.Add(3);
            ints.Add(4);
            ints.Add(5);
            ints.Add(6);
            ints.Add(7);
            ints.Add(8);
            ints.Add(9);
            ints.Add(10);
            printNums(ints);
            ints.Remove(1);
            ints.Add(1);
            printNums(ints);

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
