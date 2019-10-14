using System;
using NUnit.Framework;
using RestSharp;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using CompanyWebsitePageFactory.APIMethods;
using NUnit.Framework;

namespace CompanyWebsitePageFactory.APIMethods
{
    class APIActions
    {
        //string Board1 = "https://api.trello.com/1/boards/5d9f30d4bd96ec8a9d4bd389?fields=name,url&key=ebd1f371dd70dc02f3ba8bece74198e3&token=a01ad06d09e40ed4b1a426b2107a2eab79bcced748f2c726dd441763c84f0023";
        string trelloURI = "https://api.trello.com/1";
        string boardID = "5d9f30d4bd96ec8a9d4bd389";
        string listID = "5d9f3dcf1aea3f44c1e9685d";
        string key = "ebd1f371dd70dc02f3ba8bece74198e3";
        string token = "a01ad06d09e40ed4b1a426b2107a2eab79bcced748f2c726dd441763c84f0023";
        CreateBoardResponse createResponse;
        string newBoardID;

        public CreateBoardResponse CreateBoard(string name)
        {
            RestClient client = new RestClient(trelloURI);

            IRestRequest request = new RestRequest("/boards");

            //createBoardRequest becomes POST method
            request.Method = Method.POST;

            //at this point createboardrequest is a post method.  Here we add parameters
            request.AddParameter("idBoard", boardID);   //is this used?
            request.AddParameter("name", name);
            request.AddParameter("key", key);
            request.AddParameter("token", token);

            //website stated IRestRequest - error can't convert response to request
            //create response is an object that contains the json data
            IRestResponse response = client.Execute(request);

            return JsonConvert.DeserializeObject<CreateBoardResponse>(response.Content);
        }

        public void DeleteBoard(string boardID)
        {
            RestClient client = new RestClient(trelloURI);
            IRestRequest request = new RestRequest("/boards/" + boardID);
            request.Method = Method.DELETE;

            request.AddParameter("key", key);
            request.AddParameter("token", token);

            IRestResponse response = client.Execute(request);
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

        public void AssertBoardProperty(string property)
        {
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
    }
}
