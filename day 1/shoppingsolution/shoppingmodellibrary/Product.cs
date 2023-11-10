namespace shoppingmodellibrary
{
    public class product
    {
        public int Id {  get; set; }
        public string Name { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public float Price { get; set; }
        public string Picture { get; set; } = string.Empty;
        public string Description { get; set; }= string.Empty;
        public double Rating { get; set; }
        public float Discount { get; set; }
        public product()
        {
            Price = 0.0f;
            Discount = 0.5f;
            Quantity = 1;
            Rating = 0;
        }
        /// <summary>
        /// construct the product objects with the essential properties
        /// </summary>
        /// <param name="id">Product id</param>
        /// <param name="name">name of the product</param>
        /// <param name="quantity">quantity of the product</param>
        /// <param name="price"> price in rs</param>
        /// <param name="picture">picture of the product</param>
        /// <param name="description">about the product</param>
        /// <param name="rating">customer rating of the product</param>
        /// <param name="discount">discount given</param>

        public product(int id, string name, int quantity, float price, string picture, string description, double rating, float discount)
        {
            Id = id;
            Name = name;
            Quantity = quantity;
            Price = price;
            Picture = picture;
            Description = description;
            Rating = rating;
            Discount = discount;
        }
        public override string ToString()
        {
            float netPrice = Price - (Price * Discount / 100);
            return $"Product Id : {Id}\nProduct Name : {Name}\nProduct Price : Rs. {Price}\nProduct Quantity In Hand : {Quantity}" +
                $"\nDiscount offered : {Discount}%\nRating : {Rating}\nNet Price : {netPrice}";
        }
    }
}