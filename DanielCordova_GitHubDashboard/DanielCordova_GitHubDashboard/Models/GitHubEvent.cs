using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DanielCordova_GitHubDashboard.Models
{
    public class GitHubEvent
    {
        /// <summary>
        /// POCO Fields
        /// </summary>
        private string username;
        private string eventType;
        private string eventId;
        private bool isPublic;
        private string createdDate;

        /// <summary>
        /// POCO Properties
        /// </summary>

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        [JsonProperty("type")]
        public string EventType
        {
            get
            {
                return eventType;
            }

            set
            {
                eventType = value;
            }
        }

        [JsonProperty("id")]
        public string EventId
        {
            get
            {
                return eventId;
            }

            set
            {
                eventId = value;
            }
        }

        [JsonProperty("public")]
        public bool IsPublic
        {
            get
            {
                return isPublic;
            }

            set
            {
                isPublic = value;
            }
        }

        [JsonProperty("created_at")]
        public string CreatedDate
        {
            get
            {
                return createdDate;
            }

            set
            {
                createdDate = value;
            }
        }
    }
}