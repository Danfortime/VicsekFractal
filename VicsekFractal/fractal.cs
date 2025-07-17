public class fractal
{
    private int _depth;
    private RectangleF _bounds;

    public fractal(int depth, RectangleF bounds)
    {
        _depth = depth;
        _bounds = bounds;
    }

    public void Draw(Graphics g)
    {
        DrawVicsek(g, _depth, _bounds);
    }

    private void DrawVicsek(Graphics g, int depth, RectangleF rect)
    {
        if (depth == 0)
        {
            g.FillRectangle(Brushes.Black, rect);
            return;
        }

        float w = rect.Width / 3;
        float h = rect.Height / 3;

        // Центральный квадрат
        DrawVicsek(g, depth - 1, new RectangleF(
            rect.X + w,
            rect.Y + h,
            w,
            h
        ));

        // Угловые квадраты
        DrawVicsek(g, depth - 1, new RectangleF(rect.X, rect.Y, w, h));
        DrawVicsek(g, depth - 1, new RectangleF(rect.X + 2 * w, rect.Y, w, h));
        DrawVicsek(g, depth - 1, new RectangleF(rect.X, rect.Y + 2 * h, w, h));
        DrawVicsek(g, depth - 1, new RectangleF(rect.X + 2 * w, rect.Y + 2 * h, w, h));
    }
}