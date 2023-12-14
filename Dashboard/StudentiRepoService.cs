using Dashboard.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard
{
   public class StudentiRepoService
    {
        public ObservableCollection<Studente> Studenti { get; set; } = new(JsonManagement.ReadCollection<Studente>("ciao.json"));

        private static Lazy<StudentiRepoService> instance = new (() => new StudentiRepoService());
        public static StudentiRepoService Instance => instance.Value;

    }
}

