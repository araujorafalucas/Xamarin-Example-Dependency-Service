﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ExDepenServ
{
    public class ViewModel //: INotifyPropertyChanged
    {
        //public event PropertyChangedEventHandler PropertyChanged;

        public int Height { get { return App.ServiceDeviceSettings.GetHeight(); } }

        public int Width { get { return App.ServiceDeviceSettings.GetWidth(); } }

    }
}
