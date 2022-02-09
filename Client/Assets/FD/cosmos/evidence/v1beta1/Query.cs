// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: cosmos/evidence/v1beta1/query.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cosmos.Evidence.V1Beta1 {

  /// <summary>Holder for reflection information generated from cosmos/evidence/v1beta1/query.proto</summary>
  public static partial class QueryReflection {

    #region Descriptor
    /// <summary>File descriptor for cosmos/evidence/v1beta1/query.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static QueryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNjb3Ntb3MvZXZpZGVuY2UvdjFiZXRhMS9xdWVyeS5wcm90bxIXY29zbW9z",
            "LmV2aWRlbmNlLnYxYmV0YTEaKmNvc21vcy9iYXNlL3F1ZXJ5L3YxYmV0YTEv",
            "cGFnaW5hdGlvbi5wcm90bxoUZ29nb3Byb3RvL2dvZ28ucHJvdG8aGWdvb2ds",
            "ZS9wcm90b2J1Zi9hbnkucHJvdG8aHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMu",
            "cHJvdG8iZwoUUXVlcnlFdmlkZW5jZVJlcXVlc3QSTwoNZXZpZGVuY2VfaGFz",
            "aBgBIAEoDEI4+t4fNGdpdGh1Yi5jb20vdGVuZGVybWludC90ZW5kZXJtaW50",
            "L2xpYnMvYnl0ZXMuSGV4Qnl0ZXMiPwoVUXVlcnlFdmlkZW5jZVJlc3BvbnNl",
            "EiYKCGV2aWRlbmNlGAEgASgLMhQuZ29vZ2xlLnByb3RvYnVmLkFueSJVChdR",
            "dWVyeUFsbEV2aWRlbmNlUmVxdWVzdBI6CgpwYWdpbmF0aW9uGAEgASgLMiYu",
            "Y29zbW9zLmJhc2UucXVlcnkudjFiZXRhMS5QYWdlUmVxdWVzdCJ/ChhRdWVy",
            "eUFsbEV2aWRlbmNlUmVzcG9uc2USJgoIZXZpZGVuY2UYASADKAsyFC5nb29n",
            "bGUucHJvdG9idWYuQW55EjsKCnBhZ2luYXRpb24YAiABKAsyJy5jb3Ntb3Mu",
            "YmFzZS5xdWVyeS52MWJldGExLlBhZ2VSZXNwb25zZTLOAgoFUXVlcnkSpAEK",
            "CEV2aWRlbmNlEi0uY29zbW9zLmV2aWRlbmNlLnYxYmV0YTEuUXVlcnlFdmlk",
            "ZW5jZVJlcXVlc3QaLi5jb3Ntb3MuZXZpZGVuY2UudjFiZXRhMS5RdWVyeUV2",
            "aWRlbmNlUmVzcG9uc2UiOYLT5JMCMxIxL2Nvc21vcy9ldmlkZW5jZS92MWJl",
            "dGExL2V2aWRlbmNlL3tldmlkZW5jZV9oYXNofRKdAQoLQWxsRXZpZGVuY2US",
            "MC5jb3Ntb3MuZXZpZGVuY2UudjFiZXRhMS5RdWVyeUFsbEV2aWRlbmNlUmVx",
            "dWVzdBoxLmNvc21vcy5ldmlkZW5jZS52MWJldGExLlF1ZXJ5QWxsRXZpZGVu",
            "Y2VSZXNwb25zZSIpgtPkkwIjEiEvY29zbW9zL2V2aWRlbmNlL3YxYmV0YTEv",
            "ZXZpZGVuY2VCL1otZ2l0aHViLmNvbS9jb3Ntb3MvY29zbW9zLXNkay94L2V2",
            "aWRlbmNlL3R5cGVzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Cosmos.Base.Query.V1Beta1.PaginationReflection.Descriptor, global::Gogoproto.GogoReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.AnyReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cosmos.Evidence.V1Beta1.QueryEvidenceRequest), global::Cosmos.Evidence.V1Beta1.QueryEvidenceRequest.Parser, new[]{ "EvidenceHash" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Cosmos.Evidence.V1Beta1.QueryEvidenceResponse), global::Cosmos.Evidence.V1Beta1.QueryEvidenceResponse.Parser, new[]{ "Evidence" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Cosmos.Evidence.V1Beta1.QueryAllEvidenceRequest), global::Cosmos.Evidence.V1Beta1.QueryAllEvidenceRequest.Parser, new[]{ "Pagination" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Cosmos.Evidence.V1Beta1.QueryAllEvidenceResponse), global::Cosmos.Evidence.V1Beta1.QueryAllEvidenceResponse.Parser, new[]{ "Evidence", "Pagination" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// QueryEvidenceRequest is the request type for the Query/Evidence RPC method.
  /// </summary>
  public sealed partial class QueryEvidenceRequest : pb::IMessage<QueryEvidenceRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<QueryEvidenceRequest> _parser = new pb::MessageParser<QueryEvidenceRequest>(() => new QueryEvidenceRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<QueryEvidenceRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cosmos.Evidence.V1Beta1.QueryReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryEvidenceRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryEvidenceRequest(QueryEvidenceRequest other) : this() {
      evidenceHash_ = other.evidenceHash_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryEvidenceRequest Clone() {
      return new QueryEvidenceRequest(this);
    }

    /// <summary>Field number for the "evidence_hash" field.</summary>
    public const int EvidenceHashFieldNumber = 1;
    private pb::ByteString evidenceHash_ = pb::ByteString.Empty;
    /// <summary>
    /// evidence_hash defines the hash of the requested evidence.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString EvidenceHash {
      get { return evidenceHash_; }
      set {
        evidenceHash_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as QueryEvidenceRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(QueryEvidenceRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EvidenceHash != other.EvidenceHash) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EvidenceHash.Length != 0) hash ^= EvidenceHash.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (EvidenceHash.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(EvidenceHash);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (EvidenceHash.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(EvidenceHash);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (EvidenceHash.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(EvidenceHash);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(QueryEvidenceRequest other) {
      if (other == null) {
        return;
      }
      if (other.EvidenceHash.Length != 0) {
        EvidenceHash = other.EvidenceHash;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            EvidenceHash = input.ReadBytes();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            EvidenceHash = input.ReadBytes();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// QueryEvidenceResponse is the response type for the Query/Evidence RPC method.
  /// </summary>
  public sealed partial class QueryEvidenceResponse : pb::IMessage<QueryEvidenceResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<QueryEvidenceResponse> _parser = new pb::MessageParser<QueryEvidenceResponse>(() => new QueryEvidenceResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<QueryEvidenceResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cosmos.Evidence.V1Beta1.QueryReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryEvidenceResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryEvidenceResponse(QueryEvidenceResponse other) : this() {
      evidence_ = other.evidence_ != null ? other.evidence_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryEvidenceResponse Clone() {
      return new QueryEvidenceResponse(this);
    }

    /// <summary>Field number for the "evidence" field.</summary>
    public const int EvidenceFieldNumber = 1;
    private global::Google.Protobuf.WellKnownTypes.Any evidence_;
    /// <summary>
    /// evidence returns the requested evidence.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Any Evidence {
      get { return evidence_; }
      set {
        evidence_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as QueryEvidenceResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(QueryEvidenceResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Evidence, other.Evidence)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (evidence_ != null) hash ^= Evidence.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (evidence_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Evidence);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (evidence_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Evidence);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (evidence_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Evidence);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(QueryEvidenceResponse other) {
      if (other == null) {
        return;
      }
      if (other.evidence_ != null) {
        if (evidence_ == null) {
          Evidence = new global::Google.Protobuf.WellKnownTypes.Any();
        }
        Evidence.MergeFrom(other.Evidence);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (evidence_ == null) {
              Evidence = new global::Google.Protobuf.WellKnownTypes.Any();
            }
            input.ReadMessage(Evidence);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            if (evidence_ == null) {
              Evidence = new global::Google.Protobuf.WellKnownTypes.Any();
            }
            input.ReadMessage(Evidence);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// QueryEvidenceRequest is the request type for the Query/AllEvidence RPC
  /// method.
  /// </summary>
  public sealed partial class QueryAllEvidenceRequest : pb::IMessage<QueryAllEvidenceRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<QueryAllEvidenceRequest> _parser = new pb::MessageParser<QueryAllEvidenceRequest>(() => new QueryAllEvidenceRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<QueryAllEvidenceRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cosmos.Evidence.V1Beta1.QueryReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryAllEvidenceRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryAllEvidenceRequest(QueryAllEvidenceRequest other) : this() {
      pagination_ = other.pagination_ != null ? other.pagination_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryAllEvidenceRequest Clone() {
      return new QueryAllEvidenceRequest(this);
    }

    /// <summary>Field number for the "pagination" field.</summary>
    public const int PaginationFieldNumber = 1;
    private global::Cosmos.Base.Query.V1Beta1.PageRequest pagination_;
    /// <summary>
    /// pagination defines an optional pagination for the request.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Cosmos.Base.Query.V1Beta1.PageRequest Pagination {
      get { return pagination_; }
      set {
        pagination_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as QueryAllEvidenceRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(QueryAllEvidenceRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Pagination, other.Pagination)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (pagination_ != null) hash ^= Pagination.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (pagination_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Pagination);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (pagination_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Pagination);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (pagination_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pagination);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(QueryAllEvidenceRequest other) {
      if (other == null) {
        return;
      }
      if (other.pagination_ != null) {
        if (pagination_ == null) {
          Pagination = new global::Cosmos.Base.Query.V1Beta1.PageRequest();
        }
        Pagination.MergeFrom(other.Pagination);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (pagination_ == null) {
              Pagination = new global::Cosmos.Base.Query.V1Beta1.PageRequest();
            }
            input.ReadMessage(Pagination);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            if (pagination_ == null) {
              Pagination = new global::Cosmos.Base.Query.V1Beta1.PageRequest();
            }
            input.ReadMessage(Pagination);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// QueryAllEvidenceResponse is the response type for the Query/AllEvidence RPC
  /// method.
  /// </summary>
  public sealed partial class QueryAllEvidenceResponse : pb::IMessage<QueryAllEvidenceResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<QueryAllEvidenceResponse> _parser = new pb::MessageParser<QueryAllEvidenceResponse>(() => new QueryAllEvidenceResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<QueryAllEvidenceResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cosmos.Evidence.V1Beta1.QueryReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryAllEvidenceResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryAllEvidenceResponse(QueryAllEvidenceResponse other) : this() {
      evidence_ = other.evidence_.Clone();
      pagination_ = other.pagination_ != null ? other.pagination_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryAllEvidenceResponse Clone() {
      return new QueryAllEvidenceResponse(this);
    }

    /// <summary>Field number for the "evidence" field.</summary>
    public const int EvidenceFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Google.Protobuf.WellKnownTypes.Any> _repeated_evidence_codec
        = pb::FieldCodec.ForMessage(10, global::Google.Protobuf.WellKnownTypes.Any.Parser);
    private readonly pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Any> evidence_ = new pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Any>();
    /// <summary>
    /// evidence returns all evidences.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Any> Evidence {
      get { return evidence_; }
    }

    /// <summary>Field number for the "pagination" field.</summary>
    public const int PaginationFieldNumber = 2;
    private global::Cosmos.Base.Query.V1Beta1.PageResponse pagination_;
    /// <summary>
    /// pagination defines the pagination in the response.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Cosmos.Base.Query.V1Beta1.PageResponse Pagination {
      get { return pagination_; }
      set {
        pagination_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as QueryAllEvidenceResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(QueryAllEvidenceResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!evidence_.Equals(other.evidence_)) return false;
      if (!object.Equals(Pagination, other.Pagination)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= evidence_.GetHashCode();
      if (pagination_ != null) hash ^= Pagination.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      evidence_.WriteTo(output, _repeated_evidence_codec);
      if (pagination_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Pagination);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      evidence_.WriteTo(ref output, _repeated_evidence_codec);
      if (pagination_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Pagination);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += evidence_.CalculateSize(_repeated_evidence_codec);
      if (pagination_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pagination);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(QueryAllEvidenceResponse other) {
      if (other == null) {
        return;
      }
      evidence_.Add(other.evidence_);
      if (other.pagination_ != null) {
        if (pagination_ == null) {
          Pagination = new global::Cosmos.Base.Query.V1Beta1.PageResponse();
        }
        Pagination.MergeFrom(other.Pagination);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            evidence_.AddEntriesFrom(input, _repeated_evidence_codec);
            break;
          }
          case 18: {
            if (pagination_ == null) {
              Pagination = new global::Cosmos.Base.Query.V1Beta1.PageResponse();
            }
            input.ReadMessage(Pagination);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            evidence_.AddEntriesFrom(ref input, _repeated_evidence_codec);
            break;
          }
          case 18: {
            if (pagination_ == null) {
              Pagination = new global::Cosmos.Base.Query.V1Beta1.PageResponse();
            }
            input.ReadMessage(Pagination);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
