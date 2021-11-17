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
        private static List<Issue> issues = new List<Issue>();

        public FakeIssueRepository()
        {
            if(issues.Count < 1)
            {
                Issue tempIssue = new Issue()
                {
                    Id = 1,
                    ProjectId = 1,
                    Title = "Starting Issue",
                    DiscoveryDate = DateTime.Now,
                    Discoverer = "Shawn Ensz",
                    InitialDescription = "This is a test starting issue.",
                    Component = "Test Component",
                    IssueStatusId = 1,
                };
                issues.Add(tempIssue);

                tempIssue = new Issue()
                {
                    Id = 2,
                    ProjectId = 1,
                    Title = "New Issue",
                    DiscoveryDate = DateTime.Now,
                    Discoverer = "Shawn Ensz",
                    InitialDescription = "This is a test starting issue.",
                    Component = "Test Component",
                    IssueStatusId = 1,
                };
                issues.Add(tempIssue);

                tempIssue = new Issue()
                {
                    Id = 3,
                    ProjectId = 1,
                    Title = "boop Issue",
                    DiscoveryDate = DateTime.Now,
                    Discoverer = "Dave Bishop",
                    InitialDescription = "This is a test starting issue.",
                    Component = "Test Component",
                    IssueStatusId = 1,
                };
                issues.Add(tempIssue);

                tempIssue = new Issue()
                {
                    Id = 4,
                    ProjectId = 2,
                    Title = "new porj Issue",
                    DiscoveryDate = DateTime.Now,
                    Discoverer = "Dave Bishop",
                    InitialDescription = "This is a test starting issue.",
                    Component = "Test Component",
                    IssueStatusId = 1,
                };
                issues.Add(tempIssue);
            }
            
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
            var indexToModify = issues.FindIndex(r => r.Id == issue.Id);
            if (ValidateIssue(issue) != NO_ERROR && (issue.Title != issues[indexToModify].Title))
                return ValidateIssue(issue);
           
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
            List<string> displayList = new List<string>();
            List<Issue> projectIssues = GetAll(projectId);
            string tmpString;

            foreach(Issue issue in projectIssues)
            {
                tmpString = $"{issue.DiscoveryDate.Year} - {issue.DiscoveryDate.Month}: {issue.Id}";
                displayList.Add(tmpString);
            }
            return displayList;
        }
        public List<string> GetIssuesByDiscoverer(int projectId)
        {
            List<string> displayList = new List<string>();
            List<Issue> projectIssues = GetAll(projectId);
            string tmpString;

            foreach (Issue issue in projectIssues)
            {
                tmpString = $"{issue.Discoverer}: {issue.Id}";
                displayList.Add(tmpString);
            }
            return displayList;
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
            if (issue.DiscoveryDate == null)
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
