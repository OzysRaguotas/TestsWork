using System;
using GalaSoft.MvvmLight;

namespace WpfApplication2.Model
{
   public class Presets:ViewModelBase
    {
        int _temperature;
        int _tint;
        int _exposure;
        int _contrast;
        int _highlight;
        int _shadows;
        int _whites;
        int _blacks;
        int _clarity;
        int _filtersAmount;

        public Presets()
        { }

        public int Temperature
        {
            get
            {
                return _temperature;
            }
            set
            {
                _temperature = value;
                RaisePropertyChanged();
            }
        }

        public int Tint
        {
            get { return _tint; }
            set
            {
                _tint = value;
                RaisePropertyChanged();
            }
        }

        public int Exposure
        {
            get { return _exposure; }
            set
            {
                _exposure = value;
                RaisePropertyChanged();
            }
        }

        public int Contrast
        {
            get { return _contrast; }
            set
            {
                _contrast = value;
                RaisePropertyChanged();
            }
        }

        public int HighLight
        {
            get { return _highlight; }
            set
            {
                _highlight = value;
                RaisePropertyChanged();
            }
        }

        public int Shadows
        {
            get { return _shadows; }
            set
            {
                _shadows = value;
                RaisePropertyChanged();
            }
        }

        public int Whites
        {
            get { return _whites; }
            set
            {
                _whites = value;
                RaisePropertyChanged();
            }
        }

        public int Blacks
        {
            get { return _blacks; }
            set
            {
                _blacks = value;
                RaisePropertyChanged();
            }
        }

        public int Clarity
        {
            get { return _clarity; }
            set
            {
                _clarity = value;
                RaisePropertyChanged();
            }
        }

        public int FiltersAmount
        {
            get { return _filtersAmount; }
            set
            {
                _filtersAmount = value;
                RaisePropertyChanged();
            }
        }

        public string[] GetPresetsArray()
        {
            string[] arr = new string[] { _temperature.ToString(),
                                        _tint.ToString(),
                                        _exposure.ToString(),
                                        _contrast.ToString(),
                                        _highlight.ToString(),
                                        _shadows.ToString(),
                                        _whites.ToString(),
                                        _blacks.ToString(),
                                        _clarity.ToString(),
                                        _filtersAmount.ToString()};
            return arr;
        }
    }
}
