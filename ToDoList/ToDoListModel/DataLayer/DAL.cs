using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListModel.DataLayer
{
    public sealed class DAL
    {
        private static IDataAccessLayer instance = null;
        private static readonly object padlock = new object();

        public DAL()
        {
        }

        public static IDataAccessLayer Instance
        {
            get
            {
                lock(padlock)
                {
                    if (instance == null)
                    {
                        //instance = new JsonDAL();
                        instance = null; // todo maken

                    }
                    return instance;
                }
            }
        }

    }
}
