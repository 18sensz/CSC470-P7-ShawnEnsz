using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    public class FakeRequirementRepository : IRequirementRepository
    {
        public string NO_ERROR = "";
        public string DUPLICATE_STATEMENT_ERROR = "Statements must be unique.";
        public string EMPTY_STATEMENT_ERROR = "Statements must have a value.";
        public string REQUIREMENT_NOT_FOUND_ERROR = "Requirement does not exist.";
        public string MISSING_FEATUREID_ERROR = "Must select a requirement for this requirement.";
        public string MISSING_PROJECTID_ERROR = "Must select a project for this requirement.";

        private static List<Requirement> requirements = new List<Requirement>();

        public string Add(Requirement requirement)
        {
            if (requirement.FeatureId > 0)
                return MISSING_FEATUREID_ERROR;
            if (requirement.ProjectId > 0)
                return MISSING_PROJECTID_ERROR;
            if (GetAll(requirement.ProjectId).FindIndex(r => r.Statement == requirement.Statement) != -1)
                return DUPLICATE_STATEMENT_ERROR;
            if (string.IsNullOrEmpty(requirement.Statement))
                return EMPTY_STATEMENT_ERROR;
            requirement.Id = requirements.Count + 1;

            requirements.Add(requirement);
            return NO_ERROR;
        }
        public List<Requirement> GetAll(int projectId)
        {
            List<Requirement> returnList = new List<Requirement>();
            foreach (Requirement requirement in requirements)
            {
                if (requirement.ProjectId == projectId)
                    returnList.Add(requirement);
            }
            return returnList;
        }
        public string Remove(Requirement requirement)
        {
            var requirementToRemove = requirements.FindIndex(r => r.Id == requirement.Id);
            if (requirementToRemove == -1)
                return REQUIREMENT_NOT_FOUND_ERROR;
            requirements.RemoveAt(requirementToRemove);
            return NO_ERROR;
        }
        public string Modify(Requirement requirement)
        {
            var requirementToModify = requirements.FindIndex(r => r.Id == requirement.Id);
            if (requirementToModify == -1)
                return REQUIREMENT_NOT_FOUND_ERROR;

            requirements.RemoveAt(requirementToModify);
            if (GetAll(requirement.ProjectId).FindIndex(r => r.Statement == requirement.Statement) != -1)
                return DUPLICATE_STATEMENT_ERROR;
            if (string.IsNullOrEmpty(requirement.Statement))
                return EMPTY_STATEMENT_ERROR;

            requirements.Add(requirement);
            return NO_ERROR;
        }
        public Requirement GetRequirementById(int projectId, int requirementId)
        {
            List<Requirement> searchList = new List<Requirement>();
            searchList = GetAll(projectId);

            var requirementToReturn = searchList.FindIndex(r => r.Id == requirementId);

            return requirements[requirementToReturn];
        }
        public int CountByFeatureId(int featureId)
        {
            int count = 0;
            foreach(Requirement requirement in requirements)
            {
                if (requirement.FeatureId == featureId)
                    count++;
            }
            return count;
        }
        public void RemoveByFeatureId(int featureId)
        {
            foreach (Requirement requirement in requirements)
            {
                if (requirement.FeatureId == featureId)
                    Remove(requirement);
            }
        }
    }
}
