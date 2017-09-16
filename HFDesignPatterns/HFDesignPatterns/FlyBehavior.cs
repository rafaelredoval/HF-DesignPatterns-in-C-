using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFDesignPatterns
{
    interface FlyBehavior
    {
        void fly();
        
    }
    interface FlyWithWings : FlyBehavior
    {
        void fly();
        //Implementa o voar dos patos
    
    }
    interface FlyNoWay : FlyBehavior
    {
        void fly();
        //fazer nda - não pode voar
    }
}
