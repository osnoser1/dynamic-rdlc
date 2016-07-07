namespace DynamicRdlc.Rdl
{
    public class Point
    {
        private readonly double point;

        public Point(double point)
        {
            this.point = point;
        }

        public override string ToString()
        {
            return this.point + "pt";
        }
    }
}
