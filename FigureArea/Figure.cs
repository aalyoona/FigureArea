namespace FigureArea
{
    public abstract class Figure
    {
        private readonly string _name;

        public Figure(string name)
        {
            _name = name;
        }

        public abstract double CalculateArea();
    }
}