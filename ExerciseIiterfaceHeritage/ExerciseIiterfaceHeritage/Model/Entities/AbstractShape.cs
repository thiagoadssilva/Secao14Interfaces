using ExerciseIiterfaceHeritage.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseIiterfaceHeritage.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color{ get; set; }

        public abstract double Area();
    }
}
