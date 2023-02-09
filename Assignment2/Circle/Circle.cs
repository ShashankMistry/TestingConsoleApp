namespace Assignment2_SM_MP;
public class Circle
{
    public int Radius;

    public Circle() { 
        Radius= 1;
    }

    public Circle(int radius)
    {
        Radius= radius;
    }

    public void SetRadius(int radius) { 
        if (radius < 0)
        {
            throw new ArgumentException("Amount must be positive");
        }
       Radius = radius;
    }

    public int GetRadius()
    {
        return Radius;
    }


    public double GetCircumference(){
        return Radius * 2 * Math.PI;
    }

    public double GetArea() { 
        return Radius * Radius * Math.PI;
    }


}
