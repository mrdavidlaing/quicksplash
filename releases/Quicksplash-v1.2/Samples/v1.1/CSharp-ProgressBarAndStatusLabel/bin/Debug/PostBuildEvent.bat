@echo off
copy "C:\Documents and Settings\David\My Documents\QuickSplash.NET\Releases\Quicksplash-v1.2\Samples\v1.1\CSharp-ProgressBarAndStatusLabel\Splash*" "C:\Documents and Settings\David\My Documents\QuickSplash.NET\Releases\Quicksplash-v1.2\Samples\v1.1\CSharp-ProgressBarAndStatusLabel\bin\Debug\"
copy "C:\Documents and Settings\David\My Documents\QuickSplash.NET\Releases\Quicksplash-v1.2\Samples\v1.1\CSharp-ProgressBarAndStatusLabel\ConnectWait.ico" "C:\Documents and Settings\David\My Documents\QuickSplash.NET\Releases\Quicksplash-v1.2\Samples\v1.1\CSharp-ProgressBarAndStatusLabel\bin\Debug\"
if errorlevel 1 goto CSharpReportError
goto CSharpEnd
:CSharpReportError
echo Project error: A tool returned an error code from the build event
exit 1
:CSharpEnd