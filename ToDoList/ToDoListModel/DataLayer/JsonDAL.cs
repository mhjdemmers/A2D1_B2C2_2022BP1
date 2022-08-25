using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListModel.Models;

namespace ToDoListModel.DataLayer
{
    //todo implementeren
    internal class JsonDAL : IDataAccessLayer
    {
        public ToDoTask CreateToDoTask(ToDoTask ToDoTask)
        {
            throw new NotImplementedException();
        }

        public bool DeleteToDoTask(ToDoTask ToDoTask)
        {
            throw new NotImplementedException();
        }

        public ToDoTask ReadToDoTask(int id)
        {
            throw new NotImplementedException();
        }

        public List<ToDoTask> ReadToDoTasks()
        {
            throw new NotImplementedException();
        }

        public ToDoTask UpdateToDoTask(ToDoTask ToDoTask)
        {
            throw new NotImplementedException();
        }
    }
}
