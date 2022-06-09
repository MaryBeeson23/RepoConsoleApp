using xunit;
using DeliveryService_Repo;

namespace DeliveryService_Tests;

public class UnitTest1
{
    [Fact]
    public void IsAddToOrderListSuccess()
    {
        Delivery antsInPants = new Delivery("Itchy Bum", 666, StatusType.Scheduled);
        OrderRepo repo = new OrderRepo();

        bool isAddOrderSuccess = repo.AddOrderToList(antsInPants);

    }
}