﻿using DanielCordova_GitHubDashboard.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Web.Mvc;

namespace DanielCordova_GitHubDashboard.Controllers
{
    public class DashboardController : Controller
    {
        private const string apiUri = "https://api.github.com/events";
        private const string acceptHeader = "application/vnd.github.v3+json";
        private const string userName = "TechInter";
        private const string password = "TestAccount123";
        private string credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes(userName + ":" + password));

        public ActionResult Index()
        {
            WebClient client = new WebClient();
            List<GitHubEvent> events = new List<GitHubEvent>();
            client.Headers.Add(HttpRequestHeader.Authorization, credentials);
            client.Headers.Add(HttpRequestHeader.UserAgent, userName);   //required in request header per GitHub API documentation: https://developer.github.com/v3/
            client.Headers.Add(HttpRequestHeader.Accept, acceptHeader);     //recommended to include in request header per GitHub API documentation

            string response = client.DownloadString(apiUri);
            events = JsonConvert.DeserializeObject<List<GitHubEvent>>(response);

            //for (int i = 0; i < events.Count; i++)
            //{
            //    client.Credentials = new NetworkCredential(userName, password);
            //    client.Headers.Add(HttpRequestHeader.UserAgent, userName);
            //    client.Headers.Add(HttpRequestHeader.Accept, acceptHeader);

            //    string repoUri = events[i].EventRepository.RepositoryUrl;
            //    string repoResponse = client.DownloadString(repoUri);
            //    events[i].RepoMainPage = JsonConvert.DeserializeObject<GitHubEvent>(repoResponse).RepoMainPage;
            //}

            return View(events);
        }

        public ActionResult About()
        {
            ViewBag.Message = "This web application was designed and developed to be as a user-friendly client to view and explore the feed of public events in the GitHub API";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Information";

            return View();
        }
    }
}