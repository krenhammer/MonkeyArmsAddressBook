using System;
using System.Collections.Generic;
using MonkeyArms.LockedAddressBook.Core.Models;

namespace MonkeyArms.LockedAddressBook.Core.ViewModels
{
	public class ContactsListViewModel
	{

		public virtual event EventHandler ContactsChanged;

		private List<Person> contacts;

		public List<Person> Contacts {
			get {
				return contacts;
			}
			set {
				contacts = value;
				ContactsChanged (this, EventArgs.Empty);
			}
		}

		public ContactsListViewModel ()
		{
		}
	}
}

