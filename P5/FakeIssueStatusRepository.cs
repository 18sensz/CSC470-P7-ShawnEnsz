using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    public class FakeIssueStatusRepository : IIssueStatusRepository
    {
        private List<IssueStatus> issueStatuses;

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
