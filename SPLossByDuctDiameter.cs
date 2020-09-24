namespace SP_calc
{
    public class SPLossByDuctDiameter
    {
        private static readonly double _twoInSPLoss = .15;
        private static readonly double _twoAndHalfInSPLoss = .11;
        private static readonly double _threeInSPLoss = .1;
        private static readonly double _fourInSPLoss = .07;
        private static readonly double _fiveInSPLoss = .055;
        private static readonly double _sixInSPLoss = .045;
        private static readonly double _twoIn45Equiv = 1.5;
        private static readonly double _twoAndHalfIn45Equiv = 2;
        private static readonly double _threeIn45Equiv = 2.5;
        private static readonly double _fourIn45Equiv = 3;
        private static readonly double _fiveIn45Equiv = 4.5;
        private static readonly double _sixIn45Equiv = 6;
        private static readonly double _twoIn90Equiv = 3;
        private static readonly double _twoAndHalfIn90Equiv = 4;
        private static readonly double _threeIn90Equiv = 5;
        private static readonly double _fourIn90Equiv = 6;
        private static readonly double _fiveIn90Equiv = 9;
        private static readonly double _sixIn90Equiv = 12;

        public double TwoInSPLoss { get; set; } = _twoInSPLoss;
        public double TwoAndHalfInSPLoss { get; set; } = _twoAndHalfInSPLoss;
        public double ThreeInSPLoss { get; set; } = _threeInSPLoss;
        public double FourInSPLoss { get; set; } = _fourInSPLoss;
        public double FiveInSPLoss { get; set; } = _fiveInSPLoss;
        public double SixInSPLoss { get; set; } = _sixInSPLoss;
        public double TwoIn45Equiv { get; set; } = _twoIn45Equiv;
        public double TwoAndHalfIn45Equiv { get; set; } = _twoAndHalfIn45Equiv;
        public double ThreeIn45Equiv { get; set; } = _threeIn45Equiv;
        public double FourIn45Equiv { get; set; } = _fourIn45Equiv;
        public double FiveIn45Equiv { get; set; } = _fiveIn45Equiv;
        public double SixIn45Equiv { get; set; } = _sixIn45Equiv;
        public double TwoIn90Equiv { get; set; } = _twoIn90Equiv;
        public double TwoAndHalfIn90Equiv { get; set; } = _twoAndHalfIn90Equiv;
        public double ThreeIn90Equiv { get; set; } = _threeIn90Equiv;
        public double FourIn90Equiv { get; set; } = _fourIn90Equiv;
        public double FiveIn90Equiv { get; set; } = _fiveIn90Equiv;
        public double SixIn90Equiv { get; set; } = _sixIn90Equiv;

        //public SPLossByDuctDiameter(double TwoInSPLoss,
        //    double TwoAndHalfInSPLoss,
        //    double ThreeInSPLoss,
        //    double FourInSPLoss,
        //    double FiveInSPLoss,
        //    double SixInSPLoss,
        //    double TwoIn45Equiv,
        //    double TwoAndHalfIn45Equiv,
        //    double ThreeIn45Equiv,
        //    double FourIn45Equiv,
        //    double FiveIn45Equiv,
        //    double SixIn45Equiv,
        //    double TwoIn90Equiv,
        //    double TwoAndHalfIn90Equiv,
        //    double ThreeIn90Equiv,
        //    double FourIn90Equiv,
        //    double FiveIn90Equiv,
        //    double SixIn90Equiv)
        //{
        //    this.TwoInSPLoss = _twoInSPLoss;
        //    this.TwoAndHalfInSPLoss = _twoAndHalfInSPLoss;
        //    this.ThreeInSPLoss = _threeInSPLoss;
        //    this.FourInSPLoss = _fourInSPLoss;
        //    this.FiveInSPLoss = _fiveInSPLoss;
        //    this.SixInSPLoss = _sixInSPLoss;
        //    this.TwoIn45Equiv = _twoIn45Equiv;
        //    this.TwoAndHalfIn45Equiv = _twoAndHalfIn45Equiv;
        //    this.ThreeIn45Equiv = _threeIn45Equiv;
        //    this.FourIn45Equiv = _fourIn45Equiv;
        //    this.FiveIn45Equiv = _fiveIn45Equiv;
        //    this.SixIn45Equiv = _sixIn45Equiv;
        //    this.TwoIn90Equiv = _twoIn90Equiv;
        //    this.TwoAndHalfIn90Equiv = _twoAndHalfIn45Equiv;
        //    this.ThreeIn90Equiv = _threeIn90Equiv;
        //    this.FourIn90Equiv = _fourIn90Equiv;
        //    this.FiveIn90Equiv = _fiveIn90Equiv;
        //    this.SixIn90Equiv = _sixIn90Equiv;
        //}
    }
}