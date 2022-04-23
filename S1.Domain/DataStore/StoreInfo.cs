using System;
using System.Collections.Generic;

#nullable disable

namespace S1.DataStore
{
    public partial class StoreInfo
    {
        public long Oid { get; set; }
        public long? Cid { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
