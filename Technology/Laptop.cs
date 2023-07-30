namespace Technology;

public class Laptop : Computers
{
    public double Weight { get; set; }
    public void CheckWeight()
    {
        if (Weight<=2)
        {
            System.Console.WriteLine("Your Laptop is Good");
        }
        else System.Console.WriteLine("Your Laptop is Heavy");
    }
}
