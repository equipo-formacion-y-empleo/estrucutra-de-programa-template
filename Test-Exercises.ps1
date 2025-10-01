# Autograding Script for C# Programming Exercises
# This script runs all exercises and compares output with expected results

param(
    [string]$ExerciseName = "",
    [switch]$Verbose = $false
)

# Import test data from JSON file
$testDataPath = Join-Path $PSScriptRoot "test-data.json"
$testData = Get-Content $testDataPath -Raw | ConvertFrom-Json
$testCasesWithArgs = @{}
foreach ($exercise in $testData.testCases.PSObject.Properties) {
    $testCasesWithArgs[$exercise.Name] = $exercise.Value
}

# Color functions for output
function Write-Success($message) {
    Write-Host $message -ForegroundColor Green
}

function Write-Error($message) {
    Write-Host $message -ForegroundColor Red
}

function Write-Info($message) {
    Write-Host $message -ForegroundColor Cyan
}

# Function to run an exercise and capture output
function Test-Exercise {
    param(
        [string]$ExercisePath,
        [string[]]$Arguments = @(),
        [string[]]$ExpectedOutputs = @(),
        [string]$ExerciseName
    )

    Write-Info "Testing $ExerciseName..."

    # Check if exercise directory exists
    if (!(Test-Path $ExercisePath)) {
        Write-Error "Exercise directory not found: $ExercisePath"
        return $false
    }

    # Change to exercise directory
    Push-Location $ExercisePath

    try {
        # Find the correct .csproj file        
        $csprojFiles = @(Get-ChildItem -Name "*.csproj")
        
        if ($csprojFiles.Count -eq 0) {
            Write-Error "No .csproj file found in $ExercisePath"
            return $false
        }
        
        $csprojFile = $csprojFiles[0]
        
        # Run the project 
        $output = dotnet run --project $csprojFile --nologo -- @Arguments 2>&1

        if ($LASTEXITCODE -ne 0) {
            Write-Error "Runtime error in $ExerciseName"
            if ($Verbose) {
                Write-Host $output -ForegroundColor Red
            }
            return $false
        }

        # Check expected outputs
        $success = $true
        if ($ExpectedOutputs.Count -gt 0) {
            foreach ($expected in $ExpectedOutputs) {
                if ($output -notmatch [regex]::Escape($expected)) {
                    Write-Error "Expected output not found in $ExerciseName`: '$expected'"
                    $success = $false
                }
            }
        }

        if ($success) {
            Write-Success "$ExerciseName passed all tests!"
        }

        if ($Verbose) {
            Write-Host "Output:" -ForegroundColor Yellow
            Write-Host $output
            Write-Host "---" -ForegroundColor Gray
        }

        return $success
    }
    finally {
        Pop-Location
    }
}

# Main execution
$totalTests = 0
$passedTests = 0
$rootPath = Get-Location

# Test specific exercise if provided
if ($ExerciseName -ne "") {
    if ($testCasesWithArgs.ContainsKey($ExerciseName)) {
        $testCasesList = $testCasesWithArgs[$ExerciseName]
        $exercisePath = Join-Path $rootPath $ExerciseName
        
        for ($i = 0; $i -lt $testCasesList.Count; $i++) {
            $testCase = $testCasesList[$i]
            $totalTests++
            
            $testName = "$ExerciseName (args set $($i + 1))"
            Write-Info "Testing $testName with arguments: $($testCase.Arguments -join ' ')"
            if (Test-Exercise -ExercisePath $exercisePath -Arguments $testCase.Arguments -ExpectedOutputs $testCase.ExpectedOutputs -ExerciseName $testName) {
                $passedTests++
            }
            
            Write-Host ""
        }
    } else {
        Write-Error "Exercise '$ExerciseName' not found in test cases"
        exit 1
    }
} else {
    # Test all exercises
    foreach ($exercise in $testCasesWithArgs.Keys | Sort-Object) {
        $testCasesList = $testCasesWithArgs[$exercise]
        $exercisePath = Join-Path $rootPath $exercise
        
        for ($i = 0; $i -lt $testCasesList.Count; $i++) {
            $testCase = $testCasesList[$i]
            $totalTests++
            
            $testName = "$exercise (args set $($i + 1))"
            Write-Info "Testing $testName with arguments: $($testCase.Arguments -join ' ')"
            if (Test-Exercise -ExercisePath $exercisePath -Arguments $testCase.Arguments -ExpectedOutputs $testCase.ExpectedOutputs -ExerciseName $testName) {
                $passedTests++
            }
            
            Write-Host ""
        }
    }
}

# Summary
Write-Info "=== Test Summary ==="
Write-Info "Total tests: $totalTests"
Write-Success "Passed: $passedTests"

if ($passedTests -lt $totalTests) {
    Write-Error "Failed: $($totalTests - $passedTests)"
    exit 1
} else {
    Write-Success "All tests passed! 🎉"
    exit 0
}