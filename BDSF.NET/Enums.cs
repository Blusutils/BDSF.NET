using System;
using System.Collections.Generic;
using System.Linq;

namespace Blusutils.BDSF {
    public enum DocType {
        /// <summary>
        /// Single document in file
        /// </summary>
        Single,
        /// <summary>
        /// File with pathes and multiple documents
        /// </summary>
        Multi
    }
    public enum DataType {
        /// <summary>
        /// SByte (integer on 1 byte, rng -128/127, 01)
        /// </summary>
        SByte = 0x01,

        /// <summary>
        /// Binary data or Array[byte] (len inf b, rng inf, 02)
        /// </summary>
        Binary,

        /// <summary>
        /// Unsigned integer on 1 byte (rng 0/255, 03)
        /// </summary>
        Byte,

        /// <summary>
        /// Short (integer on 2 bytes, rng -32768/32767, 04)
        /// </summary>
        Int16,

        /// <summary>
        /// UShort (unsigned int on 2 bytes, rng 0/65535, 05)
        /// </summary>
        UInt16,

        /// <summary>
        /// Int (integer on 4 bytes, rng -2147483648/2147483647, 06)
        /// </summary>
        Int32,

        /// <summary>
        /// UInt (unsigned integer on 4 bytes, rng 0/4294967295, 07)
        /// </summary>
        UInt32,

        /// <summary>
        /// Long (integer on 8 bytes, rng -9223372036854775808/9223372036854775807, 08)
        /// </summary>
        Int64,

        /// <summary>
        /// ULong (unsigned integer on 8 bytes, rng 0/18446744073709551615, 09)
        /// </summary>
        UInt64,

        /// <summary>
        /// LongLong (integer on 16 bytes, 0A)
        /// </summary>
        [Obsolete("The Int128 and UInt128 numbers is unsupported in .NET 6.0", true)]
        Int128,

        /// <summary>
        /// ULongLong (unsigned integer on 16 bytes, 0B)
        /// </summary>
        [Obsolete("The Int128 and UInt128 numbers is unsupported in .NET 6.0", true)]
        UInt128,

        /// <summary>
        /// BigInt (integer on inf bytes, inf rng, 0C) with 00 EOT
        /// </summary>
        BigInt,

        /// <summary>
        /// BigUInt (unsigned integer on inf bytes, inf rng, 0D) with 00 EOT
        /// </summary>
        BigUInt,

        /// <summary>
        /// Float (decimal number on 4 bytes, rng -3.4*10^38/3.4*10^38, 0E)
        /// </summary>
        Float,

        /// <summary>
        /// Double (decimal number on 8 bytes, rng ±5.0*10-324/±1.7*10308, 0F)
        /// </summary>
        Double,

        /// <summary>
        /// Decimal (decimal number on 16 bytes, rng ±1.0*10-28/±7.9228*1028, 10)
        /// </summary>
        Decimal,

        /// <summary>
        /// String (UTF8 char array, len inf b, rng inf, 11)
        /// </summary>
        String,

        /// <summary>
        /// Boolean (len 1b, rng 0/1, 12)
        /// </summary>
        Boolean,

        /// <summary>
        /// Array with dynamic type (len inf b, rng inf, 13) and with 00 EOT.
        /// Must not contain <see cref="Array"/>, <see cref="ArrayOfType"/> and <see cref="Dictionary"/>.
        /// </summary>
        Array,

        /// <summary>
        /// Array of one type (len inf b, rng inf, 14) with typecode byte and 00 EOT.
        /// Must not contain <see cref="Array"/>, <see cref="ArrayOfType"/> and <see cref="Dictionary"/>.
        /// </summary>
        ArrayOfType,

        /// <summary>
        /// Dictionary, dynamic typed key - dynamic typed value pair (len inf b, rng inf, 15) with 00 EOT.
        /// </summary>
        Dictionary,

        /// <summary>
        /// Dictionary, static typed key - static typed value pair (len inf b, rng inf, 16) with two typecode bytes and 00 EOT.
        /// </summary>
        DictionaryOfType,

        /// <summary>
        /// Unix timestamp (timestamp on 4 bytes, rng 0/2147483647, 17)
        /// </summary>
        UnixTimestamp,

        /// <summary>
        /// Timestamp64 (timestamp on 8 bytes, rng 0/9223372036854775807, 18)
        /// </summary>
        Timestamp64,

        /// <summary>
        /// Null (no value, 1B)
        /// </summary>
        Null,

        /// <summary>
        /// ItemID or just a string GUID/UUID (len 8b, 19)
        /// </summary>
        ItemID
    }
}
