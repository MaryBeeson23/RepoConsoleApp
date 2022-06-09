
namespace DeliveryService_Repo;

public class NewBaseType
{
    public List<Delivery> OrderNum()
    {
        throw new NotImplementedException();
    }
}

public class Delivery : NewBaseType
{
   
   public Delivery()
    {

    }
    
    
    public Delivery (string customerName, int quantityAmt, DateTime dayOfOrder, DateTime dayDelivered, StatusType orderStatus)
    {
        Name = customerName;
        Quantity = quantityAmt;
        OrderDate = dayOfOrder;
        DeliveryDate = dayDelivered;
        OrderStatus = orderStatus;
    }

    public Delivery(string v1, int v2, StatusType complete)
    {
    }

    //customer id
    public string Name {get; set; }

    //order number
    public string OrderNum {get {
        Random ranNum = new Random();
        return $"{Name[0]}-{ranNum.Next()}";
    } }

    
    //item quantity
    public int Quantity {get; set; }

    //Order date
    public DateTime OrderDate {get; set; }
   
    //delivery date
    public DateTime DeliveryDate {get; set; }
    
    //order status ( Scheduled, En route, complete, or cancelled)
    //use if else statement? or switch case?
    //possibly use bool?
    public StatusType OrderStatus {get; set; }
    public bool CheckMyOrder {
        get {
            switch (OrderStatus)
                {
                    case StatusType.Scheduled:
                    case StatusType.EnRoute:
                    case StatusType.Complete:
                        return true;
                    default:
                        return false;
                }
        }
    }

    public Delivery ToString(string orderNum)
    {
        throw new NotImplementedException();
    }

    public bool CheckOrderStatus(string orderNum)
    {
        throw new NotImplementedException();
    }

    public bool RemoveOrderFromList(string orderNum)
    {
        throw new NotImplementedException();
    }

    public void AddOrderToList(Delivery randoComando)
    {
       // throw new NotImplementedException();
    }
}
public enum StatusType {
    Scheduled,
    EnRoute,
    Complete,
    Cancelled
}