namespace SunamoLogMessage;

/// <summary>
/// Represents the log service abstract color storage class text block type.
/// </summary>
public abstract class LogServiceAbstract<Color, StorageClass, TextBlock>
{
    /// <summary>
    /// Get background brush of type of message.
    /// </summary>
    /// <param name="typeOfMessage">The type of message.</param>
    /// <returns>The get background brush of type of message result.</returns>
    public abstract Color GetBackgroundBrushOfTypeOfMessage(string typeOfMessage);
    /// <summary>
    /// Get foreground brush of type of message.
    /// </summary>
    /// <param name="typeOfMessage">The type of message.</param>
    /// <returns>The get foreground brush of type of message result.</returns>
    public abstract Color GetForegroundBrushOfTypeOfMessage(string typeOfMessage);

    /// <summary>
    /// Read messages from file.
    /// </summary>
    /// <param name="fileStream">The file stream.</param>
    /// <returns>The read messages from file result.</returns>
    protected virtual List<LogMessageAbstract<Color, StorageClass>>? ReadMessagesFromFile(StorageClass fileStream)
    {
        return null;
    }

    /// <summary>
    /// Initialize.
    /// </summary>
    /// <param name="soubor">The soubor.</param>
    /// <param name="invariant">The invariant.</param>
    /// <param name="tssl">The tssl.</param>
    /// <param name="langs">The langs.</param>
    public virtual void Initialize(string soubor, bool invariant, TextBlock tssl, LangsLogMessage langs)
    {
    }

    /// <summary>
    /// Save to file.
    /// </summary>
    public abstract void SaveToFile();

    /// <summary>
    /// Create message.
    /// </summary>
    /// <returns>The create message result.</returns>
    protected abstract LogMessageAbstract<Color, StorageClass> CreateMessage();

    /// <summary>
    /// Add.
    /// </summary>
    /// <param name="typeOfMessage">The type of message.</param>
    /// <param name="status">The status.</param>
    /// <returns>The add result.</returns>
    public abstract LogMessageAbstract<Color, StorageClass> Add(string typeOfMessage, string status);
}