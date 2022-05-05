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

namespace Exercice601
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> exercice1 = new List<int>();

        void FAddNumber (List<int> list , int value)//This function add numbers to the list.
        {
            list.Add(value);
        }

        void FInsertNumber (List<int>list, int value, int position)//This function insert numbers to the list in a specific position.
        {
            list.Insert(position, value);
        }

        string FShowList(List<int>list)//This function show the list in a MessageBox.
        {
            string text = "The elements in the list are: " + "\n";
            foreach(int value in list)
            {
                text += value.ToString() + ", ";
            }
            return text;
        }

        int FShowPosition (List<int> list, int value)//This function show the position from the entered value.
        {
            int position = list.IndexOf(value);
            return position;
        }

        bool FRemoveValue (List<int>list, int value)//This function remove the entered value.
        {
            bool comprobation = list.Remove(value);
            return comprobation;
        }

        void FRemovePosition (List<int>list, int position)//This function remove the entered position.
        {
            list.RemoveAt(position);
        }

        void FSortList (List<int>list)//This function sort the list.
        {
            list.Sort();
        }

        void FRemoveAllElements (List<int>list)//This function remove all elements from the list.
        {
            list.Clear();
        }

        private void BAddNumbers_Click(object sender, EventArgs e)
        {
            int value = int.Parse(Interaction.InputBox("Enter a number in the list: "));
            FAddNumber(exercice1,value);
        }

        private void BInsertNumbers_Click(object sender, EventArgs e)
        {
            int value = int.Parse(Interaction.InputBox("Enter a number in the list: "));
            int position = int.Parse(Interaction.InputBox("Enter the position of the list: "));
            int findout = exercice1.Count;
            if (position <= findout && position >= 0)
                FInsertNumber(exercice1, value, position);
            else
                MessageBox.Show("Error, you can't enter a number in this position.");
        }

        private void BShowList_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FShowList(exercice1));
        }

        private void BShowPosition_Click(object sender, EventArgs e)
        {
            int value = int.Parse(Interaction.InputBox("Enter the list number: "));
            if (FShowPosition(exercice1, value) == -1)
            {
                MessageBox.Show("The position doesn't exists.");
            }
            else
            {
                MessageBox.Show(FShowPosition(exercice1, value).ToString());
            }
        }

        private void BRemoveValue_Click(object sender, EventArgs e)
        {
            int value = int.Parse(Interaction.InputBox("Enter the number you want to remove: "));
            if (FRemoveValue(exercice1, value))
            {
                MessageBox.Show("The number has been deleted."); 
            }
            else
            {
                MessageBox.Show("The number doesn't exists.");
            }
        }

        private void BRemovePosition_Click(object sender, EventArgs e)
        {
            int position = int.Parse(Interaction.InputBox("Enter the position you want to remove: "));
            if (exercice1.Count >= position && position >= 0)
                FRemovePosition(exercice1, position);
            else
                MessageBox.Show("Error, this position doesn't exists.");
        }

        private void BSortList_Click(object sender, EventArgs e)
        {
            FSortList(exercice1);
        }

        private void BRemoveAllElements_Click(object sender, EventArgs e)
        {
            FRemoveAllElements(exercice1);
        }
    }
}
