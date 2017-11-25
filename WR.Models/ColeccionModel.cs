﻿using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace WR.Models
{
    public class Coleccion<T> : BindingList<T>
    {
        private bool _isSorted;
        private ListSortDirection _sortDirection = ListSortDirection.Ascending;

        private PropertyDescriptor _sortProperty;
        public Coleccion() { }
        public Coleccion(IList<T> list) : base(list) { }
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
    }
}
