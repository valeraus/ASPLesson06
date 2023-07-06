namespace Task01.Services
{
    public class DaysOfWeekService:IValuesService
    {
        public string[] GetValues()
        {
            return new[] { "Понеділок", "Вівторок", "Середа", "Четвер", "П'ятниця", "Субота", "Неділя" };
        }
    }
}
