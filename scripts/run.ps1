# Parameters
param ($Config = "Debug")

Write-Output "Selected Build Configuration: $Config"

# Initialize and update submodules
Write-Output "Initializing and updating submodules..."
git submodule update --init --recursive

# Restore projects
Write-Output "Restoring the Frontend projects..."
dotnet restore ..\Velocity.Frontend.sln

# Build the projects
Write-Output "Building the Frontend projects..."
dotnet build ..\Velocity.Frontend.sln --configuration $Config --no-restore

# Run the Windows Forms project
Write-Output "Running the Frontend project..."
dotnet run --project ..\src\Velocity.Frontend\Velocity.Frontend.csproj --configuration $Config --no-build

Write-Output "Press any key to continue..."
$null = $Host.UI.RawUI.ReadKey("NoEcho,IncludeKeyDown")