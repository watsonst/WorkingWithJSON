using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace WorkingWithJSON
{
    public class Movie
    {
        [JsonProperty(propertyName: "movie_title")] //property name attribute overrides property name. We add this to change the name of the property in the Json. JS and C# conflict
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Runtime { get; set; }
    }
}
