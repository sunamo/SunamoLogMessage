namespace SunamoLogMessage;

public interface ILogMessage<Color, StorageClass>
{
    Color Bg { get; set; }
    string Message { get; }
    LogMessageAbstract<Color, StorageClass> Initialize(DateTime datum, string typeOfMessage, string zprava, Color color);
}