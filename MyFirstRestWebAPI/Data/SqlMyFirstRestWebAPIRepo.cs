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

        public void CreateItem(Command cmd)
        {
            if(cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }
            _context.Commands.Add(cmd);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void Update(Command cmd)
        {
            //nothing
        }

        public void Delete(Command cmd)
        {
            if (cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }
            _context.Commands.Remove(cmd);
        }
    }
}
