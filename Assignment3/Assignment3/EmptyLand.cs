using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Assignment3
{
    class EmptyLand : Facility
    {
        public EmptyLand()
            : base(0, 0, 0, 0, 0)
        {
            _image = Properties.Resources.emptyland;
        }
    }
}
