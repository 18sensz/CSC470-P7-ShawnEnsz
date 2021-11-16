using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    public class FakeIssueRepository : IIssueRepository
    {
        public string NO_ERROR = "";
        public string EMPTY_TITLE_ERROR = "A Title is required.";
        public string EMPTY_DISCOVERY_DATETIME_ERROR = "Must select a Discovery Date/Time.";
        public string FUTURE_DISCOVERY_DATETIME_ERROR = "Issues cannot be from the future.";
        public string EMPTY_DISCOVERER_ERROR = "A Discoverer is required.";
        List<Issue> issues;

        public FakeIssueRepository()
        {
            Issue tempIssue = new Issue() {
                Id = 1,
                ProjectId = 1,
                Title = "Starting Issue",
                DiscoveryDate = DateTime.Now,
                Discoverer = "Shawn Ensz",
                InitialDescription = "This is a test starting issue.",
                Component = "Test Component",
                IssueStatusId = 1,
            };

            var result = Add(tempIssue);
        }

        public string Add(Issue issue)
        {
            //Error checking
            var error = ValidateIssue(issue);
            if (error == NO_ERROR)
            {
                issues.Add(issue);
                return error;
            }
            return error;
        }
        public List<Issue> GetAll(int projectId)
        {
            List<Issue> returnList = new List<Issue>();
            foreach( Issue issue in issues){
                if(issue.ProjectId == projectId)
                {
                    returnList.Add(issue);
                }
            }
            return returnList;
        }
        public bool Remove(Issue issue)
        {
            var indexToRemove = issues.FindIndex(r => r.Id == issue.Id);
            if(indexToRemove != -1)
            {
                issues.RemoveAt(indexToRemove);
                return true;
            }
            else
            {
                //Failed to remove - couldnt find issue
                return false;
            }
        }
        public string Modify(Issue issue)
        {

            if (ValidateIssue(issue) != NO_ERROR)
                return ValidateIssue(issue);
           
            var indexToModify = issues.FindIndex(r => r.Id == issue.Id);
            if (indexToModify != -1)
            {
                issues[indexToModify] = issue;
                return NO_ERROR;
            }
            else
            {
                //Failed to remove - couldnt find issue
                return "Failed to find Issue to modify.";
            }
        }
        public int GetTotalNumberOfIssues(int projectId)
        {
            int count = 0;
            foreach (Issue issue in issues)
            {
                if (issue.ProjectId == projectId)
                {
                    count++;
                }
            }
            return count;
        }
        public List<string> GetIssuesByMonth(int projectId)
        {
            return null;
        }
        public List<string> GetIssuesByDiscoverer(int projectId)
        {
            return null;
        }
        public Issue GetIssueById(int id)
        {
            var indexToReturn = issues.FindIndex(r => r.Id == id);
            if (indexToReturn != -1)
            {
                return issues[indexToReturn];
            }
            else
            {
                //Couldnt find issue
                return null;
            }
        }

        private string ValidateIssue(Issue issue)
        {
            if (string.IsNullOrEmpty(issue.Title))
                return EMPTY_TITLE_ERROR;
            if (issue.DiscoveryDate != null)
                return EMPTY_DISCOVERY_DATETIME_ERROR;
            if (issue.DiscoveryDate > DateTime.Now)
                return FUTURE_DISCOVERY_DATETIME_ERROR;
            if (string.IsNullOrEmpty(issue.Discoverer))
                return EMPTY_DISCOVERER_ERROR;
            if (isDuplicate(issue.Title))
                return "ERROR: Duplicate Title!";
            
            return NO_ERROR;
        }

        private bool isDuplicate(string title)
        {
            foreach(Issue issue in issues)
            {
                if(issue.Title == title)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
