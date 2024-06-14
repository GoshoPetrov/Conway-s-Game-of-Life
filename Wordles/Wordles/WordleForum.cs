using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wordles
{
    public partial class WordleForm : Form
    {
        private const string WordsTextFile = @"wordsForWordle.txt";

        private const int RowLenght = 5;

        private const string PlayAgainMessage = "Play again?";

        private int previousRow = 0;
        private int hintsCount = 0;

        private string currentWord = string.Empty;
        private List<TextBox> currentBoxes = new List<TextBox>();

        public WordleForm()
        {
            InitializeComponent();

            
            //StartGame();
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                tb.MouseClick += this.FocusTextBox;
                //tb.KeyDown += this.MoveCursor;
            }
            

        }

        private void FocusTextBox(object sender, MouseEventArgs e)
        {
            if(sender is TextBox textBox)
            {
                textBox.Focus();
            }
        }

        private void MoveCursor(object sender, KeyEventArgs e)
        {
            var pressedKey = e.KeyCode;
            var senderTextBox = sender as TextBox;
            var currentTextBoxIndex = int.Parse(senderTextBox.Name.Replace("textBox", ""));

            if(ShouldGoToLeftTextBox(pressedKey, currentTextBoxIndex))
            {
                currentTextBoxIndex--;
            }
            else if(ShouldGoToRightTextBox(pressedKey, currentTextBoxIndex))
            {
                currentTextBoxIndex++;
            }

            var textBox = GetTextBox(currentTextBoxIndex);
            textBox.Focus();
        }

        private bool ShouldGoToLeftTextBox(Keys pressedKey, int currentTextBoxIndex) => pressedKey == Keys.Left && !IsFirstTextBox(currentTextBoxIndex);

        private bool IsFirstTextBox(int currentTextBoxIndex) => (currentTextBoxIndex + 4) % RowLenght == 0;


        private bool ShoulGoToRightTextBox(Keys pressedKeys, int currentTextBoxIndex) => (pressedKeys == Keys.Right || IsAlphabetKeyPressed(pressedKeys.ToString()))
        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
