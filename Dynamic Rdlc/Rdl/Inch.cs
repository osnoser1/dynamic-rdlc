using System.Globalization;

namespace DynamicRdlc.Rdl
{
    public class Inch
    {
        private const double HundredthOfInches = 0.01;
        private const string Unit = "in";

        public Inch(double value)
        {
            Value = value;
        }

        public double Value { get; }

        public static Inch operator +(Inch i1, Inch i2) => new Inch(i1.Value + i2.Value);

        public static Inch operator -(Inch i1, Inch i2) => new Inch(i1.Value - i2.Value);

        public static Inch operator *(Inch i1, double d) => new Inch(i1.Value*d);

        public static Inch operator *(double d, Inch i2) => new Inch(i2.Value*d);

        public static Inch operator /(Inch i1, double d) => new Inch(i1.Value/d);

        public static explicit operator Inch(string s) => new Inch(double.Parse(s.Replace(Unit, string.Empty)));

        public static explicit operator Inch(double d) => new Inch(d);

        public static Inch CentiInchToInch(int centiInch) => new Inch(centiInch*HundredthOfInches);

        public override string ToString() => Value.ToString("0.###########", CultureInfo.InvariantCulture) + Unit;
    }
}