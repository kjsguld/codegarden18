using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Umbraco.Web.WebApi;
using Umbraco.Core.Services;
using Umbraco.Web.PublishedContentModels;
using System.Globalization;

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
                    var vote = cs.CreateContent("api entry ticket: " + ticketID.ToString(), 1215, "vote");
                    vote.Properties["ticketID"].Value = ticketID;
                    vote.Properties["ProjectID"].Value = projectID;

                    cs.Publish(vote);
                    cs.Save(vote);
                    return "success";
                }
                if(!validates)
                {
                    return "The vote is invalid";
                }

                //do vote on Guid
                // add time to vote

            }
            catch (Exception)
            {

                throw;
            }
            return "failed to vote";
        }

        private bool ValidateVote(int ticketID, int projectID)
        {
            var cs = Services.ContentService;
            //lookup project
            List<Project> projects = GetProjects();
            //lookup ticket entry
            List<Vote> votes = GetVotes();
            bool isProject = false;
            bool isOtherCategory = true;

            try
            {
                //check exsistance 
                if (projects.Find(x => x.ID == projectID) != null)
                {
                    //store bool for evaluating return
                    isProject = true;
                    var currentCategoryID = projects.Find(x => x.ID == projectID).CategoryID;

                    if (isProject)
                    {
                        //validate that only one vote exsists in the given catagory!
                        var allProjectsInCategory = projects.FindAll(x => x.CategoryID == currentCategoryID);

                        foreach (var projInCat in allProjectsInCategory)
                        {
                            // if vote exists, then set false
                            if (votes.Exists(x => x.ProjectID == projInCat.ID && x.TicketID == ticketID))
                            {
                                isOtherCategory = false;
                            }
                        }
                    }
                }

                if(isProject && isOtherCategory)
                {
                    return true;
                }
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
                    VoteTime = vote.CreateDate
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