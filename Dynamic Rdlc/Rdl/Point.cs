namespace DynamicRdlc.Rdl
{
    public class Point
    {
        private readonly double _point;

        public Point(double point)
        {
            _point = point;
        }

        public override string ToString() => _point + "pt";
    }
}