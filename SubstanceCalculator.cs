public class SubstanceCalculator
{
    // Oblicza łączną objętość płynu
    public double CalculateTotalVolume(double vesselVolume, int count)
    {
        return vesselVolume * count;
    }

    // Oblicza objętość czystej substancji
    public double CalculatePureSubstance(double percentage, double totalVolume)
    {
        return (percentage / 100.0) * totalVolume;
    }
}
