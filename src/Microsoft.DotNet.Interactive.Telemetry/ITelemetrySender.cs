﻿// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;

namespace Microsoft.DotNet.Interactive.Telemetry;

public interface ITelemetrySender
{
    bool Enabled { get; }

    void TrackEvent(string eventName, IDictionary<string, string> properties, IDictionary<string, double> measurements);
}