using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DifferentControlsApp
{
    public partial class MainUI : Form
    {
        string GlobalValueOfRadioButton = "", GlobalValueOfCheckBox = "",GlobalValueofComboBox = "";

        public MainUI()
        {
            InitializeComponent();
        }

        private void showComboBoxButton_Click(object sender, EventArgs e)
        {
            GlobalValueofComboBox = numberComboBox.SelectedItem.ToString();
            ComboBoxSelection(numberComboBox.SelectedItem.ToString(), "Selected Item of Combo Box");
            
        }

        private void ComboBoxSelection(string selectedItem, string messageBoxCaption)
        {
            MessageBox.Show(selectedItem,messageBoxCaption,MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
           
        }



        private void showRadioButtonButton_Click(object sender, EventArgs e)
        {
            string valueOfRadioButton = "";

            if (EvenRadioButton.Checked)
            {
                valueOfRadioButton = "Even";
            }
            else {
                valueOfRadioButton = "Odd";
            }
            GlobalValueOfRadioButton = valueOfRadioButton;
            RadioBoxSelection(valueOfRadioButton, "Selected Radio Button");
        }

        private void RadioBoxSelection(string valueOfRadioButton, string messageBoxCaption)
        {
            MessageBox.Show(valueOfRadioButton, messageBoxCaption, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void showCheckBoxButton_Click(object sender, EventArgs e)
        {
            string valueOfCheckBox = "";

            if (EvenCheckBox.Checked)
            {
                valueOfCheckBox = "Even";
            }
            if (OddCheckBox.Checked)
            {
                valueOfCheckBox = "Odd";
            }
            
            if (EvenCheckBox.Checked & OddCheckBox.Checked)
            {
                valueOfCheckBox = "Both buttons are checked.";
            }

            if (!EvenCheckBox.Checked & !OddCheckBox.Checked)
            {
                valueOfCheckBox = "No button checked.";
            }
            GlobalValueOfCheckBox = valueOfCheckBox;
            CheckBoxSelection(valueOfCheckBox, "Selected Check Box");
        }

        private void CheckBoxSelection(string valueOfCheckBox, string messageBoxCaption)
        {
            MessageBox.Show(valueOfCheckBox, messageBoxCaption, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            ComboBoxSelection(GlobalValueofComboBox, "Selected Item of Combo Box");
            RadioBoxSelection(GlobalValueOfRadioButton, "Selected Radio Button");
            CheckBoxSelection(GlobalValueOfCheckBox, "Selected Check Box");
        }
    }
}
