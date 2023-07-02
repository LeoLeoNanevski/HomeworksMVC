namespace SEDC.PizzaApp.ViewModels
{
    public class OrderDetailsViewModel
    {
        public string UserFullName { get; set; }
        public string PizzaName { get; set; }
        public decimal OrderPrice { get; set; }
        public string PaymentMethod { get; set; }

        public string UserAddress { get; set; }

    }
}
