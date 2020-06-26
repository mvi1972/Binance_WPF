﻿using Binance.Net.ClientWPF.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binance.Net.ClientWPF.ViewModels
{
    class BalansViewModel : ObservableObject
    {
        private string asset;
        public string Asset
        {
            get { return asset; }
            set
            {
                asset = value;
                RaisePropertyChangedEvent("Asset");
            }
        }

        private decimal free;
        public decimal Free
        {
            get { return free; }
            set
            {
                free = value;
                RaisePropertyChangedEvent("Free");
            }
        }

        private decimal locked;
        public decimal Locked
        {
            get { return locked; }
            set
            {
                locked = value;
                RaisePropertyChangedEvent("Locked");
            }
        }
    }
}
