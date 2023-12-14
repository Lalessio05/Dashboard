using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Models
{
    interface IDataManagement
    {
        static abstract ICollection<T> ReadCollection<T>(string filePath);
        static abstract void WriteCollection<T>(string filePath,ICollection<T> collection);
    }
}
