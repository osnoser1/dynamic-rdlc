namespace PeriodicTable.Report.Rdl
{
    public class Inch
    {
        private const double HundredthOfInches = 0.01;
        private const string Unit = "in";

        public Inch(double value)
        {
            this.Value = value;
        }

        public double Value { get; private set; }

        public static Inch operator +(Inch i1, Inch i2)
        {
            return new Inch(i1.Value + i2.Value);
        }

        public static Inch operator -(Inch i1, Inch i2)
        {
            return new Inch(i1.Value - i2.Value);
        }

        public static Inch operator *(Inch i1, double d)
        {
            return new Inch(i1.Value * d);
        }

        public static Inch operator *(double d, Inch i2)
        {
            return new Inch(i2.Value * d);
        }

        public static Inch operator /(Inch i1, double d)
        {
            return new Inch(i1.Value / d);
        }

        public static explicit operator Inch(string s)
        {
            return new Inch(double.Parse(s.Replace(Unit, string.Empty)));
        }

        public static Inch CentiInchToInch(int centiInch)
        {
            return new Inch(centiInch * HundredthOfInches);
        }

        public override string ToString()
        {
            return this.Value.ToString("0.###########") + Unit;
        }
    }
}
