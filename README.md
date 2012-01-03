#QuickSplash.NET

##Make your Windows Forms / Visual Basic / VB.NET / C# .NET app startup instantly!

QuickSplash.NET will instantly (<0.5s) launch a splash screen for your Windows Forms application, giving your users immediate feedback whilst the .NET framework and your Windows application loads in the background.  This dramatically improves the perceived performance of your application.

First impressions count!  Should nothing happen for 10 seconds after launching your fantastic Windows application, your users will conclude that your application is slow and of poor quality.  You need to let them know that something is happening - whilst your application loads in the background.

###The .NET startup problem

Before your Windows Forms / Visual Basic / VB.NET / C# .NET can do anything (even show a splashscreen), the .NET framework must be loaded into memory.  On a cold start (i.e, just after a reboot), the .NET framework isn’t loaded into memory by default, nor is it in the disk cache; so approximately 21Mb must first be loaded from disk before your application gets to execute its first instruction.  Depending on hard disk speed, this can take up to 7sec on 2005 hardware, or 20sec on 2001 hardware!

The result is that the time between the user clicking on your application icon, and the first indication that something (anything!) happened can be up to 20 seconds.  Users will often end up clicking on the app icon multiple times, trying to make something happen, and thinking “what a crap app!”  Not the kind of first impression you want, especially if you are trying to entice your users away from a "speedy" legacy application.

###The Solution

QuickSplash.NET is a native Win32 component that shows a (customised) splashscreen - in less than 0.5 seconds, whilst loading your Windows Forms / Visual Basic / VB.NET / C# .NET application in the background.  Once the framework and your application has initialised, a simple file deletion tells the splashscreen to shut down.

This dramatically improves the perceived startup performance of your application.  Rather than having to wait for up to 20 seconds wondering if anything is happening, your users watch an interactive splash screen giving them a progress update of what is happening.  20 seconds just seem to fly buy when you're distracted by something.

##Installing

1. Download the lastest release from releases/
1. Follow the instructions in the included PDF manual.
1. Use the license key: 409015232017034763863342786458

##Building from source

1.  Requires Delphi 7
1.  Open src/Splash.dpr
1.  Build

##License: MIT

The MIT License (MIT)
Copyright (c) 2006-2011 David Laing & Brian Grantham

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.