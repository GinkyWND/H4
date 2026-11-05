namespace MyBusinessCard.Models
{
    public class Person
    {
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Description { get; set; }

        // Дополнительный метод для вычисления возраста
        public int GetAge()
        {
            var today = DateTime.Today;
            var age = today.Year - BirthDate.Year;
            if (BirthDate.Date > today.AddYears(-age)) age--;
            return age;
        }
    }
}
