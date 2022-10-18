using System;
using BillingDashboardUI.Models;

namespace BillingDashboardUI.ViewModels
{
    public class InformationViewModel
    {
        private List<Information> informationCollection = new List<Information>();
        public InformationViewModel()
        {
            informationCollection.Add(new Information("Status", "Completed"));
            informationCollection.Add(new Information("ID Number", "EKG2SJFN"));
            informationCollection.Add(new Information("Invoice date", "Apr 10, 2022"));
            informationCollection.Add(new Information("Date paid", "Apr 10, 2022"));
        }

        public List<Information> InformationCollection
        {
            get { return informationCollection; }
            set { informationCollection = value; }
        }
    }
} 

