﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Resources.Test.ScenarioTests
{
    using Microsoft.WindowsAzure.Commands.ScenarioTest;
    using ServiceManagement.Common.Models;
    using Xunit;
    using Xunit.Abstractions;
    public class ProviderTests
    {
        public XunitTracingInterceptor _logger;

        public ProviderTests(ITestOutputHelper output)
        {
            _logger = new XunitTracingInterceptor(output);
            XunitTracingInterceptor.AddToContext(_logger);
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestAzureProvider()
        {
            ResourcesController.NewInstance.RunPsTest(_logger, "Test-AzureProvider");
        }

        [Fact(Skip = "ZoneMapping removed.")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestAzureProvider_WithZoneMappings()
        {
            ResourcesController.NewInstance.RunPsTest(_logger, "Test-AzureProvider-WithZoneMappings");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestAzureProviderOperation()
        {
            ResourcesController.NewInstance.RunPsTest(_logger, "Test-AzureProviderOperation");
        }
        
        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestAzureProviderOperationDataActions()
        {
            ResourcesController.NewInstance.RunPsTest(_logger, "Test-AzureProviderOperationDataActions");
        }
    }
}
