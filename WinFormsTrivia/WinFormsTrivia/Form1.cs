﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WinFormsTrivia
{
    public partial class Form1 : Form
    {
        private Dictionary<string, int> categoryValue;
        private RootObject questionsRootObject;
        public Form1()
        {
            InitializeComponent();
            
            labelPoints.Text = StaticVariables.Points.ToString();
            labelTries.Text = StaticVariables.Tries.ToString();

            comboCategory.Items.Add("General Knowledge");
            comboCategory.Items.Add("History");
            comboCategory.Items.Add("Mythology");
            comboCategory.Items.Add("Movies");
            comboCategory.Items.Add("Art");
            comboCategory.Items.Add("Video Games");
            comboCategory.Items.Add("Board Games");
            comboCategory.Items.Add("Animals");

            comboDifficulty.Items.Add("Easy");
            comboDifficulty.Items.Add("Medium");
            comboDifficulty.Items.Add("Hard");

            comboCategory.SelectedIndex = 0; //set default value
            comboDifficulty.SelectedIndex = 0; //set default value
            
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            categoryValue = new Dictionary<string, int> //match json URL value
            {
                {"General Knowledge", 9},
                {"History", 23},
                {"Mythology", 20},
                {"Movies", 11},
                {"Art", 25},
                {"Video Games", 15},
                {"Board Games", 16},
                {"Animals", 27}
            };

            var category = comboCategory.SelectedItem.ToString();
            var chosenCategory = categoryValue[category];

            var difficulty = comboDifficulty.SelectedItem.ToString();
            difficulty = difficulty.ToLower();

            var json = new WebClient().DownloadString("https://www.opentdb.com/api.php?amount=10&category="
                + chosenCategory + "&difficulty=" + difficulty + "&type=multiple");
            questionsRootObject = JsonConvert.DeserializeObject<RootObject>(json);

            foreach (var item in questionsRootObject.results)
            {
                byte[] bytes = Encoding.Default.GetBytes(item.question);
                string encodedString = Encoding.UTF8.GetString(bytes);
                listBox1.Items.Add(encodedString);
            }
        }

        private void listBox1_DoubleClick_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                int selectedIndex = listBox1.SelectedIndex; 
                StaticVariables.Question = listBox1.SelectedItem.ToString(); //save question as static string
                StaticVariables.Answers = questionsRootObject.results[selectedIndex].incorrect_answers;
                StaticVariables.Answers.Add(questionsRootObject.results[selectedIndex].correct_answer);
                StaticVariables.CorrectAnswer = questionsRootObject.results[selectedIndex].correct_answer;

                Form2 answerForm = new Form2(); //change form
                answerForm.Show();
                this.Hide();
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }


        //Non implemented events
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelPoints_Click(object sender, EventArgs e)
        {

        }
    }
}
