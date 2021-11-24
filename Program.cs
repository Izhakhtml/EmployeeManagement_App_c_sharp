// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using EmployeeManagementApp;

//developer1.firstName = "izhak";
//developer1.lastNme = "lijalem";
//developer1.age = 30;
//Console.WriteLine(developer1);
//developer1.firstName = Console.ReadLine();
//developer1.lastNme = Console.ReadLine();
//developer1.age = int.Parse(Console.ReadLine());
//int i = 0;
//while (i < 5)
//{
//    new Developer();
//}

//Teem[] arrayTeem = new Teem[5]; 
Developer[] arrayDeveloper = new Developer[5];

//int i = 0;
//    while (i < 5)
//    {
//    //arrayTeem[i].devel1.firstName = Console.ReadLine();
//    //arrayTeem[i].devel1.lastNme = Console.ReadLine();
//    //arrayTeem[i].devel1.age = int.Parse(Console.ReadLine());
//    Console.WriteLine("enter first name");
//    arrayDeveloper[i].firstName = Console.ReadLine();
//    Console.WriteLine("enter last name");
//    arrayDeveloper[i].lastNme = Console.ReadLine();
//    Console.WriteLine("enter age");
//    arrayDeveloper[i].age = int.Parse(Console.ReadLine());
//    i++;
//    }

//Console.WriteLine("ALl DEVELOPERS DETAILS");
//int x = 0;
//while (x < arrayDeveloper.Length)
//{
//    //Console.WriteLine(arrayTeem[0].devel1.firstName);
//    //Console.WriteLine(arrayTeem[0].devel1.lastNme);
//    //Console.WriteLine(arrayTeem[0].devel1.age);
//    Console.WriteLine($"{x}.Developer name: {arrayDeveloper[x].firstName}");
//    Console.WriteLine($"{x}.Developer lName: {arrayDeveloper[x].lastNme}");
//    Console.WriteLine($"{x}.Developer age: {arrayDeveloper[x].age}");

//    x++;
//}

Teem array = new Teem();

//array.array[0].firstName = "";
int i = 0;
while (i < 5)
{
    //arrayTeem[i].devel1.firstName = Console.ReadLine();
    //arrayTeem[i].devel1.lastNme = Console.ReadLine();
    //arrayTeem[i].devel1.age = int.Parse(Console.ReadLine());
    Console.WriteLine("enter first name");
    array.array[i].firstName = Console.ReadLine();
    Console.WriteLine("enter last name");
    array.array[i].lastNme = Console.ReadLine();
    Console.WriteLine("enter age");
    array.array[i].age = int.Parse(Console.ReadLine());
    i++;
}

int x = 0;
while (x < array.array.Length)
{
    //Console.WriteLine(arrayTeem[0].devel1.firstName);
    //Console.WriteLine(arrayTeem[0].devel1.lastNme);
    //Console.WriteLine(arrayTeem[0].devel1.age);
    Console.WriteLine($"{x}.Developer name: {array.array[x].firstName}");
    Console.WriteLine($"{x}.Developer lName: {array.array[x].lastNme}");
    Console.WriteLine($"{x}.Developer age: {array.array[x].age}");

    x++;
}












