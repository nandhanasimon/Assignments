// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/CompanyDescription.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace CareerCloud.gRPC.Protos {

  /// <summary>Holder for reflection information generated from Protos/CompanyDescription.proto</summary>
  public static partial class CompanyDescriptionReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/CompanyDescription.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CompanyDescriptionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9Qcm90b3MvQ29tcGFueURlc2NyaXB0aW9uLnByb3RvEhBDYXJlZXJDbG91",
            "ZC5nUlBDGh9nb29nbGUvcHJvdG9idWYvdGltZXN0YW1wLnByb3RvGhtnb29n",
            "bGUvcHJvdG9idWYvZW1wdHkucHJvdG8iIQoTQ29tcGFueURlc0lkUmVxdWVz",
            "dBIKCgJJZBgBIAEoCSJ3ChNDb21wYW55RGVzY3JpcHRpb25OEgoKAklkGAEg",
            "ASgJEg8KB0NvbXBhbnkYAiABKAkSEgoKTGFuZ3VhZ2VJZBgDIAEoCRITCgtD",
            "b21wYW55TmFtZRgEIAEoCRIaChJDb21wYW55RGVzY3JpcHRpb24YBSABKAki",
            "TQoTQ29tcGFueURlc2NyaXB0aW9ucxI2CgdDb21EZXNjGAEgAygLMiUuQ2Fy",
            "ZWVyQ2xvdWQuZ1JQQy5Db21wYW55RGVzY3JpcHRpb25OMpMDChlDb21wYW55",
            "RGVzY3JpcHRpb25TZXJ2aWNlEmUKFUdldENvbXBhbnlEZXNjcmlwdGlvbhIl",
            "LkNhcmVlckNsb3VkLmdSUEMuQ29tcGFueURlc0lkUmVxdWVzdBolLkNhcmVl",
            "ckNsb3VkLmdSUEMuQ29tcGFueURlc2NyaXB0aW9uThJZChhDcmVhdGVDb21w",
            "YW55RGVzY3JpcHRpb24SJS5DYXJlZXJDbG91ZC5nUlBDLkNvbXBhbnlEZXNj",
            "cmlwdGlvbnMaFi5nb29nbGUucHJvdG9idWYuRW1wdHkSWQoYVXBkYXRlQ29t",
            "cGFueURlc2NyaXB0aW9uEiUuQ2FyZWVyQ2xvdWQuZ1JQQy5Db21wYW55RGVz",
            "Y3JpcHRpb25zGhYuZ29vZ2xlLnByb3RvYnVmLkVtcHR5ElkKGERlbGV0ZUNv",
            "bXBhbnlEZXNjcmlwdGlvbhIlLkNhcmVlckNsb3VkLmdSUEMuQ29tcGFueURl",
            "c2NyaXB0aW9ucxoWLmdvb2dsZS5wcm90b2J1Zi5FbXB0eUIaqgIXQ2FyZWVy",
            "Q2xvdWQuZ1JQQy5Qcm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.gRPC.Protos.CompanyDesIdRequest), global::CareerCloud.gRPC.Protos.CompanyDesIdRequest.Parser, new[]{ "Id" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.gRPC.Protos.CompanyDescriptionN), global::CareerCloud.gRPC.Protos.CompanyDescriptionN.Parser, new[]{ "Id", "Company", "LanguageId", "CompanyName", "CompanyDescription" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.gRPC.Protos.CompanyDescriptions), global::CareerCloud.gRPC.Protos.CompanyDescriptions.Parser, new[]{ "ComDesc" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CompanyDesIdRequest : pb::IMessage<CompanyDesIdRequest> {
    private static readonly pb::MessageParser<CompanyDesIdRequest> _parser = new pb::MessageParser<CompanyDesIdRequest>(() => new CompanyDesIdRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CompanyDesIdRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.gRPC.Protos.CompanyDescriptionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyDesIdRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyDesIdRequest(CompanyDesIdRequest other) : this() {
      id_ = other.id_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyDesIdRequest Clone() {
      return new CompanyDesIdRequest(this);
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
      return Equals(other as CompanyDesIdRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CompanyDesIdRequest other) {
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
    public void MergeFrom(CompanyDesIdRequest other) {
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

  public sealed partial class CompanyDescriptionN : pb::IMessage<CompanyDescriptionN> {
    private static readonly pb::MessageParser<CompanyDescriptionN> _parser = new pb::MessageParser<CompanyDescriptionN>(() => new CompanyDescriptionN());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CompanyDescriptionN> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.gRPC.Protos.CompanyDescriptionReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyDescriptionN() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyDescriptionN(CompanyDescriptionN other) : this() {
      id_ = other.id_;
      company_ = other.company_;
      languageId_ = other.languageId_;
      companyName_ = other.companyName_;
      companyDescription_ = other.companyDescription_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyDescriptionN Clone() {
      return new CompanyDescriptionN(this);
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

    /// <summary>Field number for the "Company" field.</summary>
    public const int CompanyFieldNumber = 2;
    private string company_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Company {
      get { return company_; }
      set {
        company_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "LanguageId" field.</summary>
    public const int LanguageIdFieldNumber = 3;
    private string languageId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LanguageId {
      get { return languageId_; }
      set {
        languageId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "CompanyName" field.</summary>
    public const int CompanyNameFieldNumber = 4;
    private string companyName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CompanyName {
      get { return companyName_; }
      set {
        companyName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "CompanyDescription" field.</summary>
    public const int CompanyDescriptionFieldNumber = 5;
    private string companyDescription_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CompanyDescription {
      get { return companyDescription_; }
      set {
        companyDescription_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CompanyDescriptionN);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CompanyDescriptionN other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Company != other.Company) return false;
      if (LanguageId != other.LanguageId) return false;
      if (CompanyName != other.CompanyName) return false;
      if (CompanyDescription != other.CompanyDescription) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Company.Length != 0) hash ^= Company.GetHashCode();
      if (LanguageId.Length != 0) hash ^= LanguageId.GetHashCode();
      if (CompanyName.Length != 0) hash ^= CompanyName.GetHashCode();
      if (CompanyDescription.Length != 0) hash ^= CompanyDescription.GetHashCode();
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
      if (Company.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Company);
      }
      if (LanguageId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(LanguageId);
      }
      if (CompanyName.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(CompanyName);
      }
      if (CompanyDescription.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(CompanyDescription);
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
      if (Company.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Company);
      }
      if (LanguageId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LanguageId);
      }
      if (CompanyName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CompanyName);
      }
      if (CompanyDescription.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CompanyDescription);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CompanyDescriptionN other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Company.Length != 0) {
        Company = other.Company;
      }
      if (other.LanguageId.Length != 0) {
        LanguageId = other.LanguageId;
      }
      if (other.CompanyName.Length != 0) {
        CompanyName = other.CompanyName;
      }
      if (other.CompanyDescription.Length != 0) {
        CompanyDescription = other.CompanyDescription;
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
            Company = input.ReadString();
            break;
          }
          case 26: {
            LanguageId = input.ReadString();
            break;
          }
          case 34: {
            CompanyName = input.ReadString();
            break;
          }
          case 42: {
            CompanyDescription = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class CompanyDescriptions : pb::IMessage<CompanyDescriptions> {
    private static readonly pb::MessageParser<CompanyDescriptions> _parser = new pb::MessageParser<CompanyDescriptions>(() => new CompanyDescriptions());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CompanyDescriptions> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.gRPC.Protos.CompanyDescriptionReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyDescriptions() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyDescriptions(CompanyDescriptions other) : this() {
      comDesc_ = other.comDesc_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyDescriptions Clone() {
      return new CompanyDescriptions(this);
    }

    /// <summary>Field number for the "ComDesc" field.</summary>
    public const int ComDescFieldNumber = 1;
    private static readonly pb::FieldCodec<global::CareerCloud.gRPC.Protos.CompanyDescriptionN> _repeated_comDesc_codec
        = pb::FieldCodec.ForMessage(10, global::CareerCloud.gRPC.Protos.CompanyDescriptionN.Parser);
    private readonly pbc::RepeatedField<global::CareerCloud.gRPC.Protos.CompanyDescriptionN> comDesc_ = new pbc::RepeatedField<global::CareerCloud.gRPC.Protos.CompanyDescriptionN>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::CareerCloud.gRPC.Protos.CompanyDescriptionN> ComDesc {
      get { return comDesc_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CompanyDescriptions);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CompanyDescriptions other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!comDesc_.Equals(other.comDesc_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= comDesc_.GetHashCode();
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
      comDesc_.WriteTo(output, _repeated_comDesc_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += comDesc_.CalculateSize(_repeated_comDesc_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CompanyDescriptions other) {
      if (other == null) {
        return;
      }
      comDesc_.Add(other.comDesc_);
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
            comDesc_.AddEntriesFrom(input, _repeated_comDesc_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
