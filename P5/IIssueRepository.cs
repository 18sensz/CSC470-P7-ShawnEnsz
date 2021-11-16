﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace P5
{
    interface IIssueRepository
    {
        string Add(Issue issue);
        List<string> GetAll(int projectId);
        bool Remove(Issue issue);
        string Modify(Issue issue);
        int GetTotalNumberOfIssues(int projectId);
        List<string> GetIssuesByMonth(int projectId);
        List<string> GetIssuesByDiscoverer(int projectId);
        Issue GetIssueById(int id);
    }
}
