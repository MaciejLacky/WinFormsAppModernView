﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppModernView.Views
{
    public interface IRectangle
    {
        string LengthText { get; set; }
        string WidthText { get; set; }
        string AreaText { get; set; }
    }
}
