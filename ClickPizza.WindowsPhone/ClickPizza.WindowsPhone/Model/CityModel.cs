namespace ClickPizza.WindowsPhone.Model
{
    public class CityModel
    {
        public CityModel(string key, string name)
        {
            Key = key;
            Name = name;
        }

        public string Key { get; set; }

        public string Name  { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
