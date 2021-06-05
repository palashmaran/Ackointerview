using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ackointerview.Controllers
{
    public class Teamview
    {
        public int ID { get; set; }
        public string name { get; set; }

        public Teamview(int ID, string name)
        {
            this.ID = ID;
            this.name = name;
        }

    }
}