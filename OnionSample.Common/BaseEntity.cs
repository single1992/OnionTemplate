using System;
using System.Collections.Generic;
using System.Text;

namespace OnionSample.Common
{
    public abstract class BaseEntity<Tid>
    {
        public Tid Id { get; set; }
    }
}
