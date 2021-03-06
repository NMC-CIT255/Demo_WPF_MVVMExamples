﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Demo_WPF_BasicMVVMApp
{
    public class ZoomCommand : ICommand
    {
        enum ZoomType
        {
            ZoomIn,
            ZoomOut,
            ZoomNormal
        }

        ImageData _data;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }


        public ZoomCommand(ImageData data)
        {
            _data = data;
        }

        public bool CanExecute(object parameter)
        {
            return _data.ImagePath != null;
        }

        public void Execute(object parameter)
        {
            var zoomType = (ZoomType)Enum.Parse(typeof(ZoomType), (string)parameter, true);

            switch (zoomType)
            {
                case ZoomType.ZoomIn:
                    _data.Zoom *= 1.2;
                    break;
                case ZoomType.ZoomOut:
                    _data.Zoom /= 1.2;
                    break;
                case ZoomType.ZoomNormal:
                    _data.Zoom = 1;
                    break;
            }
        }
    }



}
