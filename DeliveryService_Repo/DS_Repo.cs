namespace DeliveryService_Repo
{
    public class DS_Repo
    {
        public readonly List<Delivery> _orderDirectory = new List<Delivery>();

        //create
        public void AddDeliveryToDirectory(Delivery delivery)
        {
            _orderDirectory.Add(delivery);
        }

        //read
        public List<Delivery> GetAllDelivery()
        {
            return _orderDirectory;
        }

        public Delivery GetDeliveryByName(string Name)
        {
            return _orderDirectory.Find(order => order.Name.ToLower() == Name.ToLower());
        }

        public bool UpdateExistingDelivery(string originalName, Delivery newDelivery)
        {
            Delivery deliveryToUpdate = GetDeliveryByName(originalName);
            if (deliveryToUpdate != default)
            {
                deliveryToUpdate.Name = newDelivery.Name;
                deliveryToUpdate.Quantity = newDelivery.Quantity;
                deliveryToUpdate.OrderDate = newDelivery.OrderDate;
                deliveryToUpdate.DeliveryDate = newDelivery.DeliveryDate;
                deliveryToUpdate.OrderStatus = newDelivery.OrderStatus;
                return true;
            } else {
                return false;
            }
        }

        //delete
        public bool DeleteExistingDelivery(string name)
        {
            Delivery deliveryToDelete = GetDeliveryByName(name);
            if (deliveryToDelete != default)
            {
                return _orderDirectory.Remove(deliveryToDelete);
            } else {
                return false;
            }
        }
    }
}