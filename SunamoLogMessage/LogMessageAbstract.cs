namespace SunamoLogMessage;

/// <summary>
///     Must be LoggerAbstract because same public class exists in uap
/// </summary>
public abstract class LogMessageAbstract<Color, StorageClass> : ILogMessage<Color, StorageClass>
{
    public DateTime Dt { get; private set; }

    public string st { get; private set; } = null!;

    public string Message { get; private set; } = null!;

    public Color Bg { get; set; } = default!;

    /// <summary>
    ///     Is here for easy cast LogMessage to generic version
    /// </summary>
    /// <param name="dateTime"></param>
    /// <param name="typeOfMessage"></param>
    /// <param name="message"></param>
    /// <param name="color"></param>
    public LogMessageAbstract<Color, StorageClass> Initialize(DateTime dateTime, string typeOfMessage, string message,
        Color color)
    {
        Dt = dateTime;
        st = typeOfMessage;
        Message = message;
        Bg = color;
        return this;
    }

    /// <summary>
    ///     Must be method because call WpfApp.cd.RunAsync (works with controls)
    /// </summary>
    /// <param name="color"></param>
    protected virtual void SetBg(Color color)
    {
    }
}