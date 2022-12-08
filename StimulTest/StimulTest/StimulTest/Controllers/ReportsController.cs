using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;
using StimulTest.Models;

namespace StimulTest.Controllers
{
    public class ReportsController : Controller
    {
        // GET
        public ActionResult Print()
        {
            return View();
        }

        public ActionResult Report()
        {
            var report = new StiReport();
            report.Load(Server.MapPath("/Reports/Report.mrt"));
            report.Compile();
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
            return StiMvcViewer.GetReportSnapshotResult(report);
        }

        public ActionResult ViewerEvent()
        {
            return StiMvcViewer.ViewerEventResult(HttpContext);
        }
    }
}