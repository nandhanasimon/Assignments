// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/CompanyJob.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace CareerCloud.gRPC.Protos {
  public static partial class CompanyJobService
  {
    static readonly string __ServiceName = "CareerCloud.gRPC.CompanyJobService";

    static readonly grpc::Marshaller<global::CareerCloud.gRPC.Protos.CompanyJobIdRequest> __Marshaller_CareerCloud_gRPC_CompanyJobIdRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::CareerCloud.gRPC.Protos.CompanyJobIdRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::CareerCloud.gRPC.Protos.CompanyJob> __Marshaller_CareerCloud_gRPC_CompanyJob = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::CareerCloud.gRPC.Protos.CompanyJob.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::CareerCloud.gRPC.Protos.CompanyJobs> __Marshaller_CareerCloud_gRPC_CompanyJobs = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::CareerCloud.gRPC.Protos.CompanyJobs.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);

    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.CompanyJobIdRequest, global::CareerCloud.gRPC.Protos.CompanyJob> __Method_GetCompanyJob = new grpc::Method<global::CareerCloud.gRPC.Protos.CompanyJobIdRequest, global::CareerCloud.gRPC.Protos.CompanyJob>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCompanyJob",
        __Marshaller_CareerCloud_gRPC_CompanyJobIdRequest,
        __Marshaller_CareerCloud_gRPC_CompanyJob);

    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.CompanyJobs, global::Google.Protobuf.WellKnownTypes.Empty> __Method_CreateCompanyJob = new grpc::Method<global::CareerCloud.gRPC.Protos.CompanyJobs, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateCompanyJob",
        __Marshaller_CareerCloud_gRPC_CompanyJobs,
        __Marshaller_google_protobuf_Empty);

    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.CompanyJobs, global::Google.Protobuf.WellKnownTypes.Empty> __Method_UpdateCompanyJob = new grpc::Method<global::CareerCloud.gRPC.Protos.CompanyJobs, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateCompanyJob",
        __Marshaller_CareerCloud_gRPC_CompanyJobs,
        __Marshaller_google_protobuf_Empty);

    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.CompanyJobs, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteCompanyJob = new grpc::Method<global::CareerCloud.gRPC.Protos.CompanyJobs, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteCompanyJob",
        __Marshaller_CareerCloud_gRPC_CompanyJobs,
        __Marshaller_google_protobuf_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::CareerCloud.gRPC.Protos.CompanyJobReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CompanyJobService</summary>
    [grpc::BindServiceMethod(typeof(CompanyJobService), "BindService")]
    public abstract partial class CompanyJobServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::CareerCloud.gRPC.Protos.CompanyJob> GetCompanyJob(global::CareerCloud.gRPC.Protos.CompanyJobIdRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> CreateCompanyJob(global::CareerCloud.gRPC.Protos.CompanyJobs request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> UpdateCompanyJob(global::CareerCloud.gRPC.Protos.CompanyJobs request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> DeleteCompanyJob(global::CareerCloud.gRPC.Protos.CompanyJobs request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(CompanyJobServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetCompanyJob, serviceImpl.GetCompanyJob)
          .AddMethod(__Method_CreateCompanyJob, serviceImpl.CreateCompanyJob)
          .AddMethod(__Method_UpdateCompanyJob, serviceImpl.UpdateCompanyJob)
          .AddMethod(__Method_DeleteCompanyJob, serviceImpl.DeleteCompanyJob).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CompanyJobServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetCompanyJob, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.CompanyJobIdRequest, global::CareerCloud.gRPC.Protos.CompanyJob>(serviceImpl.GetCompanyJob));
      serviceBinder.AddMethod(__Method_CreateCompanyJob, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.CompanyJobs, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.CreateCompanyJob));
      serviceBinder.AddMethod(__Method_UpdateCompanyJob, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.CompanyJobs, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.UpdateCompanyJob));
      serviceBinder.AddMethod(__Method_DeleteCompanyJob, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.CompanyJobs, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.DeleteCompanyJob));
    }

  }
}
#endregion
