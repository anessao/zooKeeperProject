using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace zooWorld.DataModels
{
    public class ZooKeeper
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FavoriteStarTrekSeries { get; set; }
        public DateTime StartDate { get; set; }
        public bool IsActive { get; set; }

    }
}