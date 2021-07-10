using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordCounterApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK) 
            {
                String filePath = openFileDialog.FileName;
                textBox1.Text = File.ReadAllText(filePath);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String allWords = textBox1.Text;
            String[] wordsArray = allWords.Split(' ', ',', '.', '!', '-' );
            foreach (string word in wordsArray)
            {
                if (!listBox1.Items.Contains(word))
                {
                    listBox1.Items.Add(word);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            String allWords = textBox1.Text;
            String[] wordsArray = allWords.Split(' ', ',', '.', '!', '-');

            List<WordCounter> wordCounters = new List<WordCounter>();

            foreach (string word in wordsArray) 
            {
                WordCounter findWord = wordCounters.Find(x => x.word == word);

                if (findWord == null)
                {
                    wordCounters.Add(new WordCounter(word, 1));
                }

                else {
                    findWord.frequency++;
                }
            }

            listView1.Columns.Add("Frequency", 100);
            listView1.Columns.Add("Word", 100);
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            foreach (WordCounter w in wordCounters) 
            {
                String[] rowItem = new String[] {w.frequency.ToString("D5"), w.word };
                listView1.Items.Add(new ListViewItem(rowItem));
                
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            listView1.Sorting = SortOrder.Ascending;
        }
    }
}
