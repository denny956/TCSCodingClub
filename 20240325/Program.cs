// 輸出星期
Console.WriteLine($"日\t一\t二\t三\t四\t五\t六");

// 計算當月第一天的星期
DateTime firstDayOfMonth = new DateTime(2024, 3, 1);
int firstDayOfWeek = (int)firstDayOfMonth.DayOfWeek;

// 填充空白
for (int space = 1; space <= firstDayOfWeek; space = space + 1)
{
    Console.Write("\t");
}

// 輸出月曆內容
for (int i = 1; i <= 31; i = i + 1)
{
    Console.Write(i);
    if ((5 + i) % 7 == 0)
    {
        Console.WriteLine(); // 每週最後一天要換一行
    }
    else
    {
        Console.Write("\t"); // 不用換行的填充空白
    }
}