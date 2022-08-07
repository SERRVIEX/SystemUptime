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
[MIT](https://choosealicense.com/licenses/mit/)
