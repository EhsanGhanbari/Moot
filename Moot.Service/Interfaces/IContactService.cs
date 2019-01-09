using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moot.Service.Messages.Contacts;

namespace Moot.Service.Interfaces
{
    public interface IContactService
    {
        CreateContactResponse CreateContact(CreateContactRequest request);
        GetContactResponse GetContact(GetContactRequest request);
        GetContactResponse GetAllContact(GetContactRequest request);
        RemoveContactResponse RemoveContact(RemoveContactRequest request);
    }
}
