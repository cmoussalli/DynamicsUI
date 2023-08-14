using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicsUI.Utilities
{
    public static class ColorBuilder
    {
        public static string ConvertToString(Color color)
        {
            return $"rgb({ color.R.ToString()},{color.G.ToString()},{color.B.ToString()})";
        }
    }
}
