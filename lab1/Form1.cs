using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const double dt = 0.01;

        const double g = 9.81;
        const double C = 0.15;
        const double rho = 1.29;

        double height, angle, speed, S, mas;
        double cosa, sina, beta, k;

        double t, x, y, vx, vy;

        int iter = 0;

        double max_height = 0;

        private void btStart_Click(object sender, EventArgs e)
        {
            if (iter == 0)
            {
                for (int i = 0; i < 3; i++) table.Rows.Add();

                table.Rows[0].Cells[0].Value = "Time Step";
                table.Rows[1].Cells[0].Value = "Distance";
                table.Rows[2].Cells[0].Value = "Max Height";
                table.Rows[3].Cells[0].Value = "Speed at the end point";
            }

            iter++;

            table.Columns.Add("Iteration", "Iteration" + iter);

            height = (double)zxcHeight.Value;
            angle= (double)zxcAngle.Value;
            speed = (double)zxcSpeed.Value;
            S = (double)zxcSize.Value;
            mas = (double)zxcWeight.Value;

            cosa = Math.Cos(angle * Math.PI / 180);
            sina = Math.Sin(angle * Math.PI / 180);

            beta = 0.5 * C * S * rho;
            k = beta / mas;

            t = 0;
            x = 0;
            y = height;
            vx = speed * cosa;
            vy = speed * sina;

            graphic.Series[0].Points.Clear();
            graphic.Series[0].Points.AddXY(x, y);

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double root = Math.Sqrt(vx * vx + vy * vy);

            t += dt;

            vx = vx - k * vx * root * dt;
            vy = vy - (g + k* vy * root) * dt;

            x = x + vx * dt;
            y = y + vy * dt;

            if (y > max_height)
            {
                max_height = y;
            }

            graphic.Series[0].Points.AddXY(x, y);
            
            table.Rows[0].Cells[iter].Value = dt;
            table.Rows[1].Cells[iter].Value = x;
            table.Rows[3].Cells[iter].Value = root;
            table.Rows[2].Cells[iter].Value = max_height;

            if (y <= 0) timer1.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
