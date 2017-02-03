using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionScolarite.Models
{
    public abstract class Model
    {
        protected Model()
        {
                
        }
        public string Code { get; set; }
        public virtual string Name { get; set; }    
    }
}