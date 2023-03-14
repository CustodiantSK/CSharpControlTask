
void MassiveA(string[] stroke)  /* Метод заполнения массива */
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("PS: Если хотите прекратить ввод, введите цифру 0,");
    Console.WriteLine("и остальная часть заполнится нулевыми значениями.");
    Console.ResetColor();
    Console.WriteLine("Введите данные.");
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
        if (collect[index] == null)
        {
            break;
        }
        Console.Write($"{collect[index]}; ");
    }
    Console.Write($"{collect[count - 1]}]");
}

void MassiveB(string[] collectb)   /*  Метод печати 3х символьных значений */
{
    int control = 0;
    string exit = "0";
    for (int count = 0; count < collectb.Length; count++)
    {
        string stroke = collectb[count];
        if (stroke.Length <= 3)
        {
            if (stroke != exit)
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

Console.Write($"Альтернативное решение: ");
string[] tree = new string[nums];
int control = 0;

for (int count = 0; count < nums; count++)
{
    string exit = "0";
    {
        string stroke = index[count];
        if (stroke.Length <= 3)
        {
            if (stroke != exit)
            {
                tree[control] = index[count];
                control++;
            }
        }
    }
}
if (control == 0)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.Write($" В заданном тексте, нет нужных данных! ");
    Console.ResetColor();
}
Console.ForegroundColor = ConsoleColor.DarkGreen;
PrintMassive(tree);
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.ResetColor();
Console.WriteLine();
