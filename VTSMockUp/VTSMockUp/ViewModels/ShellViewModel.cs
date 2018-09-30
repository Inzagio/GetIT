using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using VTSMockUp.Models;

namespace VTSMockUp.ViewModels
{
    class ShellViewModel : Conductor<object>
    {
        private string _areaName = "Horten VTS";
        private AreaModel _selectedArea;
        private BindableCollection<AreaModel> _areas = new BindableCollection<AreaModel>();

        public ShellViewModel()
        {
            Areas.Add(new AreaModel { AreaName = "Horten VTS" });
            Areas.Add(new AreaModel { AreaName = "Brevik VTS" });
            Areas.Add(new AreaModel { AreaName = "Kvitsøy VTS" });
            Areas.Add(new AreaModel { AreaName = "Fedje VTS" });
            Areas.Add(new AreaModel { AreaName = "Vardø VTS" });
        }

        public string AreaName
        {
            get => _areaName;
            set
            {
                _areaName = value;
                NotifyOfPropertyChange(() => AreaName);
            }
        }

        public string AreaNames => $"{AreaName}";

        public BindableCollection<AreaModel> Areas
        {
            get => _areas;
            set => _areas = value;
        }

        public AreaModel SelectedArea
        {
            get => _selectedArea;
            set
            {
                _selectedArea = value;
                NotifyOfPropertyChange(() => SelectedArea);
            }
        }

        public bool CanClearText(string areaName) => !string.IsNullOrWhiteSpace(areaName);

        public void ClearText(string areaName)
        {
            AreaName = string.Empty;
        }

        //public void LoadPageOne()
        //{
        //    ActivateItem(new FirstChildViewModel());
        //}

        //public void LoadPageTwo()
        //{
        //    ActivateItem(new SecondChildViewModel());
        //}
    }
}
