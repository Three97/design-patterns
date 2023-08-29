namespace DesignPatterns.Creational.Builder
{
    public class FurnitureItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Weight { get; set; }

        public FurnitureItem(string name, double price, double height, double width, double weight)
        {
            this.Name = name;
            this.Price = price;
            this.Height = height;
            this.Width = width;
            this.Weight = weight;
        }
    }
}