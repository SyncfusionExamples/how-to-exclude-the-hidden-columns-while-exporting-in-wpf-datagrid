using System.Collections.ObjectModel;

namespace SfDataGridDemo
{
    public class ViewModel
    {
        public ObservableCollection<OrderInfo> Orders { get; set; }
        public ObservableCollection<Customer> Customers { get; set; }
        public bool HideName { get; set; }

        public ViewModel()
        {
            Orders = new ObservableCollection<OrderInfo>();
            Customers = new ObservableCollection<Customer>();
            GenerateCustomers();
            GenerateOrders();

            HideName = true;
        }

        private void GenerateCustomers()
        {
            Customers.Add(new Customer("ALFKI", "Maria Anders"));
            Customers.Add(new Customer("ANATR", "Ana Trujilo"));
            Customers.Add(new Customer("ANTON", "Antonio Moreno"));
            Customers.Add(new Customer("AROUT", "Thomas Hardy"));
            Customers.Add(new Customer("BERGS", "Christina Berglund"));
            Customers.Add(new Customer("BLAUS", "Hanna Moos"));
            Customers.Add(new Customer("BLONP", "Frederique Citeaux"));
            Customers.Add(new Customer("BOLID", "Martin Sommer"));
            Customers.Add(new Customer("BONAP", "Laurence Lebihan"));
            Customers.Add(new Customer("BOTTM", "Elizabeth Lincoln"));
        }

        private void GenerateOrders()
        {
            Orders.Add(new OrderInfo(1001, "Maria Anders", "Germany", "ALFKI", "Berlin"));
            Orders.Add(new OrderInfo(1002, "Ana Trujilo", "Mexico", "ANATR", "Mexico D.F."));
            Orders.Add(new OrderInfo(1003, "Antonio Moreno", "Mexico", "ANTON", "Mexico D.F."));
            Orders.Add(new OrderInfo(1004, "Thomas Hardy", "UK", "AROUT", "London"));
            Orders.Add(new OrderInfo(1005, "Christina Berglund", "Sweden", "BERGS", "Lula"));
            Orders.Add(new OrderInfo(1006, "Hanna Moos", "Germany", "BLAUS", "Mannheim"));
            Orders.Add(new OrderInfo(1007, "Frederique Citeaux", "France", "BLONP", "Strasbourg"));
            Orders.Add(new OrderInfo(1008, "Martin Sommer", "Spain", "BOLID", "Madrid"));
            Orders.Add(new OrderInfo(1009, "Laurence Lebihan", "France", "BONAP", "Marseille"));
            Orders.Add(new OrderInfo(1010, "Elizabeth Lincoln", "Canada", "BOTTM", "Tsawassen"));
        }
    }
}
