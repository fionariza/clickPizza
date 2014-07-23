namespace ClickPizza.WindowsPhone.Model
{
    public class PizzaDetailsModel
    {
        public   PizzaDetailsModel()
        { }

        public PizzaDetailsModel(int id,string imageStringUri, string name, string composition, int length, int weight, float price)
        {
            Id = id;
            ImageStringUri = imageStringUri;
            Name = name;
            Composition = composition;
            Weight = weight;
            Length = length;
            Price = price; 
        }
        public int Id { get; private set; }
        public string ImageStringUri { get; private set; }
        public string Name { get; private set; }
        public string Composition { get; private set; }
        public int Length { get; private set; }
        public int Weight { get; private set; }
        public float Price { get; private set; }

        public override bool Equals(object obj)
        {
            var pizzaDetailsModel = obj as PizzaDetailsModel;
            return pizzaDetailsModel != null && this.Id == pizzaDetailsModel.Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

    }
}
