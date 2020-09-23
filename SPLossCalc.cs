using System;

namespace SP_calc
{
    class SPLossCalc
    {
        SPLossByDuctDiameter spLossByDuctDiameter = new SPLossByDuctDiameter();

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
                    (num45 * spLossByDuctDiameter.getTwoInch45Equiv()) +
                    (num90 * spLossByDuctDiameter.getTwoInch90Equiv())) *
                    spLossByDuctDiameter.getTwoInchSPLoss());
                case "2.5":
                    return ((rigidDuctLength +
                            (flexHoseLength * 3) +
                            (num45 * spLossByDuctDiameter.getTwoAndHalfInch45Equiv()) +
                            (num90 * spLossByDuctDiameter.getTwoAndHalfInch90Equiv())) *
                            spLossByDuctDiameter.getTwoAndHalfInchSPLoss());
                case "3":
                    return ((rigidDuctLength +
                            (flexHoseLength * 3) +
                            (num45 * spLossByDuctDiameter.getThreeInch45Equiv()) +
                            (num90 * spLossByDuctDiameter.getThreeInch90Equiv())) *
                            spLossByDuctDiameter.getThreeInchSPLoss());
                case "4":
                    return ((rigidDuctLength +
                            (flexHoseLength * 3) +
                            (num45 * spLossByDuctDiameter.getFourInch45Equiv()) +
                            (num90 * spLossByDuctDiameter.getFourInch90Equiv())) *
                            spLossByDuctDiameter.getFourInchSPLoss());
                case "5":
                    return ((rigidDuctLength +
                            (flexHoseLength * 3) +
                            (num45 * spLossByDuctDiameter.getFiveInch45Equiv()) +
                            (num90 * spLossByDuctDiameter.getFiveInch90Equiv())) *
                            spLossByDuctDiameter.getFiveInchSPLoss());
                case "6":
                    return ((rigidDuctLength +
                            (flexHoseLength * 3) +
                            (num45 * spLossByDuctDiameter.getSixInch45Equiv()) +
                            (num90 * spLossByDuctDiameter.getSixInch90Equiv())) *
                            spLossByDuctDiameter.getSixInchSPLoss());
                default:
                    return 0.0;
            }
        }
    }
}