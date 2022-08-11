using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete
{
    public class Command
    {
        [Key]
        public int CommandID { get; set; }

        public string CommandUsername { get; set; }

        public string CommandTitle { get; set; }

        public string CommandContent { get; set; }

        public DateTime CommandDate { get; set; }

        public int BlogScore { get; set; }

        public bool CommandStatus { get; set; }

        public int BlogID { get; set; }

        public Blog Blog { get; set; }
        public bool IsDelete { get; set; }
    }
}
