// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis;

namespace Microsoft.DotNet.CodeFormatting
{
    internal interface IFormattingFilter
    {
        bool ShouldBeProcessed(Document document);
    }
}
