using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.Domain.Questions
{
    public class QuestionChoixUnique : Question 
    {
        public List<string> Propositions { get; set; }
    }
}
