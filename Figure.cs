namespace LibraryMindbox
{
    public abstract class Figure
    {
        public virtual string Name { get; init; }
        public double Square { get; init; }

        public virtual double MakeSquare(double r) { return r * r * 3.14; }
        public virtual double MakeSquare(double h1, double h2, double h3) { double p = (h1 + h2 + h3) / 2; return Math.Sqrt(p * (p - h1) * (p - h2) * (p - h3)); }
        public override string ToString()
        {
            return $"{Name}, площадь = {Square}";
        }
    }
}