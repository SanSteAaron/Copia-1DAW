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

namespace Ejercicio602
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> numbers = new List<int>();
        List<int> newnumbers = new List<int>();

        void readList(List<int> list)
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

        void CopyEvenNumbers (List<int> numbers,List<int> newnumbers)
        {
            foreach(int num in numbers)
            {
                if(num % 2 == 0)
                {
                    newnumbers.Add(num);
                }
            }
        }

        void MoveOddNumbers (List<int> numbers,List<int> newnumbers)
        {
            int i = 0;
            while (i < numbers.Count)
            {
                if (numbers[i] % 2 == 0)
                {
                    newnumbers.Add(numbers[i]);
                    numbers.RemoveAt(i);
                }
                else
                    i++;
            }
        }

        string ShowList (List<int> list)
        {
            string text = " ";
            for(int i = 0; i < list.Count;i++)
            {
                text += list[i] + ", ";
            }
            text += "\n";
            return text;
        }

        string ShowResult (List<int> numbers, List<int> newnumbers)
        {
            string text = "This is the result: " + "\n";
            text += "First list " + ShowList(numbers) + "\n";
            text += "Even list" + ShowList(newnumbers);
            return text;

        }

        private void BReadList_Click(object sender, EventArgs e)
        {
            readList(numbers);
        }

        private void BCopyList_Click(object sender, EventArgs e)
        {
            CopyEvenNumbers(numbers, newnumbers);
        }

        private void BMoveList_Click(object sender, EventArgs e)
        {
            MoveOddNumbers(numbers, newnumbers);
        }

        private void BShowResult_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ShowResult(numbers, newnumbers));
        }
    }
}
