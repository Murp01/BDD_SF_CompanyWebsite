using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;
using RestSharp;

namespace CompanyWebsitePageFactory.APIMethods
{
    class APIRequests
    {
        string Board1 = "https://api.trello.com/1/boards/5d8a068a841027562d773c27?fields=name,url&key=ebd1f371dd70dc02f3ba8bece74198e3&token=a01ad06d09e40ed4b1a426b2107a2eab79bcced748f2c726dd441763c84f0023";

        [Test]
        public void GetWeatherInfo()
        {
            //Creates teh connection
            RestClient restClient = new RestClient("http://restapi.demoqa.com/utilities/weather/city/");

            RestRequest restRequest = new RestRequest("Guntur", Method.GET);
            //Can use the above request for different request types, e.g. post, delete etc)

            //This statement executes the restRequest (GET "Guntur") so restResponse contains the response
            IRestResponse restResponse = restClient.Execute(restRequest);

            //This collects all the content from restResponse 
            string response = restClient.Execute(restRequest).Content;

            if (!response.Contains("Guntur"))
            {
                Assert.Fail("Weather information is not displayed");
            }

        }

        public void PostRequest()
        {
            //https://itanex.blogspot.com/2012/02/restsharp-and-advanced-post-requests.html


            var client = new RestClient("http://www.example.com/where/else?key=value"); //add uri as parameter maybe concatonate for key
            var request = new RestRequest();
            string strJSONContent = ""; //body content for post goes here

            request.Method = Method.POST;
            request.AddHeader("Accept", "application/json");
            request.Parameters.Clear();
            request.AddParameter("application/json", strJSONContent, ParameterType.RequestBody);

            var response = client.Execute(request);
            //Comment
        }


        [Test]
        public void GetWeatherResponseCode()
        {
            string uri = "http://restapi.demoqa.com/utilities/weather/city/";
            string location = "Guntur";
            EnsureResponseIsOkay(uri, location);
        }


        public void EnsureResponseIsOkay(string uri, string location)
        {
            RestClient restClient = new RestClient(uri);
            RestRequest restRequest = new RestRequest(location, Method.GET);
            IRestResponse restResponse = restClient.Execute(restRequest);
            int StatusCode = (int)restResponse.StatusCode;
            Assert.AreEqual(200, StatusCode, "Status code is not 200");
            //comment to help with commit
        }
    }

}
}
