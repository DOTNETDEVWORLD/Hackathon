using System.Collections.Generic;

namespace Hackathon.Domain
{
    public class Page
    {
        public ICollection<Question> Questions { get; set; }
    }
}