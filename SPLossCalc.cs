namespace SP_calc
{
    class SPLossCalc
    {
        SPLossByDuctDiameter spLossByDuctDiameter;

        public double SpLossFormula(string diameter,
                                double rigidDuctLength,
                                double flexHoseLength,
                                int num45,
                                int num90)
        {
            switch (diameter)
            {
                case "2":
                    return ((rigidDuctLength +
                    (flexHoseLength * 3) +
                    (num45 * spLossByDuctDiameter.TwoIn45Equiv) +
                    (num90 * spLossByDuctDiameter.TwoIn90Equiv)) *
                    spLossByDuctDiameter.TwoInSPLoss);
                case "2.5":
                    return ((rigidDuctLength +
                            (flexHoseLength * 3) +
                            (num45 * spLossByDuctDiameter.TwoAndHalfIn45Equiv) +
                            (num90 * spLossByDuctDiameter.TwoAndHalfIn90Equiv)) *
                            spLossByDuctDiameter.TwoAndHalfInSPLoss);
                case "3":
                    return ((rigidDuctLength +
                            (flexHoseLength * 3) +
                            (num45 * spLossByDuctDiameter.ThreeIn45Equiv) +
                            (num90 * spLossByDuctDiameter.ThreeIn90Equiv)) *
                            spLossByDuctDiameter.ThreeInSPLoss);
                case "4":
                    return ((rigidDuctLength +
                            (flexHoseLength * 3) +
                            (num45 * spLossByDuctDiameter.FourIn45Equiv) +
                            (num90 * spLossByDuctDiameter.FourIn90Equiv)) *
                            spLossByDuctDiameter.FourInSPLoss);
                case "5":
                    return ((rigidDuctLength +
                            (flexHoseLength * 3) +
                            (num45 * spLossByDuctDiameter.FiveIn45Equiv) +
                            (num90 * spLossByDuctDiameter.FiveIn90Equiv)) *
                            spLossByDuctDiameter.FiveInSPLoss);
                case "6":
                    return ((rigidDuctLength +
                            (flexHoseLength * 3) +
                            (num45 * spLossByDuctDiameter.SixIn45Equiv) +
                            (num90 * spLossByDuctDiameter.SixIn90Equiv)) *
                            spLossByDuctDiameter.SixInSPLoss);
                default:
                    return 0.0;
            }
        }
    }
}