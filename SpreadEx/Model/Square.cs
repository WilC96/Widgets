using SpreadEx.Model.Core;

namespace SpreadEx.Model
{
    public class Square : IWidget
    {
        public int x, y, size;
        public string WidgetType => ConstantValue.Square;
    }
}
