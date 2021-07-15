using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Entities
{
    public class Communite
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}
