﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.InteropServices;

namespace Microsoft.Diagnostics.Tools.Monitor
{
    internal sealed class AuthOptions : IAuthOptions
    {
        public bool EnableNegotiate => RuntimeInformation.IsOSPlatform(OSPlatform.Windows);

        public KeyAuthenticationMode KeyAuthenticationMode { get; }

        public bool EnableKeyAuth => (KeyAuthenticationMode == KeyAuthenticationMode.StoredKey) ||
                                     (KeyAuthenticationMode == KeyAuthenticationMode.TemporaryKey);

        public AuthOptions(KeyAuthenticationMode mode)
        {
            KeyAuthenticationMode = mode;
        }
    }
}
