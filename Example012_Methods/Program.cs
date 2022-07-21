// ВИД 1

void Method1()
{
    Console.WriteLine("Привет!");
}

// Method1();


// ВИД 2

void Method2a(string msg)
{
    Console.WriteLine(msg);
}

// Method2a("Привет, Алена!");


void Method2b(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

// Method2b("Привет, Алена!", 3);
// ИЛИ
// Method2b(count: 3, msg: "Как твои дела?");


// ВИД 3

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
// Console.WriteLine(year);


// ВИД 4

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result += text;
        i++;
    }
    return result;
}

string result4a = Method4(10, "z ");
// Console.WriteLine(result4a);


// ЦИКЛ for

string MethodFor(int count, string text)
{
    string result = String.Empty;

    for (int i = 0; i < count; i++)
    {
        result += text;
    }
    return result;
}

string result4b = MethodFor(10, "x ");
//Console.WriteLine(result4b);


// ЦИКЛ В ЦИКЛЕ
/*
for (int i = 2; i < 10; i++)
{
    for (int j = 2; j < 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}
*/


/* 
ЗАДАЧА 1
Дан текст. В тексте нужно все пробелы заменить черточками, маленькие буквы “к” заменить большими “К”, 
а большие “С” заменить маленькими “с”.
*/

string textWarAndPeace = "— Я думаю, — сказал князь, улыбаясь, — что, "
                       + "ежели бы вас послали вместо нашего милого Винценгероде, " 
                       + "вы бы взяли приступом согласие прусского короля. " 
                       + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;

    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result += $"{newValue}";
        else result += $"{text[i]}";
    }

    return result;
}
/*
string newText = Replace(textWarAndPeace, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);
Console.WriteLine();
*/


/*
ЗАДАЧА 2
Отсортировать массив из чисел.
*/

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);

SelectionSort(arr);
PrintArray(arr);
