Commands();
string[] array = new string[] {};

string fromUser = ReaderInput("Введите команнду: ");
switch (fromUser)
{
    case"1":
        array = new string[] { "Hello ", "2", "world ,", ":-)"};
        break;
    case "2":
        array = new string[] {"1234", "1567", "-2", "computer science"};
        break;
    case"3":
        array = new string[] {"Russia","Denmark", "kazan" };
        break;
    default:
        Console.WriteLine($"{fromUser} - Такой команды нет");
        break;
}


int LenNewArray = 0;
for (int i = 0; i <= array.Length - 1; i++)
{
    if (array[i].Length <= 3) LenNewArray++;
}

string[] newArray = new string[LenNewArray];
int idx = 0; 
for (int i = 0; i <= array.Length - 1; i++)

{
    if (array[i].Length <= 3)
    {   newArray[idx] = array[i];
       idx++; 
    }   
}   

PrintArray(array);
Console.Write("→ ");

// Фукция: Вывод команд для работы с программой
void Commands()
{
    Console.WriteLine();
    Console.WriteLine("СПИСОК КОМАНД:");
    Console.WriteLine("1 - использовать массив : ['Hello', '2','world', ':-)']");
    Console.WriteLine("2 - использовать массив : ['1234', '1567', '-2', 'computer science']");
    Console.WriteLine("3 – использовать массив: [“Russia”, “Denmark”, “Kazan”]");
    Console.WriteLine();
}

//Функция ввода
string ReaderInput(string msg)
{
    Console.Write(msg);
    return Console.ReadLine();
}


// Фукция вывода масива в терминал
void PrintArray(string[]array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)  
    {
        Console.Write($"'{array[i]}',");   
    }
    Console.WriteLine("] ");
}