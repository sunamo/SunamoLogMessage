namespace SunamoLogMessage;
/// <summary>
/// Must be LoggerAbstract because same public class exists in uap
/// </summary>

public abstract class LogMessageAbstract<Color, StorageClass> : ILogMessage<Color, StorageClass>
{
    private DateTime _dateTime;
    private string _typeOfMessage;
    private string _message;
    private Color _bg;

    public DateTime Dt { get { return _dateTime; } }
    public string st { get { return _typeOfMessage; } }
    public string Message { get { return _message; } }
    public Color Bg { get { return _bg; } set { _bg = value; } }

    /// <summary>
    /// Must be method because call WpfApp.cd.RunAsync (works with controls)
    /// </summary>
    /// <param name="c"></param>
    protected virtual void SetBg(Color c)
    {
    }

    public LogMessageAbstract()
    {
    }

    /// <summary>
    /// Is here for easy cast LogMessage to generic version
    /// </summary>
    /// <param name="dt"></param>
    /// <param name="typeOfMessage"></param>
    /// <param name="message"></param>
    /// <param name="color"></param>
    public LogMessageAbstract<Color, StorageClass> Initialize(DateTime dt, string typeOfMessage, string message, Color color)
    {
        _dateTime = dt;
        _typeOfMessage = typeOfMessage;
        _message = message;
        _bg = color;
        return this;
    }
}
