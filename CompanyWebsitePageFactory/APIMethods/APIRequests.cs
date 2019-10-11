using System;
using NUnit.Framework;
using RestSharp;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace CompanyWebsitePageFactory.APIMethods
{
    class APIRequests
    {
        //string Board1 = "https://api.trello.com/1/boards/5d9f30d4bd96ec8a9d4bd389?fields=name,url&key=ebd1f371dd70dc02f3ba8bece74198e3&token=a01ad06d09e40ed4b1a426b2107a2eab79bcced748f2c726dd441763c84f0023";
        string trelloURI = "https://api.trello.com/1";
        string boardID = "5d9f30d4bd96ec8a9d4bd389";
        string listID = "5d9f3dcf1aea3f44c1e9685d";
        string key = "ebd1f371dd70dc02f3ba8bece74198e3";
        string token = "a01ad06d09e40ed4b1a426b2107a2eab79bcced748f2c726dd441763c84f0023";
        CreateBoardResponse createResponse;
        string newBoardID;

        [Test]
        public void CreateATrelloBoard()
        {
            RestClient client = new RestClient(trelloURI);

            IRestRequest createBoardRequest = new RestRequest("/boards");

            //createBoardRequest becomes POST method
            createBoardRequest.Method = Method.POST;

            //at this point createboardrequest is a post method.  Here we add parameters
            createBoardRequest.AddParameter("idBoard", boardID);
            createBoardRequest.AddParameter("name", "RestSharpBoard");
            createBoardRequest.AddParameter("key", key);
            createBoardRequest.AddParameter("token", token);

            //website stated IRestRequest - error can't convert response to request
            //create response is an object that contains the json data
            IRestResponse createResponse = client.Execute(createBoardRequest);

            //the output will be displayed within test explorer.  Click output after result
            Console.WriteLine(createResponse.Content);

            //deserialize json object into a class
            //variable that stores response content (currently json format)
            string returnedJson = createResponse.Content;

            CreateBoardResponse response = JsonConvert.DeserializeObject<CreateBoardResponse>(returnedJson);

            Console.WriteLine(response.id);
            Console.WriteLine(response.name);
            Console.WriteLine(response.url);

            this.createResponse = response;

            string newBoardID = response.id;

        }

        [Test]
        public void GetBoardByID()
        {
            //Do I need to even create the parameters again or just call from the class
            //test can only be ran if board has been created.  Better way to do this?
            RestClient client = new RestClient(trelloURI);
            IRestRequest editBoardRequest = new RestRequest("/boards/" + newBoardID);

            editBoardRequest.Method = Method.GET;
            editBoardRequest.AddParameter("key", key);
            editBoardRequest.AddParameter("token", token);

            IRestResponse createResponse = client.Execute(editBoardRequest); //there is a problem on this line

            string returnedJson = createResponse.Content;

            dynamic api = JObject.Parse(returnedJson);

            var id = api.id;
            var name = api.name;
            var url = api.url;

            Console.WriteLine("I can confirm that the id is " + id);
        }

        //Get property from board
        public void GetPropertiesFromBoard()
        {

        }


        //public T ReturnJsonObject<T> (ref T jsonData)
        //{
        //    //objectHere json = JsonConvert.DeserializeObject<objectHere>(jsonData);
        //} 




        [Test]
        public void CreateATrelloCard()
        {
            RestClient client = new RestClient(trelloURI);

            IRestRequest createCardRequest = new RestRequest("/cards");

            createCardRequest.Method = Method.POST;

            createCardRequest.AddParameter("idBoard", boardID);
            createCardRequest.AddParameter("name", "TestAddCard");
            createCardRequest.AddParameter("idList", listID);
            createCardRequest.AddParameter("key", key);
            createCardRequest.AddParameter("token", token);

            //website stated IRestRequest - error can't convert response to request
            IRestResponse createResponse = client.Execute(createCardRequest);

            Console.WriteLine(createResponse.Content);
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
