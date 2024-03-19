// 輸出星期
Console.WriteLine($"日\t一\t二\t三\t四\t五\t六");

// 計算當月第一天的星期
DateTime firstDayOfMonth = new DateTime(2024, 3, 1);
int firstDayOfWeek = (int)firstDayOfMonth.DayOfWeek;

// 計算當月的天數
int daysInMonth = DateTime.DaysInMonth(2024, 3);

// 輸出月曆內容
for (int i = 0; i < firstDayOfWeek; i = i + 1)
{
    Console.Write("\t"); // 填充空白
}

for (int day = 1; day <= daysInMonth; day = day + 1)
{
    Console.Write(day);
    if ((firstDayOfWeek + day) % 7 == 0)
    {
        Console.WriteLine();
    }
    else
    {
        Console.Write("\t");
    }
}