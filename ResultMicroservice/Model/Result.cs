using System.Collections.Generic;

namespace ResultMicroservice.Model
{
    public class Result
    {
        public int StudentId { get; set; }

        public Dictionary<string, string> result { get; set; }
    }
}
