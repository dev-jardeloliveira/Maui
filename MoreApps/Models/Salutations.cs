namespace MoreApps.Models
{
    public class Salutations
    {
        public string Salutation => GetSalutation();

        public string GetSalutation()
        {
            DateTime date = DateTime.UtcNow;

            if (date.TimeOfDay.Hours > 24 && date.TimeOfDay.Hours < 12)
            {
                return "Good morning,";

            }
            else if (date.TimeOfDay.Hours > 12 && date.TimeOfDay.Hours < 18)
            {
                return "Good afternon,";
            }
            else
            {
                return "Good evening,";
            }

        }
    }
   
}
