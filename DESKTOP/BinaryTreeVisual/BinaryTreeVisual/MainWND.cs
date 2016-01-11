using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryTreeVisual
{
    public partial class MainWND : Form
    {
        public MainWND()
        {
            InitializeComponent();

            int height = this.Height;
            int width = this.Width;

        }

        public BinaryTree bt = new BinaryTree(new int[] { 4, 9, 8, 2, 5, 6, 3, 1, 7 });
        public List<Point> points = new List<Point>();

        public void DrawTree(BTNode node, int width, int height, bool? leftFlag )
        {
            int tempHeight = height, tempWidth = width;
            
            if (leftFlag != null)
            {
                if (leftFlag == true)
                {
                    width /= 2;
                }
            }
            PaintMethod(width, height, node.value.ToString());
            height += 100;

            if (node.leftNode != null)
            {
                DrawTree(node.leftNode, width, height, true );
            }
            if (leftFlag != null)
            {
                if (leftFlag == true)
                {
                    width /= 2;
                }
            }
            width = tempWidth;
            width += tempWidth / 2;
            if (node.rightNode != null)
            {

                DrawTree(node.rightNode, width, height, false );
            }
           width = tempWidth;

        }
        public void PaintMethod(int width, int height, string value)
        {
            Pen p = new Pen(Color.Black, 3);
            Graphics g = this.CreateGraphics();
            g.DrawEllipse(p, width, height, 30, 30);
            Label lbl = new Label();
            g.DrawString(value, new Font("Arial", 20), Brushes.Black, width, height);
            points.Add(new Point(width+15, height+15));
        }

        public void Lines()
        {
            Graphics g = this.CreateGraphics();
            Point prev = points.First();
            Pen p = new Pen(Color.Red, 2);
            foreach (Point current in points)
            {
                g.DrawLine(p, current, prev);
                prev = current;
            }
        }
        private void PaintBtn_Click(object sender, EventArgs e)
        {
            DrawTree(bt.rootNode, this.Width/2, 0, null);

            Lines();
        }
        class BTDRaw
        {
            public void Drawing(Graphics g, int w,int h)
            {
                
            }

            private void DrawNode(BTNode node, Graphics g, int left,int right, int step, int level)
            {
                if (node == null)
                {
                    return;
                }

                int x = (left + right) / 2;
                int y = level + step;

                DrawNode(node.leftNode, g, left, x, step, level + 1);
                DrawNode(node.rightNode, g, x, right, step, level + 1);
            }
        }
    }
}
