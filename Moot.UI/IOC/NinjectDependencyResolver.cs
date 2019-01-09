using System;
using System.Web.Mvc;
using System.Web.Routing;
using Moot.Business.Interfaces;
using Moot.DAL.Repositories;
using Moot.DAL.UnitOfWork;
using Moot.Service.Implementation;
using Moot.Service.Interfaces;
using Ninject;

namespace Moot.UI.IOC
{
    public class NinjectDependencyResolver : DefaultControllerFactory
    {
        private static IKernel _ninjectKernel;

        public NinjectDependencyResolver()
        {
            _ninjectKernel = new StandardKernel();
            ConfigurDepndency();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)_ninjectKernel.Get(controllerType);
        }

        private static void ConfigurDepndency()
        {
            //Base
            _ninjectKernel.Bind<IUnitOfWork>().To<UnitOfWork>();


            //Contact
            _ninjectKernel.Bind<IContactRepository>().To<ContactRepository>();
            _ninjectKernel.Bind<IContactService>().To<ContactService>();


            //Question
            _ninjectKernel.Bind<IQuestionRepository>().To<QuestionRepository>();
            _ninjectKernel.Bind<IQuestionService>().To<QuestionService>();


            //Tag
            _ninjectKernel.Bind<ITagRepository>().To<TagRepository>();
            _ninjectKernel.Bind<ITagService>().To<TagService>();


            //User
            _ninjectKernel.Bind<IUserRepository>().To<UserRepository>();
            _ninjectKernel.Bind<IUserService>().To<UserService>();



            //Blog
            _ninjectKernel.Bind<IBlogRepository>().To<BlogRepository>();
            _ninjectKernel.Bind<IBlogService>().To<BlogService>();
        }
    }
}