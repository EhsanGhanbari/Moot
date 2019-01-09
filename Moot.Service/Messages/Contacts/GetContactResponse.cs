using System.Collections.Generic;
using Moot.Service.ViewModels;

namespace Moot.Service.Messages.Contacts
{
    public class GetContactResponse
    {
        public ContactViewModel ContactViewModel { get; set; }
        public IEnumerable<ContactViewModel> ContactViewModelList { get; set; } 
    }
}
