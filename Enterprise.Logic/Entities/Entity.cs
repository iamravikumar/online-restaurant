﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Logic.Entities
{
    [DataContract(IsReference = false)]
    public class Entity: IEntity
    {
        [DataMember]
        public int Id { get; set; }
    }
}
