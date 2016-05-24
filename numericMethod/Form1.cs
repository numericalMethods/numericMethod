using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace numericMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        PointF point = new Point();
        List<PointF> minPoints = new List<PointF>();

        int countStepsOfSizeStep, countStepsOfFriction, countStepsOfWeight, countStepsOfRigidity;

        private double first_function(double y)
        {  // Первая функция
            return y;
        }

        private double second_function(double k, double m, double M, double x, double y)
        { //Вторая функция
            return -(k / m) * x - (M / m) * y;
        }
        private void runge_kutta_method(double h, double k, double m, double M)
        {	
            double k1,k2,k3,k4; // Коэффициенты метода для первой функции
            double m1,m2,m3,m4;
            double t = 0;
            double x = point.X;
            double y = point.Y;
            int count = 0;
                count++;

                k1 = h * first_function(y);
                m1 = h * second_function(k, m, M, x, y);

                k2 = h * first_function(y + k1 / 2);
                m2 = h * second_function(k, m, M, x + h / 2, y + (h * m1) / 2);

                k3 = h * first_function(y + k2 / 2);
                m3 = h * second_function(k, m, M, x + h / 2, y + (h * m2) / 2);

                k4 = h * first_function(y + h * k3);
                m4 = h * second_function(k, m, M, x + h, y + h * m3);

                point.X += (float)((h / 6) * (k1 + 2 * k2 + 2 * k3 + k4));
                point.Y += (float)((h / 6) * (m1 + 2 * m2 + 2 * m3 + m4));

                t += h;
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            point.X = 5;
            point.Y = -0.0001f;
            minPoints.Add(new PointF(0, 10));
            minPoints.Add(new PointF(1000, 10));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void computePloatWithNecessaryParameters(float h, float k, float m, float M)
        {
            chart1.Series[0].Points.Clear();
            List<PointF> currentPoints = new List<PointF>();
            while (point.Y < 0.0)
            {
                runge_kutta_method(h, k, m, M);
                currentPoints.Add(point);
                //chart1.Series[0].Points.AddXY(point.X, point.Y);
            }
            while (point.Y > 0.0)
            {
                runge_kutta_method(h, k, m, M);
                currentPoints.Add(point);
                //chart1.Series[0].Points.AddXY(point.X, point.Y);
            }
            if (checkMinDeltaXValue(currentPoints, minPoints))
            {
                minPoints = currentPoints;
            }
            point.X = Convert.ToInt32(numericUpDownTK.Value);
            point.Y = -0.0001f;

        }
        private bool checkMinDeltaXValue(List<PointF> currentPoints, List<PointF> minPoints)
        {
            float currentDeltaX = currentPoints.ElementAt(currentPoints.Count - 1).X - currentPoints.ElementAt(0).X;
            float minDeltaX = minPoints.ElementAt(minPoints.Count - 1).X - minPoints.ElementAt(0).X;
            if (currentDeltaX < minDeltaX)
            {
                return true;
            }
            return false;
        }
        private int calculateCountExperiment()
        {
             countStepsOfSizeStep = (Convert.ToInt32(numericUpDownSMax.Value) - Convert.ToInt32(numericUpDownSMin.Value)) / Convert.ToInt32(numericUpDownSBust.Value);
             countStepsOfFriction = (Convert.ToInt32(numericUpDownTMax.Value) - Convert.ToInt32(numericUpDownTMin.Value)) / Convert.ToInt32(numericUpDownSBust.Value);
             countStepsOfWeight = (Convert.ToInt32(numericUpDownMMax.Value) - Convert.ToInt32(numericUpDownMMin.Value)) / Convert.ToInt32(numericUpDownSBust.Value);
             countStepsOfRigidity = (Convert.ToInt32(numericUpDownRMax.Value) - Convert.ToInt32(numericUpDownRMin.Value)) / Convert.ToInt32(numericUpDownSBust.Value);
            return countStepsOfSizeStep + countStepsOfFriction + countStepsOfWeight + countStepsOfRigidity;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            computePloatWithNecessaryParameters(0.1f, 1.8f, 5.0f, 0.2f);
            computePloatWithNecessaryParameters(0.2f, 2, 5, 0.2f);
            for (int i = 0; i < minPoints.Count; i++)
            {
                chart1.Series[0].Points.AddXY(minPoints.ElementAt(i).X, minPoints.ElementAt(i).Y);
            }

        }
    }
}
