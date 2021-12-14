using RestWithASPNET5.Models;
using RestWithASPNET5.Models.Context;
using RestWithASPNET5.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestWithASPNET5.Services.Implementations
{
    public class PersonBusinessImplementation : IPersonBusiness
    {
        private readonly IPersonRepository _repository;
        private object _context;

        public PersonBusinessImplementation(IPersonRepository repository) 
        {
            _repository = repository;
        }
        public Person Create(Person person)
        {
            //try {
            //    _context.Add(person);
            //    _context.SaveChanges();
            //} 
            //catch(Exception) 
            //{
            //    throw;
            //}
            //return person;
            return _repository.Create(person);
        }

        public void Delete(long id)
        {
            //var oldPerson = _context.Persons.SingleOrDefault(p => p.Id.Equals(id));
            //if (oldPerson != null) {
            //    try 
            //    {
            //        _context.Persons.Remove(oldPerson);
            //        _context.SaveChanges();
            //    }
            //    catch(Exception) {
            //        throw;
            //    }
            //}
            _repository.Delete(id);
        }

        public List<Person> FindAll()
        {
            //return _context.Persons.ToList();
            return _repository.FindAll();
        }

        public Person FindById(long id)
        {
            //return _context.Persons.SingleOrDefault(p => p.Id == id);
            return _repository.FindById(id);
        }

        public Person Update(Person person)
        {
            //if (Exists(person.Id))
            //{
            //    var oldPerson = _context.Persons.SingleOrDefault(p => p.Id.Equals(person.Id));
            //    if (oldPerson != null)
            //    {
            //        try
            //        {
            //            _context.Entry(oldPerson).CurrentValues.SetValues(person);
            //            _context.SaveChanges();
            //        }
            //        catch (Exception)
            //        {
            //            throw;
            //        }
            //        return person;
            //    }
            //}

            //return null;
            return _repository.Update(person);
        }

    //    private bool Exists(long id)
    //    {
    //        //return _context.Persons.Any(p => p.Id.Equals(id));
    //    }
    }
}

