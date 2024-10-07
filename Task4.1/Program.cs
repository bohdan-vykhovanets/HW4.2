interface IGeographicalObject
{
    private double _x;
    private double _y;
    private string _name;
    private string _description;

    public virtual void ShowInfo()
    {

    }
}

class River : IGeographicalObject
{
    private double _flowRate;
    private double _length;
}

class Mountain : IGeographicalObject
{
    private string _highestPoint;
}
