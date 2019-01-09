using Moot.Business.Entities;
using Moot.Business.Interfaces;
using Moot.DAL.UnitOfWork;
using Moot.Service.Interfaces;
using Moot.Service.Mappers;
using Moot.Service.Messages.Contacts;

namespace Moot.Service.Implementation
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ContactService(IContactRepository contactRepository, IUnitOfWork unitOfWork)
        {
            _contactRepository = contactRepository;
            _unitOfWork = unitOfWork;
        }


        /// <summary>
        /// Create contatc
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public CreateContactResponse CreateContact(CreateContactRequest request)
        {
            var response = new CreateContactResponse();
            var contactViewModel = new CreateContactRequest
                {
                    Body = request.Body,
                    Email = request.Email,
                    Name = request.Name,
                    Title = request.Title
                };
          //  var contact = contactViewModel.
         //   _contactRepository.Add(contact);
           // _unitOfWork.Commit();
            return response;
        }


        /// <summary>
        /// Get Contact By it's Id
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetContactResponse GetContact(GetContactRequest request)
        {
            var response =new GetContactResponse();
            var requested = request.ContactId;
            var contact = _contactRepository.Get(requested);
            response.ContactViewModel = contact.ConvertToContactViewModel();
            return response;
        }


        /// <summary>
        /// Get All the contact that maed before!
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetContactResponse GetAllContact(GetContactRequest request)
        {
            var response = new GetContactResponse();
            var contactModel = _contactRepository.GetAll();
            response.ContactViewModelList = contactModel.ConvertToContactViewModelList();
            return response;
        }


        /// <summary>
        /// Remove contact Based on requested Id
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public RemoveContactResponse RemoveContact(RemoveContactRequest request)
        {
            var response = new RemoveContactResponse();
            var contactModel = new Contact {Id = request.ContactId};
            _contactRepository.Delete(contactModel);
            _unitOfWork.Commit();
            return response;
        }
    }
}
