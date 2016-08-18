using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_Lesson12
{
    public partial class FinalForm : Form
    {
        public ListForm listForm {get; set;}

        public FinalForm()
        {
            InitializeComponent();
        }

        // show ListForm and close the FinalForm
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.listForm.Show();
            this.Close();
        }


        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            // show diaglor
            aboutBox.ShowDialog();
        }
    }
}
