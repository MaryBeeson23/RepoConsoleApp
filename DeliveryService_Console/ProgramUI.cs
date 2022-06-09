using DeliveryService_Repo;
public class ProgramUI
{
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

            string? selection = Console.ReadLine();

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
    newDelivery.CustomerName = Console.ReadLine();

    System.Console.WriteLine("How many do you want?");
    newDelivery.Quantity = Console.ReadLine();

if (Repo.AddNewOrder(newOrder))
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
    string? orderNum = Console.ReadLine();

    Delivery item = _repo.GetOneDeliveryFromList(orderNum);

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
    List<Delivery> orderList = _repo.GetList();

    if(orderList < 1)
    (
        System.Console.WriteLine("There are no orders to see here. Use option one to create a new order.");
    ) else {
        foreach (Delivery order in orderList)
        {
            System.Console.WriteLine($"---------- Delivery {item.OrderNum} ----------\n" +
        $"Ordered by: {item.Name}\n" +
        $"Got {item.Quantity} deliveries");
        }
    }
    WaitForKey();
}

    public void CheckOrderStatus()
{
    Console.Clear();
    System.Console.WriteLine("Enter your order number to check order status.");
    string orderNum = Console.ReadLine();
    bool StatusType = _repo.CheckMyOrderStatus(orderNum);
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
        throw new NotImplementedException();
    }
}


/*internal class newDelivery
{
    internal static string? CustomerName;
    internal static int? Quantity;
}*/