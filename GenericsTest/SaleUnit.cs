namespace GenericsTest
{
    public class SaleUnit : IUnit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class LegacyUnit : IUnit
    {
        public int Id { get; set; }
        
        private string name;

        public string Name
        {
            get { return $"{name}.Legacy"; }
            set { name = value; }
        }

        public string Description { get; set; }
    }

    public interface IUnit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
