﻿#region License
// 
// Copyright (c) 2013, Kooboo team
// 
// Licensed under the BSD License
// See the file LICENSE.txt for details.
// 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kooboo.CMS.Sites.Extension.UI.TopToolbar
{
    public class ToolbarGroupButtons
    {
        public ToolbarGroup Group { get; set; }

        public IList<ToolbarButton> Buttons { get; set; }
    }
}
