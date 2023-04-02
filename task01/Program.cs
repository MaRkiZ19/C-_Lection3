/*Вид 1

void Metod1()
{
    System.Console.WriteLine("Автор Григоренко");
}
Metod1();*/


/*Вид2

void Metod2(string msg)
{
    System.Console.WriteLine(msg);
}
//Metod2("Текст сообщения");

void Metod21(string msg, int count)
{
    int i = 0;
    while (i<count)
    {
        System.Console.WriteLine(msg);
        i++;
    }
}
Metod21("Текст", 4);*/



//Вид3

/*int Metod3()
{
    return DataTime.Now.Year;
}

int year = Metod3();
System.Console.WriteLine(year);*/


//Вид4

/*string Metod4(int count, string text)
{
    int i =0;
    string result = String.Empty;
    while (i<count)
    {
        result = result +text;
        i++;
    }
    return result;
}

string res = Metod4(10, "u");
System.Console.WriteLine(res);*/


/* for

string Metod5(int count, string text)
{
    string result = String.Empty;
    for (int i =0; i<count; i++)
    {
        result = result +text;
    }
    return result;
}

string res = Metod5(10, "u");
System.Console.WriteLine(res);*/

// Цикл в Цикле

for (int i = 2; i <=10; i++)
{
    for (int j = 2; j <=10; j++)
    {
        System.Console.WriteLine($"{i}*{j}={i*j}");
    }
    System.Console.WriteLine();
}