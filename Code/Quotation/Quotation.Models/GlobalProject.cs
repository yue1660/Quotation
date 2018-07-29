using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quotation.Models
{
    public class GlobalProject
    {

        public GlobalProject(string filename)
        {
            DbContext = Global.GetDataContext(filename);
            var list = DbContext.Project.Take(1);
            foreach (var p in list)
            {
                Project = p;
            }
        }


        public DataContext DbContext
        {
            get;
            private set;
        }

        public Project Project
        {
            get;
            private set;
        }

    }
}
