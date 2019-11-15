using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertionCalculatorArabicAndRomanNumbers
{
    public partial class Form2 : MaterialForm
    {
        public bool NeedToCleanOutput = false;
        List<string> userInputCollection = new List<string>();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void ButtonI_Click(object sender, EventArgs e)
        {
            userInputCollection.Add(buttonI.Text);
            UserInputTB.Text = String.Concat(userInputCollection);
        }

        private void ButtonV_Click(object sender, EventArgs e)
        {
            userInputCollection.Add(buttonV.Text);
            UserInputTB.Text = String.Concat(userInputCollection);
        }

        private void ButtonX_Click(object sender, EventArgs e)
        {
            userInputCollection.Add(buttonX.Text);
            UserInputTB.Text = String.Concat(userInputCollection);
        }

        private void ButtonL_Click(object sender, EventArgs e)
        {
            userInputCollection.Add(buttonL.Text);
            UserInputTB.Text = String.Concat(userInputCollection);
        }

        private void ButtonC_Click(object sender, EventArgs e)
        {
            userInputCollection.Add(buttonC.Text);
            UserInputTB.Text = String.Concat(userInputCollection);
        }

        private void ButtonD_Click(object sender, EventArgs e)
        {
            userInputCollection.Add(buttonD.Text);
            UserInputTB.Text = String.Concat(userInputCollection);
        }

        private void ButtonM_Click(object sender, EventArgs e)
        {
            userInputCollection.Add(buttonM.Text);
            UserInputTB.Text = String.Concat(userInputCollection);
        }

        private void ButtonV̅_Click(object sender, EventArgs e)
        {
            userInputCollection.Add(buttonV̅.Text);
            UserInputTB.Text = String.Concat(userInputCollection);
        }

        private void ButtonX̅_Click(object sender, EventArgs e)
        {
            userInputCollection.Add(buttonX̅.Text);
            UserInputTB.Text = String.Concat(userInputCollection);
        }

        private void ButtonL̅_Click(object sender, EventArgs e)
        {
            userInputCollection.Add(buttonL̅.Text);
            UserInputTB.Text = String.Concat(userInputCollection);
        }

        private void ButtonC̅_Click(object sender, EventArgs e)
        {
            userInputCollection.Add(buttonC̅.Text);
            UserInputTB.Text = String.Concat(userInputCollection);
        }

        private void ButtonD̅_Click(object sender, EventArgs e)
        {
            userInputCollection.Add(buttonD̅.Text);
            UserInputTB.Text = String.Concat(userInputCollection);
        }

        private void ButtonM̅_Click(object sender, EventArgs e)
        {
            userInputCollection.Add(buttonM̅.Text);
            UserInputTB.Text = String.Concat(userInputCollection);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            UserInputTB.Clear();
            UserOutputTB.Clear();
            userInputCollection.Clear();
        }

        private void BackspaceButton_Click(object sender, EventArgs e)
        {
            NeedToCleanOutput = false;
            bool isRemoved = userInputCollection.Remove(userInputCollection.LastOrDefault());
            if (isRemoved)
            {
                UserInputTB.Text = String.Concat(userInputCollection);
            }
        }

        public static Dictionary<string, int> DictionaryOfNumbers()
        {
            Dictionary<string, int> dictionaryOfNumbers = new Dictionary<string, int>
            {
                { "I", 1 },
                { "V", 5 },
                { "X", 10 },
                { "L", 50 },
                { "C", 100 },
                { "D", 500 },
                { "M", 1000 },
                { "V̅", 5000 },
                { "X̅", 10000 },
                { "L̅", 50000 },
                { "C̅", 100000 },
                { "D̅", 500000 },
                { "M̅", 1000000 }
            };

            return dictionaryOfNumbers;
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            int convertedResult = ConvertionCalculator(userInputCollection, DictionaryOfNumbers());
            UserOutputTB.Text = convertedResult.ToString();
            NeedToCleanOutput = true;
        }

        public static int ConvertionCalculator(List<string> userInputCollection, Dictionary<string, int> dictionaryOfNumbers)
        {
            int answer = dictionaryOfNumbers[userInputCollection[0]];

            for (int index = 1; index < userInputCollection.Count; ++index)
            {
                if (dictionaryOfNumbers[userInputCollection[index]] > dictionaryOfNumbers[userInputCollection[index - 1]])
                {
                    answer += dictionaryOfNumbers[userInputCollection[index]] - dictionaryOfNumbers[userInputCollection[index - 1]] * 2;
                }

                else
                {
                    answer += dictionaryOfNumbers[userInputCollection[index]];
                }
            }

            return answer;
        }

        private void SwapButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.StartPosition = FormStartPosition.Manual;
            form1.Location = this.Location;
            form1.Size = this.Size;
            form1.ShowDialog();
            this.Close();

        }

        private void UserInputTB_TextChanged(object sender, EventArgs e)
        {
            int maxInputLength = 7;

            if (UserInputTB.Text.Length > maxInputLength)
            {
                UserInputTB.Text = UserInputTB.Text.Substring(0, maxInputLength);
            }

            if (NeedToCleanOutput && !String.IsNullOrWhiteSpace(((TextBox)sender).Text))
            {
                string lastCharInput = userInputCollection.LastOrDefault();
                userInputCollection.Clear();
                userInputCollection.Add(lastCharInput);
                UserInputTB.Text = String.Concat(userInputCollection);
            }
            NeedToCleanOutput = false;
        }
    }
}
