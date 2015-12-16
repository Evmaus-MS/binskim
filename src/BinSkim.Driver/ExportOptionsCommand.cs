﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;
using System.Reflection;

using Microsoft.CodeAnalysis.IL.Rules;
using Microsoft.CodeAnalysis.Driver.Sdk;

namespace Microsoft.CodeAnalysis.IL
{
    internal class ExportConfigurationCommand : ExportConfigurationCommandBase
    {
        public override IEnumerable<Assembly> DefaultExportAssemblies
        {
            get
            {
                return new Assembly[] {
                    typeof(MarkImageAsNXCompatible).Assembly
                }; 
            }
        }
    }
}