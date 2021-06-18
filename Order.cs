namespace SfDataGridDemo
{
    public class OrderInfo
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string Country { get; set; }
        public string ShipCity { get; set; }

        public OrderInfo(int orderId, string customerName, string country, string customerId, string shipCity)
        {
            OrderID = orderId;
            CustomerName = customerName;
            Country = country;
            CustomerID = customerId;
            ShipCity = shipCity;
        }
    }
}
