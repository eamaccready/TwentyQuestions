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

            //
            //if (current.isleaf())// not recognising 
            //{
                //yes? I rock!
                MessageBox.Show("Yay! I guessed it!");// currently shows for both options.
                // then ask " Do you want to play again?"
                if (MessageBox.Show("Do you want to play again?", "Twenty questions", MessageBoxButtons.YesNo) == DialogResult.No)
                {

                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
                //}
                // no? ask next question.
                // else 
                //{
                //New game?

                //}

               // else
                //{
                   // ; //Next yes question.
                //}
            //}
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            //am I a leaf?
            //if(current.isleaf())
            // no: ask next question.
            // yes: it's new, go learn stuff.


            // then ask "Do you want to play again?"
           if(MessageBox.Show("Do you want to play again?", "Twenty questions", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
                //this. DialogResult = DialogResult. // other option/not cancel.
            }

            AddNewItem add = new AddNewItem();//flips to new window
            if (add.ShowDialog() == DialogResult.OK);// both ways add new window now.
            //else cancel?
        }
     }
}
