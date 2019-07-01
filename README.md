# Mobile Pascal TDP Tweaker 

Windows application designed to read and raise thermal design power (TDP) values of video BIOS that is based on Nvidia Pascal and Turing architecture; provided up to 20% extra graphics performance in computation and gaming.

## Supported platforms
- Windows (64/32bit)

## Target framework:
- .NET Framework 4.6.1

## Features
- Support reading and modifying vBIOS TDP values for mobile Pascal and Turing cards
- Support standalone 32-bit checksum correction
- Embedded base converter

## Installing / running
- Download [latest Mobile Pascal TDP Tweaker from releases](https://github.com/LaneLyng/MobilePascalTDPTweaker/releases)
- Run 'Mobile Pascal TDP Tweaker.exe'
- Open the vBIOS file that you would like to modify and adjust the TDP values
- Save the vBIOS
- Flash the modified vBIOS file into your chip through using a hardware programmer

## Development
- Recommend using Microsoft Visual Studio to build/compile
- To add new model, add model name and addresses in 'Models.config' under Resources folder (you need to know what addresses to add)
- To change the read, load, or save logic, modify the 'MainForm.cs'
- To add new address field, modify the 'BiosConfig.cs'

## Future TO-DO list
- Fix the issue that RTX 2060 is regonized as RTX 2070
- Add support for MX150 and GTX 1050 Ti
- Furthur decouple MainForm application
