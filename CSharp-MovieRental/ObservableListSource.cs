using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_MovieRental
{
    public class ObservableListSource<T> : ObservableCollection<T>, IListSource where T : class
    {
        private IBindingList bindingList;
        public bool ContainsListCollection { get { return false; } }

        public IList GetList()
        {
            return bindingList ?? (bindingList = this.ToBindingList());
        }
    }
}
