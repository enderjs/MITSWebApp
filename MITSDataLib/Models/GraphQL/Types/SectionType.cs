﻿using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace MITSDataLib.Models.GraphQL.Types
{
    class SectionType : ObjectGraphType<Section>
    {
        public SectionType()
        {
            Field(s => s.Name);
            Field(s => s.Description);
            Field(s => s.SlideUrl);
            Field(s => s.RestrictSlide);
            Field(s => s.IsPanel);
            Field(s => s.StartDate);
            Field(s => s.EndDate);

        }
    }
}