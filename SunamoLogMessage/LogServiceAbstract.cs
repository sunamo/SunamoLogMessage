namespace SunamoLogMessage;

public abstract class LogServiceAbstract<Color, StorageClass, TextBlock>
{
    public abstract Color GetBackgroundBrushOfTypeOfMessage(string typeOfMessage);
    public abstract Color GetForegroundBrushOfTypeOfMessage(string typeOfMessage);

    protected virtual List<LogMessageAbstract<Color, StorageClass>>? ReadMessagesFromFile(StorageClass fileStream)
    {
        return null;
    }

    public virtual void Initialize(string soubor, bool invariant, TextBlock tssl, LangsLogMessage langs)
    {
    }

    public abstract void SaveToFile();

    protected abstract LogMessageAbstract<Color, StorageClass> CreateMessage();

    public abstract LogMessageAbstract<Color, StorageClass> Add(string typeOfMessage, string status);
}