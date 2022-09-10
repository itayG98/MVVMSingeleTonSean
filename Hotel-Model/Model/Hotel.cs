﻿using System.Collections.Generic;

namespace MVVM.Model
{
    public class Hotel
    {
        private ReservationBook _reservationBook;
        private string _name;   

        public Hotel(string name)
        {
            _reservationBook = new ReservationBook();
            _name = name;   
        }

        /// <summary>
        /// Get reservation for a user
        /// </summary>
        /// <returns>The User's reservation</returns>
        public IEnumerable<Reservation> GetReservations()
            => _reservationBook.GetReservations();

        /// <summary>
        /// Make a new reservation
        /// </summary>
        /// <param name="Reservation to make"></param>
        /// <exception cref="ReservationConflictException"></exception>
        public void MakeReserbation(Reservation reserv)
            => _reservationBook.AddReservation(reserv);
    }
}