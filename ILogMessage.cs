namespace SunamoLogMessage;

public interface ILogMessage<Color, StorageClass>
{
    LogMessageAbstract<Color, StorageClass> Initialize(DateTime datum, string st, string zprava, Color color);
    Color Bg { get; set; }
    string Message { get; }
}
