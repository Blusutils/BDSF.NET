using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blusutils.BDSF.Conversions {
    public static class Conversions {
        static byte[] deccv(decimal i) {
            var r = decimal.GetBits(i);
            var res = new byte[r.Length * sizeof(int)];
            Buffer.BlockCopy(r, 0, res, 0, res.Length);
            return res;
        }
        public static byte[] ToBdsfObject(this object inp) {
            byte[] outBytes = Type.GetTypeCode(inp.GetType()) switch {
                TypeCode.Int16 => BitConverter.GetBytes((short)inp),
                TypeCode.UInt16 => BitConverter.GetBytes((ushort)inp),
                TypeCode.Int32 => BitConverter.GetBytes((int)inp),
                TypeCode.UInt32 => BitConverter.GetBytes((uint)inp),
                TypeCode.Int64 => BitConverter.GetBytes((long)inp),
                TypeCode.UInt64 => BitConverter.GetBytes((ulong)inp),
                TypeCode.Single => BitConverter.GetBytes((float)inp),
                TypeCode.Double => BitConverter.GetBytes((double)inp),
                TypeCode.Decimal => deccv((decimal)inp),
                TypeCode.String => Encoding.UTF8.GetBytes(inp.ToString()!),
                _ => throw new TypeAccessException("This type is unsupported by BDSF format")
            };
            if (BitConverter.IsLittleEndian)
                Array.Reverse(outBytes);
            return outBytes;
        }
    }
}
