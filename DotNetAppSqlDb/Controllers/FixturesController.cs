using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AFCRosterProject.Models;
using System.Diagnostics;
using System.Net.Http;
using Newtonsoft.Json;
using static System.Windows.Forms.LinkLabel;
using System.Threading.Tasks;

namespace AFCRosterProject.Controllers
{
    public class FixturesController : Controller
    {
        private String baseFootballDataUrl = "https://api.football-data.org/v4";
        private String footballDataAuthToken = "0a441189322b4bfc821dc1f156fe40b3";
        // GET: Fixtures
        public ActionResult Index()
        {
            return View();
        }
        public async Task<ActionResult> AllFixtures(int team)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-AUTH-TOKEN", footballDataAuthToken);
                HttpResponseMessage response = await client.GetAsync(baseFootballDataUrl + "/teams/"+ team + "/matches");
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    // Process API response data
                    return Json(responseBody, JsonRequestBehavior.AllowGet);
                }
                return null;
            }
        }




    }
}
