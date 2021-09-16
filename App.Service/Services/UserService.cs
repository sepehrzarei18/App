using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App.DataLayer.Models;
using App.DataLayer.Models.Context;
using App.Service.Services.Interfaces;

namespace App.Service.Services
{
    public class UserService : IuserService
    {
        private AppDbContext _context;

        public UserService(AppDbContext context)
        {
            _context = context;
        }

        public List<Person> GetAllPerson()
        {
            return _context.Persons.ToList();
        }

        public Person GetPerson(int id)
        {
            if (id == null)
                throw new Exception("not found");

            return _context.Persons.Find(id);
        }
    }
}
