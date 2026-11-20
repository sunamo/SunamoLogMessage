namespace SunamoLogMessage;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

/// <summary>
/// Represents the wpf control generator type.
/// </summary>
public class WpfControlGenerator
{
    /// <summary>
    /// Vertical colored list.
    /// </summary>
    /// <param name="messages">The messages.</param>
    /// <returns>The vertical colored list result.</returns>
    public static StackPanel VerticalColoredList(List<ILogMessage<Color, string>> messages)
    {
        StackPanel stackPanel = new StackPanel();
        stackPanel.Orientation = Orientation.Vertical;
        foreach (var item in messages)
        {
            Grid grid = new Grid();
            grid.Background = new SolidColorBrush(item.Bg);
            TextBlock textBlock = new TextBlock();
            textBlock.Text = item.Message;
            Grid.SetColumn(textBlock, 0);
            Grid.SetRow(textBlock, 0);
            grid.Children.Add(textBlock);
            stackPanel.Children.Add(grid);
        }
        return stackPanel;
    }

    /// <summary>
    /// Log message.
    /// </summary>
    /// <param name="logMessage">The log message.</param>
    /// <returns>The log message result.</returns>
    public static Grid LogMessage(ILogMessage<Color, string> logMessage)
    {
        Grid grid = new Grid();
        grid.Background = new SolidColorBrush(logMessage.Bg);
        TextBlock textBlock = new TextBlock();
        textBlock.Text = logMessage.Message;
        textBlock.TextWrapping = TextWrapping.Wrap;
        Grid.SetColumn(textBlock, 0);
        Grid.SetRow(textBlock, 0);
        grid.Children.Add(textBlock);
        return grid;
    }
}