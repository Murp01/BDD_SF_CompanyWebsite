using System;
using NUnit.Framework;
using RestSharp;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using CompanyWebsitePageFactory.APIMethods;

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
            request.AddParameter("idBoard", boardID);
            request.AddParameter("name", name);
            request.AddParameter("key", key);
            request.AddParameter("token", token);

            //website stated IRestRequest - error can't convert response to request
            //create response is an object that contains the json data
            IRestResponse response = client.Execute(request);

            return JsonConvert.DeserializeObject<CreateBoardResponse>(response.Content);
        }
    }
}
