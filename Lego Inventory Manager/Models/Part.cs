namespace LegoInventoryManager.Models
{
    public class Part
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int PartNumber { get; set; }
        public int Qty { get; set; }
        public List<Set> Sets { get; set; } = new List<Set>();
    }
}