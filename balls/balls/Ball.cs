using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace balls
{
    [Serializable]
    public class Ball
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int DX { get; set; }
        public int DY { get; set; }
        public int BallWidth { get; set; }
        public int BallHeight { get; set; }

        public Ball()
        {

        }

        public Ball(int left, int top, int BallHeight, int BallWidth)
        {
            this.X = left;
            this.Y = top;
            this.BallHeight = BallHeight;
            this.BallWidth = BallWidth;
            Random rand = new Random();
            this.DX = rand.Next(-7, 7);
            this.DY = rand.Next(-7, 7);
            
        }

        public void MoveBall(int WindowWidth, int WindowHeight)
        {

            if (this.X <= 0)
            {
                this.DX = -DX;
            }

            if (this.X >= WindowWidth - 45)
            {
                this.DX = -DX;
            }

            if (this.Y <= 0)
            {
                this.DY = -DY;
            }

            if (this.Y >= WindowHeight - 45)
            {
                this.DY = -DY;
            }


            this.X += DX;
            this.Y += DY;
        }
        //balls
        public void SaveData(string filename, List<Ball> balls)
        {
            var formatter = new BinaryFormatter();
            var filestream = new FileStream(filename, FileMode.Create);
            formatter.Serialize(filestream, balls);
        }
    }
}
