using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Графика_ЛР1_Лысенко_Алексей
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class dot
    {
        double x;
        double y;

        public dot(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double getX() { return x; }
        public double getY() { return y; }
        public void setX(int x) { this.x = x; }
        public void setY(int y) { this.y = y; }

        public override string ToString()
        {
            return "X=" + x + ", Y=" + y;
        }
    }

    public class line
    {
        dot begin;
        dot end;

        public line(dot begin, dot end)
        {
            this.begin = begin;
            this.end = end;
        }

        public line(line temp)
        {
            this.begin = temp.getBegin();
            this.end = temp.getEnd();
        }

        public void print()
        {
            Console.WriteLine("begin: " + begin.ToString() + "\n" + "end: " + end.ToString());
        }

        public dot getBegin() { return begin; }
        public dot getEnd() { return end; }
    }
}
