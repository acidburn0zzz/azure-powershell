//
// Copyright (c) Microsoft and contributors.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//
// See the License for the specific language governing permissions and
// limitations under the License.
//

// Warning: This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using Microsoft.Azure.Commands.Compute.Automation.Models;
using Microsoft.Azure.Management.Compute.Models;
using Microsoft.WindowsAzure.Commands.Common.CustomAttributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Compute.Automation
{
    [Cmdlet(VerbsCommon.Add, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "VmssAdditionalUnattendContent", SupportsShouldProcess = true)]
    [OutputType(typeof(PSVirtualMachineScaleSet))]
    public partial class AddAzureRmVmssAdditionalUnattendContentCommand : Microsoft.Azure.Commands.ResourceManager.Common.AzureRMCmdlet
    {
        [Parameter(
            Mandatory = true,
            Position = 0,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true)]
        public PSVirtualMachineScaleSet VirtualMachineScaleSet { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 1,
            ValueFromPipelineByPropertyName = true)]
        public PassNames? PassName { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 2,
            ValueFromPipelineByPropertyName = true)]
        public ComponentNames? ComponentName { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 3,
            ValueFromPipelineByPropertyName = true)]
        public SettingNames? SettingName { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 4,
            ValueFromPipelineByPropertyName = true)]
        public string Content { get; set; }

        protected override void ProcessRecord()
        {
            if (ShouldProcess("VirtualMachineScaleSet", "Add"))
            {
                Run();
            }
        }

        private void Run()
        {
            // VirtualMachineProfile
            if (this.VirtualMachineScaleSet.VirtualMachineProfile == null)
            {
                this.VirtualMachineScaleSet.VirtualMachineProfile = new VirtualMachineScaleSetVMProfile();
            }

            // OsProfile
            if (this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile == null)
            {
                this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile = new VirtualMachineScaleSetOSProfile();
            }

            // WindowsConfiguration
            if (this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile.WindowsConfiguration == null)
            {
                this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile.WindowsConfiguration = new WindowsConfiguration();
            }

            // AdditionalUnattendContent
            if (this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile.WindowsConfiguration.AdditionalUnattendContent == null)
            {
                this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile.WindowsConfiguration.AdditionalUnattendContent = new List<AdditionalUnattendContent>();
            }

            var vAdditionalUnattendContent = new AdditionalUnattendContent();

            vAdditionalUnattendContent.PassName = this.MyInvocation.BoundParameters.ContainsKey("PassName") ? this.PassName : (PassNames?)null;
            vAdditionalUnattendContent.ComponentName = this.MyInvocation.BoundParameters.ContainsKey("ComponentName") ? this.ComponentName : (ComponentNames?)null;
            vAdditionalUnattendContent.SettingName = this.MyInvocation.BoundParameters.ContainsKey("SettingName") ? this.SettingName : (SettingNames?)null;
            vAdditionalUnattendContent.Content = this.MyInvocation.BoundParameters.ContainsKey("Content") ? this.Content : null;
            this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile.WindowsConfiguration.AdditionalUnattendContent.Add(vAdditionalUnattendContent);
            WriteObject(this.VirtualMachineScaleSet);
        }
    }
}
