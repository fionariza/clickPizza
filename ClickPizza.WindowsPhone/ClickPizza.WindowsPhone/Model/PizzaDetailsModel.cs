namespace ClickPizza.WindowsPhone.Model
{
    public class PizzaDetailsModel
    {
        public   PizzaDetailsModel()
        { }

        public PizzaDetailsModel(string imageUri, string name, string composition, int length, int weight, float price)
        {
            ImageUri = imageUri;
            Name = name;
            Composition = composition;
            Weight = weight;
            Length = length;
            Price = price; 
        }
        public string ImageUri { get; private set; }
        public string Name { get; private set; }
        public string Composition { get; private set; }
        public int Length { get; private set; }
        public int Weight { get; private set; }
        public float Price { get; private set; }
    }
}
