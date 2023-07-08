# 🌕 Matic clicker 🌕
Minecraft auto-clicker made in modern C++, performance optimized and easy to use. 

# Pictures

![image](https://i.ibb.co/HKTwKtH/1.jpg)
#
![image](https://i.ibb.co/2y86pYq/2.jpg)
#
![image](https://i.ibb.co/tx3K6FJ/3.jpg)

# Getting started

## Download
Download the latest release at the [releases section](https://github.com/TheRealJoelmatic/Matic-Clicker/releases/tag/Release).

## Bugs or suggestions
Bugs or suggestions should be reported at the [issues section](https://github.com/TheRealJoelmatic/Matic-Clicker/issues).

## Compiling
### Prerequisites
Microsoft Visual Studio (Preferably the latest version) with C++ installed.

### Compiling from the source
Open the solution file `clicker.sln`, then select `Release | x64` on the Build configuration and press Build solution.

### Compiling errors
If you get errors related to DirectX, please install the DirectX Software Development Kit.
- https://www.microsoft.com/en-us/download/confirmation.aspx?id=6812

## Errors
### vcruntime140.dll and msvcp140.dll errors
That happens because you don't have the runtime and libraries required for this to run.  
Please install preferably both `x86` and `x64` packages of the VC++ 2019 runtime linked below.
- https://aka.ms/vs/16/release/vc_redist.x86.exe
- https://aka.ms/vs/16/release/vc_redist.x64.exe

### d3d9.dll error
Install the following
- https://www.microsoft.com/en-us/download/confirmation.aspx?id=35
