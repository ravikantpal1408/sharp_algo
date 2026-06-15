
namespace Solid;

public class LiskovSub
{
    
    public void test()
    {
        var result = new Square();
        result.setHeight(6);
        result.setWidth(6);
    }    
}



class Rectangle
{
    protected int height, width ;

    public virtual void setHeight(int h)
    {
        height = h;
    }

    public virtual void setWidth(int w)
    {
        width = w;
    }
}

class Square : Rectangle
{
    public override void setHeight(int h)
    {
        height = h;
        width = h;        
    }

    public override void setWidth(int w)
    {
        height = w;
        width = w;
    }
}


