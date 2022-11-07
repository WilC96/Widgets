using SpreadEx.Factories;
using SpreadEx.Model;
using SpreadEx.Model.Core;

namespace SpreadEx.Service
{
    public class DrawWidget : IDrawWidget
    {
        private readonly IWidgetFactory _widgetFactory;
        private readonly IList<string> _drawings;

        public DrawWidget(IWidgetFactory widgetFactory)
        {
            this._widgetFactory = widgetFactory;
            this._drawings = new List<string>();
        }

        public void DrawRectangle(int x, int y, int width, int height)
        {
            Rectangle rectangle = (Rectangle)_widgetFactory.Create(ConstantValue.Rectangle);
            rectangle.x = x;
            rectangle.y = y;
            rectangle.width = width;
            rectangle.height = height;
            _drawings.Add($"{rectangle.WidgetType} ({rectangle.x}, {rectangle.y}) width = {rectangle.width} height = {rectangle.height}");    
        }

        public void DrawSquare(int x, int y, int size)
        {
            Square square = (Square)_widgetFactory.Create(ConstantValue.Square);
            square.x = x;
            square.y = y;
            square.size = size;
            _drawings.Add($"{square.WidgetType} ({square.x}, {square.y}) size = {square.size}");
        }

        public void DrawEllipse(int x, int y, int diameterH, int diameterV)
        {
            Ellipse ellipse = (Ellipse)_widgetFactory.Create(ConstantValue.Ellipse);
            ellipse.x = x;
            ellipse.y = y;
            ellipse.diameterH = diameterH;
            ellipse.diameterV = diameterV;
            _drawings.Add($"{ellipse.WidgetType} ({ellipse.x}, {ellipse.y}) diameterH = {ellipse.diameterH} diameterV = {ellipse.diameterV}");
        }

        public void DrawCircle(int x, int y, int size)
        {
            Circle circle = (Circle)_widgetFactory.Create(ConstantValue.Circle);
            circle.x = x;
            circle.y = y;
            circle.size = size;
            _drawings.Add($"{circle.WidgetType} ({circle.x}, {circle.y}) size = {circle.size}");
        }

        public void DrawTextbox(int x, int y, int width, int height, string text)
        {
            TextBox textbox = (TextBox)_widgetFactory.Create(ConstantValue.TextBox);
            textbox.x = x;
            textbox.y = y;
            textbox.width = width;
            textbox.height = height;
            textbox.text = text;
            _drawings.Add($"{textbox.WidgetType} ({textbox.x}, {textbox.y}) width = {textbox.width} height = {textbox.height} Text = {textbox.text}");
        }

        public void PrintWidgets()
        {
            if(!_drawings.Any())
            {
                Console.WriteLine("No drawings saved");
                return;
            }
            foreach (string drawing in _drawings)
            {
                Console.WriteLine(drawing);
            }
        }
    }
}
