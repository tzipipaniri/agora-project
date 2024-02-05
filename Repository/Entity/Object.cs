using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entity
{
    public enum enumSituation { newObject,oldObject};
    public class Object
    {
        public int Code { get; set; }
        public string Description { get; set; } = string.Empty;
        public enumSituation Situation { get; set; }
    }
}
