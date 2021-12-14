using RestWithASPNET5.Models;
using RestWithASPNET5.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestWithASPNET5.Repositories.Implementations
   
{
    public class PersonRepositoryImplementation : IPersonRepository
         
    {
        private SqlServerContext _context;
        public PersonRepositoryImplementation(SqlServerContext context)
        {
            _context = context;
        }
        public Person Create(Person person)
        {
            try
            {
                _context.Add(person);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
            return person;
        }

        public void Delete(long id)
        {
            var oldPerson = _context.Persons.SingleOrDefault(p => p.Id.Equals(id));
            if (oldPerson != null)
            {
                try
                {
                    _context.Persons.Remove(oldPerson);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public List<Person> FindAll()
        {
                return _context.Persons.ToList();
        }

        public Person FindById(long id)
        {
            throw new System.NotImplementedException();
        }

        public Person Update(Person person)
        {
            if (Exists(person.Id))
            {
                var oldPerson = _context.Persons.SingleOrDefault(p => p.Id.Equals(person.Id));
                if (oldPerson != null)
                {
                    try
                    {
                        _context.Entry(oldPerson).CurrentValues.SetValues(person);
                        _context.SaveChanges();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    return person;
                }
            }

            return null;
        }

        public bool Exists(long id)
        {
            return _context.Persons.Any(p => p.Id.Equals(id));
        }
    }
}
