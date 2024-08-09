namespace SunamoLogMessage;

/// <summary>
///     Must be LoggerAbstract because same public class exists in uap
/// </summary>
public abstract class LogMessageAbstract<Color, StorageClass> : ILogMessage<Color, StorageClass>
{
    public DateTime Dt { get; private set; }

    public string st { get; private set; }

    public string Message { get; private set; }

    public Color Bg { get; set; }

    /// <summary>
    ///     Is here for easy cast LogMessage to generic version
    /// </summary>
    /// <param name="dt"></param>
    /// <param name="typeOfMessage"></param>
    /// <param name="message"></param>
    /// <param name="color"></param>
    public LogMessageAbstract<Color, StorageClass> Initialize(DateTime dt, string typeOfMessage, string message,
        Color color)
    {
        Dt = dt;
        st = typeOfMessage;
        Message = message;
        Bg = color;
        return this;
    }

    /// <summary>
    ///     Must be method because call WpfApp.cd.RunAsync (works with controls)
    /// </summary>
    /// <param name="c"></param>
    protected virtual void SetBg(Color c)
    {
    }
}