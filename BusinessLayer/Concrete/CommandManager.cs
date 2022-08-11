using BusinessLayer.Abstract;
using DataAcessLayer.Abstract;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommandManager : ICommandService
    {
        ICommandDal _commandDal;

        public CommandManager(ICommandDal commandDal)
        {
            _commandDal = commandDal;
        }

        public void AddCommand(Command command)
        {
            _commandDal.Add(command);
        }

        public void AddT(Command t)
        {
            _commandDal.Add(t);
        }

        public List<Command> GetCommandWithBlog()
        {
            return _commandDal.GetListWithBlog();
        }

        public List<Command> GetList(int id)
        {
            return _commandDal.GetListAll(x => x.BlogID == id);
        }

        public List<Command> GetList()
        {
            throw new NotImplementedException();
        }

        public void TDelete(Command t)
        {
            throw new NotImplementedException();
        }

        public Command TGetById(int id)
        {
            return _commandDal.GetByID(id);
        }

        public void TUpdate(Command t)
        {
            _commandDal.Update(t);
        }
    }
}
