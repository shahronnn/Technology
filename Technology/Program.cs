using Technology;

var lap1=new Laptop();
var comp1=new Computers();
var smart=new Smartphone();

System.Console.WriteLine("Inter information about your Laptop");
System.Console.Write("ram : ");
lap1.Ram=Convert.ToInt32(Console.ReadLine());
System.Console.Write("storage : ");
lap1.Storage=Convert.ToInt32(Console.ReadLine());
System.Console.Write("keyboard : ");
lap1.Keybord=Console.ReadLine();
System.Console.Write("weight : ");
lap1.Weight=Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Would you add rum?");
string a=System.Console.ReadLine();
if(a=="yes")
{
    System.Console.Write("How much : ");
    int b=System.Convert.ToInt32(Console.ReadLine());
    lap1.AddRum(b);
    System.Console.WriteLine($"Your ram now {lap1.Ram} GB");
}


lap1.CheckWeight();

