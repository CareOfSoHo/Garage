using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Garage
{
    internal interface IGarage<T>: IEnumerable<T>
    {
    }
}