﻿// Copyright (c) to owners found in https://github.com/AArnott/pinvoke/blob/master/COPYRIGHT.md. All rights reserved.
// Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.

using System.Runtime.InteropServices;

namespace PInvoke
{
    /// <content>
    /// Contains the <see cref="BCRYPT_DSA_KEY_BLOB_V2"/> nested type.
    /// </content>
    public partial class BCrypt
    {
        /// <summary>
        /// A key blob format for transporting DSA keys.
        /// Used as a header for a Digital Signature Algorithm (DSA) public key or private key BLOB in memory.
        /// </summary>
        /// <remarks>
        /// The structure applies to DSA keys that exceed 1024 bits in length but are less than or equal to 3072 bits.
        /// </remarks>
        public struct BCRYPT_DSA_KEY_BLOB_V2
        {
            /// <summary>
            /// The structure represents a DSA public key.
            /// </summary>
            public const uint BCRYPT_DSA_PUBLIC_MAGIC_V2 = 0x32425044;  // DPB2

            /// <summary>
            /// The structure represents a DSA private key.
            /// </summary>
            public const uint BCRYPT_DSA_PRIVATE_MAGIC_V2 = 0x32565044;  // DPV2

            /// <summary>
            /// Determines the type of key this structure represents. This can be one of the following values:
            /// <see cref="BCRYPT_DSA_PUBLIC_MAGIC_V2"/>, <see cref="BCRYPT_DSA_PRIVATE_MAGIC_V2"/>.
            /// </summary>
            public uint dwMagic;

            /// <summary>
            /// The length, in bytes, of the key.
            /// </summary>
            public uint cbKey;

            /// <summary>
            /// A value that specifies the hashing algorithm to use.
            /// </summary>
            public HASHALGORITHM_ENUM hashAlgorithm;

            /// <summary>
            /// A value that specifies the Federal Information Processing Standard(FIPS) to apply.
            /// </summary>
            public DSAFIPSVERSION_ENUM standardVersion;

            /// <summary>
            /// Length of the seed used to generate the prime number q.
            /// </summary>
            public uint cbSeedLength;

            /// <summary>
            /// Size of the prime number q . Currently, if the key is less than 128 bits, q is 20 bytes long. If the key exceeds 256 bits, q is 32 bytes long.
            /// </summary>
            public uint cbGroupSize;

            /// <summary>
            /// The number of iterations performed to generate the prime number q from the seed. For more information, see NIST standard FIPS186-3.
            /// </summary>
            public uint Count;
        }
    }
}
