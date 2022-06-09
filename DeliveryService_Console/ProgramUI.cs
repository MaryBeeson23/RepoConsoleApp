using DeliveryService_Repo;
public class ProgramUI
{
    public readonly Delivery _repo = new Delivery();

    public object OrderNum { get; private set; }
    public object Name { get; private set; }
    public object Quantity { get; private set; }
    public bool Scheduled { get; private set; }
    public bool EnRoute { get; private set; }
    public bool Delivered { get; private set; }

    public void Run()
    {
        Seed();
        
        RunMenu();
    }

    public void RunMenu()
    {
        bool continueToRun = true;
        do
        {
            Console.Clear();
            System.Console.WriteLine("Wanna cheack up on your delivery? Choose from the list\n" +
            "1. Create New Delivery.\n" +
            "2. Get one order, by name, from the list.\n" +
            "3. Get all orders on the list.\n" +
            "4. Cancel order.\n" +
            "5. Check Status.\n" +
            "6. Exit");

            string selection = Console.ReadLine();

            switch (selection)
            {
                case "1":
                AddNewOrder();
                break;
                case "2":
                GetOneOrder();
                break;
                case "3":
                GetAllOrders();
                break;
                case "4":
                DeleteOneOrder();
                break;
                case "5":
                CheckOrderStatus();
                break;
                case "6":
                System.Console.WriteLine("Toodles!!");
                continueToRun = false;
                break;
                default:
                System.Console.WriteLine("Please choose a valid selection.");
                WaitForKey();
                break;
            }
        } while (continueToRun);
    }

public void AddNewOrder()
{
    Console.Clear();

    Delivery newOrder = new Delivery();
    
    System.Console.WriteLine("Please write your name:");
    newOrder.Name = Console.ReadLine();

    System.Console.WriteLine("How many do you want?");
    newOrder.Quantity = Int32.Parse(Console.ReadLine());

if (_repo.Equals(newOrder))
{
    Console.Clear();
    System.Console.WriteLine($"Delivery {newOrder.Name} has been added.");
    } else {
        Console.Clear();
        System.Console.WriteLine("Issue creating your delivery, please try again.");
    }

    WaitForKey();
}

public void GetOneOrder()
{
    Console.Clear();
    System.Console.WriteLine("If you know the number on your order, please enter it below. If not, choose option 3 on the main menu to view all deliveres.");
    string orderNum = Console.ReadLine();

    Delivery item = _repo.ToString(orderNum);

    if(item == default)
    {
        System.Console.WriteLine("Item not found. Use option 3 to search all orders.");
    } else {
        System.Console.WriteLine($"---------- Delivery {item.OrderNum} ----------\n" +
        $"Ordered by: {item.Name}\n" +
        $"Got {item.Quantity} deliveries");
    }
    WaitForKey();
}

public void GetAllOrders()
    {
        Console.Clear();
        List<Delivery> orderList = _repo.OrderNum();

            foreach (Delivery order in orderList)
            {
                System.Console.WriteLine($"---------- Delivery {OrderNum} ----------\n" +
            $"Ordered by: {Name}\n" +
            $"Got {Quantity} deliveries");
            }
        
        WaitForKey();
    }

    private static int NewMethod()
    {
        return 0;
    }

    public void CheckOrderStatus()
{
    Console.Clear();
    System.Console.WriteLine("Enter your order number to check order status.");
    string orderNum = Console.ReadLine();
    bool StatusType = _repo.CheckOrderStatus(orderNum);
    if (Scheduled)
    {
        System.Console.WriteLine("Order has been scheduled");
    } else if (EnRoute)
    {
        System.Console.WriteLine("Order is on its way.");
    } else if (Delivered)
    {
        System.Console.WriteLine("Did you check your doorstep? its delivered!");
    } else {
        System.Console.WriteLine("Order Canceled");
    }
}

public void DeleteOneOrder()
{
    Console.Clear();
    System.Console.WriteLine("Find the order you want to cancel by order number");
    string orderNum = Console.ReadLine();

    bool isSuccess = _repo.RemoveOrderFromList(orderNum);

    if (isSuccess)
    {
        System.Console.WriteLine("Order cancelled");
    } else {
        System.Console.WriteLine("Could not cancel our order. Verify order number and try again.");
    }
    
    WaitForKey();
}





    private void WaitForKey()
    {
        System.Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    private void Seed()
    {
        Delivery randoComando = new Delivery("Dan the Man", 32, StatusType.Complete);
        Delivery gumdropButtons = new Delivery("Gingy", 1, StatusType.EnRoute);
        Delivery antInPants = new Delivery("Itchy Bum", 666, StatusType.Scheduled);
        Delivery idekAnymore = new Delivery("Bob", 74, StatusType.Cancelled);

        _repo.AddOrderToList(randoComando);
        _repo.AddOrderToList(gumdropButtons);
        _repo.AddOrderToList(antInPants);
        _repo.AddOrderToList(idekAnymore);   
    }
}



