using SpreadEx.Model.Core;

namespace SpreadEx.Model
{
    public class Rectangle : IWidget
    {
        public int x, y, width, height;
        public string WidgetType => ConstantValue.Rectangle;
    }
}
