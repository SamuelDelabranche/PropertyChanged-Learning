using PropertyChanged.Model;
using PropertyChanged.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyChanged.View
{
    public class ItemViewModel : ObservableItem
    {
        private readonly Item _item;

		private string _name;
		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				_name = value;
				OnPropertyChanged();
			}
		}

		private string _serialNumber;
		public string SerialNumber
		{
			get
			{
				return _serialNumber;
			}
			set
			{
				_serialNumber = value;
				OnPropertyChanged();
			}
		}

		private string _quantity;
		public string Quantity
		{
			get
			{
				return _quantity;
			}
			set
			{
				_quantity = value;
				OnPropertyChanged();
			}
		}

		public ItemViewModel(Item item)
        {
            _item = item;

			_name = _item.Name;
			_serialNumber = _item.SerialNumber;
			_quantity = _item.Quantity.ToString();
        }
    }
}
