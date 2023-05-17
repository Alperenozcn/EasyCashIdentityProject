﻿using EasyCashIdentityProject.BusinessLayer.Abstract;
using EasyCashIdentityProject.DataAccessLayer.Abstract;
using EasyCashIdentityProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.Concrete
{
    public class CustomerAccountManager : ICustomerAccountService
    {
        private readonly ICustomerAccountDal _customerAccountDal;
        
        public CustomerAccountManager(ICustomerAccountDal customerAccountDal)
        {
            _customerAccountDal= customerAccountDal;
        }

        public void TDelete(CustomerAccount t)
        {
            
        }

        public CustomerAccount TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<CustomerAccount> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(CustomerAccount t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(CustomerAccount t)
        {
            throw new NotImplementedException();
        }
    }
}
