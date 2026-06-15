namespace Solid;


public class Program
{
    public static async Task Main(string[] args)
    {
        var res = new SquareQuad();
        res.setHeight(50);
        res.setHeight(50);

        var currHeight = res.getHeight();
        var currWidth = res.getHeight();

        Console.WriteLine($"area of square = {currHeight * currWidth}");
    }
}



class RectangleQaud
{
    protected int height;
    protected int width;

    public virtual void setHeight(int h)
    {
        height = h;
    }

    public virtual void setWidth(int w)
    {
        width = w;
    }
}


class SquareQuad: RectangleQaud
{
    public override void setHeight(int h)
    {
        height = h;
    }

    public override void setWidth(int w)
    {
        width = w;
    }

    public int getHeight()
    {
        return height;
    }

    public int getWidth()
    {
        return width;
    }

}