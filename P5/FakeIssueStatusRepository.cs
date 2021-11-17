using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    public class FakeIssueStatusRepository : IIssueStatusRepository
    {
        private static List<IssueStatus> issueStatuses = new List<IssueStatus>();

        public FakeIssueStatusRepository()
        {
            Add(1, "Open");
            Add(2, "Assigned");
            Add(3, "Fixed");
            Add(4, "Closed - Won't Fix");
            Add(5, "Closed - Fixed");
            Add(6, "Closed - by design");
        }

        public void Add(int id, string value)
        {
            IssueStatus newStatus = new IssueStatus()
            {
                Id = id,
                Value = value
            };
            issueStatuses.Add(newStatus);
        }
        public List<IssueStatus> GetAll()
        {
            return issueStatuses;
        }
        public int GetIdByStatus(string value)
        {
            var index = issueStatuses.FindIndex(r => r.Value == value);
            return issueStatuses[index].Id;
        }
        public string GetValueById(int id)
        {
            var index = issueStatuses.FindIndex(r => r.Id == id);
            return issueStatuses[index].Value;
        }
    }
}
