using System;
using System.Collections.Generic;
using System.Text;
using App.DataLayer.Models;

namespace App.Service.Services.Interfaces
{
    public interface IuserService
    {
        Person GetPerson(int id);
        List<Person> GetAllPerson();

    }
}
