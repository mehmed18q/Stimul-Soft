using System.ComponentModel.DataAnnotations;

namespace StimulTest.Models
{
    public class City
    {

        public City()
        {
            
        }

        [Key]
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public string Name { get; set; }

        public virtual Country Country { get; set; }
    }
}