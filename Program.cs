
void MassiveA(string[] stroke)  /* Метод заполнения массива */
{
    Console.WriteLine("Введите данные.");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("PS: Если хотите прекратить ввод, введите цифру 0,");
    Console.WriteLine("и остальная часть заполнится нулевыми значениями.");
    Console.ResetColor();
    string exit = "0";
    for (int count = 0; count < stroke.Length; count++)
    {
        string text = Console.ReadLine()!;
        if (text != exit)
        {
            stroke[count] = text;
        }
        else
        {
            for (; count < stroke.Length; count++)
            {
                text = "0";
                stroke[count] = text;
            }
        }
    }

}

void PrintMassive(string[] collect) /* Метод печати массива */
{
    int count = collect.Length;
    Console.Write($"[");
    for (int index = 0; index < count - 1; index++)
    {
        Console.Write($"{collect[index]}; ");
    }
    Console.Write($"{collect[count - 1]}]");
}

void MassiveB(string[] collectb)   /*  Метод печати 3х символьных значений */
{
    int control = 0;
    for (int count = 0; count < collectb.Length; count++)
    {
        string stroke = collectb[count];
        if (stroke.Length == 3)
        {
            Console.Write($" {collectb[count]} ");
            control++;
        }
    }
    if (control == 0)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write($" В заданном тексте, нет нужных данных! ");
        Console.ResetColor();
    }
}


Console.Clear();
Console.WriteLine($"Сколько элементов хотите проверить?");
int nums = int.Parse(Console.ReadLine()!);

string[] index = new string[nums];
MassiveA(index);
Console.Write($"Ваши вводные данные: ");
Console.ForegroundColor = ConsoleColor.DarkYellow;
PrintMassive(index);
Console.ResetColor();
Console.WriteLine();

Console.Write($"Посмотрите все данные, состоящие из 3 символов: ");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write("[");
MassiveB(index);
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write("]");
Console.ResetColor();
Console.WriteLine();

