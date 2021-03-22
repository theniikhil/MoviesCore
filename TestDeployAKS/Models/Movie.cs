using System;
using System.Collections.Generic;

#nullable disable

namespace TestDeployAKS.Models
{
    public partial class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Director { get; set; }
    }
}
