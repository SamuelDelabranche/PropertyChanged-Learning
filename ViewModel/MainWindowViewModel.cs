using PropertyChanged.Model;
using PropertyChanged.ViewModel;
using PropertyChanged.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PropertyChanged.ViewModel
{
    public class MainWindowViewModel : ObservableItem 
    {
        public ObservableCollection<ItemViewModel> Items { get; set; }


		private ItemViewModel _selectedItem;
		public ItemViewModel SelectedItem
        {
			get
			{
				return _selectedItem;
			}
			set
			{
				_selectedItem = value;
				OnPropertyChanged();
			}
		}

		public MainWindowViewModel()
        {
            Items = new ObservableCollection<ItemViewModel>();

            Items.Add(new ItemViewModel(new Item("Taysir", "9192A", 7)));
            Items.Add(new ItemViewModel(new Item("Samuel", "9192A", 7)));
            Items.Add(new ItemViewModel(new Item("Subbu", "9192A", 7)));
            Items.Add(new ItemViewModel(new Item("Lawis", "9192A", 7)));
        }
    }
}
