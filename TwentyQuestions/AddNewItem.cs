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
        public AddNewItem()
        {
            InitializeComponent();
        }

        private void AddNewItem_Load(object sender, EventArgs e)
        {
            AddNewLabel.Text = "Need INPUT!! Need INPUT!!!";
        }
    }
}
