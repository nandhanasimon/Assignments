using System;
using System.Collections.Generic;
using System.Text;
using CareerCloud.Pocos;
using CareerCloud.DataAccessLayer;

namespace CareerCloud.BusinessLogicLayer
{
    public class SecurityLoginsRoleLogic : BaseLogic<SecurityLoginsRolePoco>
    {
        public SecurityLoginsRoleLogic(
            IDataRepository<SecurityLoginsRolePoco> repo)
            : base(repo) { }
        protected override void Verify(SecurityLoginsRolePoco[] pocos)
        {
            List<ValidationException> exceptions = new List<ValidationException>();
        }
    }
}
