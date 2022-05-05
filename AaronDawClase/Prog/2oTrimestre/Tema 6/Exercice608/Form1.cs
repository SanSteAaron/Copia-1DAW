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

namespace Exercice608
{
    public partial class BReadList : Form
    {
        public BReadList()
        {
            InitializeComponent();
        }
        List<int> ListWin = new List<int>();
        List<int> ListIntroduce = new List<int>();

        void IntroduceNumberWin (List<int> ListWin)
        {
            ListWin.Clear();
            Random r = new Random();
            int i = 0;
            int num;
            while(i<6)
            {
                num = r.Next(1, 50);
                if(!ListWin.Contains(num))
                {
                    ListWin.Add(num);
                    i++;
                }
            }
        }

        void IntroduceNumber (List<int> ListIntroduce)
        {
            ListIntroduce.Clear();
            int i = 0;
            int num;
            while(i<6)
            {
                num = int.Parse(Interaction.InputBox("Introduce a number: "));
                if (!ListIntroduce.Contains(num) && num < 50 && num > 0)
                {
                    ListIntroduce.Add(num);
                    i++;
                }
                else
                    MessageBox.Show("Error.");
            }
        }

        int CorrectNumbers (List<int> ListWin, List<int> ListIntroduce)
        {
            int correct = 0;
            for (int i = 0; i < 6;i++)
            {
                if(ListWin.Contains(ListIntroduce[i]))
                {
                    correct++;
                }
            }
            return correct;
        }

        string ShowLists (List<int> list)
        {
            string text = "";
            foreach(int num in list)
            {
                text += num.ToString() + ", ";
            }
            return text;
        }

        string ShowResult (List<int> ListWin, List<int> ListIntroduce)
        { 
            string text = "PRIMITIVA" + "\n" + "Win list: " + ShowLists(ListWin) + "\n" + "Introduced list: " + ShowLists(ListIntroduce) + "\n" + "Correct numbers: " + CorrectNumbers(ListWin,ListIntroduce);
            return text;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            IntroduceNumberWin(ListWin);
            IntroduceNumber(ListIntroduce);
            MessageBox.Show(ShowResult(ListWin, ListIntroduce));
        }
    }
}
