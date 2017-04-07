﻿namespace Gadgeteer.SocketInterfaces
{
    using Gadgeteer;
    using Gadgeteer.Modules;
    using System;
    using System.Runtime.CompilerServices;

    public delegate DigitalOutput DigitalOutputIndirector(Socket socket, Socket.Pin pin, bool initialState, Module module);
}

