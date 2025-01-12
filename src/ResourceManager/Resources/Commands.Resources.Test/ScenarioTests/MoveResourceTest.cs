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
    using ServiceManagement.Common.Models;
    using WindowsAzure.Commands.ScenarioTest;
    using Xunit;
    using Xunit.Abstractions;
    public class MoveResourceTest
    {
        public XunitTracingInterceptor _logger;

        public MoveResourceTest(ITestOutputHelper output)
        {
            _logger = new XunitTracingInterceptor(output);
            XunitTracingInterceptor.AddToContext(_logger);
        }

        [Fact(Skip = "Need to re-record test")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestMoveAzureResource()
        {
            ResourcesController.NewInstance.RunPsTest(_logger, "Test-MoveAzureResource");
        }
    }
}
