using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Графика_ЛР1_Лысенко_Алексей
{
    public partial class Form1 : Form
    {
        public static line rotate(line line_to_check, dot dot_to_check, int angle)
        {
            double new_x_begin = dot_to_check.getX() + (line_to_check.getBegin().getX() - dot_to_check.getX()) * Math.Cos(Math.PI * angle / 180) -
                (line_to_check.getBegin().getY() - dot_to_check.getY()) * Math.Sin(Math.PI * angle / 180);
            double new_y_begin = dot_to_check.getY() + (line_to_check.getBegin().getX() - dot_to_check.getX()) * Math.Sin(Math.PI * angle / 180) +
                (line_to_check.getBegin().getY() - dot_to_check.getY()) * Math.Cos(Math.PI * angle / 180);

            double new_x_end = dot_to_check.getX() + (line_to_check.getEnd().getX() - dot_to_check.getX()) * Math.Cos(Math.PI * angle / 180) -
                (line_to_check.getEnd().getY() - dot_to_check.getY()) * Math.Sin(Math.PI * angle / 180);
            double new_y_end = dot_to_check.getY() + (line_to_check.getEnd().getX() - dot_to_check.getX()) * Math.Sin(Math.PI * angle / 180) +
                (line_to_check.getEnd().getY() - dot_to_check.getY()) * Math.Cos(Math.PI * angle / 180);

            return new line(new dot(new_x_begin, new_y_begin), new dot(new_x_end, new_y_end));
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            Graphics graphics = pictureBox1.CreateGraphics();
            int m = 20;
            Pen pen = new Pen(Color.Black, 3);

            Point[] points = new Point[2];

            line first_line = new line(new dot(Double.Parse(textBox1.Text), Double.Parse(textBox2.Text)), new dot(Double.Parse(textBox3.Text), Double.Parse(textBox4.Text)));

            dot my_point = new dot(Double.Parse(textBox5.Text), Double.Parse(textBox6.Text));

            int angle = int.Parse(textBox7.Text);

            points[0] = new Point((int)(first_line.getBegin().getX() * m + (pictureBox1.Width / 2)), (int)(pictureBox1.Height - (first_line.getBegin().getY() * m + (pictureBox1.Height / 2))));
            points[1] = new Point((int)(first_line.getEnd().getX() * m + (pictureBox1.Width / 2)), (int)(pictureBox1.Height - (first_line.getEnd().getY() * m + (pictureBox1.Height / 2))));

            graphics.DrawLines(pen, points);

            pen = new Pen(Color.Green, 3);

            line second_line = rotate(first_line, my_point, angle);

            points[0] = new Point((int)(second_line.getBegin().getX() * m + (pictureBox1.Width / 2)), (int)(pictureBox1.Height - (second_line.getBegin().getY() * m + (pictureBox1.Height / 2))));
            points[1] = new Point((int)(second_line.getEnd().getX() * m + (pictureBox1.Width / 2)), (int)(pictureBox1.Height - (second_line.getEnd().getY() * m + (pictureBox1.Height / 2))));

            graphics.DrawLines(pen, points);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
