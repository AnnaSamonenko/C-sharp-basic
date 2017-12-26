namespace Task1
{
    public class Square
    {
        private readonly double _a;

        public Square(int a)
        {
            _a = a;
        }

        public double Area()
        {
            return _a * _a;
        }

        public double Perimeter()
        {
            return 4 * _a;
        }
    }
}