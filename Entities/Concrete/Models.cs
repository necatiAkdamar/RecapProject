using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Models:Brand, IEntity
    {
        
        public int ModelId { get; set; }
        public string ModelName { get; set; }
    }
}
