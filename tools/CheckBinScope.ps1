[CmdletBinding(
    SupportsShouldProcess=$true
)]
param(
    [Parameter(Mandatory = $false)]
    [string] $BuildConfig = "Debug",
    [Parameter(Mandatory = $false)]
    [string] $CIToolsPath
)

$RMFolders = Get-ChildItem $PSScriptRoot/../src/Package/$BuildConfig/ResourceManager/AzureResourceManager -Directory

$RMFolders | ForEach-Object {
    $dlls = Get-ChildItem $_.FullName -Recurse | Where-Object { $_ -like "*dll" } | ForEach-Object { $_.FullName };
    & "$CIToolsPath/tools/BinScope/BinScope7.0.7/BinScope.exe" $dlls /OutDir "$PSScriptRoot/../src/Package/BinScope/" /html | Out-Null
}

$shouldThrow = $false
$binscopeFolders = Get-ChildItem $PSScriptRoot/../src/Package/BinScope
$binscopeFolders | ForEach-Object {
    $binscopeReport = Get-Content $_.FullName
    if ($binscopeReport -like "*No failed checks*")
    {
        Remove-Item $_.FullName
    }
    else
    {
        $shouldThrow = $true
    }
}

if ($shouldThrow)
{
    throw "Binscope failed, please check the files in src/Package/BinScope"
}
else
{
    Remove-Item $PSScriptRoot/../src/Package/BinScope
}
