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

namespace Exercice607
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> List1 = new List<string>();

        void ReadListAlpha (List<string>list)
        {
            DialogResult res;
            do
            {
                string word = (Interaction.InputBox("Write a word: "));
                InsertWordSort(word, list);
                res = MessageBox.Show("Do you want to enter another word?", "Word", MessageBoxButtons.YesNo);
            }
            while (res == DialogResult.Yes);
        }

        void InsertWordSort(string word, List<string> list)
        {
            int i = 0;
            bool enc = false;
            while(i < list.Count && !enc)
            {
                if(string.Compare(word,list[i]) > 0)
                {
                    i++;
                }
                else
                {
                    enc = true;
                }
            }
            list.Insert(i, word);
        }

        private void BReadList_Click(object sender, EventArgs e)
        {

        }
    }
}
