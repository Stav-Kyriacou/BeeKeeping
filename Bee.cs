namespace Bees
{
    public class Bee
    {
        public string Name { get; set; }
        public float Size { get; set; }

        public Bee(string name, float size)
        {
            this.Name = name;
            this.Size = size;
        }
    }
}