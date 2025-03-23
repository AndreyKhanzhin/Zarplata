Random rand = new Random();
int[] zp = new int[12];

int sum = 0;
double pensia = 0;

for (int i = 0; i < zp.Length; i++){
    zp[i] = rand.Next(1000, 5000);
    Console.WriteLine($"Зарплата за {i + 1} месяц расчитана и равна — {zp[i]}");
}

Console.WriteLine("");

for (int i = 0; i < zp.Length; i++){
    Console.WriteLine($"Отчисление в пенсионный фонд за {i + 1} месяц — {Math.Round(zp[i] * 0.02, 2)} рублей.");
    sum += zp[i];
    pensia += zp[i] * 0.02;
}

Console.WriteLine("");
Console.WriteLine($"Общая сумма выплат за год — {sum}.");
Console.WriteLine($"Средняя зарплата за год — {sum / zp.Length}.");
Console.WriteLine($"Общая сумма выплат в пенсию — {pensia}.");
Console.WriteLine("");

for (int i = 0; i < zp.Length; i++){
    Console.WriteLine($"Отклонение от средней зарплаты в {i + 1} день — {Math.Abs(zp[i] - sum / zp.Length)}.");
}

Console.WriteLine($"Максимальная и минимальная зарплаты составляют {zp.Max()} и {zp.Min()} и принадлежат {Array.IndexOf(zp, zp.Max()) + 1} и {Array.IndexOf(zp, zp.Min()) + 1} месяцам соответственно.");