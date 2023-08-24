# SystemUptime

![Version](https://img.shields.io/badge/Version-v1.0.0-brightgreen.svg)
[![License](https://img.shields.io/badge/License-MIT-blue.svg)](https://github.com/SERRVIEX/SimpleRecyclerCollection/blob/main/LICENSE) 
[![Contact](https://img.shields.io/badge/LinkedIn-blue.svg?logo=LinkedIn)](https://www.linkedin.com/in/sergiu-ciornii-466395220/)

## Requirements
[![Unity 2020+](https://img.shields.io/badge/unity-2020+-black.svg?style=flat&logo=unity&cacheSeconds=2592000)](https://unity3d.com/get-unity/download/archive)
![.NET 4.x Scripting Runtime](https://img.shields.io/badge/.NET-4.x-blueviolet.svg?style=flat&cacheSeconds=2592000)

## Description
A native plugin for Unity to get System Uptime on iOS/Android (SystemClock.elapsedRealtime). 
That can be used to prevent offline time cheating in your Unity mobile game.

### How to use?
The plugin offers only one variable - ```TotalSeconds```. It contains the number of seconds that determines how long the device has been on, or at least when the hardware was booted or rebooted for the last time.

```csharp
long totalSeconds = SystemUptime.TotalSeconds;
```

## License
MIT License

Copyright (c) 2023 SERRVIEX

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.