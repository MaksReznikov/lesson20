namespace lesson20.Exceptions;

[Serializable]
public class MyRangeException : ApplicationException
{
    public MyRangeException() : base("incorrect range")
    {
    }

    public MyRangeException(string message) : base(message)
    {
    }
}