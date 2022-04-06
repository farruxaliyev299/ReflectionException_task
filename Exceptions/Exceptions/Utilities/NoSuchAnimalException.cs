using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions.Utilities
{
    internal class NoSuchAnimalException:Exception
    {
        public NoSuchAnimalException(string message):base(message)
        {

        }
    }
}
