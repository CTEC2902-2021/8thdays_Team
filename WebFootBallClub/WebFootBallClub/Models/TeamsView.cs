using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFootBallClub.Models
{
    public class TeamsView
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MP { get; set; }
        public int Win { get; set; }
        public int Draw { get; set; }
        public int Lose { get; set; }
        public int GF { get; set; }
        public int GA { get; set; }
        public int GD { get; set; }
        public int Pts { get; set; }
    }
}