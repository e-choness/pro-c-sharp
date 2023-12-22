using System;
using SolidLibrary.Interfaces;

namespace SolidLibrary.Models
{
    public class Personnel : IPersonnel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Salary { get; set; }
        
        public void HourlyRateCheck(float hourlyRate)
        {
            if (hourlyRate > 30.0f || hourlyRate < 0.0f)
            {
                throw new OverflowException($"Employee {FirstName} {LastName} hourly rate is not legit.");
            }
        }

        public void CalculateHourlyRate(float multiplier)
        {
            var hourlyRate = Salary * multiplier / 40;
            try
            {
                HourlyRateCheck(hourlyRate);
                Console.WriteLine($"{FirstName} {LastName} - hourly rate is {hourlyRate} dollars.");
            } catch (OverflowException e)
            {
                Console.WriteLine($"{e.Message}");
            } 
            
        }
    }
}