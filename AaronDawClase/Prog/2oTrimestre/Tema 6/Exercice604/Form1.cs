using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Exercice604
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> Base = new List<int>();
        List<int> Exponent = new List<int>();
        void readList(List<int> list)
        {
            int value;
            list.Clear();
            for(int i = 0; i < 10;i++)
            {
                value = int.Parse(Interaction.InputBox("Enter a value: "));
                list.Add(value);
            }
        }

        int ExponentBase (List<int> Base, List<int> Exponent, int i)
        {
            int res = 0;
            res = Base[i];
            for(int j = 0;j < Exponent[i] - 1;j++)
            {
                res = Base[i] * res;
            }
            return res;
        }

        string ShowResult (List<int> Base,List<int> Exponent)
        {
            string text = "The result of all operations is:" + "\n";
            for (int i = 0; i < 10; i++)
            {
                text += ExponentBase(Base, Exponent, i) + ", ";
            }
            return text;
        }
 
        private void BIntroduceBase_Click(object sender, EventArgs e)
        {
            readList(Base);
        }

        private void BIntroduceExponent_Click(object sender, EventArgs e)
        {
            readList(Exponent);
        }

        private void BShowResult_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ShowResult(Base, Exponent));
        }
    }
}
