using CoffeeShop.Abstract;
using CoffeeShop.Concrete;
using CoffeeShop.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop
{
	class Program
	{
		static void Main(string[] args)
		{
			BaseCustomerManager customerManager = new NeroCustomerManager();

			//Aşağıdaki bilgileri kendi bilgileriniz ile deneyebilirsiniz.

			customerManager.Save(new Customer
			{
				DateOfBirth = 2000,
				FirstName = "Sedat",
				LastName = "Öztürk",
				NationalityId = "1234455677"
			});
			Console.ReadLine();
		}
	}

	
}
