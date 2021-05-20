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
using static CareerCloud.gRPC.Protos.CompanyDescriptionService;

namespace CareerCloud.gRPC.Services
{
    public class CompanyDescriptionService :CompanyDescriptionServiceBase
    {
        public override Task<CompanyDescriptionN> GetCompanyDescription(CompanyDesIdRequest request, ServerCallContext context)
        {
            var logic = new CompanyDescriptionLogic(
               new EFGenericRepository<CompanyDescriptionPoco>());
            CompanyDescriptionPoco poco = logic.Get(Guid.Parse(request.Id));

            if (poco == null)
            {
                throw new ArgumentOutOfRangeException();
            }

            return new Task<CompanyDescriptionN>(
                () => { return TranslateFromPoco(poco); });
        }
        public override Task<Empty> DeleteCompanyDescription(CompanyDescriptions request, ServerCallContext context)
        {
            var logic = new CompanyDescriptionLogic(
                new EFGenericRepository<CompanyDescriptionPoco>());
            List<CompanyDescriptionPoco> pocos = new List<CompanyDescriptionPoco>();
            foreach (CompanyDescriptionN proto in request.ComDesc)
            {
                pocos.Add(TranslateFromProto(proto));
            }

            logic.Delete(pocos.ToArray());
            return Task.FromResult(new Empty());

        }
        public override Task<Empty> CreateCompanyDescription(CompanyDescriptions request, ServerCallContext context)
        {
            var logic = new CompanyDescriptionLogic(
                new EFGenericRepository<CompanyDescriptionPoco>());
            List<CompanyDescriptionPoco> pocos = new List<CompanyDescriptionPoco>();
            foreach (CompanyDescriptionN proto in request.ComDesc)
            {
                pocos.Add(TranslateFromProto(proto));
            }
            logic.Add(pocos.ToArray());
            return Task.FromResult(new Empty());
        }
        public override Task<Empty> UpdateCompanyDescription(CompanyDescriptions request, ServerCallContext context)
        {
            var logic = new CompanyDescriptionLogic(
                 new EFGenericRepository<CompanyDescriptionPoco>());
            List<CompanyDescriptionPoco> pocos = new List<CompanyDescriptionPoco>();
            foreach (CompanyDescriptionN proto in request.ComDesc)
            {
                pocos.Add(TranslateFromProto(proto));
            }
            logic.Update(pocos.ToArray());
            return Task.FromResult(new Empty());
        }

        private CompanyDescriptionPoco TranslateFromProto(CompanyDescriptionN proto)
        {
            return new CompanyDescriptionPoco
            {
                Id = Guid.Parse(proto.Id),
                Company = Guid.Parse(proto.Company),
                LanguageId = proto.LanguageId,
                CompanyName = proto.CompanyName,
                CompanyDescription=proto.CompanyDescription                
            };
        }

        private CompanyDescriptionN TranslateFromPoco(CompanyDescriptionPoco poco)
        {
            return new CompanyDescriptionN()
            {
                Id = poco.Id.ToString(),
                Company = poco.Company.ToString(),
                LanguageId = poco.LanguageId,
                CompanyName=poco.CompanyName,
                CompanyDescription=poco.CompanyDescription

            };
        }
    }
}
