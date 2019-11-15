using MaterialSkin;
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
    public partial class Form1 : MaterialForm
    {
        public bool NeedToCleanOutput = false;
        public Form1()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void UserInputTB_TextChanged(object sender, EventArgs e)
        {
            int maxInputLength = 7;

            if (UserInputTB.Text.Length > maxInputLength)
            {
                UserInputTB.Text = UserInputTB.Text.Substring(0, maxInputLength);
            }

            TextBox convertedFromSender = (TextBox)sender;
            string stringFromTB = convertedFromSender.Text;
            bool isStringFromTBEmpty = String.IsNullOrWhiteSpace(stringFromTB);


            if (NeedToCleanOutput && !isStringFromTBEmpty)
            {
                UserInputTB.Text = ((TextBox)sender).Text.Last().ToString();
            }

            NeedToCleanOutput = false;
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            UserInputTB.Text += button0.Text;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            UserInputTB.Text += button7.Text;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            UserInputTB.Text += button2.Text;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            UserInputTB.Text += button1.Text;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            UserInputTB.Text += button8.Text;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            UserInputTB.Text += button3.Text;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            UserInputTB.Text += button4.Text;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            UserInputTB.Text += button5.Text;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            UserInputTB.Text += button6.Text;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            UserInputTB.Text += button9.Text;
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            UserInputTB.Clear();
            UserOutputTB.Clear();
        }

        private void ButtonConvert_Click(object sender, EventArgs e)
        {
            string answer = "";
            List<int> listOfUserInputArabicNumbersDigits = ListOfUserInputArabicNumbersDigits(UserInputTB.Text);
            UserOutputTB.Text = CalculationAlgorithm(answer, listOfUserInputArabicNumbersDigits, ListOfArabicNumbers(), DictionariOfNumbers());
            NeedToCleanOutput = true;
        }

        public static Dictionary<int, string> DictionariOfNumbers()
        {
            Dictionary<int, string> dictionaryOfNumbers = new Dictionary<int, string>
            {
                { 0, "" },
                { 1, "I"},
                { 5, "V"},
                { 10, "X"},
                { 50, "L"},
                { 100, "C"},
                { 500, "D"},
                { 1000, "M"},
                { 5000, "V̅"},
                { 10000, "X̅"},
                { 50000, "L̅"},
                { 100000, "C̅"},
                { 500000, "D̅"},
                { 1000000, "M̅"}
            };

            return dictionaryOfNumbers;
        }

        public static List<int> ListOfArabicNumbers()
        {
            List<int> listOfArabicNumbers = new List<int> { 0, 1, 5, 10, 50, 100, 500, 1000, 5000, 10000, 50000, 100000, 500000, 1000000 };
            return listOfArabicNumbers;
        }

        public static List<int> ListOfUserInputArabicNumbersDigits(string userInputNumber)
        {
            List<char> listOfUserInputNumber = userInputNumber.ToList();
            List<int> listOfUserInputArabicNumbersDigits = new List<int>();

            int i = 0;
            foreach (char number in listOfUserInputNumber)
            {
                int count = userInputNumber.Length - 1 - listOfUserInputNumber.FindIndex(i, x => x == number);
                string numberDigit = number + String.Concat(Enumerable.Repeat("0", count));
                listOfUserInputArabicNumbersDigits.Add(Convert.ToInt32(numberDigit));
                i++;
            }

            return listOfUserInputArabicNumbersDigits;
        }

        public static string FirstCondition(int number, string answer, Dictionary<int, string> dictionaryOfNumbers)
        {
            answer += dictionaryOfNumbers[number];
            return answer;
        }

        public static string SecondCondition(int nextNumber, int differenceBetweenNumbers, string answer, Dictionary<int, string> dictionaryOfNumbers)
        {
            answer += dictionaryOfNumbers[differenceBetweenNumbers];
            answer += dictionaryOfNumbers[nextNumber];
            return answer;
        }

        public static string ThirdCondition(int previousNumber, int resultOfDivision, string answer, Dictionary<int, string> dictionaryOfNumbers)
        {
            answer += String.Concat(Enumerable.Repeat(dictionaryOfNumbers[previousNumber], resultOfDivision));
            return answer;
        }

        public static string CalculationAlgorithm(string answer, List<int> listOfUserInputArabicNumbersDigits, List<int> listOfArabicNumbers, Dictionary<int, string> dictionaryOfNumbers)
        {
            foreach (int number in listOfUserInputArabicNumbersDigits)
            {
                if (listOfArabicNumbers.Contains(number))
                {
                    answer = FirstCondition(number, answer, dictionaryOfNumbers);
                    continue;
                }

                int resultOfDivision;

                if (number > 1000000)
                {
                    resultOfDivision = number / 1000000;
                    answer = ThirdCondition(1000000, resultOfDivision, answer, dictionaryOfNumbers);
                    continue;
                }

                listOfArabicNumbers.Add(number);
                listOfArabicNumbers.Sort();
                int nextNumber = listOfArabicNumbers[listOfArabicNumbers.IndexOf(number) + 1];
                int previousNumber = listOfArabicNumbers[listOfArabicNumbers.IndexOf(number) - 1];
                int differenceBetweenNumbers = nextNumber - number;

                if (listOfArabicNumbers.Contains(differenceBetweenNumbers))
                {
                    answer = SecondCondition(nextNumber, differenceBetweenNumbers, answer, dictionaryOfNumbers);
                    continue;
                }

                resultOfDivision = number / previousNumber;

                if (number % previousNumber == 0)
                {
                    answer = ThirdCondition(previousNumber, resultOfDivision, answer, dictionaryOfNumbers);
                    continue;
                }

                answer += dictionaryOfNumbers[previousNumber];
                int subtractionResult = number - previousNumber;

                if (listOfArabicNumbers.Contains(subtractionResult))
                {
                    answer = FirstCondition(subtractionResult, answer, dictionaryOfNumbers);
                    continue;
                }

                listOfArabicNumbers.Add(subtractionResult);
                listOfArabicNumbers.Sort();
                previousNumber = listOfArabicNumbers[listOfArabicNumbers.IndexOf(subtractionResult) - 1];
                resultOfDivision = subtractionResult / previousNumber;

                if (listOfArabicNumbers.Contains(subtractionResult))
                {
                    answer = ThirdCondition(previousNumber, resultOfDivision, answer, dictionaryOfNumbers);
                    continue;
                }
            }

            return answer;
        }

        private void BackSpaceButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(UserInputTB.Text))
            {
                NeedToCleanOutput = false;
                UserInputTB.Text = UserInputTB.Text.Substring(0, UserInputTB.Text.Length - 1);
            }
        }

        private void UserOutputTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void SwapButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.StartPosition = FormStartPosition.Manual;
            form2.Location = this.Location;
            form2.Size = this.Size;
            form2.ShowDialog();
            this.Close();
        }
    }
}
                                                                                                    