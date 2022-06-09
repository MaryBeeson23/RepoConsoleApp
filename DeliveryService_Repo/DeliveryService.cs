
namespace DeliveryService_Repo;
public class Delivery
{
   /* 
   public Delivery()
    {

    }
    */
    
    public Delivery (string customerName, int quantityAmt, DateTime dayOfOrder, DateTime dayDelivered, StatusType orderStatus)
    {
        Name = customerName;
        Quantity = quantityAmt;
        OrderDate = dayOfOrder;
        DeliveryDate = dayDelivered;
        OrderStatus = orderStatus;
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
    


}
public enum StatusType {
    Scheduled,
    EnRoute,
    Complete,
    Cancelled
}