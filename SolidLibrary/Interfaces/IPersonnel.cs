namespace SolidLibrary.Interfaces
{
    public interface IPersonnel
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        float Salary { get; set; }

        void HourlyRateCheck(float hourlyRate);
        void CalculateHourlyRate(float multiplier);
    }
}