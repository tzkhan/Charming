param (
    [string]$ArtefactsPath = "\artefacts",
    [string]$Configuration = "Release",
    [string]$BuildId
)

function Log-Host
{
    param (
        [string] $Text
    )

    Write-Host $Text -BackgroundColor Yellow -ForegroundColor DarkRed
}

$sln = "Charming.sln"
$versionSuffix = "alpha-$BuildId"
$packProjects = @(
    "Charming\Charming.csproj"
)

Log-Host "Building solution"
dotnet build $sln -c $Configuration

Log-Host "Running tests on solution"
dotnet test $sln -c $Configuration --no-restore --no-build

Log-Host "Publishing nuget packages for build $BuildId"
foreach ($project in $packProjects) {
    dotnet pack $project -c $Configuration -o $ArtefactsPath --version-suffix $versionSuffix --no-restore --no-build
}
