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
    public partial class ListForm : Form
    {
        public ListForm()
        {
            InitializeComponent();
        }

        // selected choice will be displayed in textbox
        private void ProvinceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProvinceTextBox.Text = ProvinceListBox.SelectedItem.ToString();
        }

        // hide this form and call the next form
        private void NextButton_Click(object sender, EventArgs e)
        {
            // Instatiate the next form - in this case the Final Form
            FinalForm finalForm = new FinalForm();
            // Pass a reference to the current form(this) to the a public property of the next form
            finalForm.listForm = this;
            // pass some data
            finalForm.ProvinceTextBox.Text = this.ProvinceTextBox.Text;
            // show the next form
            finalForm.Show();
            // hide this form
            this.Hide();
        }

        private void ListForm_Load(object sender, EventArgs e)
        {
            // select first item in the list
            ProvinceListBox.SetSelected(0,true);
        }
    }
}
