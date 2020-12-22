﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using RulesEngine.HelperFunctions;
using System;
using System.Diagnostics.CodeAnalysis;

namespace RulesEngine.Models
{
    [ExcludeFromCodeCoverage]
    public class RuleParameter
    {
        public RuleParameter(string name, object value)
        {
            Value = Utils.GetTypedObject(value);
            Type = Value.GetType();
            Name = name;
        }

        internal RuleParameter(string name, Type type)
        {
            Name = name;
            Type = type;
        }
        public Type Type { get; }
        public string Name { get; }
        public object Value { get; }

    }
}
