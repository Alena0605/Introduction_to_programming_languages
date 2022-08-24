// Console.WriteLine("Hello, World!");


// ЛЕКЦИЯ 7 - РЕКУРСИЯ


// ЗАДАЧА 1: Вывести дату создания папки и показать файлы внутри этой папки.
string path = @"вставить путь к папке";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);

FileInfo[] fi = di.GetFiles();
for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}


// ЗАДАЧА 2: Вывести все содержимое какой-либо папки.
void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);
    
    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + "  ");
    }

    FileInfo[] files = catalog.GetFiles();
    for (int j = 0; j < files.Length; j++)
    {
        Console.WriteLine($"{indent}{files[j].Name}");
    }
}

string path2 = @"вставить путь к папке"; 
CatalogInfo(path2);


// ЗАДАЧА 3: Игра "пирамидка".
void Towers(string with = "1", string on = "3", string some = "2", int count = 4)
{
    if (count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");

    if (count > 1) Towers(some, on, with, count - 1);
}

Towers();
