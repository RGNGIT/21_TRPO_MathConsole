﻿namespace _21_TRPO_MathConsole
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
            MathNormalHelper.SetupNormalTables();
            MathExponentialHelper.SetupExpTables();
            chartNormal.Series.Clear();
            chartExp.Series.Clear();
            chart1.Series.Clear();
            chartNormal.Series.Add("Нормальный");
            chartExp.Series.Add("Экспоненциальный");
            chart1.Series.Add("Общий");
            chart1.Series["Общий"].Color = Color.Black;
            chartNormal.ChartAreas[0].AxisY.Interval = 1;
            chartExp.ChartAreas[0].AxisY.Interval = 1;
            chart1.ChartAreas[0].AxisY.Interval = 2;
        }

        List<double> normals = new List<double>();
        List<double> exps = new List<double>();

        List<double> normalgram = new List<double>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        List<double> expgram = new List<double>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        List<double> commongram = new List<double> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        List<double> divgram = new List<double>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        double normalsum = 0;
        double expsum = 0;
        double normalavg;
        double expavg;

        double NormalDiv(double elem)
        {
            normalsum += elem;
            if (elem >= 0 && elem <= 2)
            {
                normalgram[0]++;
            }
            if (elem > 2 && elem <= 4)
            {
                normalgram[1]++;
            }
            if (elem > 4 && elem <= 6)
            {
                normalgram[2]++;
            }
            if (elem > 6 && elem <= 8)
            {
                normalgram[3]++;
            }
            if (elem > 8 && elem <= 10)
            {
                normalgram[4]++;
            }
            if (elem > 10 && elem <= 12)
            {
                normalgram[5]++;
            }
            if (elem > 12 && elem <= 14)
            {
                normalgram[6]++;
            }
            if (elem > 14 && elem <= 16)
            {
                normalgram[7]++;
            }
            if (elem > 16 && elem <= 18)
            {
                normalgram[8]++;
            }
            if (elem > 18 && elem <= 20)
            {
                normalgram[9]++;
            }
            return elem;
        }

        double ExpDiv(double elem)
        {
            expsum += elem;
            if (elem >= 0 && elem <= 0.2)
            {
                expgram[0]++;
            }
            if (elem > 0.2 && elem <= 0.4)
            {
                expgram[1]++;
            }
            if (elem > 0.4 && elem <= 0.6)
            {
                expgram[2]++;
            }
            if (elem > 0.6 && elem <= 0.8)
            {
                expgram[3]++;
            }
            if (elem > 0.8 && elem <= 1)
            {
                expgram[4]++;
            }
            if (elem > 1 && elem <= 1.2)
            {
                expgram[5]++;
            }
            if (elem > 1.2 && elem <= 1.4)
            {
                expgram[6]++;
            }
            if (elem > 1.4 && elem <= 1.6)
            {
                expgram[7]++;
            }
            if (elem > 1.6 && elem <= 1.8)
            {
                expgram[8]++;
            }
            if (elem > 1.8 && elem <= 2)
            {
                expgram[9]++;
            }
            return elem;
        }

        double NormalDispersion()
        {
            for (int i = 0; i < normals.Count; i++)
            {
                normals[i] -= normalavg;
            }
            for (int i = 0; i < normals.Count; i++)
            {
                normals[i] = Math.Pow(normals[i], 2);
            }
            double sum = 0;
            foreach (int i in normals)
            {
                sum += i;
            }
            return sum / (normals.Count - 1);
        }

        double ExpDispersion()
        {
            for (int i = 0; i < exps.Count; i++)
            {
                exps[i] -= expavg;
            }
            for (int i = 0; i < exps.Count; i++)
            {
                exps[i] = Math.Pow(exps[i], 2);
            }
            double sum = 0;
            foreach (int i in exps)
            {
                sum += i;
            }
            return sum / (exps.Count - 1);
        }

        string FindMinMax()
        {
            double min = normals[0];
            double max = exps[expgram.Count - 1];
            foreach (double i in normals)
            {
                if (i > max)
                {
                    max = i;
                }
                if (i < min)
                {
                    min = i;
                }
            }
            foreach (double i in exps)
            {
                if (i > max)
                {
                    max = i;
                }
                if (i < min)
                {
                    min = i;
                }
            }
            return $"{min}/{max}";
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Visible = false;
            for (int i = 0; i < 20; i++)
            {
                double res = NormalDiv(MathNormalHelper.Normal(4, 5));
                normals.Add(res);
                dataGridViewNormal.Rows.Add(res);
            }
            for (int i = 0; i < 80; i++)
            {
                double res = ExpDiv(MathExponentialHelper.Exponential(3));
                exps.Add(res);
                dataGridViewExp.Rows.Add(res);
            }
            chartNormal.Series["Нормальный"].Points.DataBindXY(divgram.ToArray(), normalgram.ToArray());
            chartExp.Series["Экспоненциальный"].Points.DataBindXY(divgram.ToArray(), expgram.ToArray());
            normals.Sort();
            exps.Sort();
            string[] minmax = FindMinMax().Split('/');
            double min = double.Parse(minmax[0]);
            double max = double.Parse(minmax[1]);
            double step = (max - min) / 10;
            int multiplier = 0;
            foreach(double val in normals)
            {
                dataGridViewCommon.Rows.Add(val);
            }
            foreach(double val in exps) 
            {
                dataGridViewCommon.Rows.Add(val);
            }
            for (int i = 0; i < 10; i++)
            {
                foreach (double j in normals)
                {
                    if ((j >= (step * multiplier)) && (j <= (step * (multiplier + 1))))
                    {
                        commongram[i]++;
                    }
                }
                multiplier++;
            }
            multiplier = 0;
            for (int i = 0; i < 10; i++)
            {
                foreach (double j in exps)
                {
                    if ((j >= (step * multiplier)) && (j <= (step * (multiplier + 1))))
                    {
                        commongram[i]++;
                    }
                }
                multiplier++;
            }
            chart1.Series["Общий"].Points.DataBindXY(divgram.ToArray(), commongram.ToArray());
            normalavg = normalsum / 20;
            expavg = expsum / 80;
            labelResult.Text = $"Среднее значение нормального распределения: {normalavg}\n" +
            $"Среднее значение экспоненциального распределения: {expavg}\n" +
            $"Дисперсия нормального распределения: {NormalDispersion()}\n" +
            $"Дисперсия экспоненциального распределения: {ExpDispersion()}";
        }
    }
}