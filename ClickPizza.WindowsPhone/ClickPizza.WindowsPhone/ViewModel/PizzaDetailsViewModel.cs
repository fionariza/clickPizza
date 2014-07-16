﻿using ClickPizza.WindowsPhone.Model;
using GalaSoft.MvvmLight;

namespace ClickPizza.WindowsPhone.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class PizzaDetailsViewModel : ViewModelBase
    {
        private PizzaDetailsModel _model;
        /// <summary>
        /// Initializes a new instance of the PizzaDetailsViewModel class.
        /// </summary>
        public PizzaDetailsViewModel()
        {
            _model = new PizzaDetailsModel();
        }

        public string ImageUri { get { return _model.ImageUri; } }

        public string Name { get { return _model.Name; } }

        public string Composition { get { return _model.Composition; } }

        public int Length { get { return _model.Length; } }

        public int Weight {get { return _model.Weight; }}

        public float Price { get { return _model.Price; } }
    }
}