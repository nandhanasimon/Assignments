using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.gRPC.Protos;
using CareerCloud.Pocos;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CareerCloud.gRPC.Protos.SecurityLoginService;

namespace CareerCloud.gRPC.Services
{
    public class SecurityLoginService:SecurityLoginServiceBase
    {
        public override Task<SecurityLogin> GetSecurityLogin(SecurityLoginIdRequest request, ServerCallContext context)
        {
            var logic = new SecurityLoginLogic(
                 new EFGenericRepository<SecurityLoginPoco>());
            SecurityLoginPoco poco = logic.Get(Guid.Parse(request.Id));

            if (poco == null)
            {
                throw new ArgumentOutOfRangeException();
            }

            return new Task<SecurityLogin>(
                () => { return TranslateFromPoco(poco); });
        }
        public override Task<Empty> DeleteSecurityLogin(SecurityLogins request, ServerCallContext context)
        {
            var logic = new SecurityLoginLogic(
               new EFGenericRepository<SecurityLoginPoco>());
            List<SecurityLoginPoco> pocos = new List<SecurityLoginPoco>();
            foreach (SecurityLogin proto in request.SecLog)
            {
                pocos.Add(TranslateFromProto(proto));
            }

            logic.Delete(pocos.ToArray());
            return Task.FromResult(new Empty());
        }
        public override Task<Empty> CreateSecurityLogin(SecurityLogins request, ServerCallContext context)
        {
            var logic = new SecurityLoginLogic(
                 new EFGenericRepository<SecurityLoginPoco>());
            List<SecurityLoginPoco> pocos = new List<SecurityLoginPoco>();
            foreach (SecurityLogin proto in request.SecLog)
            {
                pocos.Add(TranslateFromProto(proto));
            }
            logic.Add(pocos.ToArray());
            return Task.FromResult(new Empty());
        }
        public override Task<Empty> UpdateSecurityLogin(SecurityLogins request, ServerCallContext context)
        {
            var logic = new SecurityLoginLogic(
                  new EFGenericRepository<SecurityLoginPoco>());
            List<SecurityLoginPoco> pocos = new List<SecurityLoginPoco>();
            foreach (SecurityLogin proto in request.SecLog)
            {
                pocos.Add(TranslateFromProto(proto));
            }
            logic.Update(pocos.ToArray());
            return Task.FromResult(new Empty());
        }
        private SecurityLoginPoco TranslateFromProto(SecurityLogin proto)
        {
            return new SecurityLoginPoco
            {
                Id = Guid.Parse(proto.Id),
                Login=proto.Login,
                Password=proto.Password,
                Created=proto.Created.ToDateTime(),
                PasswordUpdate=proto.PasswordUpdate.ToDateTime(),
                AgreementAccepted=proto.AgreementAccepted.ToDateTime(),
                IsLocked=proto.IsLocked,
                IsInactive=proto.IsInactive,
                EmailAddress=proto.EmailAddress,
                PhoneNumber=proto.PhoneNumber,
                FullName=proto.FullName,
                ForceChangePassword=proto.ForceChangePassword,
                PrefferredLanguage=proto.PrefferredLanguage
            };
        }

        private SecurityLogin TranslateFromPoco(SecurityLoginPoco poco)
        {
            return new SecurityLogin()
            {
                Id = poco.Id.ToString(),
                Login = poco.Login,
                Password = poco.Password,
                Created = poco.Created == null ? null :Timestamp.FromDateTime((DateTime)poco.Created),
                PasswordUpdate=poco.PasswordUpdate==null?null:Timestamp.FromDateTime((DateTime)poco.PasswordUpdate),
                AgreementAccepted=poco.AgreementAccepted==null?null:Timestamp.FromDateTime((DateTime)poco.AgreementAccepted),
                IsLocked=poco.IsLocked,
                IsInactive=poco.IsInactive,
                EmailAddress=poco.EmailAddress,
                PhoneNumber=poco.PhoneNumber,
                FullName=poco.FullName,
                ForceChangePassword=poco.ForceChangePassword,
                PrefferredLanguage=poco.PrefferredLanguage
            };
        }
    }
}
