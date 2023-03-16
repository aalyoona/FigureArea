namespace FigureArea
{
    public class Triangle : Figure
    {
        private double _firstSide;
        private double _secondSide;
        private double _thirdSide;

        public double FirstSide
        {
            get { return _firstSide; }
            set { _firstSide = value; }
        }

        public double SecondSide
        {
            get { return _secondSide; }
            set { _secondSide = value; }
        }

        public double ThirdSide
        {
            get { return _thirdSide; }
            set { _thirdSide = value; }
        }

        protected Triangle() : base(nameof(Triangle)) { }

        public Triangle(double firstSide, double secondSide, double thirdSide) : this()
        {
            if (firstSide + secondSide > thirdSide && firstSide + thirdSide > secondSide && secondSide + thirdSide > firstSide)
            {
                FirstSide = firstSide;
                SecondSide = secondSide;
                ThirdSide = thirdSide;
            }
            else
            {
                Console.WriteLine("Triangle with such sides cannot exist. One or more sides don't match.");
                throw new ArgumentException("Triangle with such sides cannot exist. One or more sides don't match.");
            }
        }

        public override double CalculateArea()
        {
            double area = 0;
            double halfPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;
            area = Math.Sqrt(halfPerimeter * (halfPerimeter - FirstSide) *
                (halfPerimeter - SecondSide) * (halfPerimeter - ThirdSide));
            return Math.Round(area, 3);
        }

        public bool CheckRightTriangle()
        {
            bool result = false;
            double[] sides = { FirstSide, SecondSide, ThirdSide };

            int longestSideIndex = Array.IndexOf(sides, sides.Max());

            double longSidePow2 = 0;
            double smallSidePow2 = 0;

            for (int i = 0; i < sides.Length; i++)
            {
                if (i != longestSideIndex)
                {
                    smallSidePow2 += Math.Pow(sides[i], 2);
                }
                else
                {
                    longSidePow2 = Math.Pow(sides[i], 2);
                }
            }

            if (longSidePow2 == smallSidePow2)
            {
                result = true;
            }

            return result;
        }
    }
}
