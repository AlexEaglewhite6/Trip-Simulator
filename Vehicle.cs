using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trip_Simulator
{
    internal class Vehicle
    {
        private double Tank;
        private double Consumption;
        public double CurrentTank;

        public Vehicle( double tank, double consumption) 
        {
            Tank = tank;
            CurrentTank = tank * 0.5;
            Consumption = consumption/100;
        }

        public double[] GetOneWayTripInfo(double distance, double gasPrice)
        {
            double price = Math.Round((distance * Consumption * gasPrice), 2);
            int refill;
            if(CurrentTank > Consumption * distance)
            {
                refill = 0;
            }
            else
            {
                refill = 1;
                refill += Convert.ToInt32(Math.Floor((Consumption * distance - CurrentTank) / Tank));
            }
            double firstRefillDistance = CurrentTank / Consumption;
            double remainallTank = Tank * (refill - 1);
            double remainDistance = remainallTank / Consumption;
            CurrentTank = Tank - Consumption * (distance - firstRefillDistance - remainDistance);
            //double price = refill * Tank * gasPrice;
            return new double[] { price, refill };
        }

    }
}
