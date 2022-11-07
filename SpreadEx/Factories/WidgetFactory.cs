using SpreadEx.Model;

namespace SpreadEx.Factories
{
    public class WidgetFactory : IWidgetFactory
    {
        private readonly Func<IEnumerable<IWidget>> _factory;

        public WidgetFactory(Func<IEnumerable<IWidget>> factory)
        {
            _factory = factory;
        }

        public IWidget Create(string widgetType)
        {
            return _factory().Where(x => x.WidgetType == widgetType).First();
        }
    }
}
