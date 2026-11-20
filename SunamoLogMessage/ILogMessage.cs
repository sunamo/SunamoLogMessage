namespace SunamoLogMessage;

/// <summary>
/// Represents the i log message color storage class type.
/// </summary>
public interface ILogMessage<Color, StorageClass>
{
    /// <summary>
    /// Gets or sets the bg.
    /// </summary>
    Color Bg { get; set; }
    /// <summary>
    /// Gets the message.
    /// </summary>
    string Message { get; }
    /// <summary>
    /// Initialize.
    /// </summary>
    /// <param name="datum">The datum.</param>
    /// <param name="typeOfMessage">The type of message.</param>
    /// <param name="zprava">The zprava.</param>
    /// <param name="color">The color.</param>
    /// <returns>The initialize result.</returns>
    LogMessageAbstract<Color, StorageClass> Initialize(DateTime datum, string typeOfMessage, string zprava, Color color);
}