// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/SecurityLoginsLog.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace CareerCloud.gRPC.Protos {

  /// <summary>Holder for reflection information generated from Protos/SecurityLoginsLog.proto</summary>
  public static partial class SecurityLoginsLogReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/SecurityLoginsLog.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SecurityLoginsLogReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5Qcm90b3MvU2VjdXJpdHlMb2dpbnNMb2cucHJvdG8SEENhcmVlckNsb3Vk",
            "LmdSUEMaH2dvb2dsZS9wcm90b2J1Zi90aW1lc3RhbXAucHJvdG8aG2dvb2ds",
            "ZS9wcm90b2J1Zi9lbXB0eS5wcm90byIoChpTZWN1cml0eUxvZ2luc0xvZ0lk",
            "UmVxdWVzdBIKCgJJZBgBIAEoCSKEAQoRU2VjdXJpdHlMb2dpbnNMb2cSCgoC",
            "SWQYASABKAkSDQoFTG9naW4YAiABKAkSEAoIU291cmNlSVAYAyABKAkSLQoJ",
            "TG9nb25EYXRlGAQgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcBIT",
            "CgtJc1N1Y2Nlc2Z1bBgFIAEoCCJPChJTZWN1cml0eUxvZ2luc0xvZ3MSOQoM",
            "U2VjTG9naW5zTG9nGAEgAygLMiMuQ2FyZWVyQ2xvdWQuZ1JQQy5TZWN1cml0",
            "eUxvZ2luc0xvZzKQAwoYU2VjdXJpdHlMb2dpbnNMb2dTZXJ2aWNlEmkKFEdl",
            "dFNlY3VyaXR5TG9naW5zTG9nEiwuQ2FyZWVyQ2xvdWQuZ1JQQy5TZWN1cml0",
            "eUxvZ2luc0xvZ0lkUmVxdWVzdBojLkNhcmVlckNsb3VkLmdSUEMuU2VjdXJp",
            "dHlMb2dpbnNMb2cSVwoXQ3JlYXRlU2VjdXJpdHlMb2dpbnNMb2cSJC5DYXJl",
            "ZXJDbG91ZC5nUlBDLlNlY3VyaXR5TG9naW5zTG9ncxoWLmdvb2dsZS5wcm90",
            "b2J1Zi5FbXB0eRJXChdVcGRhdGVTZWN1cml0eUxvZ2luc0xvZxIkLkNhcmVl",
            "ckNsb3VkLmdSUEMuU2VjdXJpdHlMb2dpbnNMb2dzGhYuZ29vZ2xlLnByb3Rv",
            "YnVmLkVtcHR5ElcKF0RlbGV0ZVNlY3VyaXR5TG9naW5zTG9nEiQuQ2FyZWVy",
            "Q2xvdWQuZ1JQQy5TZWN1cml0eUxvZ2luc0xvZ3MaFi5nb29nbGUucHJvdG9i",
            "dWYuRW1wdHlCGqoCF0NhcmVlckNsb3VkLmdSUEMuUHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.gRPC.Protos.SecurityLoginsLogIdRequest), global::CareerCloud.gRPC.Protos.SecurityLoginsLogIdRequest.Parser, new[]{ "Id" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.gRPC.Protos.SecurityLoginsLog), global::CareerCloud.gRPC.Protos.SecurityLoginsLog.Parser, new[]{ "Id", "Login", "SourceIP", "LogonDate", "IsSuccesful" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.gRPC.Protos.SecurityLoginsLogs), global::CareerCloud.gRPC.Protos.SecurityLoginsLogs.Parser, new[]{ "SecLoginsLog" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SecurityLoginsLogIdRequest : pb::IMessage<SecurityLoginsLogIdRequest> {
    private static readonly pb::MessageParser<SecurityLoginsLogIdRequest> _parser = new pb::MessageParser<SecurityLoginsLogIdRequest>(() => new SecurityLoginsLogIdRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SecurityLoginsLogIdRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.gRPC.Protos.SecurityLoginsLogReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SecurityLoginsLogIdRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SecurityLoginsLogIdRequest(SecurityLoginsLogIdRequest other) : this() {
      id_ = other.id_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SecurityLoginsLogIdRequest Clone() {
      return new SecurityLoginsLogIdRequest(this);
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
      return Equals(other as SecurityLoginsLogIdRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SecurityLoginsLogIdRequest other) {
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
    public void MergeFrom(SecurityLoginsLogIdRequest other) {
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

  public sealed partial class SecurityLoginsLog : pb::IMessage<SecurityLoginsLog> {
    private static readonly pb::MessageParser<SecurityLoginsLog> _parser = new pb::MessageParser<SecurityLoginsLog>(() => new SecurityLoginsLog());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SecurityLoginsLog> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.gRPC.Protos.SecurityLoginsLogReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SecurityLoginsLog() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SecurityLoginsLog(SecurityLoginsLog other) : this() {
      id_ = other.id_;
      login_ = other.login_;
      sourceIP_ = other.sourceIP_;
      logonDate_ = other.logonDate_ != null ? other.logonDate_.Clone() : null;
      isSuccesful_ = other.isSuccesful_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SecurityLoginsLog Clone() {
      return new SecurityLoginsLog(this);
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

    /// <summary>Field number for the "Login" field.</summary>
    public const int LoginFieldNumber = 2;
    private string login_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Login {
      get { return login_; }
      set {
        login_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "SourceIP" field.</summary>
    public const int SourceIPFieldNumber = 3;
    private string sourceIP_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SourceIP {
      get { return sourceIP_; }
      set {
        sourceIP_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "LogonDate" field.</summary>
    public const int LogonDateFieldNumber = 4;
    private global::Google.Protobuf.WellKnownTypes.Timestamp logonDate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp LogonDate {
      get { return logonDate_; }
      set {
        logonDate_ = value;
      }
    }

    /// <summary>Field number for the "IsSuccesful" field.</summary>
    public const int IsSuccesfulFieldNumber = 5;
    private bool isSuccesful_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsSuccesful {
      get { return isSuccesful_; }
      set {
        isSuccesful_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SecurityLoginsLog);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SecurityLoginsLog other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Login != other.Login) return false;
      if (SourceIP != other.SourceIP) return false;
      if (!object.Equals(LogonDate, other.LogonDate)) return false;
      if (IsSuccesful != other.IsSuccesful) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Login.Length != 0) hash ^= Login.GetHashCode();
      if (SourceIP.Length != 0) hash ^= SourceIP.GetHashCode();
      if (logonDate_ != null) hash ^= LogonDate.GetHashCode();
      if (IsSuccesful != false) hash ^= IsSuccesful.GetHashCode();
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
      if (Login.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Login);
      }
      if (SourceIP.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(SourceIP);
      }
      if (logonDate_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(LogonDate);
      }
      if (IsSuccesful != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsSuccesful);
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
      if (Login.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Login);
      }
      if (SourceIP.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SourceIP);
      }
      if (logonDate_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LogonDate);
      }
      if (IsSuccesful != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SecurityLoginsLog other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Login.Length != 0) {
        Login = other.Login;
      }
      if (other.SourceIP.Length != 0) {
        SourceIP = other.SourceIP;
      }
      if (other.logonDate_ != null) {
        if (logonDate_ == null) {
          LogonDate = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        LogonDate.MergeFrom(other.LogonDate);
      }
      if (other.IsSuccesful != false) {
        IsSuccesful = other.IsSuccesful;
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
            Login = input.ReadString();
            break;
          }
          case 26: {
            SourceIP = input.ReadString();
            break;
          }
          case 34: {
            if (logonDate_ == null) {
              LogonDate = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(LogonDate);
            break;
          }
          case 40: {
            IsSuccesful = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  public sealed partial class SecurityLoginsLogs : pb::IMessage<SecurityLoginsLogs> {
    private static readonly pb::MessageParser<SecurityLoginsLogs> _parser = new pb::MessageParser<SecurityLoginsLogs>(() => new SecurityLoginsLogs());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SecurityLoginsLogs> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.gRPC.Protos.SecurityLoginsLogReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SecurityLoginsLogs() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SecurityLoginsLogs(SecurityLoginsLogs other) : this() {
      secLoginsLog_ = other.secLoginsLog_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SecurityLoginsLogs Clone() {
      return new SecurityLoginsLogs(this);
    }

    /// <summary>Field number for the "SecLoginsLog" field.</summary>
    public const int SecLoginsLogFieldNumber = 1;
    private static readonly pb::FieldCodec<global::CareerCloud.gRPC.Protos.SecurityLoginsLog> _repeated_secLoginsLog_codec
        = pb::FieldCodec.ForMessage(10, global::CareerCloud.gRPC.Protos.SecurityLoginsLog.Parser);
    private readonly pbc::RepeatedField<global::CareerCloud.gRPC.Protos.SecurityLoginsLog> secLoginsLog_ = new pbc::RepeatedField<global::CareerCloud.gRPC.Protos.SecurityLoginsLog>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::CareerCloud.gRPC.Protos.SecurityLoginsLog> SecLoginsLog {
      get { return secLoginsLog_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SecurityLoginsLogs);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SecurityLoginsLogs other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!secLoginsLog_.Equals(other.secLoginsLog_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= secLoginsLog_.GetHashCode();
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
      secLoginsLog_.WriteTo(output, _repeated_secLoginsLog_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += secLoginsLog_.CalculateSize(_repeated_secLoginsLog_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SecurityLoginsLogs other) {
      if (other == null) {
        return;
      }
      secLoginsLog_.Add(other.secLoginsLog_);
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
            secLoginsLog_.AddEntriesFrom(input, _repeated_secLoginsLog_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
