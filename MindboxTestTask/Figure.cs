namespace MindboxTestTask;

public abstract class Figure
{
    private double _area;
    public double Area
    {
        get
        {
            if (_area == 0)
                _area = GetArea();
            return _area;
        }
    }

    protected abstract double GetArea();
}

    