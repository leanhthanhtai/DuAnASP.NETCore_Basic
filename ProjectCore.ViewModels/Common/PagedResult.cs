﻿using ProjectCore.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectCore.ViewModels.Common
{
    public class PagedResult<T> : PagedResultBase
    {
        public List<T> Items { set; get; }
    }
}