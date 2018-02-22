using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Component.Interfaces
{
    public interface IBird
    {
        IBirdActivity Fly { get; set; }
        IBirdActivity Eat { get; set; }
        IBirdActivity Tweet { get; set; }
    }
}
