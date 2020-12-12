using MyFirstRestWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstRestWebAPI.Data
{
    public interface IMyFirstRestWebAPIRepo
    {
        IEnumerable<Command> GetItems(); //Command in here is used Command class from Models
        Command GetItemById(int id);
    }
}
