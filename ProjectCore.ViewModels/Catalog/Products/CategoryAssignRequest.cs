﻿using ProjectCore.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectCore.ViewModels.Catalog.Products
{
    public class CategoryAssignRequest
    {
        public int Id { get; set; }
        public List<SelectItem> Categories { get; set; } = new List<SelectItem>();
    }
}