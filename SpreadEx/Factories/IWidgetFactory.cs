using SpreadEx.Model;

namespace SpreadEx.Factories
{
    public interface IWidgetFactory
    {
        IWidget Create(string widgetType);
    }
}
