using System;
using System.Collections.Generic;
using System.Text;
using Business_Card.Model;

namespace Business_Card.ViewModel
{
    public class MockDataClass : List<BusinessCard>
    {
        public MockDataClass () {
            List<BusinessCard> BusinessCards = new List<BusinessCard>();

            BusinessCards.Add(new BusinessCard
            {
                Name = "Micheal Johnson",
                CompanyName = "Steel Company",
                Email = "MJSteelCpy@businessemail.com",
                PhoneNumber = "444-4444"
            });

            BusinessCards.Add(new BusinessCard
            {
                Name = "Jennifer Hannison",
                CompanyName = "Great Flights",
                Email = "Flyaplanewithus@businessemail.co",
                PhoneNumber = "412-489-9573 ext 48757"
            });
        }
    }
}