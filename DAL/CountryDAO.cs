using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;
using MongoDB.Driver;

namespace DAL
{
    public class CountryDAO
    {
        private readonly MongoService<User> _repository;
    }
}
