using DanielCordova_GitHubDashboard.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace DanielCordova_GitHubDashboard.Controllers
{
    public class HomeController : Controller
    {
        private const string apiUri = "https://api.github.com/events";
        private const string userAgentHeader = "DanielCordova";
        private const string acceptHeader = "application/vnd.github.v3+json";
        private WebClient client;

        public ActionResult Index()
        {
            List<GitHubEvent> events = new List<GitHubEvent>();
            client = new WebClient();
            client.Headers.Add(HttpRequestHeader.UserAgent, userAgentHeader);
            client.Headers.Add(HttpRequestHeader.Accept, acceptHeader);

            string response = client.DownloadString(apiUri);
            events = JsonConvert.DeserializeObject<List<GitHubEvent>>(response);

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}