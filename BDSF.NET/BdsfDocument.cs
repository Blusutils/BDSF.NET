using System;
using System.Collections.Generic;
using System.Linq;

namespace Blusutils.BDSF {
    public class BdsfDocument {
        public DocType DocType { get; set; }
        public BdsfPath? Path { get; set; }
        public byte[] Data { get; set; } = Array.Empty<byte>();
    }
}
