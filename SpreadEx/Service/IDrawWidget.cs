namespace SpreadEx.Service
{
    public interface IDrawWidget
    {
        public void DrawRectangle(int x, int y, int width, int height);

        public void DrawSquare(int x, int y, int size);

        public void DrawEllipse(int x, int y, int diameterH, int diameterV);

        public void DrawCircle(int x, int y, int size);

        public void DrawTextbox(int x, int y, int width, int height, string text);

        void PrintWidgets();
    }
}
