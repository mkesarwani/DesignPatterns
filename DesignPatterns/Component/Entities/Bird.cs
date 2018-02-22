using DesignPatterns.Component.Enums;
using DesignPatterns.Component.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Component.Entity
{
    public class Bird : IBird
    {
        public Bird(string name, BirdType type)
        {
            this.BirdName = name;
            this.BirdType = type;
        }
        public string BirdName { get; }
        public BirdType BirdType { get; }
        public IBirdActivity Eat { get; set; }
        public IBirdActivity Fly { get; set; }
        public IBirdActivity Tweet { get; set; }
        public override string ToString()
        {
            return string.Format($"'{BirdName}' is a '{BirdType}' type Bird.");
        }
    }

}
