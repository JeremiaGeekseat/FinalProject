using DomainData;
using DomainRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainService
{
    interface IContactService : IRepository<Contact>
    {
    }
}
