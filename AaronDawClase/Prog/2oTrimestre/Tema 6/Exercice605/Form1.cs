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

namespace Exercice605
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> List1 = new List<int>();
        List<int> List2 = new List<int>();
        List<int> List3 = new List<int>();

        void IntroduceNumbers(List<int> list)
        {
            DialogResult more;
            int value;

            do
            {
                value = int.Parse(Interaction.InputBox("Enter a value: "));
                list.Add(value);

                // This messageBox show us a question and we can select Yes or No
                more = MessageBox.Show("Do you want to enter another value?", "Value", MessageBoxButtons.YesNo);
            } while (more == DialogResult.Yes);
        }

        void CopyandOrderNumbers (List<int> list, List<int> finallist)
        {
            foreach(int num in list)
            {
                finallist.Add(num);
            }
            finallist.Sort();
        }

        void MoveandOrderNumbers(List<int> list, List<int> finallist)
        {
            int i = 0;
            while (i < list.Count)
            {
                finallist.Add(list[i]);
                list.RemoveAt(i);
            }
            finallist.Sort();
        }

        string ShowList (List<int> list)
        {
            string text = " ";
            foreach(int num in list)
            {
                text += num + ", ";
            }
            text += "\n";
            return text;
        }

        string ShowResult (List<int> List1, List<int> List2, List<int> List3)
        {
            string text = "The curent status of lists is: " + "\n";
            text += "List 1: " + ShowList(List1) + "List 2: " + ShowList(List2) + "List 3: " + ShowList(List3);
            return text;
        }

        private void BIntroduceNumbers_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are going to introduce numbers in the List1.");
            IntroduceNumbers(List1);
            MessageBox.Show("You are going to introduce numbers in the List2.");
            IntroduceNumbers(List2);
        }

        private void BCopyNumbers_Click(object sender, EventArgs e)
        {
            CopyandOrderNumbers(List1, List3);
            CopyandOrderNumbers(List2, List3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MoveandOrderNumbers(List1, List3);
            MoveandOrderNumbers(List2, List3);
        }

        private void BShowResult_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ShowResult(List1, List2, List3));
        }
    }
}
