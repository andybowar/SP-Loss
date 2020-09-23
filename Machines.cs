using System;

namespace SP_calc
{
    class Machines
    {
        private double circularSaw = 350;
        private double bandSaw = 350;
        private double beltSander6 = 440;
        private double beltSander7 = 550;
        private double discSander12 = 350;
        private double discSander13 = 440;
        private double drumSander200 = 350;
        private double drumSander201 = 550;
        private double jointer6 = 350;
        private double jointer7 = 440;
        private double thicknessPlaner13 = 400;
        private double thicknessPlaner14 = 785;
        private double router = 195;
        private double shaper = 350;
        private double lathe = 350;

        public double getCircularSaw()
        {
            return circularSaw;
        }

        public void setCircularSaw(double circularSaw)
        {
            this.circularSaw = circularSaw;
        }

        public double getBandSaw()
        {
            return bandSaw;
        }

        public void setBandSaw(double bandSaw)
        {
            this.bandSaw = bandSaw;
        }

        public double getBeltSander6()
        {
            return beltSander6;
        }

        public void setBeltSander6(double beltSander6)
        {
            this.beltSander6 = beltSander6;
        }

        public double getBeltSander7()
        {
            return beltSander7;
        }

        public void setBeltSander7(double beltSander7)
        {
            this.beltSander7 = beltSander7;
        }

        public double getDiscSander12()
        {
            return discSander12;
        }

        public void setDiscSander12(double discSander12)
        {
            this.discSander12 = discSander12;
        }

        public double getDiscSander13()
        {
            return discSander13;
        }

        public void setDiscSander13(double discSander13)
        {
            this.discSander13 = discSander13;
        }

        public double getDrumSander200()
        {
            return drumSander200;
        }

        public void setDrumSander200(double drumSander200)
        {
            this.drumSander200 = drumSander200;
        }

        public double getDrumSander201()
        {
            return drumSander201;
        }

        public void setDrumSander201(double drumSander201)
        {
            this.drumSander201 = drumSander201;
        }

        public double getJointer6()
        {
            return jointer6;
        }

        public void setJointer6(double jointer6)
        {
            this.jointer6 = jointer6;
        }

        public double getJointer7()
        {
            return jointer7;
        }

        public void setJointer7(double jointer7)
        {
            this.jointer7 = jointer7;
        }

        public double getThicknessPlaner13()
        {
            return thicknessPlaner13;
        }

        public void setThicknessPlaner13(double thicknessPlaner13)
        {
            this.thicknessPlaner13 = thicknessPlaner13;
        }

        public double getThicknessPlaner14()
        {
            return thicknessPlaner14;
        }

        public void setThicknessPlaner14(double thicknessPlaner14)
        {
            this.thicknessPlaner14 = thicknessPlaner14;
        }

        public double getRouter()
        {
            return router;
        }

        public void setRouter(double router)
        {
            this.router = router;
        }

        public double getShaper()
        {
            return shaper;
        }

        public void setShaper(double shaper)
        {
            this.shaper = shaper;
        }

        public double getLathe()
        {
            return lathe;
        }

        public void setLathe(double lathe)
        {
            this.lathe = lathe;
        }

        public Machines(double circularSaw, double bandSaw, double beltSander6, double beltSander7, double discSander12, double discSander13, double drumSander200, double drumSander201, double jointer6, double jointer7, double thicknessPlaner13, double thicknessPlaner14, double router, double shaper, double lathe)
        {
            this.circularSaw = circularSaw;
            this.bandSaw = bandSaw;
            this.beltSander6 = beltSander6;
            this.beltSander7 = beltSander7;
            this.discSander12 = discSander12;
            this.discSander13 = discSander13;
            this.drumSander200 = drumSander200;
            this.drumSander201 = drumSander201;
            this.jointer6 = jointer6;
            this.jointer7 = jointer7;
            this.thicknessPlaner13 = thicknessPlaner13;
            this.thicknessPlaner14 = thicknessPlaner14;
            this.router = router;
            this.shaper = shaper;
            this.lathe = lathe;
        }
    }
}