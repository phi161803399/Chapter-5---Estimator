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
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public bool HealthyOptions { get; set; }

        public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += NumberOfPeople *
                             (CalculateCostOfBeveragesPerPerson() + CostOfFoodPerPerson);
                if (HealthyOptions)
                     totalCost *= 0.95M;
                return totalCost;
            }
        }

        public DinnerParty(int numberOfPeople, bool fancyDecorations, bool healthyOptions)
        {
            Console.Write(this.Cost);
            Console.Write(CalculateCostOfDecorations());

            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            HealthyOptions = healthyOptions;
        }

        private decimal CalculateCostOfDecorations()
        {
            return FancyDecorations ?
                NumberOfPeople * 15.00M + 50.00M :
                NumberOfPeople * 7.50M + 30.00M;
        }

        private decimal CalculateCostOfBeveragesPerPerson()
        {
            return HealthyOptions ? 5.00M : 20.00M;
        }

        /*
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
        */
    }
}
