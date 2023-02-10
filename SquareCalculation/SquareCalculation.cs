namespace SquareCalculation
{
    public class Triangle : Figure
    {
        public bool isRectangular { get; private set; }

        public  double GetSquare(double x, double y, double z) 
        {
            if (x > 0 && y > 0 && z > 0)

            {
                //check if is rectangular
                if ((x * x + y * y == z * z) || (x * x + z * z == y * y) || (z * z + y * y == x * x))
                    isRectangular = true;

                //Half Perimiter
                double P = (x + y + z) / 2;

                return Math.Sqrt(P * (P - x) * (P - y) * (P - z));
            }
            else if (x + y < z || y + z < x || x + z < y)
            {
                throw new ArgumentException("Стороны не формируют треугольник");
            }
            else
            {
                throw new ArgumentException("Все переменные должны иметь значения отличные от нуля");
            }
        }

    }
    public class Circle : Figure
    {
        public double GetSquare(double R) 
        {
            return R > 0 ? Math.PI * Math.Pow(R, 2) : 0;
        }
    }

    public class Figure
    {
        interface IFigure
        {
            double Square { get; set; }
        }

    }
}