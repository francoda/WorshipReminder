using Newtonsoft.Json;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Collections;

namespace WR.Models
{

    public class Lista<T> : BindingList<T>
    {
        private List<T> ItemsOcultos = new List<T>();
        private Dictionary<T, int> dicValores = new Dictionary<T, int>();

        public Lista()
        {
            string text = string.Empty;

            if (File.Exists(Path.Combine(Archivo.localpath, "WorshipReminder", typeof(T).Name + ".WR")))
                text = File.ReadAllText(Path.Combine(Archivo.localpath, "WorshipReminder", typeof(T).Name + ".WR"));
            if (text != string.Empty)
            {
                foreach (T item in JsonConvert.DeserializeObject<List<T>>(text))
                    Add(item);
            }
        }

        private bool _isSorted;
        private ListSortDirection _sortDirection = ListSortDirection.Ascending;

        private PropertyDescriptor _sortProperty;
        protected override bool SupportsSearchingCore => true;

        public Lista(IList<T> list) : base(list) { }
        protected override bool SupportsSortingCore
        {
            get { return true; }
        }
        protected override bool IsSortedCore
        {
            get { return _isSorted; }
        }
        protected override ListSortDirection SortDirectionCore
        {
            get { return _sortDirection; }
        }
        protected override PropertyDescriptor SortPropertyCore
        {
            get { return _sortProperty; }
        }
        protected override void RemoveSortCore()
        {
            _sortDirection = ListSortDirection.Ascending;
            _sortProperty = null;
            _isSorted = false;
        }
        protected override int FindCore(PropertyDescriptor prop, object key)
        {
            if (!(key is string))
                throw new NotSupportedException();
            foreach (T item in Items as List<T>)
                ItemsOcultos.Add(item);
            Clear();
            dicValores.Clear();
            foreach (T item in ItemsOcultos as List<T>)
            {
                foreach (string keyWord in key.ToString().Trim().Split(' '))
                {
                    if ((typeof(IList).IsAssignableFrom(prop.PropertyType) ? ((List<string>)prop.GetValue(item)).Aggregate((x, y) => $"{x}{y}") : prop.GetValue(item)).ToString().ToLower().Normalize().Contains(keyWord.ToString().ToLower().Normalize()))
                        dicValores[item] = (dicValores.TryGetValue(item, out int valor) ? valor : 0) + 1;
                }
            }
            foreach (KeyValuePair<T, int> item in dicValores)
            {
                if (item.Value > 0)
                    Add(item.Key);
            }
            ApplySortCore(prop, ListSortDirection.Descending);
            return -1;
        }
        protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
        {
            List<T> list = Items as List<T>;
            _sortProperty = prop;
            _sortDirection = direction;
            if (list != null)
            {
                list.Sort(Compare);
                _isSorted = true;
                OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
            }
        }
        private int Compare(T lhs, T rhs)
        {
            return _sortDirection == ListSortDirection.Descending ? -OnComparison(lhs, rhs) : OnComparison(lhs, rhs);
        }
        private int OnComparison(T lhs, T rhs)
        {
            if (dicValores.ContainsKey(lhs) && dicValores.ContainsKey(rhs) && dicValores[lhs] != dicValores[rhs])
                return dicValores[lhs].CompareTo(dicValores[rhs]);
            object lhsValue = lhs == null ? null : _sortProperty.GetValue(lhs);
            object rhsValue = rhs == null ? null : _sortProperty.GetValue(rhs);
            if (lhsValue == null)
                return (rhsValue == null) ? 0 : -1;
            if (rhsValue == null)
                return 1;
            if (lhsValue is IComparable)
                return ((IComparable)lhsValue).CompareTo(rhsValue);
            if (lhsValue.Equals(rhsValue))
                return 0;
            return lhsValue.ToString().CompareTo(rhsValue.ToString());
        }
        public void Guardar()
        {
            Directory.CreateDirectory(Path.Combine(Archivo.localpath, "WorshipReminder"));
            File.WriteAllText(Path.Combine(Archivo.localpath, "WorshipReminder", typeof(T).Name + ".WR"), JsonConvert.SerializeObject(Items));
        }
    }
}
