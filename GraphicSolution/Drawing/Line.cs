namespace Drawing;
public class Line:Shape,IPrintable{
    public Point StartPoint{get;set;}
    public Point EndPoint {get;set;}

    public Line()
    {
        this.StartPoint= new Point(0,0);
        this.EndPoint= new Point(0,0);
    }

    public Line(Point pt1 ,Point pt2)
    {
        this.StartPoint=pt1;
        this.EndPoint=pt2;
    }

    public override void Draw()
    {
        Type t =this.GetType();
        Console.WriteLine("Type="+t.Name);
        Console.WriteLine("("+this.StartPoint +"),("+this.EndPoint+ "),"+ this.Width+","+this.color);
    }

    public void Print()
    {
        Console.WriteLine("Printong object using existing printer");
        Type t = this.GetType();
        Console.WriteLine("Type="+t.Name);
        Console.WriteLine("("+this.StartPoint+"), ("+this.EndPoint+ "),"+this.Width+","+this.color);
    }
}