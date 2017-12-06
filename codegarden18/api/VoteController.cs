using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Umbraco.Web.WebApi;
using Umbraco.Core.Services;
using Umbraco.Web.PublishedContentModels;

namespace codegarden18.api
{
    public class VoteController : UmbracoApiController
    {
        
        [HttpGet]
        public string CommitVote(int ticketID, int projectID)
        {
            var cs = Services.ContentService;
            try
            {
                
                //validate vote
                bool validates = ValidateVote(ticketID, projectID);
                if (validates)
                {
                    //create vote object
                    var vote = cs.CreateContent("vote api", 1215, "vote");
                    vote.Properties["ticketID"].Value = ticketID;
                    vote.Properties["ProjectID"].Value = projectID;
                    vote.Properties["VoteTime"].Value = new DateTime();

                    cs.Save(vote);
                    return "success";
                }

                //do vote on Guid
                // add time to vote

            }
            catch (Exception)
            {

                throw;
            }
            return "failed";
        }

        private bool ValidateVote(int ticketID, int projectID)
        {
            var cs = Services.ContentService;
            try
            {
                //lookup project
                List<Project> projects = GetProjects();
                
                
                //lookup ticket entry
                List<Vote> votes = GetVotes();

                
                //validate that only one vote exsists in the catagory
                return true;
            }
            catch (Exception)
            {
                
            }
            return false;
        }

        [HttpGet]
        public List<Vote> GetVotes()
        {
            var cs = Services.ContentService;
            List<Vote> res = new List<Vote>();
            var votes = cs.GetChildren(1215);

            foreach(var vote in votes)
            {
                var v = new Vote
                {
                    TicketID = int.Parse(vote.Properties["ticketID"].Value.ToString()),
                    ProjectID = int.Parse(vote.Properties["projectID"].Value.ToString()),
                    VoteTime = Convert.ToDateTime(vote.Properties["voteTime"].Value.ToString())
                };
                res.Add(v);
            }
            return res;
        }
        
        [HttpGet]
        public List<Project> GetProjects()
        {
            var cs = Services.ContentService;
            // we have to use the ContentTypeService to get the correct id on the basis of the alias
            var cts = Services.ContentTypeService;

            var contentType = cts.GetContentType("project");
            var projects = cs.GetContentOfContentType(contentType.Id);
            
            List<Project> res = new List<Project>();
            
            foreach (var project in projects)
            {
                var p = new Project
                {
                    ID = project.Id,
                    Headline = project.Properties["headline"].Value.ToString(),
                    Bodytext = project.Properties["bodytext"].Value.ToString(),
                    CategoryID = project.ParentId
                };
                res.Add(p);
            }
            return res;
        }

    }

    public class Vote
    {
        public int TicketID { get; set; }
        public int ProjectID { get; set; }
        public DateTime VoteTime { get; set; }
    }

    public class Project
    {
        public int ID { get; set; }
        public string Headline { get; set; }
        public string Bodytext { get; set; }
        public int CategoryID { get; set; }
    }

    public class Category
    {
        public int ID { get; set; }
        public string Headline { get; set; }
        public string Bodytext { get; set; }
    }
}