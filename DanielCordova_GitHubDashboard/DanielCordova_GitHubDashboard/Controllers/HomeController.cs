﻿using DanielCordova_GitHubDashboard.Models;
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
            client.Headers.Add(HttpRequestHeader.UserAgent, userAgentHeader);   //required in request header per GitHub API documentation: https://developer.github.com/v3/
            client.Headers.Add(HttpRequestHeader.Accept, acceptHeader);     //recommended to include in request header per GitHub API documentation

            string response = client.DownloadString(apiUri);
            events = JsonConvert.DeserializeObject<List<GitHubEvent>>(response);

            return View(events);
        }

        public ActionResult About()
        {
            ViewBag.Message = "This web application was designed and developed to be as a user-friendly client to view and explore the feed of public events in the GitHub API";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}