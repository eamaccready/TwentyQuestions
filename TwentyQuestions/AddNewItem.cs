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
    public partial class AddNewItem : Form
    {
        Form1 f1;

        public AddNewItem(Form1 parent)
        {
            InitializeComponent();
            f1 = parent;
        } 

        private void AddNewItem_Load(object sender, EventArgs e)
        {
            AddNewLabel.Text = "Need INPUT!! Need INPUT!!! \nPlease enter a new question below.";
        }

        private void AddNewText_TextChanged(object sender, EventArgs e)
        {
              
        }

        private void AddNewPic_Click(object sender, EventArgs e)
        {
        }

        private void AddNewButton_Click(object sender, EventArgs e)
        {
            // inserts newQueston as new child question.no
            string newQuestion = AddNewText.Text;
            f1.InsertQuestion(newQuestion);
            Close();// won't always work in debug mode.
        }
        
    }
}
