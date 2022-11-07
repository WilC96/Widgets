using SpreadEx.Model.Core;

namespace SpreadEx.Model
{
    public class TextBox : IWidget
    {
        public int x, y, width, height;
        public string? text;
        public string WidgetType => ConstantValue.TextBox;
    }
}
