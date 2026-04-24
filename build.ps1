Write-Host "Running Build Script" -ForegroundColor Green

Write-Host "1 - Checking formatting" -ForegroundColor Cyan
dotnet format --verify-no-changes
if ($LASTEXITCODE -ne 0) { throw "Code formatting failed. Run 'dotnet format' to fix." }

Write-Host "2 - Building Debug Mode" -ForegroundColor Cyan
dotnet build -c Debug
if ($LASTEXITCODE -ne 0) { throw "Debug build failed." }

Write-Host "3 - Building Release Mode..." -ForegroundColor Cyan
dotnet build -c Release
if ($LASTEXITCODE -ne 0) { throw "Release build failed." }

Write-Host "4 - Running Unit Tests" -ForegroundColor Cyan
dotnet test -c Release --no-build
if ($LASTEXITCODE -ne 0) { throw "Unit tests failed." }

Write-Host "Build Complete!" -ForegroundColor Green