﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Com.MrIT.ViewModels
{
    public class VmSeat:ViewModelItemBase 
    {
        public int BusID { get; set; }
        public string SeatName { get; set; }

        public VmBus Bus { get; set; }
    }

   
}
