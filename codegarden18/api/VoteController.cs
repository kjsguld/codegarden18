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
                    var vote = cs.CreateContent("Vote", 1215, "vote");
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
            try
            {
                //lookup project


                //lookup ticket entry
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

    }

    public class Vote
    {
        public int TicketID { get; set; }
        public int ProjectID { get; set; }
        public DateTime VoteTime { get; set; }
    }
}