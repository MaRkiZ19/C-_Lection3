﻿//Вид 1
void Metod1()
{
    System.Console.WriteLine("Автор Григоренко");
}
/*Metod1();*/


//Вид2
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
//Metod21("Текст", 4);



//Вид3

int Metod3()
{
    return DataTime.Now.Year;
}

int year = Metod3();
System.Console.WriteLine(year);