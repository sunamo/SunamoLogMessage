namespace SunamoLogMessage;

public interface ILogMessage<Color, StorageClass>
{
    Color Bg { get; set; }
    string Message { get; }
    LogMessageAbstract<Color, StorageClass> Initialize(DateTime datum, string st, string zprava, Color color);
}