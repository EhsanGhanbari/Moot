using System;
using Moot.Business.Interfaces;
using Moot.DAL.UnitOfWork;
using Moot.Service.Interfaces;
using Moot.Service.Messages.Questions;
using CreateTagResponse = Moot.Service.Messages.Tags.CreateTagResponse;

namespace Moot.Service.Implementation
{
    public class QuestionService:IQuestionService
    {
        private readonly IQuestionRepository _questionRepository;
        private readonly IUnitOfWork _unitOfWork;

        public QuestionService(IQuestionRepository questionRepository, IUnitOfWork unitOfWork)
        {
            _questionRepository = questionRepository;
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// Create Question by 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public CreateTagResponse CreateQuestion(CreateTagRequest request)
        {
            throw new NotImplementedException();
        }

        public GetQuestionResponse GetQuestion(GetTagRequest request)
        {
            throw new NotImplementedException();
        }

        public GetQuestionResponse GetAllQuestions(GetTagRequest request)
        {
            throw new NotImplementedException();
        }

        public UpdateQuestionResponse UpdateQuestion(UpdateQuestionRequest request)
        {
            throw new NotImplementedException();
        }

        public RemoveQuestionResponse RemoveQuestion(RemoveQuestionRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
