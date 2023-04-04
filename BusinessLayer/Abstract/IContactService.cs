using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContactService
    {
        List<Contact> GetList();
        Contact GetByID(int id);
        void CategoryAdd(Contact contact);
        void CategoryDelete(Contact contact);
        void CategoryUpdate(Contact contact);
    }
}
