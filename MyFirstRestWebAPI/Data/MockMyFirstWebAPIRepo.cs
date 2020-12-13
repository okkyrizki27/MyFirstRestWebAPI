using MyFirstRestWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstRestWebAPI.Data
{
    public class MockMyFirstWebAPIRepo : IMyFirstRestWebAPIRepo
    {
        public IEnumerable<Command> GetItems()
        {
            var commands = new List<Command>
            {
                 new Command { Id = 0, HowTo = "Boil an Egg", Line = "Boil water", Platform = "Kettle & Pan" },
                 new Command { Id = 1, HowTo = "Cut Bread", Line = "Get Knife", Platform = "Knife & chopping board" },
                 new Command { Id = 2, HowTo = "Make a cup of tea", Line = "Place tea bag to a cup", Platform = "Cup" }
            };
            return commands;
        }

        public Command GetItemById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil an Egg", Line = "Boil water", Platform = "Kettle & Pan" };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void CreateItem(Command cmd)
        {
            throw new NotImplementedException();
        }

        public void Update(Command cmd)
        {
            throw new NotImplementedException();
        }

        public void Delete(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}
