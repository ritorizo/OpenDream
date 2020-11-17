﻿using OpenDreamShared.Dream;
using System.Collections.Generic;

namespace DMCompiler.DM {
    struct DMList {
        public object[] Values;
        public Dictionary<object, object> AssociatedValues;

        public DMList(object[] values, Dictionary<object, object> associatedValues) {
            Values = values;
            AssociatedValues = associatedValues;
        }
    }

    struct DMResource {
        public string ResourcePath;

        public DMResource(string resourcePath) {
            ResourcePath = resourcePath;
        }
    }
    
    //Used in object variable definitions
    struct DMNewInstance {
        public DreamPath Path;

        public DMNewInstance(DreamPath path) {
            Path = path;
        }
    }
}
