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
            root.question = "Is is hot?";
            root.yes = new Question();
            root.yes.question = "Is is black coffee?"; // change questions to theme.
            root.no = new Question();
            root.no.question = "Is is 2% milk?";

            current = root; // make sure something points to root.
            questionLabel.Text = current.question;
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            // is leaf? 

            if (current.isleaf())
            {
                //yes? I rock!
                //MessageBox.Show("Yay! I guessed it!");// currently shows for both options.
                // then ask " Do you want to play again?"
                if (MessageBox.Show("Do you want to play again?", "Twenty questions", MessageBoxButtons.YesNo) == DialogResult.No)// still needs DialogResult.yes
                {
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
                //}
                // no? ask next question.
                // else 
                //{
                //New game? current = root

                //}
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
            { // yes: it's new, go learn stuff.
                AddNewItem add = new AddNewItem();//flips to new window to enter a new question.
                //.Text = "Need INPUT!! Need INPUT!!!";// won't print to label. Figure out!!!!
                if (add.ShowDialog() == DialogResult.OK);
                
                //MessageBox.Show();
                // then ask "Do you want to play again?"
                if (MessageBox.Show("Do you want to play again?", "Twenty questions", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
                //else new game. {current = root;}
            }
            else
            {
                current = current.no;
                questionLabel.Text = current.question;
            }
        }
    }
}
