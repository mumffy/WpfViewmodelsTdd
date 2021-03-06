﻿using FriendStorage.Model;
using System;
using FriendStorage.UI.DataProvider;

namespace FriendStorage.UI.ViewModel
{
    public interface IFriendEditViewModel
    {
        void Load(int friendId);
        Friend Friend { get; }
    }

    public class FriendEditViewModel : ViewModelBase, IFriendEditViewModel
    {
        private IFriendDataProvider _dataProvider;
        private Friend _friend;

        public FriendEditViewModel(IFriendDataProvider dataProvider)
        {
            _dataProvider = dataProvider;
        }

        public Friend Friend
        {
            get
            {
                return _friend;
            }
            private set
            {
                _friend = value;
                OnPropertyChanged();
            }
        }

        public void Load(int friendId)
        {
            Friend = _dataProvider.GetFriendById(friendId);
        }

    }
}
