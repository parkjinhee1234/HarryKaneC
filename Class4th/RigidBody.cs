﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class4th
{
    class RigidBody : Component
    {
        private float gravity = 9.81f;

        public RigidBody()

            
        {

            Console.WriteLine("RigidBody 생성");
           
            Console.WriteLine("Component의 x" + x);
            Console.WriteLine("Component의 y" + y);
            Console.WriteLine("Component의 z" + z);

            Console.WriteLine("RigidBody의 gravity" + gravity);

        }
    public void Information()
        {
            Console.WriteLine("Component의 x : " + x);
            Console.WriteLine("Component의 y : " + y);
            Console.WriteLine("Co,ponent의 z : " + z);

            Console.WriteLine("RigidBody의 gravity : " + gravity);


        }
    }
}
