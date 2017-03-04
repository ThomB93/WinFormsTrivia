using System;
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
        private int score = 0;
        public Form1()
        {
            InitializeComponent();
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
            RootObject questionsRootObject = JsonConvert.DeserializeObject<RootObject>(json);

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
                SelectedQuestionClass.Question = listBox1.SelectedItem.ToString(); //save question as static string
                Form2 answerForm = new Form2();
                answerForm.Show();
                this.Hide();
            }
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
