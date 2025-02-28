﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Mouse
    {
        private int age;
        private String name;

        public int Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }

        public Mouse (int age, string name)
        {
            this.Age = age;

            this.Name = name;
        }
    }
}
