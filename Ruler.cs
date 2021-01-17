namespace RulerExercise
{
    internal class Ruler
    {
        private double _StartLength;

        public double StartLength
        {
            set { _StartLength = value; } //Write-only
        }

        public double LengthInM { get { return _StartLength; } } //Read-only
        public double LengthInCm { get { return _StartLength * 100; } }
        public double LengthInKm { get { return _StartLength / 1000; } }
        public double LengthInFeet { get { return _StartLength / 0.3048; } }
    }
}