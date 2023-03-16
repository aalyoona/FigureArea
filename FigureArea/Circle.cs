namespace FigureArea
{
    public class Circle : Figure
    {
        private double _radius;

        public double Radius
        {
            get { return _radius; }
            set { _radius = value > 0 ? value : throw new ArgumentException("Radius cannot be less than or equal to zero"); }
        }

        protected Circle() : base(nameof(Circle)) { }

        public Circle(double radius) : this()
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            double area = 0;
            area = Math.PI * Radius * Radius;
            return Math.Round(area, 3);
        }
    }
}
