using System;
using NUnit.Framework;
using RestSharp;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace CompanyWebsitePageFactory.APIMethods
{
    class APIActions
    {
        //CreateBoardResponse createResponse;
        //string newBoardID;
        string trelloURI = "https://api.trello.com/1";
        string key = "UpdateTHIS";
        string token = "UpdateTHIS";


        public CreateBoardResponse CreateBoard(string name)
        {
            RestClient client = new RestClient(trelloURI);

            IRestRequest request = new RestRequest("/boards");

            //createBoardRequest becomes POST method
            request.Method = Method.POST;

            //at this point createboardrequest is a post method.  Here we add parameters
            //request.AddParameter("idBoard", boardID);   //is this used? IF ISSUES LOOK HERE
            request.AddParameter("name", name);
            request.AddParameter("key", key);
            request.AddParameter("token", token);

            //website stated IRestRequest - error can't convert response to request
            //create response is an object that contains the json data
            IRestResponse response = client.Execute(request);

            int StatusCode = (int)response.StatusCode;
            Assert.AreEqual(200, StatusCode, "Status code is not 200");

            return JsonConvert.DeserializeObject<CreateBoardResponse>(response.Content);
        }

        public void GetBoard(string boardID)
        {


            //Do I need to even create the parameters again or just call from the class
            //test can only be ran if board has been created.  Better way to do this?
            RestClient client = new RestClient(trelloURI);
            IRestRequest request = new RestRequest("/boards/" + boardID);

            request.Method = Method.GET;
            request.AddParameter("key", key);
            request.AddParameter("token", token);

            IRestResponse createResponse = client.Execute(request); //there is a problem on this line

            string returnedJson = createResponse.Content;

            dynamic api = JObject.Parse(returnedJson);

            var id = api.id;
            var name = api.name;
            var url = api.url;

            Console.WriteLine("I can confirm that the id is " + id);
            Console.WriteLine("I can confirm that the board name is " + name);
        }

        public void DeleteBoard(string boardID)
        {
            RestClient client = new RestClient(trelloURI);
            IRestRequest request = new RestRequest("/boards/" + boardID);
            request.Method = Method.DELETE;

            request.AddParameter("key", key);
            request.AddParameter("token", token);

            IRestResponse response = client.Execute(request);
            int StatusCode = (int)response.StatusCode;
            Assert.AreEqual(200, StatusCode, "Status code is not 200");


        }

        public void AssertBoardProperty(string boardID, string property)
        {
            //Might need to add an extra argument for boardID
            RestClient client = new RestClient(trelloURI);
            IRestRequest request = new RestRequest("/boards/" + boardID);
            request.Method = Method.GET;
            request.AddParameter("key", key);
            request.AddParameter("token", token);
            IRestResponse createResponse = client.Execute(request); //there is a problem on this line
            string returnedJson = createResponse.Content;
            dynamic api = JObject.Parse(returnedJson);

            var id = api.id;
            var name = api.name;
            var url = api.url;

            switch (property)
            {
                case "ID":
                  Console.WriteLine("I can confirm that the id is " + id);
                    Assert.That(id == "5d9f30d4bd96ec8a9d4bd389");
                    break;
                case "NAME":
                   Console.WriteLine("I can confirm that the board name is " + name);
                    Assert.That(name == "NewBoardcatpuredVariable"); 
                    break;
            }
        }

        public void CreateACard(string boardID, string listID, string cardName)
        {
            RestClient client = new RestClient(trelloURI);
            IRestRequest request = new RestRequest("/cards");
            request.Method = Method.POST;

            request.AddParameter("name", cardName);
            request.AddParameter("key", key);
            request.AddParameter("token", token);
            request.AddParameter("idBoard", boardID);
            request.AddParameter("idList", listID);

            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }

        public void CreateAList(string boardID, string listName)
        {
            RestClient client = new RestClient(trelloURI);
            IRestRequest request = new RestRequest("/lists");
            request.Method = Method.POST;
         
            request.AddParameter("name", listName);
            request.AddParameter("key", key);
            request.AddParameter("token", token);
            request.AddParameter("idBoard", boardID);

            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }

        public void MoveCardBetweenLists(string boardID, string cardID, string listID)
        {
            RestClient client = new RestClient(trelloURI);
            IRestRequest request = new RestRequest("/cards");
            request.Method = Method.PUT;

            request.AddParameter("key", key);
            request.AddParameter("token", token);
            request.AddParameter("idList", listID);

            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }

    }
}
