using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Loteria.Entidades
{
    [DataContract]
    public class Premio
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int premio { get; set; }

        [DataMember]
        public double monto { get; set; }

    }
}