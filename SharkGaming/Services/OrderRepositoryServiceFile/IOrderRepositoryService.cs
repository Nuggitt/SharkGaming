namespace SharkGaming.Services.OrderRepositoryServiceFile
{
    public interface IOrderRepositoryService
    {
        public void CreateOrder();

        public void ReadOrder();

        public void UpdateOrder();

        public void DeleteOrder();

        public void AddOrderItemToOrderList();

        public double CalculateTotalPrice();




    }
}
