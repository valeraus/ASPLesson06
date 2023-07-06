namespace Task01.Services
{
    public class MonthsService : IValuesService
    {
        public string[] GetValues()
        {
            return new[] { "Січень", "Лютий", "Березень", "Квітень", "Травень", "Червень", "Липень", "Серпень", "Вересень", "Жовтень", "Листопад", "Грудень" };
        }
    }
}
