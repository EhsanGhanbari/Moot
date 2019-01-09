using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moot.Service.Messages.Questions
{
    public class GetTagRequest
    {
        public Guid UserId { get; set; }
        public Guid QuestionId { get; set; }
    }
}
