﻿using MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.ViewModel
{
    public class ReservationViewModel : ViewModelBase
    {
        private readonly Reservation reservation;
        public string RoomID => reservation.roomID?.ToString();
        public string UserName => reservation.UserName;
        public string StartDate => reservation.Start.ToString("d");
        public string EndDate => reservation.End.ToString("d");
        public TimeSpan Duration => reservation.Duration;

        public ReservationViewModel(Reservation resev)
        {
            reservation = resev;
        }

    }
}
