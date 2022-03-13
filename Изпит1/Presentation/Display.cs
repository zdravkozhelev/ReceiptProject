using System;

public class Display
{
    public Display()
    {
        Input();
    }
    

    ReceiptController reciepController = new ReceiptController();
    private int closeOperationId = 6;
    private void ShowMenu()
    {
        Console.WriteLine(new string('-', 40));
        Console.WriteLine(new string(' ', 18) + "Me");
        Console.WriteLine(new string('-',40));
        Console.WriteLine("1. Listall entries");
        Console.WriteLine("2. Add new entry");
        Console.WriteLine("3. Update entry");
        Console.WriteLine("4. Fetch entry by ID");
        Console.WriteLine("5. Delete entry by ID");
        Console.WriteLine("6. Exit");




    }
    public void Input() 
    {
        var operation = -1;

        do
        {
            ShowMenu();
            operation = int.Parse(Console.ReadLine());
            switch (operation)
            {
                case 1:
                    ListAll();
                    break;
                case 2:
                    Add();
                    break;
                case 3:
                    Update();
                    break;
                case 4:
                    Fetch();
                    break;
                case 5:
                    Delete();
                    break;
                default:
                    break;


            }
        } while (operation != closeOperationId);
    }
    private void Add() 
    {
        Receipts receipt = new Receipts();
        Console.WriteLine("Enter name: ");
        receipt.Name = Console.ReadLine();
        Console.WriteLine("Enter stock: ");
        receipt.Stock = int.Parse(Console.ReadLine());
        reciepController.Add(receipt);
    }
    public void ListAll() 
    {
        Console.WriteLine(new string('-', 40));
        Console.WriteLine(new string('-', 16)+"PRODUCTS"+new string(' ', 16));
        Console.WriteLine(new string('-', 40));
        var products = reciepController.GetAll();
        foreach (var item in products) 
        {
            Console.WriteLine("{0} {1} {2} {3}", item.Id, item.Name, item.Price, item.Stock);
        }
    }
    private void Update() 
    {
        Console.WriteLine("Enter ID to update: ");
        int id = int.Parse(Console.ReadLine());
        Receipts receipt = reciepController.Get(id);
        if (receipt!= null)
        {
            Console.WriteLine("Enter name: ");
            receipt.Name = Console.ReadLine();
            Console.WriteLine("Enter price: ");
            receipt.Price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter stock: ");
            receipt.Stock = int.Parse(Console.ReadLine());
            reciepController.Update(receipt);

        }
        else 
        {
            Console.WriteLine("receipt not found!");
        }
    }
    private void Fetch() 
    {
        Console.WriteLine("Enter ID to fetch: ");
        int id = int.Parse(Console.ReadLine());
        Receipts receipt = reciepController.Get(id);
        if (receipt!=null)
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Id: "+receipt.Id);
            Console.WriteLine("Name: "+receipt.Name);
            Console.WriteLine("Price: " + receipt.Price);
            Console.WriteLine("Stock: " + receipt.Stock);
            Console.WriteLine(new string('-', 40));


        }

    }
    private void Delete() 
    {
        Console.WriteLine("Enter ID to delete:");
        int id = int.Parse(Console.ReadLine());
        reciepController.Delete(id);
        Console.WriteLine("Done");
    }
}
