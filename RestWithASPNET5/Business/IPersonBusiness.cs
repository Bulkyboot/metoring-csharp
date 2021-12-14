using RestWithASPNET5.Models;
using RestWithASPNET5.Models.Context;
using System.Collections.Generic;

namespace RestWithASPNET5.Services
{
    public interface IPersonBusiness
    {
        List<Person> FindAll();
        Person FindById(long id);
        Person Create(Person person);
        Person Update(Person person);
        void Delete(long id);
    }
}
