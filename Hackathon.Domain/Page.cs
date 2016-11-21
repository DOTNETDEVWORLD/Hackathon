using System.Collections.Generic;

namespace Hackathon.Domain
{
    public class Page
    {
        public IList<Question> Questions { get; set; }

        public string Test { get; set; }
    }
}