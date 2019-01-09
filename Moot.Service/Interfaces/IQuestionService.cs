using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moot.Service.Messages.Questions;
using CreateTagResponse = Moot.Service.Messages.Tags.CreateTagResponse;

namespace Moot.Service.Interfaces
{
    public interface IQuestionService
    {
        CreateTagResponse CreateQuestion(CreateTagRequest request);
        GetQuestionResponse GetQuestion(GetTagRequest request);
        GetQuestionResponse GetAllQuestions(GetTagRequest request);
        UpdateQuestionResponse UpdateQuestion(UpdateQuestionRequest request);
        RemoveQuestionResponse RemoveQuestion(RemoveQuestionRequest request);
    }
}
