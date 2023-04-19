using LinkedLists.Logic;

Console.WriteLine("*** Linked Lists ***");
var fruits = new DoubleList<Fruit>();
fruits.Add(new Fruit { Name = "Naranja", Price = 5000 });
fruits.Add(new Fruit { Name = "Pera", Price = 4000 });
fruits.Add(new Fruit { Name = "Kiwy", Price = 6000 });
fruits.Add(new Fruit { Name = "Aguacate", Price = 4500 });
fruits.Add(new Fruit { Name = "Limón", Price = 1500 });

Console.WriteLine("List in order =>");
Console.WriteLine(fruits);
Console.WriteLine("List in inverted order =>");
Console.WriteLine(fruits.ToInvertedList());

Console.WriteLine("List converted to array =>");
var fruitsArray = fruits.ToArray();
foreach (var fruit in fruitsArray.OrderByDescending(fruit => fruit.Price))
{
    Console.WriteLine(fruit);
}


/*
var singleList = new SingleList<string>();
FillList();

void FillList()
{
    singleList.Add("a");
    singleList.Add("b");
    singleList.Add("c");
    singleList.Add("d");
    singleList.Add("e");
    singleList.Add("f");
    singleList.Add("g");
}

int option;
do
{
    option = Menu();
    switch (option)
    {
        case 1: AddItem(); break;
        case 2: ShowList(); break;
        case 3: RemoveItem(); break;
        case 4: InsertItem(); break;
    }
} while (option != 0);

void InsertItem()
{
    Console.Write("Enter the current item: ");
    var current = Console.ReadLine();
    Console.Write("Enter the new item: ");
    var item = Console.ReadLine();
    var result = singleList.Insert(current!, item!);
    if (result)
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.WriteLine("Item inserted.");
        Console.BackgroundColor = ConsoleColor.Black;
    }
    else
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("Item not found.");
        Console.BackgroundColor = ConsoleColor.Black;
    }
}

void RemoveItem()
{
    Console.Write("Enter the item: ");
    var item = Console.ReadLine();
    var result = singleList.Remove(item!);
    if (result)
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.WriteLine("Item removed.");
        Console.BackgroundColor = ConsoleColor.Black;
    }
    else
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("Item not found.");
        Console.BackgroundColor = ConsoleColor.Black;
    }
}

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
    Console.WriteLine("3. Remove item.");
    Console.WriteLine("4. Insert item.");
    Console.WriteLine("0. Exit.");
    Console.Write("Enter your choice: ");
    var option = Console.ReadLine();
    return Convert.ToInt32(option);
}
*/