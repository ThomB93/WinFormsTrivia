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
                MessageBox.Show("Correct Answer!");
                StaticVariables.Points++;

                Form1 questionsForm = new Form1(); //change form
                questionsForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Answer!");

                Form1 questionsForm = new Form1(); //change form
                questionsForm.Show();
                this.Hide();
            }
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
