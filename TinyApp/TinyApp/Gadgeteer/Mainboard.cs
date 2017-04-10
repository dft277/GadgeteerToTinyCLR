﻿// Generated by .NET Reflector from C:\Program Files (x86)\Microsoft .NET Gadgeteer\Core\Assemblies\.NET Micro Framework 4.3\Gadgeteer.dll
namespace Gadgeteer
{
    using Gadgeteer.Modules;
    //using Microsoft.SPOT;
    //using Microsoft.SPOT.Hardware;
    using System;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using GHIElectronics.TinyCLR.Devices.Spi;

    public abstract class Mainboard
    {
        public BitmapConvertBPP NativeBitmapConverter;
        public BitmapCopyToSpi NativeBitmapCopyToSpi;

        protected Mainboard()
        {
            SpiController ctl = SpiController.GetDefault();
           
            
        }

        public abstract void EnsureRgbSocketPinsAvailable();
        public abstract string[] GetStorageDeviceVolumeNames();
        public abstract bool MountStorageDevice(string volumeName);
        protected internal abstract void OnOnboardControllerDisplayConnected(string displayModel, int width, int height, int orientationDeg, Module.DisplayModule.TimingRequirements timing);
        protected internal virtual void OnOnboardControllerDisplayDisconnected()
        {
        }

        public abstract void PostInit();
        public abstract void SetDebugLED(bool on);
        public abstract void SetProgrammingMode(ProgrammingInterface programmingInterface);
        public abstract bool UnmountStorageDevice(string volumeName);

        public abstract string MainboardName { get; }

        public abstract string MainboardVersion { get; }

        public delegate void BitmapConvertBPP(Bitmap bitmap, byte[] pixelBytes, Mainboard.BPP bpp);

        public delegate void BitmapCopyToSpi(Bitmap bitmap, SpiConnectionSettings config, int xSrc, int ySrc, int width, int height, Mainboard.BPP bpp);
        
        public enum BPP
        {
            BPP16_BGR_BE
        }

        public enum ProgrammingInterface
        {
            Serial_COM1,
            Serial_COM2,
            Serial_COM3,
            Serial_COM4,
            USB,
            Network
        }
    }
}