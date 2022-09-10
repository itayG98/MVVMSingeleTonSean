﻿using MVVM.Commands;
using MVVM.Model;
using MVVM.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using ViewModel.Commands;

namespace MVVM.ViewModel
{
    public class ReservationLVViewModel : ViewModelBase
    {
        private readonly ObservableCollection<ReservationViewModel> _reservations;
        public IEnumerable<ReservationViewModel> Reservations => _reservations;
        public ICommand MakeReservationCommand { get; } 
        public ICommand LoadReservationCommand { get; }

        public ReservationLVViewModel(Hotel hotel,NavigationService makeReservationNavitaionService)
        {
            LoadReservationCommand = new LoadeResrvationCommand(hotel, this);
            MakeReservationCommand = new NavigateCommand(makeReservationNavitaionService);
            _reservations = new ObservableCollection<ReservationViewModel>();

        }

        public static ReservationLVViewModel LoadViewModel(Hotel hotel, NavigationService makeReservationNavitaionService) 
        {
            ReservationLVViewModel viewModel = new ReservationLVViewModel(hotel, makeReservationNavitaionService);
            viewModel.LoadReservationCommand.Execute(null);
            return viewModel;
        }

        public void UpdateReservation(IEnumerable<Reservation> reservations)
        {
            _reservations.Clear();
            foreach (Reservation reserv in reservations)
            {
                ReservationViewModel reservationViewModel = new ReservationViewModel(reserv);
                _reservations.Add(reservationViewModel);
            }
        }
    }
}
