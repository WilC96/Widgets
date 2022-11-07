using SpreadEx.Model.Core;

namespace SpreadEx.Model
{
    public class Ellipse : IWidget
    {
        public int x, y, diameterH, diameterV;
        public string WidgetType => ConstantValue.Ellipse;
    }
}
