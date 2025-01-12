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


using Microsoft.Azure.ServiceManagement.Common.Models;
using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Microsoft.WindowsAzure.Commands.Test.Utilities.Common;
using Xunit;
using Xunit.Abstractions;

namespace Microsoft.Azure.Commands.Management.Storage.Test.ScenarioTests
{
    public class StorageAccountTests : RMTestBase
    {
        public XunitTracingInterceptor _logger;

        public StorageAccountTests(ITestOutputHelper output)
        {
            _logger = new XunitTracingInterceptor(output);
            XunitTracingInterceptor.AddToContext(_logger);
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestStorageAccount()
        {
            TestController.NewInstance.RunPsTest(_logger, "Test-StorageAccount");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestNewAzureStorageAccount()
        {
            TestController.NewInstance.RunPsTest(_logger, "Test-NewAzureStorageAccount");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestGetAzureStorageAccount()
        {
            TestController.NewInstance.RunPsTest(_logger, "Test-GetAzureStorageAccount");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestSetAzureStorageAccount()
        {
            TestController.NewInstance.RunPsTest(_logger, "Test-SetAzureStorageAccount");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestRemoveAzureStorageAccount()
        {
            TestController.NewInstance.RunPsTest(_logger, "Test-RemoveAzureStorageAccount");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestGetAzureStorageAccountKey()
        {
            TestController.NewInstance.RunPsTest(_logger, "Test-GetAzureStorageAccountKey");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestNewAzureStorageAccountKey()
        {
            TestController.NewInstance.RunPsTest(_logger, "Test-NewAzureStorageAccountKey");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestPipingGetAccountToGetKey()
        {
            TestController.NewInstance.RunPsTest(_logger, "Test-PipingGetAccountToGetKey");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestPipingSetStorageAccount()
        {
            TestController.NewInstance.RunPsTest(_logger, "Test-PipingToSetAzureRmCurrentStorageAccount");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestSetCurrentStorageAccount()
        {
            TestController.NewInstance.RunPsTest(_logger, "Test-SetAzureRmCurrentStorageAccount");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestSetAzureRmStorageAccountKeySource()
        {
            TestController.NewInstance.RunPsTest(_logger, "Test-SetAzureRmStorageAccountKeySource");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestNetworkRule()
        {
            TestController.NewInstance.RunPsTest(_logger, "Test-NetworkRule");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestSetAzureStorageAccountStorageV2()
        {
            TestController.NewInstance.RunPsTest(_logger, "Test-SetAzureStorageAccountStorageV2");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestGetAzureStorageLocationUsage()
        {
            TestController.NewInstance.RunPsTest(_logger, "Test-GetAzureStorageLocationUsage");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestPipingNewUpdateAccount()
        {
            TestController.NewInstance.RunPsTest(_logger, "Test-PipingNewUpdateAccount");
        }

        
    }
}
