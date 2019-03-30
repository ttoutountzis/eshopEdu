using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Abstruct_Classes
{
    public abstract class BaseProps
    {
        public string Id { get; set; }

        public DateTime Created { get; set; }
        public DateTime LastUpdate { get; set; }
        public BaseProps()
        {
            Created = DateTime.UtcNow;
        }

    }
}
