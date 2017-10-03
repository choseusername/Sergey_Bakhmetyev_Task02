namespace Task1
{
    class Rectangle: IFigure
    {
        private int width, height;
        public int Height { get => height; }
        public int Width { get => width; }

        public int Area { get => width * height; }

        public Rectangle(int a, int b)
        {
            width = a;
            height = b;
        }
    }
}
