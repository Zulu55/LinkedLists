using LinkedLists.Logic;
using System.ComponentModel.Design;

Console.WriteLine("¨*** Linked Lists ***");
var singleList = new SingleList<string>();

int option;
do
{
    option = Menu();
    switch (option)
    {
        case 1: AddItem(); break;
        case 2: ShowList(); break;
    }
} while (option != 0);

void ShowList()
{
    if (singleList.IsEmpty)
    {
        Console.WriteLine("The list is empty.");
        return;
    }
    Console.WriteLine("The elements are: ");
    Console.WriteLine(singleList);
}

void AddItem()
{
    Console.Write("Enter the item: ");
    var item = Console.ReadLine();
    singleList.Add(item!);
}

int Menu()
{
    Console.WriteLine("1. Add item.");
    Console.WriteLine("2. Show List.");
    Console.WriteLine("0. Exit.");
    Console.Write("Enter your choice: ");
    var option = Console.ReadLine();
    return Convert.ToInt32(option); 
}