using System;
using System.Collections.Generic;
using System.Text;

namespace Planer_Przyjec
{
    class DinnerParty
    {
        /*private int numberOfPeople;
        private bool fancyDecorations;
        private bool healthyOption;
        private decimal totalCost;*/
       
        public const int CostOfFoodPerPerson = 25; // Stała 25zł za jedzenie od osoby
        //public decimal CostOfBeveragesPerPerson; // Koszt napojów od osoby
        public decimal CostOfDecorations = 0; // Początkowy koszt dekoracji

        // Właściwości, które są ustawiane w konstruktorze
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public bool HealthyOption { get; set; }
        public decimal Cost
        {
            get
            {
               decimal totalCost = CalculateCostOfDecorations();
                totalCost += ((CalculateCostOfBeveragesPerPerson() + CostOfFoodPerPerson) * NumberOfPeople);
                if (HealthyOption)
                    totalCost *= .95M; // Nalicza 5% rabaty
                return totalCost;
            }
        }
        // Konstruktor klasy
        public DinnerParty(int numberOfPeople, bool fancyDecorations, bool healthyOption)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            HealthyOption = healthyOption;
        }

        private decimal CalculateCostOfDecorations()
        {
            decimal costOfDecorations;
            if (FancyDecorations)
                // Jeżeli opcja fantazyjna to 15zł/os + 50zł opłata stała
                costOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            else
                // Jeżeli nie to 7.5zł/os + 30zł opłata stała
                costOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            return costOfDecorations;
        }

        /// <summary>
        /// Jeżeli została wybrana opcja zdrowa, to
        /// koszt za napoje 5zł/os, inaczej 20zł/os
        /// </summary>
        private decimal CalculateCostOfBeveragesPerPerson()
        {
            decimal costOfBeveragesPerPerson;
            if (HealthyOption)
                costOfBeveragesPerPerson = 5.00M;
            else
                costOfBeveragesPerPerson = 20.00M;
            return costOfBeveragesPerPerson;
        }
    }
}
