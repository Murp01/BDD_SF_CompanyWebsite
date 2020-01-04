using System;
using NUnit.Framework;
using RestSharp;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;


namespace CompanyWebsitePageFactory.APIMethods
{
    class APITests
    {
        //string Board1 = "https://api.trello.com/1/boards/5d9f30d4bd96ec8a9d4bd389?fields=name,url&key=ebd1f371dd70dc02f3ba8bece74198e3&token=a01ad06d09e40ed4b1a426b2107a2eab79bcced748f2c726dd441763c84f0023";
        string trelloURI = "https://api.trello.com/1";
        string boardID = "5da47ead4b6b976fb6299607";
        string listID = "5da457632e26ab5f02d33c6f";
        string key = "UPDATETHIS";
        string token = "UPDATETHIS";
        string delBoardID = "5da454018463d52c2e4fe42a";
        CreateBoardResponse createResponse;
        string listName = "New Test List";
        string cardID = "5da45e1347ae5063fcc2c6e2";
        string cardName = "New Card Test";


        [Test]
        public void CreateATrelloBoard()
        {
            APIActions action = new APIActions();
            CreateBoardResponse response = action.CreateBoard("RestSharpBoardTest");

            Console.WriteLine(response.id);
            Console.WriteLine(response.name);
            Console.WriteLine(response.url);

            this.createResponse = response;
        }

        [Test]
        public void E2EDeleteBoard()
        {
            APIActions action = new APIActions();
            CreateBoardResponse createResponse = action.CreateBoard("DeleteBoardTest");

            RestClient client = new RestClient(trelloURI);
            IRestRequest request = new RestRequest("/boards/" + createResponse.id);
            request.Method = Method.DELETE;

            request.AddParameter("key", key);
            request.AddParameter("token", token);

            IRestResponse response = client.Execute(request);
        }

        [Test]
        public void DeleteBoardByID()
        {
            APIActions action = new APIActions();
            action.DeleteBoard(delBoardID);
        }

        [Test]
        public void GetBoardByID()
        {
            APIActions action = new APIActions();
            action.GetBoard(boardID);

        }

        [Test]
        public void AssertBoardName()
        {
            APIActions actions = new APIActions();
            actions.AssertBoardProperty(boardID, "NAME");
        }

        [Test]
        public void AssertBoardID()
        {
            APIActions actions = new APIActions();
            actions.AssertBoardProperty(boardID, "ID");
        }

        [Test]
        public void CreateCardOnList()
        {
            APIActions actions = new APIActions();
            actions.CreateACard(boardID, listID, cardName);
        }

        [Test]
        public void CreateListOnBoard()
        {
            APIActions action = new APIActions();
            action.CreateAList(boardID, listName);
        }

        [Test]
        public void MoveCardToList()
        {
            //Doesn't work?
            APIActions actions = new APIActions();
            actions.MoveCardBetweenLists(boardID, cardID, listID);
        }










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
