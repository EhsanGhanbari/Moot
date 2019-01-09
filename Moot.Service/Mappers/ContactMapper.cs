using System.Collections.Generic;
using AutoMapper;
using Moot.Business.Entities;
using Moot.Service.ViewModels;

namespace Moot.Service.Mappers
{
    public static class ContactMapper
    {
        /// <summary>
        /// Convert to Contact Model
        /// </summary>
        /// <param name="contactViewModel"></param>
        /// <returns></returns>
        public static Contact ConvertToContactModel(this ContactViewModel contactViewModel)
        {
            return Mapper.Map<ContactViewModel, Contact>(contactViewModel);
        }



        /// <summary>
        /// Convert to ContactViewModel 
        /// </summary>
        /// <param name="contact"></param>
        /// <returns></returns>
        public static ContactViewModel ConvertToContactViewModel(this Contact contact)
        {
            return Mapper.Map<Contact, ContactViewModel>(contact);
        }



        /// <summary>
        /// Convert To contact ViewModel List
        /// </summary>
        /// <param name="contacts"></param>
        /// <returns></returns>
        public static IEnumerable<ContactViewModel> ConvertToContactViewModelList(
            this IEnumerable<Contact> contacts)
        {
            return Mapper.Map<IEnumerable<Contact>, IEnumerable<ContactViewModel>>(contacts);
        }
      
    }
}
