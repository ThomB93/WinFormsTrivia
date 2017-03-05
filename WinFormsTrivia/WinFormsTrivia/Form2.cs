using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsTrivia.Properties;

namespace WinFormsTrivia
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            label1.Text = StaticVariables.Question;
            StaticVariables.Answers.Shuffle(); //randomize correct answer in list
            foreach (var item in StaticVariables.Answers)
            {
                listBox1.Items.Add(item);
            }
        }

        //Non-implemented events
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.ToString() == StaticVariables.CorrectAnswer)
            {
                MessageBox.Show(Resources.Form2_button1_Click_Correct_Answer_);
                StaticVariables.Points++;

                Form1 questionsForm = new Form1(); //change form
                questionsForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(Resources.Form2_button1_Click_Wrong_Answer_);
                CheckIfGameOver();
            }
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckIfGameOver();
        }

        private void CheckIfGameOver()
        {
            if (StaticVariables.Tries == 0)
            {
                MessageBox.Show(Resources.Form2_button1_Click_You_lost_the_game_);
            }
            else
            {
                StaticVariables.Tries--;
                Form1 questionsForm = new Form1(); //change form
                questionsForm.Show();
                this.Hide();
            }
        }
    }
}
