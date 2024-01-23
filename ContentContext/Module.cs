using System.Collections.Generic;

namespace P01.ContentContext
{
    public class Module
    {
        public Module()
        {
            var Lectures = new List<Lecture>();
        }
        public int Order { get; set; }
        public string Title { get; set; }
        public IList<Lecture> Lectures { get; set; }
    }

}

