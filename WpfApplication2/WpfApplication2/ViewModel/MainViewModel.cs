using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.IO;
using System.Windows.Input;
using WpfApplication2.Model;

namespace WpfApplication2.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        string fileName = "presets.txt";
  
        Presets _currentPreset;
        private RelayCommand _savePresetsCommand;
        private RelayCommand _loadPresetsCommand;

        public ICommand SavePresetsCommand => _savePresetsCommand;
        public ICommand LoadPresetsCommand => _loadPresetsCommand;

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            _savePresetsCommand = new RelayCommand(ExecuteSavePresets, CanExecuteSavePresets);
            _loadPresetsCommand = new RelayCommand(ExecuteLoadPresets, CanExecuteLoadPresets);
        }

        public Presets CurrentPresets
        {
            get
            {
                if (_currentPreset == null)
                    _currentPreset = new Presets();
                return _currentPreset;
            }
        }

        private bool CanExecuteLoadPresets()
        {
            return File.Exists(AppDomain.CurrentDomain.BaseDirectory + fileName) ? true : false;
        }

        private bool CanExecuteSavePresets()
        {
            return File.Exists(AppDomain.CurrentDomain.BaseDirectory + fileName) ? true : false;
        }

        private void ExecuteSavePresets()
        {
            var arr = CurrentPresets.GetPresetsArray();
            string text = string.Empty;
            for (int i = 0; i < arr.Length; i++)
            {
                text += arr[i] + ",";
            }
            text = text.Substring(0, text.Length - 1);
            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + fileName, text);
        }

        private void ExecuteLoadPresets()
        {
            int temp, tint, exp, contr, highlight, shadows, white, black, clarity, filtersAmount;
            string presetFromFile = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + fileName);
            var presetArr = presetFromFile.Split(',');
            Int32.TryParse(presetArr[0], out temp);
            Int32.TryParse(presetArr[1], out tint);
            Int32.TryParse(presetArr[2], out exp);
            Int32.TryParse(presetArr[3], out contr);
            Int32.TryParse(presetArr[4], out highlight);
            Int32.TryParse(presetArr[5], out shadows);
            Int32.TryParse(presetArr[6], out white);
            Int32.TryParse(presetArr[7], out black);
            Int32.TryParse(presetArr[8], out clarity);
            Int32.TryParse(presetArr[9], out filtersAmount);
            CurrentPresets.Temperature = temp;
            CurrentPresets.Tint = tint;
            CurrentPresets.Exposure = exp;
            CurrentPresets.Contrast = contr;
            CurrentPresets.HighLight = highlight;
            CurrentPresets.Shadows = shadows;
            CurrentPresets.Whites = white;
            CurrentPresets.Blacks = black;
            CurrentPresets.Clarity = clarity;
            CurrentPresets.FiltersAmount = filtersAmount;
        }
    }
}