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
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.Compute.Models;
using Microsoft.WindowsAzure.Commands.Common.CustomAttributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Compute.Automation
{
    [Cmdlet(VerbsCommon.Add, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "VmssDataDisk", SupportsShouldProcess = true)]
    [OutputType(typeof(PSVirtualMachineScaleSet))]
    public partial class AddAzureRmVmssDataDiskCommand : Microsoft.Azure.Commands.ResourceManager.Common.AzureRMCmdlet
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
        public string Name { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 2,
            ValueFromPipelineByPropertyName = true)]
        public int Lun { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 3,
            ValueFromPipelineByPropertyName = true)]
        public CachingTypes? Caching { get; set; }

        [Parameter(
            Mandatory = false)]
        public SwitchParameter WriteAccelerator { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string CreateOption { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public int DiskSizeGB { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        [PSArgumentCompleter("Standard_LRS", "Premium_LRS", "StandardSSD_LRS", "UltraSSD_LRS")]
        public string StorageAccountType { get; set; }

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

            // StorageProfile
            if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile == null)
            {
                this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile = new VirtualMachineScaleSetStorageProfile();
            }

            // DataDisks
            if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.DataDisks == null)
            {
                this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.DataDisks = new List<VirtualMachineScaleSetDataDisk>();
            }

            var vDataDisks = new VirtualMachineScaleSetDataDisk();

            vDataDisks.Name = this.MyInvocation.BoundParameters.ContainsKey("Name") ? this.Name : null;
            vDataDisks.Lun = this.Lun;
            vDataDisks.Caching = this.MyInvocation.BoundParameters.ContainsKey("Caching") ? this.Caching : (CachingTypes?)null;
            vDataDisks.WriteAcceleratorEnabled = this.WriteAccelerator.IsPresent;
            vDataDisks.CreateOption = this.MyInvocation.BoundParameters.ContainsKey("CreateOption") ? this.CreateOption : null;
            vDataDisks.DiskSizeGB = this.MyInvocation.BoundParameters.ContainsKey("DiskSizeGB") ? this.DiskSizeGB : (int?)null;
            if (this.MyInvocation.BoundParameters.ContainsKey("StorageAccountType"))
            {
                // ManagedDisk
                vDataDisks.ManagedDisk = new VirtualMachineScaleSetManagedDiskParameters();
                vDataDisks.ManagedDisk.StorageAccountType = this.StorageAccountType;
            }
            this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.DataDisks.Add(vDataDisks);
            WriteObject(this.VirtualMachineScaleSet);
        }
    }
}
