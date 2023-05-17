using _21_TRPO_MathConsole;
using System.Runtime.Serialization;

MathNormalHelper.SetupNormalTables();
MathExponentialHelper.SetupExpTables();

List<double> normals = new List<double>();
List<double> exps = new List<double>();

List<int> normalgram = new List<int>() 
{
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0
};
List<int> expgram = new List<int>()
{
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0
};

double normalsum = 0;
double expsum = 0;
double normalavg;
double expavg;

double NormalDiv(double elem)
{
    normalsum += elem;
    if(elem >= 0 && elem <= 2)
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

string BuildLines(int value)
{
    string temp = "[";
    for(int i = 0; i < value; i++)
    {
        temp += "-";
    }
    temp += "]";
    return temp;
}

double NormalDispersion()
{
    for(int i = 0; i < normals.Count; i++)
    {
        normals[i] -= normalavg;
    }
    for (int i = 0; i < normals.Count; i++)
    {
        normals[i] = Math.Pow(normals[i], 2);
    }
    double sum = 0;
    foreach(int i in normals) 
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


Console.WriteLine("Нормальное распределение");
for (int i = 0; i < 20; i++)
{
    double res = NormalDiv(MathNormalHelper.Normal(4, 5));
    normals.Add(res);
    Console.WriteLine(res);
}
Console.WriteLine();
Console.WriteLine("Экспоненциальное распределение");
for (int i = 0; i < 80; i++)
{
    double res = ExpDiv(MathExponentialHelper.Exponential(3));
    exps.Add(res);
    Console.WriteLine(res);
}
Console.WriteLine("Диаграмма нормального распределения");
foreach (int value in normalgram)
{
    Console.WriteLine(BuildLines(value));
}
Console.WriteLine("Диаграмма экспоненциального распределения");
foreach (int value in expgram)
{
    Console.WriteLine(BuildLines(value));
}
normalavg = normalsum / 20;
expavg = expsum / 80;
Console.WriteLine($"Среднее значение нормального распределения: {normalavg}");
Console.WriteLine($"Среднее значение экспоненциального распределения: {expavg}");
Console.WriteLine($"Дисперсия нормального распределения: {NormalDispersion()}");
Console.WriteLine($"Дисперсия экспоненциального распределения: {ExpDispersion()}");