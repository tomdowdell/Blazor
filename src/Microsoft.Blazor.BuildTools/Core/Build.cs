﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.Blazor.BuildTools.Core.FileSystem;
using System.IO;

namespace Microsoft.Blazor.BuildTools.Core
{
    internal static class Build
    {
        internal static void Execute(string assemblyPath, string webRootPath)
        {
            var clientFileSystem = new ClientFileProvider(assemblyPath, webRootPath);
            var distDirPath = Path.Combine(Path.GetDirectoryName(assemblyPath), "dist");
            FileUtil.WriteFileProviderToDisk(clientFileSystem, distDirPath, clean: true);
        }
    }
}