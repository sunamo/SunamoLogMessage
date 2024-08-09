namespace SunamoLogMessage;

public abstract class LogServiceAbstract<Color, StorageClass, TextBlock>
{
    public abstract Color GetBackgroundBrushOfTypeOfMessage(string st);
    public abstract Color GetForegroundBrushOfTypeOfMessage(string st);

    protected virtual List<LogMessageAbstract<Color, StorageClass>> ReadMessagesFromFile(StorageClass fileStream)
    {
        return null;
    }

    public virtual void Initialize(string soubor, bool invariant, TextBlock tssl, LangsLogMessage l)
    {
    }

    public abstract void SaveToFile();

    protected abstract LogMessageAbstract<Color, StorageClass> CreateMessage();

    public abstract LogMessageAbstract<Color, StorageClass> Add(string st, string status);
}