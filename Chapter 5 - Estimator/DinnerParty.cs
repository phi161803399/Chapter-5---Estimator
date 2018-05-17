using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5___Estimator
{
    class DinnerParty
    {
        public decimal CostOfBeveragesPerPerson, CostOfDecorations;
        public int NumberOfPeople;
        public const int CostOfFoodPerPerson = 25;

        public void SetHealthyOption(bool healthy)
        {
            CostOfBeveragesPerPerson = healthy ? 5.00M : 20.00M;
        }

        public void CalculateCostOfDecorations(bool fancy)
        {
            if (fancy)
            {
                CostOfDecorations = NumberOfPeople * 15.00M + 50.00M;
            }
            else
            {
                CostOfDecorations = NumberOfPeople * 7.50M + 30.00M;
            }
        }

        public decimal CalculateCost(bool healthy)
        {
            decimal totalCost = NumberOfPeople 
                                * (CostOfBeveragesPerPerson + CostOfFoodPerPerson) 
                                + CostOfDecorations;
            if (healthy)
            {
                 totalCost *= 0.95M;
            }
            return totalCost;
        }
    }
}
