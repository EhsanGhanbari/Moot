using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moot.Business.Entities;
using Moot.Business.Interfaces;
using Moot.DAL.UnitOfWork;

namespace Moot.DAL.Repositories
{
    public class QuestionRepository :Repository<Question>,IQuestionRepository 
    {
        public QuestionRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public override IQueryable<Question> GetObjectSet()
        {
            throw new NotImplementedException();
        }
    }
}
