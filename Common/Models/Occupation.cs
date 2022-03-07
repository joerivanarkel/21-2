using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Models
{
    public class Occupation : Entity
    {
        public string Name { get; set; }
        public int? PersonId { get; set; }
    }
}