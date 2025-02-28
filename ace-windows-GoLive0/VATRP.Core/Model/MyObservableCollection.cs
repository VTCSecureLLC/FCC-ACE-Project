﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using VATRP.Core.Events;

namespace VATRP.Core.Model
{
    public class MyObservableCollection<T> : ObservableCollection<T>
        where T : IComparable<T>, INotifyPropertyChanged
    {
        private readonly bool trackItemsPropChanges;
        public event EventHandler<StringEventArgs> onItemPropChanged;

        public MyObservableCollection()
            : this(false)
        {
        }

        public MyObservableCollection(bool trackItemsPropChanges)
            : base() 
        {
            this.trackItemsPropChanges = trackItemsPropChanges;
        }

        public MyObservableCollection(IEnumerable<T> collection, bool trackItemsPropChanges)
            : base(collection) 
        {
            this.trackItemsPropChanges = trackItemsPropChanges;
        }

        public void RemoveRange(IEnumerable<T> collection)
        {
            foreach (var i in collection)
            {
                this.Items.Remove(i);
            }

            this.OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
        }
        
        public void Replace(T item)
        {
            this.ReplaceRange(new T[] { item });
        }

        public void ReplaceRange(IEnumerable<T> collection)
        {
            this.Items.Clear();

            foreach (var i in collection)
            {
                this.Items.Add(i);
            }

            this.OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
        }

        public void AddRange(IEnumerable<T> collection)
        {
            foreach (var i in collection)
            {
                this.Items.Add(i);
            }

            this.OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
        }

        public List<T> FindAll(Predicate<T> matcher)
        {
            List<T> items = this.Items as List<T>;
            return items.FindAll(matcher);
        }

        public int RemoveAll(Predicate<T> match)
        {
            List<T> items = this.Items as List<T>;
            return items.RemoveAll(match);
        }

        protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            if (this.trackItemsPropChanges)
            {
                switch (e.Action)
                {
                    case NotifyCollectionChangedAction.Add:
                        {
                            foreach (T item in e.NewItems)
                            {
                                item.PropertyChanged += this.item_PropertyChanged;
                            }
                            break;
                        }

                    case NotifyCollectionChangedAction.Remove:
                        {
                            foreach (T item in e.OldItems)
                            {
                                item.PropertyChanged -= this.item_PropertyChanged;
                            }
                            break;
                        }

                    case NotifyCollectionChangedAction.Reset:
                        {
                            foreach (T item in this.Items)
                            {
                                item.PropertyChanged += this.item_PropertyChanged;
                            }
                            break;
                        }
                }
            }

            base.OnCollectionChanged(e);
        }

        private void item_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            EventHandlerTrigger.TriggerEvent<StringEventArgs>(this.onItemPropChanged, this, 
                new StringEventArgs(e.PropertyName));
        }
    }
}
