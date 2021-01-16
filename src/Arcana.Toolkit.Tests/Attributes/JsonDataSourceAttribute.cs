using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Arcana.Toolkit.Tests.Attributes
{
    public class JsonDataSourceAttribute : Attribute, ITestDataSource
    {
        public string FilePath { get; set; }

        public IEnumerable<object[]> GetData(MethodInfo methodInfo)
        {
            if (string.IsNullOrWhiteSpace(FilePath))
                throw new ArgumentNullException(nameof(FilePath));

            if (!File.Exists(FilePath))
                throw new ArgumentException($"{FilePath} does not exists.");

            var json = File.ReadAllText(FilePath);
            yield return new object[] { json };
        }

        public string GetDisplayName(MethodInfo methodInfo, object[] data)
        {
            return data != null ? $"Test - { methodInfo.Name} ({FilePath})" : null;
        }
    }
}
