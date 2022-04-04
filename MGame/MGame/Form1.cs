using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Windows.Forms;

namespace MGame
{
    public partial class Form1 : Form
    {
        Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>
        {
            {"Ülkemizde 2017 yılında asgari ücret ne kadardı?",
                new List<string> {"1000","2000","3000"}},
            {"1950'li yılların sonlarında tahılları yedikleri gerekçesiyle ülkesindeki tüm serçelerin öldürülmesini emreden ünlü dikdatör kimdir?",
                new List<string> {"Mao Zedong", "Josef Stalin","Adolf Hitler"} },
            {"1972’de Apollo 17 uzay aracı mürettebatınca çekilen ve yerküreyi bütün olarak gösteren ünlü fotoğrafın adı nedir?",
                new List<string> { "Mavi Bilye", "Mavi Boncuk", "Mavi Gezegen" } },
            {"Bir Gün Kaç Saniyedir?",
                new List<string> {"86400","88600","86000"}},
            {"Dünya yüzeyindeki en büyük ada hangisidir?",
                new List<string> {"Grönland","Borneo","Yeni Gine"}}
        };
        int[] data = new int[3]; //{0: Doğru sayısı, 1: Yanlış sayısı, 2: Soru sayısı}
        Random rand = new Random();
        string question;
        public Form1()
        {
            InitializeComponent();
        }

        private string randQuestion()
        {
            return dictionary.ElementAt(rand.Next(0, dictionary.Count - 1)).Key;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (startButton.Text == "BAŞLAT")
            {
                data[2]++;
                startButton.Text = "YENİDEN BAŞLAT";
                startButton.BackColor = Color.DarkRed;
                timer1.Start();
                richTextBox.Text = randQuestion();
                question = richTextBox.Text;
                writeButton();
                buttonAction(true);
            }
            else if (startButton.Text == "YENİDEN BAŞLAT") gameRestart();
        }

        private void writeButton()
        {
            List<List<int>> sayilar = new List<List<int>>
            {
                new List<int> {0,1,2},
                new List<int> {2,1,0},
                new List<int> {1,2,0},
                new List<int> {0,2,1},
                new List<int> {0,1,2}
            };
            List<int> sayi = sayilar[rand.Next(0, sayilar.Count - 1)];
            QuestionButton1.Text = dictionary[question][sayi[0]];
            QuestionButton2.Text = dictionary[question][sayi[1]];
            QuestionButton3.Text = dictionary[question][sayi[2]];
        }
        int tick = 60;
        private void timer1_Tick(object sender, EventArgs e)
        {
            tick--;
            if (startButton.Text == "BAŞLAT") return;
            correctCount.Text = data[0].ToString();
            wrongCount.Text = data[1].ToString();
            questionCount.Text = data[2].ToString();
            timeText.Text = tick / 60 + ":" + tick % 60;
            if (tick == 1)
            {
                gameRestart();
                MessageBox.Show("Süren doldu!\n\nDoğru Sayısı: " + data[0] + "\nYanlış Sayısı: " + data[1]);
            }
        }

        private void gameRestart()
        {
            tick = 60;
            startButton.Text = "BAŞLAT";
            startButton.BackColor = Color.FromArgb(0, 192, 0);
            data = new int[3] { 0, 0, 0 };
            timeText.Text = "0:0";
            timer1.Stop();
            richTextBox.Clear();
            buttonAction(false);
            questionCount.Text = "0";
        }

        private void buttonAction(bool action)
        {
            QuestionButton1.Enabled = action;
            QuestionButton2.Enabled = action;
            QuestionButton3.Enabled = action;
            pasButton.Enabled = action;
        }

        private void Question1_Click(object sender, EventArgs e)
        {
            string correctAnswer = dictionary[question][0];
            if (QuestionButton1.Text == correctAnswer) data[0]++;
            else data[1]++;
            tick = 60;
            richTextBox.Text = randQuestion();
            question = richTextBox.Text;
            writeButton();
            data[2]++;
        }

        private void QuestionButton2_Click(object sender, EventArgs e)
        {
            string correctAnswer = dictionary[question][0];
            if (QuestionButton2.Text == correctAnswer) data[0]++;
            else data[1]++;
            tick = 60;
            richTextBox.Text = randQuestion();
            question = richTextBox.Text;
            writeButton();
            data[2]++;
        }

        private void QuestionButton3_Click(object sender, EventArgs e)
        {
            string correctAnswer = dictionary[question][0];
            if (QuestionButton3.Text == correctAnswer) data[0]++;
            else data[1]++;
            tick = 60;
            richTextBox.Text = randQuestion();
            question = richTextBox.Text;
            writeButton();
            data[2]++;
        }

        private void pasButton_Click(object sender, EventArgs e)
        {
            tick = 60;
            richTextBox.Text = randQuestion();
            question = richTextBox.Text;
            writeButton();
            data[2]++;
        }
    }

    class Timeout
    {
        Timer timer;
        int timeout;
        int tick = 1;

        public Timeout()
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += timerHandler;
        }
        public void setTimeout(int timeoutTick)
        {
            timeout = timeoutTick;
            timer.Start();
        }

        private void timerHandler(object sender, EventArgs e)
        {
            ++tick;
            Timer timerH = (Timer)sender;
            if (tick == timeout)
            {
                timer.Stop();
            }
        }
    }
}