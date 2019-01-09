using System;
using Moot.Business.Interfaces;
using Moot.DAL.UnitOfWork;
using Moot.Service.Interfaces;
using Moot.Service.Messages.Blogs;

namespace Moot.Service.Implementation
{
    public class BlogService :IBlogService
    {
        private readonly IBlogRepository _blogRepository;
        private readonly IUnitOfWork _unitOfWork;

        public BlogService(IBlogRepository blogRepository, IUnitOfWork unitOfWork)
        {
            _blogRepository = blogRepository;
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public CreatePostResponse CreatePost(CreatePostRequest request)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetPostResponse GetPost(GetPostRequest request)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetPostResponse GetAllPost(GetPostRequest request)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public RemovePostResponse RemovePost(RemovePostRequest request)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public UpdatePostResponse UpdatePost(UpdatePostRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
