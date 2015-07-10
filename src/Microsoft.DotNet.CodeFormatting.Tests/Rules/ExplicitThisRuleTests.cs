﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Xunit;

namespace Microsoft.DotNet.CodeFormatting.Tests
{
    public sealed class ExplicitThisRuleTests : LocalSemanticRuleTestBase
    {
        internal override ILocalSemanticFormattingRule Rule
        {
            get { return new Rules.ExplicitThisRule(); }
        }

        [Fact]
        public void TestFieldUse()
        {
            Verify(nameof(TestFieldUse), runFormatter: false);
        }

        [Fact]
        public void TestFieldAssignment()
        {
            Verify(nameof(TestFieldAssignment), runFormatter: false);
        }

        [Fact]
        public void TestFieldAssignmentWithTrivia()
        {
            Verify(nameof(TestFieldAssignmentWithTrivia), runFormatter: false);
        }

        [Fact]
        public void TestFieldBadName()
        {
            Verify(nameof(TestFieldBadName), runFormatter: false);
        }
    }
}
