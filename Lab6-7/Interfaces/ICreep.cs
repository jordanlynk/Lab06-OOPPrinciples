using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface ICreep
    {
        public bool IsCreeping { get; set; }
        //From Interface ICreep
        public string Lurk();
        //From Interface ICreep
        public string Camoflauge();        

    }
}
