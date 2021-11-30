using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    public class FakeFeatureRepository : IFeatureRepository
    {
        public string NO_ERROR = "";
        public string DUPLICATE_TITLE_ERROR = "Title must be unique.";
        public string EMPTY_TITLE_ERROR = "Title must have a value.";
        public string NOT_FOUND_ERROR = "Feature not found.";
        public string INVALID_PROJECT_ID_ERROR = "Invalid Project Id for Feature.";

        private static List<Feature> features = new List<Feature>();

        public FakeFeatureRepository()
        {
            if(features.Count < 1)
            {
                features.Add(
                    new Feature()
                    {
                        Id = 1,
                        ProjectId = 1,
                        Title = "Default Feature"
                        
                    }
                );

                features.Add(
                    new Feature()
                    {
                        Id = 2,
                        ProjectId = 1,
                        Title = "Second Feature"

                    }
                );
            }
        }

        public string Add(Feature feature)
        {
            if (GetFeatureByTitle(feature.ProjectId, feature.Title) != null)
                return DUPLICATE_TITLE_ERROR;
            if (string.IsNullOrEmpty(feature.Title))
                return EMPTY_TITLE_ERROR;
            
            feature.Id = features.Count + 1;
            features.Add(feature);
            return NO_ERROR;
        }
        public List<Feature> GetAll(int projectId)
        {
            List<Feature> returnList = new List<Feature>();
            foreach(Feature feature in features)
            {
                if (feature.ProjectId == projectId)
                    returnList.Add(feature);
            }
            return returnList;
        }
        public string Remove(Feature feature)
        {
            var featureToRemove = features.FindIndex(r => r.Id == feature.Id);
            if (featureToRemove == -1)
                return NOT_FOUND_ERROR;
            features.RemoveAt(featureToRemove);
            return NO_ERROR;
        }
        public string Modify(Feature feature)
        {
            var featureToModify = features.FindIndex(r => r.Id == feature.Id);
            if (featureToModify == -1)
                return NOT_FOUND_ERROR;

            if (GetFeatureByTitle(feature.ProjectId, feature.Title) != null)
                return DUPLICATE_TITLE_ERROR;
            if (string.IsNullOrEmpty(feature.Title))
                return EMPTY_TITLE_ERROR;
            features.RemoveAt(featureToModify);
            features.Add(feature);
            return NO_ERROR;
        }
        public Feature GetFeatureById(int projectId, int featureId)
        {
            List<Feature> searchList = new List<Feature>();
            Feature returnFeat = new Feature();
            searchList = GetAll(projectId);

            var featureToReturn = features.FindIndex(r => r.Id == featureId);

            if (featureToReturn != -1)
            {
                returnFeat.Id = features[featureToReturn].Id;
                returnFeat.ProjectId = features[featureToReturn].ProjectId;
                returnFeat.Title = features[featureToReturn].Title;
                return returnFeat;
            }
            else
            {
                return null;
            }
                
        }
        public Feature GetFeatureByTitle(int projectId, string title)
        {
            List<Feature> searchList = new List<Feature>();
            Feature returnFeat = new Feature();
            searchList = GetAll(projectId);

            var featureToReturn = searchList.FindIndex(r => r.Title == title);
            if (featureToReturn != -1)
            {
                returnFeat.Id = features[featureToReturn].Id;
                returnFeat.ProjectId = features[featureToReturn].ProjectId;
                returnFeat.Title = features[featureToReturn].Title;
                return returnFeat;
            }
            else
            {
                return null;
            }
        }
    }
}
