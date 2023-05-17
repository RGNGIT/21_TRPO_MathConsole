namespace _21_TRPO_MathConsole
{
    internal static class MathExponentialHelper
    {
        static double[] stairWidth = new double[257];
        static double[] stairHeigh = new double[256];
        static double x1 = 7.69711747013104972;
        static double A = 3.9496598225815571993e-3;

        public static void SetupExpTables()
        {
            stairHeigh[0] = Math.Exp(-x1);
            stairWidth[0] = A / stairHeigh[0];
            stairWidth[256] = 0;
            for (int i = 1; i <= 255; i++)
            {
                stairWidth[i] = -Math.Log(stairHeigh[i - 1]);
                stairHeigh[i] = stairHeigh[i - 1] + A / stairWidth[i];
            }
        }

        static long LongRandom(long min, long max, Random rand)
        {
            long result = rand.Next((Int32)(min >> 32), (Int32)(max >> 32));
            result = (result << 32);
            result = result | (long)rand.Next((Int32)min, (Int32)max);
            return result;
        }

        static double Uniform(double one, double two)
        {
            Random rand = new Random();
            return one + rand.NextDouble() * (two - one);
        }

        static double ExpZiggurat()
        {
            int iter = 0;
            do
            {
                long stairId = LongRandom(100000000000000000, 100000000000000050, new Random()) & 255;
                double x = Uniform(0, stairWidth[stairId]);
                if (x < stairWidth[stairId + 1])
                {
                    return x;
                }
                if (stairId == 0)
                {
                    return x1 + ExpZiggurat();
                }
                if (Uniform(stairHeigh[stairId - 1], stairHeigh[stairId]) < Math.Exp(-x))
                {
                    return x;
                }
            } while (++iter <= 1e9);
            return double.NaN;
        }

        public static double Exponential(double rate)
        {
            return ExpZiggurat() / rate;
        }
    }

    internal static class MathNormalHelper
    {
        static double[] stairWidth = new double[257];
        static double[] stairHeigh = new double[256];
        static double x1 = 3.6541528853610088;
        static double A = 4.92867323399e-3;

        public static void SetupNormalTables()
        {
            stairHeigh[0] = Math.Exp(-.5 * x1 * x1);
            stairWidth[0] = A / stairHeigh[0];
            stairWidth[256] = 0;
            for (int i = 1; i <= 255; i++)
            {
                stairWidth[i] = Math.Sqrt(-2 * Math.Log(stairHeigh[i - 1]));
                stairHeigh[i] = stairHeigh[i - 1] + A / stairWidth[i];
            }
        }

        static long LongRandom(long min, long max, Random rand)
        {
            long result = rand.Next((Int32)(min >> 32), (Int32)(max >> 32));
            result = (result << 32);
            result = result | (long)rand.Next((Int32)min, (Int32)max);
            return result;
        }

        static double Uniform(double one, double two)
        {
            Random rand = new Random();
            return one + rand.NextDouble() * (two - one);
        }

        static double NormalZiggurat()
        {
            int iter = 0;
            do
            {
                long B = LongRandom(100000000000000000, 100000000000000050, new Random());
                long stairId = B & 255;
                double x = Uniform(0, stairWidth[stairId]);
                if (x < stairWidth[stairId + 1])
                {
                    return B > 0 ? x : -x;
                }
                if (stairId == 0)
                {
                    double z = -1;
                    double y;
                    if (z > 0)
                    {
                        x = MathExponentialHelper.Exponential(x1);
                        z -= 0.5 * x * x;
                    }
                    if (z <= 0)
                    {
                        do
                        {
                            x = MathExponentialHelper.Exponential(x1);
                            y = MathExponentialHelper.Exponential(1);
                            z = y - 0.5 * x * x;
                        }
                        while (z <= 0);
                    }
                    x += x1;
                    return B > 0 ? x : -x;
                }
                if (Uniform(stairHeigh[stairId - 1], stairHeigh[stairId]) < Math.Exp(-.5 * x * x))
                {
                    return B > 0 ? x : -x;
                }
            }
            while (++iter <= 1e9);
            return double.NaN;
        }

        public static double Normal(double mu, double sigma)
        {
            return mu + NormalZiggurat() * sigma;
        }
    }
}
