using System;
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
            root.question = "Is it vegan?";
            root.yes = new Question();
            root.yes.question = "Is it a fruit?"; 
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
                //Get user input for new node.
                AddNewItem add = new AddNewItem();//this);//adds new node to tree based on user input. Passes string from text box. May not need, should pass with .Text.
                if (add.ShowDialog() == DialogResult.OK) // need to get user input from AddNewItem
                {
                 //Question tempQ = new Question(add.AddNewText.Text);
                 
                ////////////////////To insert new/////////////////////////////////////
                 //set a temp variable to current question.
                 
                //current question becomes temp.no
                
                // user question becomes current.question.
                
                // user answer becomes current.yes.


                }  
                
                //make temp = current Question. set current to new question, set current.yes to old question and current.no to user's answer. 
                
                //Thank user for adding a new question.
                if(MessageBox.Show("Thank you for adding a new question!" )== DialogResult.OK) // try to reference NewNode.question next!

                //Create message box to see if they want to play another game.
                if (MessageBox.Show("Do you want to play again?", "Twenty questions", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    //this.DialogResult = DialogResult.Cancel;
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

       /* public void InsertQuestion(Question current, string question)
        {
            //Question newNode = new Question();
            //newNode.question = question;
            //var insertNode = current.no;// this doesn't work either // was current.no = newNode
            //insertNode = newNode;//is overriding when I go back to current = root and isn't storing user input variable.

            Question temp = current;
             
             temp.no = question;
            // temp.no = userinput string.*/
        }
    }
