using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicsUI.Components
{
    public partial class DynNavBar
    {

        [Parameter]
        public Color BackgroundColor { get; set; } = Color.Navy;

        [Parameter]
        public string Title { get; set; }



    }
}
