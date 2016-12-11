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
        private string eventType;
        private string eventId;
        private bool isPublic;
        private string createdDate;
        private Actor eventActor;
        private Repository eventRepository;

        /// <summary>
        /// POCO Properties
        /// </summary>
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

        [JsonProperty("actor")]
        public Actor EventActor
        {
            get
            {
                return eventActor;
            }

            set
            {
                eventActor = value;
            }
        }

        [JsonProperty("repo")]
        public Repository EventRepository
        {
            get
            {
                return eventRepository;
            }

            set
            {
                eventRepository = value;
            }
        }

        /// <summary>
        /// Nested Inner Class
        /// Created within GitHubEvent because Actor does not have any meaning outside context of a GitHubEvent
        /// </summary>
        public class Actor
        {
            private int actorId;
            private string loginName;
            private string displayLoginName;
            private string gravatarId;
            private string actorUrl;
            private string avatarUrl;

            [JsonProperty("id")]
            public int ActorId
            {
                get
                {
                    return actorId;
                }

                set
                {
                    actorId = value;
                }
            }

            [JsonProperty("login")]
            public string LoginName
            {
                get
                {
                    return loginName;
                }

                set
                {
                    loginName = value;
                }
            }

            [JsonProperty("display_login")]
            public string DisplayLoginName
            {
                get
                {
                    return displayLoginName;
                }

                set
                {
                    displayLoginName = value;
                }
            }

            [JsonProperty("gravatar_id")]
            public string GravatarId
            {
                get
                {
                    return gravatarId;
                }

                set
                {
                    gravatarId = value;
                }
            }

            [JsonProperty("url")]
            public string ActorUrl
            {
                get
                {
                    return actorUrl;
                }

                set
                {
                    actorUrl = value;
                }
            }

            [JsonProperty("avatar_url")]
            public string AvatarUrl
            {
                get
                {
                    return avatarUrl;
                }

                set
                {
                    avatarUrl = value;
                }
            }
        }

        /// <summary>
        /// Nested Inner Class
        /// Created within GitHubEvent because Repository does not have any meaning outside context of a GitHubEvent
        /// </summary>
        public class Repository
        {
            private int repositoryId;
            private string repositoryName;
            private string repositoryUrl;

            [JsonProperty("id")]
            public int RepositoryId
            {
                get
                {
                    return repositoryId;
                }

                set
                {
                    repositoryId = value;
                }
            }

            [JsonProperty("name")]
            public string RepositoryName
            {
                get
                {
                    return repositoryName;
                }

                set
                {
                    repositoryName = value;
                }
            }

            [JsonProperty("url")]
            public string RepositoryUrl
            {
                get
                {
                    return repositoryUrl;
                }

                set
                {
                    repositoryUrl = value;
                }
            }
        }
    }
}