using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_WPF_MVVMExamples
{
    public class ImageData : INotifyPropertyChanged
    {
        double _zoom = 1.0;

        public string ImagePath { get; private set; }

        public ImageData(string path)
        {
            ImagePath = path;
        }

        public double Zoom
        {
            get { return _zoom; }
            set
            {
                _zoom = value;
                OnPropertyChanged("Zoom");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string name)
        {
            var pc = PropertyChanged;
            if (pc != null)
            {
                pc(this, new PropertyChangedEventArgs(name));
            }

            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
