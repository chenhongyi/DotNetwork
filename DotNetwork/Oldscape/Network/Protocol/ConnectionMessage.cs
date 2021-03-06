﻿// Copyright (c) DotNetwork. All rights reserved.
// Licensed under the MIT license. See LICENSE file for full license information.

namespace DotNetwork.Oldscape.Network.Protocol
{

    /// <summary>
    /// The different client connection messages.
    /// </summary>
    enum ConnectionMessage
    {
        /// <summary>
        /// A successful client connection between the server and client.
        /// </summary>
        SUCCESSFUL = 0,

        /// <summary>
        /// A successful login between the server and client.
        /// </summary>
        SUCCESSFUL_LOGIN = 2,

        /// <summary>
        /// The client is out of date with the server.
        /// </summary>
        OUT_OF_DATE = 6
    }
}
