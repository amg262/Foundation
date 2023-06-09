﻿using System.ComponentModel;

namespace Foundation.Infrastructure.Find.Facets.Config
{
    public class EnumSelectionDescriptionAttribute : DescriptionAttribute
    {
        public string Text { get; set; }
        public object Value { get; set; }
    }
}