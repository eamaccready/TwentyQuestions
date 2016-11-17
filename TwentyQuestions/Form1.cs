using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwentyQuestions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Question root;
        Question current;

        private void Form1_Load(object sender, EventArgs e)
        {
            root = new Question();
            root.question = "Is it vegetarian?";
            root.yes = new Question();
            root.yes.question = "Is it a fruit?"; // change questions to theme.
            root.no = new Question();
            root.no.question = "Is it meat?";

            current = root; // make sure something points to root.
            questionLabel.Text = current.question;
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            // is leaf? 

            if (current.isleaf())
            {
                //yes? I rock!
                MessageBox.Show("Yay! I guessed it!");

                // Then ask " Do you want to play again?"
                if (MessageBox.Show("Do you want to play again?", "Twenty questions", MessageBoxButtons.YesNo) == DialogResult.No)// still needs DialogResult.yes
                {
                    //this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
                else 
                {
                    //new game
                    current = root;
                    questionLabel.Text = current.question;

                }
            }

            else
            {
                current = current.yes;
                questionLabel.Text = current.question;
            }     
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            // is leaf?
            if (current.isleaf())
            { 
                // yes: it's new, go learn stuff.
                AddNewItem add = new AddNewItem();//flips to new window to enter a new question.
                if (add.ShowDialog() == DialogResult.OK)

                // then ask "Do you want to play again?"
                if (MessageBox.Show("Do you want to play again?", "Twenty questions", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
                else
                {
                    current = root;
                    questionLabel.Text = current.question;
                    }
            }
            else
            {
                current = current.no;
                questionLabel.Text = current.question;
            }
        }
    }
}
