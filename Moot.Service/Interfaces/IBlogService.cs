using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moot.Service.Messages.Blogs;

namespace Moot.Service.Interfaces
{
    public interface IBlogService
    {
        CreatePostResponse CreatePost(CreatePostRequest request);
        GetPostResponse GetPost(GetPostRequest request);
        GetPostResponse GetAllPost(GetPostRequest request);
        RemovePostResponse RemovePost(RemovePostRequest request);
        UpdatePostResponse UpdatePost(UpdatePostRequest request);

    }
}
