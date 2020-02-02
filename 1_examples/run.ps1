# ------------------ #
# 1_examples/run.ps1 #
# ------------------ #

# Compile and execute a C# program

# --------------------------------------------------------------------------

# Helper Functions

# Check if a given command exists
# https://stackoverflow.com/questions/3919798/how-to-check-if-a-cmdlet-exists-in-powershell-at-runtime-via-script
function CheckCommand($cmdname) {
    # return [bool](Get-Command -Name $cmdname -ea 0)
    return [bool](Get-Command -Name $cmdname -ErrorAction SilentlyContinue)
}

# --------------------------------------------------------------------------

Write-Host "`n Compiling Examples.cs `n" -ForegroundColor Green
# Write-Host " Detecting Python Installation... " -NoNewLine

# Verify C# compiler is installed and available

$csc = "C:\Windows\Microsoft.NET\Framework\v3.5\csc.exe"

if (CheckCommand $csc){
    # https://stackoverflow.com/questions/6338015/how-do-you-execute-an-arbitrary-native-command-from-a-string
    # $command = 'python -V'
    $cscExists = Invoke-Expression $csc # Can use iex instead of Invoke-Expression
    Write-Host $cscExists -ForegroundColor Green -NoNewLine
} else {
    Write-Host "`n`n Csc Installation Could Not Be Found! Exiting..." -ForegroundColor Red
    exit
}

# C:\Windows\Microsoft.NET\Framework\v3.5\csc.exe
#           /t:exe /out:MyApplication.exe MyApplication.cs

# EOF #
