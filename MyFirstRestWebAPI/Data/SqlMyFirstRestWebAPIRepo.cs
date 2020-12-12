using MyFirstRestWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstRestWebAPI.Data
{
    public class SqlMyFirstRestWebAPIRepo : IMyFirstRestWebAPIRepo
    {
        private readonly MyFirstRestWebAPIContext _context;

        public SqlMyFirstRestWebAPIRepo(MyFirstRestWebAPIContext context)
        {
            _context = context;
        }
        public Command GetItemById(int id)
        {
            return _context.Commands.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Command> GetItems()
        {
            return _context.Commands.ToList();
        }
    }
}
