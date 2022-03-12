using RestSharp;
using UOM.Tests.Acceptance.Model;

namespace UOM.Tests.Acceptance.Tasks
{
    internal class DimensionTask
    {
        internal bool DefineDimension(DimensionTestModel dimensionTest)
        {
            var restClient = new RestClient("http://localhost:2000/api");
            var restRequest = new RestRequest("Dimensions", Method.Post);
            restRequest.AddObject(dimensionTest);
            var result = restClient.ExecutePostAsync(restRequest).Result;
            return result.IsSuccessful;
        }
    }
}