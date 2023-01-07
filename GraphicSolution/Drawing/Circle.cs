namespace Drawing;
public class Circle:Shape,IPrintable
{
    public Point Center{get;set;}
    public int Radius{set;get;}
    public Circle()
    {
        this.Center=new Point(0,0);
        this.Radius=1;
    }

    public Circle(Point c, int r)
    {
        this.Center=c;
        this.Radius=r;
    }

    public override void Draw()
    {
        Type t = this.GetType();
        Console.WriteLine("Type="+t.Name);
        Console.WriteLine("("+this.Center+"), Radius="+this.Radius+ ","+this.Width+","+this.color);
    }

    public void Print()
    {
        Console.WriteLine("Printing object on existing printer");
        Type t=this.GetType();
        Console.WriteLine("Type ="+t.Name);
        Console.WriteLine("("+this.Center+"),Radius="+this.Radius+ ","+ this.Width+ ","+ this.color);
    }
}