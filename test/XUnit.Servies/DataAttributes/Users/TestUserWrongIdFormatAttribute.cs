﻿using System.Collections.Generic;
using System.Reflection;
using Xunit.Sdk;

namespace XUnit.Test.DataAttributes
{
    public class TestUserWrongIdFormatAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[]
            {
                "WrongFormat"
            };
        }
    }
}


