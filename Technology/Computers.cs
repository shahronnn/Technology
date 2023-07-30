namespace Technology;

public class Computers
{
    public int Ram { get; set; }
    public int Storage { get; set; }
    public string Keybord { get; set; }
    public void AddRum(int ram)
    {
        Ram+=ram;
    }
    public void AddStorage(int storage)
    {
        Storage+=storage;
    }
}
