using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;

namespace balls
{
    public partial class Form1 : Form
    {
        public List<Ball> balls { get; set; }
        Graphics graphics;

        Pen pen = new Pen(Color.Black);
        Random rannd = new Random();
        Brush brush = new SolidBrush(Color.BurlyWood);
        Timer timer = new Timer();

        public Form1()
        {
            InitializeComponent();
            this.graphics = this.pictureBox1.CreateGraphics();
            this.balls = new List<Ball>();
            this.timer.Interval = 1;
            timer.Tick += Timer_Tick;
        }
        
        private void MoveBalls()
        {
            graphics.Clear(BackColor);
            foreach (var item in this.balls)
            {
                item.MoveBall(pictureBox1.Width, pictureBox1.Height);
                graphics.FillEllipse(brush, item.X, item.Y, item.BallHeight, item.BallWidth);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            MoveBalls();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            Ball ball = new Ball(e.X, e.Y, 30, 30);
            graphics.FillEllipse(brush, ball.X, ball.Y, ball.BallHeight, ball.BallWidth);
            balls.Add(ball);

            timer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveJson(balls, "test.json");
            SaveXml(balls, "test.xml");
        }

        //form
        public void SaveXml(List<Ball> balls, string FilePath)
        {
            timer.Stop();

            XmlSerializer writerXml = new XmlSerializer(typeof(List<Ball>));
            FileStream file = File.Create(FilePath);
            writerXml.Serialize(file, balls);
            file.Close();

            timer.Start();
        }

        public void SaveJson(List<Ball> balls, string FilePath)
        {
            timer.Stop();

            DataContractJsonSerializer writerJson = new DataContractJsonSerializer(typeof(List<Ball>));
            FileStream file = File.Create(FilePath);
            writerJson.WriteObject(file, balls);
            file.Close();

            timer.Start();
        }
        public void DeserialiseXml()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(List<Ball>));
            TextReader reader = new StreamReader("test.xml");
            object obj = deserializer.Deserialize(reader);
            List<Ball> XmlData = (List<Ball>)obj;
            reader.Close();
            balls = XmlData;
            timer.Start();
        }
        public void DeserialiseJson()
        {
            DataContractJsonSerializer deserializer = new DataContractJsonSerializer(typeof(List<Ball>));
            StreamReader str = new StreamReader("test.json");
            object obj = deserializer.ReadObject(str.BaseStream);
            List<Ball> JsonData = (List<Ball>)obj;
            str.Close();
            balls = JsonData;
            timer.Start();
        }

        private void Load_btn_Click(object sender, EventArgs e)
        {
            DeserialiseJson();
            //DeserialiseXml();
        }
    }
}
