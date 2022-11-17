River Riv = new River("River", 43, 123, 5, 1234);
Riv.ShowInfo();
Console.WriteLine("Abstract class");
Mountain Mou = new Mountain("Mountain", 122, 33, 4123);
Mou.ShowInfo();

abstract class GeograficObject
{
    protected int x;
    protected int y;
    protected string Name { get; set; }
    public GeograficObject(string _name, int _x, int _y)
    {
        this.Name = _name;
        this.x = _x;
        this.y = _y;
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine("X: " + x);
        Console.WriteLine("Y: " + y);
        Console.WriteLine("Name: " + Name);
    }


}
class River : GeograficObject
{
    private int speed;
    private int lengh;
    public River(string name, int x, int y, int _speed, int _lengh) : base(name, x, y)
    {
        this.speed = _speed;
        this.lengh = _lengh;
    }
    override public void ShowInfo()
    {
        Console.WriteLine("X: " + x);
        Console.WriteLine("Y: " + y);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine($"Speed : {this.speed}");
        Console.WriteLine($"Lengh : {this.lengh}");
    }
}
class Mountain : GeograficObject
{
    private int highPoint;
    public Mountain(string name, int x, int y, int _highPoint) : base(name, x, y)
    {
        this.highPoint = _highPoint;
    }
    override public void ShowInfo()
    {
        Console.WriteLine("X: " + x);
        Console.WriteLine("Y: " + y);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine($"High point : {this.highPoint}");
    }
}
