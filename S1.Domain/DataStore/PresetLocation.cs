using System;
using System.Collections.Generic;

#nullable disable

namespace S1.DataStore
{
    public partial class PresetLocation
    {
        public long Oid { get; set; }
        public long? Cid { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public long? UseCount { get; set; }
        public long? LastUsed { get; set; }
        public long? Modified { get; set; }
        public string SubFolder { get; set; }
    }
}
