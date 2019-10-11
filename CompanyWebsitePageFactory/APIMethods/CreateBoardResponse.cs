using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebsitePageFactory.APIMethods
{
    public class CreateBoardResponse
    {
        public string id { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public object descData { get; set; }
        public bool closed { get; set; }
        public object idOrganization { get; set; }
        public bool pinned { get; set; }
        public string url { get; set; }

    }
}
