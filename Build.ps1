param (
    [string]$ArtifactsPath = ".\artifacts",
    [string]$Configuration = "Release",
    [string]$SuffixOverride
)

Write-Host "ArtifactsPath: $ArtifactsPath"
Write-Host "Configuration: $Configuration"
Write-Host "SuffixOverride: $SuffixOverride"

function Log-Host
{
    param (
        [string] $Text
    )

    Write-Host $Text -BackgroundColor Yellow -ForegroundColor DarkRed
}

$sln = "src\Charming.sln"
$versionSuffix = @{ $true = $SuffixOverride; $false = "preview" }[$SuffixOverride -ne ""]
$packProjects = @(
    "src\Charming\Charming.csproj"
    "src\Charming.Types\Charming.Types.csproj"
)

Log-Host "Building solution"
dotnet build $sln -c $Configuration

Log-Host "Running tests on solution"
dotnet test $sln -c $Configuration --no-restore --no-build

Log-Host "Publishing nuget packages"
foreach ($project in $packProjects) {
    dotnet pack $project -c $Configuration -o $ArtifactsPath --version-suffix $versionSuffix --no-restore --no-build
}
