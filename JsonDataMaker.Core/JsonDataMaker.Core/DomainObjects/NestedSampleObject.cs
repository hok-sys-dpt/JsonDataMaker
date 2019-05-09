﻿using System;
using System.Collections.Generic;
using System.Text;

namespace JsonDataMaker.Core.DomainObjects
{
    public class ParentSampleObject
    {
        public string ParentA { get; set; }

        public string ParentB { get; set; }

        public string ParentC { get; set; }

        public string ParentD { get; set; }

        public string ParentE { get; set; }

        public IEnumerable<ChildSampleObject> Children { get; set; }
    }

    public class ChildSampleObject
    {
        public string ChildA { get; set; }

        public string ChildB { get; set; }

        public string ChildC { get; set; }

        public string ChildD { get; set; }

        public string ChildE { get; set; }
    }
}
