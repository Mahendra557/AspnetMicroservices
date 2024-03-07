namespace Basket.API.Entities
{
    public class ShoppingCart
    {
        public string Username { get; set; }
        public List<ShoppingCartItem> Item { get; set; } = new List<ShoppingCartItem>();

        public ShoppingCart()
        {

        }

        public ShoppingCart(string username)
        {
            Username = username;
        }

        public decimal TotalPrice
        {
            get { 
                decimal totalPrice = 0;
                foreach (var item in Item)
                {
                    totalPrice = totalPrice + item.Price * item.Quantity;
                }
                return totalPrice;
            }
        }
    }
}
