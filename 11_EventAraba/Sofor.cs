﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_EventAraba
{
    internal class Sofor:Insan
    {
        public event ArabaDelegate GazaBastim;
        public Sofor(string ad):base(ad)
        {

        }

        public void GazaBas()
        {
            Random random = new Random();
            int gazOrani = random.Next(1, 101);
            GazaBastim(gazOrani, this);
        }


    }
}
