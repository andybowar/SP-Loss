namespace SP_calc
{
    public class Machines
    {
        private readonly double _circularSaw = 350;
        private readonly double _bandSaw = 350;
        private readonly double _beltSander6 = 440;
        private readonly double _beltSander7 = 550;
        private readonly double _discSander12 = 350;
        private readonly double _discSander13 = 440;
        private readonly double _drumSander200 = 350;
        private readonly double _drumSander201 = 550;
        private readonly double _jointer6 = 350;
        private readonly double _jointer7 = 440;
        private readonly double _thicknessPlaner13 = 400;
        private readonly double _thicknessPlaner14 = 785;
        private readonly double _router = 195;
        private readonly double _shaper = 350;
        private readonly double _lathe = 350;

		public double CircularSaw { get; set; }
		public double BandSaw { get; set; }
		public double BeltSander6 { get; set; }
		public double BeltSander7 { get; set; }
		public double DiscSander12 { get; set; }
		public double DiscSander13 { get; set; }
		public double DrumSander200 { get; set; }
		public double DrumSander201 { get; set; }
		public double Jointer6 { get; set; }
		public double Jointer7 { get; set; }
		public double ThicknessPlaner13 { get; set; }
		public double ThicknessPlaner14 { get; set; }
		public double Router { get; set; }
		public double Shaper { get; set; }
		public double Lathe { get; set; }


        public Machines (double CircularSaw,
            double BandSaw,
            double BeltSander6,
            double BeltSander7,
            double DiscSander12,
            double DiscSander13,
            double DrumSander200,
            double DrumSander201,
            double Jointer6,
            double Jointer7,
            double ThicknessPlaner13,
            double ThicknessPlaner14,
            double Router,
            double Shaper,
            double Lathe)
        {
            this.CircularSaw = _circularSaw;
            this.BandSaw = _bandSaw;
            this.BeltSander6 = _beltSander6;
            this.BeltSander7 = _beltSander7;
            this.DiscSander12 = _discSander12;
            this.DiscSander13 = _discSander13;
            this.DrumSander200 = _drumSander200;
            this.DrumSander201 = _drumSander201;
            this.Jointer6 = _jointer6;
            this.Jointer7 = _jointer7;
            this.ThicknessPlaner13 = _thicknessPlaner13;
            this.ThicknessPlaner14 = _thicknessPlaner14;
            this.Router = _router;
            this.Shaper = _shaper;
            this.Lathe = _lathe;
        }
    }
}