using SpreadEx.Model.Core;

namespace SpreadEx.Model
{
    public class Circle : IWidget
    {
        public int x, y, size;
        public string WidgetType => ConstantValue.Circle;
    }
}
