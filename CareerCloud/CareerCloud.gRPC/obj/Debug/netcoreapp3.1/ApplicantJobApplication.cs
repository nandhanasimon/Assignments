// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/ApplicantJobApplication.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace CareerCloud.gRPC.Protos {

  /// <summary>Holder for reflection information generated from Protos/ApplicantJobApplication.proto</summary>
  public static partial class ApplicantJobApplicationReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/ApplicantJobApplication.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ApplicantJobApplicationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRQcm90b3MvQXBwbGljYW50Sm9iQXBwbGljYXRpb24ucHJvdG8SEENhcmVl",
            "ckNsb3VkLmdSUEMaH2dvb2dsZS9wcm90b2J1Zi90aW1lc3RhbXAucHJvdG8a",
            "G2dvb2dsZS9wcm90b2J1Zi9lbXB0eS5wcm90byIgChJBcHBKb2JBcHBJZFJl",
            "cXVlc3QSCgoCSWQYASABKAkiegoXQXBwbGljYW50Sm9iQXBwbGljYXRpb24S",
            "CgoCSWQYASABKAkSEQoJQXBwbGljYW50GAIgASgJEgsKA0pvYhgDIAEoCRIz",
            "Cg9BcHBsaWNhdGlvbkRhdGUYBCABKAsyGi5nb29nbGUucHJvdG9idWYuVGlt",
            "ZXN0YW1wIlcKGEFwcGxpY2FudEpvYkFwcGxpY2F0aW9ucxI7CghBcHBKb2JB",
            "cBgBIAMoCzIpLkNhcmVlckNsb3VkLmdSUEMuQXBwbGljYW50Sm9iQXBwbGlj",
            "YXRpb24yvgMKHkFwcGxpY2FudEpvYkFwcGxpY2F0aW9uU2VydmljZRJtChpH",
            "ZXRBcHBsaWNhbnRKb2JBcHBsaWNhdGlvbhIkLkNhcmVlckNsb3VkLmdSUEMu",
            "QXBwSm9iQXBwSWRSZXF1ZXN0GikuQ2FyZWVyQ2xvdWQuZ1JQQy5BcHBsaWNh",
            "bnRKb2JBcHBsaWNhdGlvbhJjCh1DcmVhdGVBcHBsaWNhbnRKb2JBcHBsaWNh",
            "dGlvbhIqLkNhcmVlckNsb3VkLmdSUEMuQXBwbGljYW50Sm9iQXBwbGljYXRp",
            "b25zGhYuZ29vZ2xlLnByb3RvYnVmLkVtcHR5EmMKHVVwZGF0ZUFwcGxpY2Fu",
            "dEpvYkFwcGxpY2F0aW9uEiouQ2FyZWVyQ2xvdWQuZ1JQQy5BcHBsaWNhbnRK",
            "b2JBcHBsaWNhdGlvbnMaFi5nb29nbGUucHJvdG9idWYuRW1wdHkSYwodRGVs",
            "ZXRlQXBwbGljYW50Sm9iQXBwbGljYXRpb24SKi5DYXJlZXJDbG91ZC5nUlBD",
            "LkFwcGxpY2FudEpvYkFwcGxpY2F0aW9ucxoWLmdvb2dsZS5wcm90b2J1Zi5F",
            "bXB0eUIaqgIXQ2FyZWVyQ2xvdWQuZ1JQQy5Qcm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.gRPC.Protos.AppJobAppIdRequest), global::CareerCloud.gRPC.Protos.AppJobAppIdRequest.Parser, new[]{ "Id" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.gRPC.Protos.ApplicantJobApplication), global::CareerCloud.gRPC.Protos.ApplicantJobApplication.Parser, new[]{ "Id", "Applicant", "Job", "ApplicationDate" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.gRPC.Protos.ApplicantJobApplications), global::CareerCloud.gRPC.Protos.ApplicantJobApplications.Parser, new[]{ "AppJobAp" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AppJobAppIdRequest : pb::IMessage<AppJobAppIdRequest> {
    private static readonly pb::MessageParser<AppJobAppIdRequest> _parser = new pb::MessageParser<AppJobAppIdRequest>(() => new AppJobAppIdRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AppJobAppIdRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.gRPC.Protos.ApplicantJobApplicationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AppJobAppIdRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AppJobAppIdRequest(AppJobAppIdRequest other) : this() {
      id_ = other.id_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AppJobAppIdRequest Clone() {
      return new AppJobAppIdRequest(this);
    }

    /// <summary>Field number for the "Id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AppJobAppIdRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AppJobAppIdRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AppJobAppIdRequest other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ApplicantJobApplication : pb::IMessage<ApplicantJobApplication> {
    private static readonly pb::MessageParser<ApplicantJobApplication> _parser = new pb::MessageParser<ApplicantJobApplication>(() => new ApplicantJobApplication());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ApplicantJobApplication> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.gRPC.Protos.ApplicantJobApplicationReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApplicantJobApplication() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApplicantJobApplication(ApplicantJobApplication other) : this() {
      id_ = other.id_;
      applicant_ = other.applicant_;
      job_ = other.job_;
      applicationDate_ = other.applicationDate_ != null ? other.applicationDate_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApplicantJobApplication Clone() {
      return new ApplicantJobApplication(this);
    }

    /// <summary>Field number for the "Id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Applicant" field.</summary>
    public const int ApplicantFieldNumber = 2;
    private string applicant_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Applicant {
      get { return applicant_; }
      set {
        applicant_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Job" field.</summary>
    public const int JobFieldNumber = 3;
    private string job_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Job {
      get { return job_; }
      set {
        job_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ApplicationDate" field.</summary>
    public const int ApplicationDateFieldNumber = 4;
    private global::Google.Protobuf.WellKnownTypes.Timestamp applicationDate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp ApplicationDate {
      get { return applicationDate_; }
      set {
        applicationDate_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ApplicantJobApplication);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ApplicantJobApplication other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Applicant != other.Applicant) return false;
      if (Job != other.Job) return false;
      if (!object.Equals(ApplicationDate, other.ApplicationDate)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Applicant.Length != 0) hash ^= Applicant.GetHashCode();
      if (Job.Length != 0) hash ^= Job.GetHashCode();
      if (applicationDate_ != null) hash ^= ApplicationDate.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Applicant.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Applicant);
      }
      if (Job.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Job);
      }
      if (applicationDate_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(ApplicationDate);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Applicant.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Applicant);
      }
      if (Job.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Job);
      }
      if (applicationDate_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ApplicationDate);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ApplicantJobApplication other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Applicant.Length != 0) {
        Applicant = other.Applicant;
      }
      if (other.Job.Length != 0) {
        Job = other.Job;
      }
      if (other.applicationDate_ != null) {
        if (applicationDate_ == null) {
          ApplicationDate = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        ApplicationDate.MergeFrom(other.ApplicationDate);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 18: {
            Applicant = input.ReadString();
            break;
          }
          case 26: {
            Job = input.ReadString();
            break;
          }
          case 34: {
            if (applicationDate_ == null) {
              ApplicationDate = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(ApplicationDate);
            break;
          }
        }
      }
    }

  }

  public sealed partial class ApplicantJobApplications : pb::IMessage<ApplicantJobApplications> {
    private static readonly pb::MessageParser<ApplicantJobApplications> _parser = new pb::MessageParser<ApplicantJobApplications>(() => new ApplicantJobApplications());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ApplicantJobApplications> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.gRPC.Protos.ApplicantJobApplicationReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApplicantJobApplications() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApplicantJobApplications(ApplicantJobApplications other) : this() {
      appJobAp_ = other.appJobAp_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApplicantJobApplications Clone() {
      return new ApplicantJobApplications(this);
    }

    /// <summary>Field number for the "AppJobAp" field.</summary>
    public const int AppJobApFieldNumber = 1;
    private static readonly pb::FieldCodec<global::CareerCloud.gRPC.Protos.ApplicantJobApplication> _repeated_appJobAp_codec
        = pb::FieldCodec.ForMessage(10, global::CareerCloud.gRPC.Protos.ApplicantJobApplication.Parser);
    private readonly pbc::RepeatedField<global::CareerCloud.gRPC.Protos.ApplicantJobApplication> appJobAp_ = new pbc::RepeatedField<global::CareerCloud.gRPC.Protos.ApplicantJobApplication>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::CareerCloud.gRPC.Protos.ApplicantJobApplication> AppJobAp {
      get { return appJobAp_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ApplicantJobApplications);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ApplicantJobApplications other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!appJobAp_.Equals(other.appJobAp_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= appJobAp_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      appJobAp_.WriteTo(output, _repeated_appJobAp_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += appJobAp_.CalculateSize(_repeated_appJobAp_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ApplicantJobApplications other) {
      if (other == null) {
        return;
      }
      appJobAp_.Add(other.appJobAp_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            appJobAp_.AddEntriesFrom(input, _repeated_appJobAp_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
