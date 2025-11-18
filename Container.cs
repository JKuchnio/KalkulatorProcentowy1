namespace SubstanceCalculator.Models
{
    public class Container
    {
        public string Name { get; set; }       // Nazwa typu naczynia
        public double CapacityMl { get; set; } // Pojemność w ml

        public override string ToString() => $"{Name} ({CapacityMl} ml)";
    }
}
