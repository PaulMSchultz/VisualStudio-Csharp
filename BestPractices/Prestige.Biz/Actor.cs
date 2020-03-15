using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestige.Biz
{
    public class Actor
    {
        public Actor()
        {
            Console.WriteLine("An actor is born.");
            //this.CurrentAgency = new Agency();
        }

        public Actor(string actorName): this()
        {
            ActorName = actorName;
        }

        private string actorName;

        public string ActorName
        {
            get { return actorName; }
            set {
                var formattedName = value?.Trim();
                actorName = formattedName; }
        }


        private string jobTitle;

        public string JobTitle
        {
            get { return jobTitle; }
            set { jobTitle = value; }
        }

        public int ActorAge { get; set; }

        public string ActorDescription { get; set; } = "Regular actor";

        private Agency currentAgency;

        public Agency CurrentAgency
        {
            get {
                if (currentAgency == null)
                {
                    currentAgency = new Agency();
                }
                return currentAgency; }
            set { currentAgency = value; }
        }


        /// <summary>
        /// Will retrun title
        /// </summary>
        public string GetOccupation()
        {
            jobTitle = "Actor"
;            return jobTitle;
        }

        /// <summary>
        /// Books actor and not date specified.
        /// </summary>
        public string BookActor()
        {
            return BookActor(string.Empty);
        }

        /// <summary>
        /// Books actor on specific date.
        /// </summary>
        /// <param name="theDate"></param>
        /// <returns></returns>
        public string BookActor(string theDate)
        {
            string details = "Booking can change if actor starts trouble.";
            string theActor = "Actor " + ActorName + " is booked";
            if (theDate != string.Empty)
            {
                return theActor + " on " + theDate + ". " + details;
            }
            else
            {
                return theActor + ". " + details;
            }            
        }

        public string GetAgency()
        {
            //var currentAgency = new Agency();
            return CurrentAgency.Name;
        }
    }
}
