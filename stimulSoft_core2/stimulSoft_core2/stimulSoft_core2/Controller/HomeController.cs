using Microsoft.AspNetCore.Mvc;
using Stimulsoft.Base;
using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;
using stimulSoft_core2.Models;
using System.Collections.Generic;

namespace stimulSoft_core2.Controller
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        public HomeController()
        {
            StiLicense.LoadFromString("6vJhGtLLLz2GNviWmUTrhSqnOItdDwjBylQzQcAOiHl2AD0gPVknKsaW0un+3PuM6TTcPMUAWEURKXNso0e5OJN40hx" +
                              "JjK5JbrxU+NrJ3E0OUAve6MDSIxK3504G4vSTqZezogz9ehm+xS8zUyh3tFhCWSvIoPFEEuqZTyO744uk+ezyGDj7C5" +
                              "jJQQjndNuSYeM+UdsAZVREEuyNFHLm7gD9OuR2dWjf8ldIO6Goh3h52+uMZxbUNal/0uomgpx5NklQZwVfjTBOg0xKB" +
                              "LJqZTDKbdtUrnFeTZLQXPhrQA5D+hCvqsj+DE0n6uAvCB2kNOvqlDealr9mE3y978bJuoq1l4UNE3EzDk+UqlPo8KwL" +
                              "1XM+o1oxqZAZWsRmNv4Rr2EXqg/RNUQId47/4JO0ymIF5V4UMeQcPXs9DicCBJO2qz1Y+MIpmMDbSETtJWksDF5ns6+" +
                              "B0R7BsNPX+rw8nvVtKI1OTJ2GmcYBeRkIyCB7f8VefTSOkq5ZeZkI8loPcLsR4fC4TXjJu2loGgy4avJVXk32bt4FFp" +
                              "9ikWocI9OQ7CakMKyAF6Zx7dJF1nZw");
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetReport()
        {
            StiReport report = new StiReport();
            report.Load(StiNetCoreHelper.MapPath(this, "wwwroot/Reports/Report3.mrt"));

            var data = new List<Country>()
            {
                new Country()
                {
                    CountryId = 1,
                    Name = "ایران",
                    Cities = new List<City>()
                    {
                        new City() {Name = "تهران",
                            CountryId = 1,
                            CityId = 9},
                        new City() {Name = "شیراز",
                            CountryId = 1,
                            CityId = 8},
                        new City() {Name = "اراک",
                            CountryId = 1,
                            CityId = 7},
                        new City() {Name = "اصفهان",
                            CountryId = 1,
                            CityId = 6}
                    }

                },
                new Country()
                {
                    CountryId = 2,
                    Name = "عراق",
                    Cities = new List<City>()
                    {
                        new City() {Name = "بغداد",
                            CountryId = 2,
                            CityId = 5},
                        new City() {Name = "کربلا",
                            CountryId = 2,
                            CityId = 4}
                    }

                },
                new Country()
                {
                    CountryId = 3,
                    Name = "ترکیه",
                    Cities = new List<City>()
                    {
                        new City() {Name = "آنکارا",
                            CountryId = 3,
                            CityId = 2},
                        new City() {Name = "استانبول",
                            CountryId = 3,
                            CityId = 3}
                    }

                },
                new Country()
                {
                    CountryId = 4,
                    Name = "روسیه",
                    Cities = new List<City>()
                    {
                        new City()
                        {
                            Name = "مسکو",
                            CountryId = 4,
                            CityId = 1
                        }
                    }

                }

            };

            report.RegBusinessObject("dt", data);
            return StiNetCoreViewer.GetReportResult(this, report);
        }
        public IActionResult ViewerEvent()
        {
            return StiNetCoreViewer.ViewerEventResult(this);
        }
    }
}