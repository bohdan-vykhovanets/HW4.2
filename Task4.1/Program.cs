interface IGeographicalObject
{
    public void ShowInfo();
}

class River : IGeographicalObject
{
    private double _flowRate;
    private double _length;

    public void ShowInfo()
    {
    
    }
}

class Mountain : IGeographicalObject
{
    private string _highestPoint;

    public void ShowInfo()
    {
    
    }
}
