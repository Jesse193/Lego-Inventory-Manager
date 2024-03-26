namespace LegoInventoryManager.Models
{
    public class Set
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SetNumber { get; set; }
        public int Qty { get; set; }
        public List<Part> Parts { get; set; } = new List<Part>();
    }
}