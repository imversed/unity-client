// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: cosmos/authz/v1beta1/tx.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Cosmos.Authz.V1Beta1 {
  /// <summary>
  /// Msg defines the authz Msg service.
  /// </summary>
  public static partial class Msg
  {
    static readonly string __ServiceName = "cosmos.authz.v1beta1.Msg";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Cosmos.Authz.V1Beta1.MsgGrant> __Marshaller_cosmos_authz_v1beta1_MsgGrant = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Cosmos.Authz.V1Beta1.MsgGrant.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Cosmos.Authz.V1Beta1.MsgGrantResponse> __Marshaller_cosmos_authz_v1beta1_MsgGrantResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Cosmos.Authz.V1Beta1.MsgGrantResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Cosmos.Authz.V1Beta1.MsgExec> __Marshaller_cosmos_authz_v1beta1_MsgExec = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Cosmos.Authz.V1Beta1.MsgExec.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Cosmos.Authz.V1Beta1.MsgExecResponse> __Marshaller_cosmos_authz_v1beta1_MsgExecResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Cosmos.Authz.V1Beta1.MsgExecResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Cosmos.Authz.V1Beta1.MsgRevoke> __Marshaller_cosmos_authz_v1beta1_MsgRevoke = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Cosmos.Authz.V1Beta1.MsgRevoke.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Cosmos.Authz.V1Beta1.MsgRevokeResponse> __Marshaller_cosmos_authz_v1beta1_MsgRevokeResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Cosmos.Authz.V1Beta1.MsgRevokeResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Cosmos.Authz.V1Beta1.MsgGrant, global::Cosmos.Authz.V1Beta1.MsgGrantResponse> __Method_Grant = new grpc::Method<global::Cosmos.Authz.V1Beta1.MsgGrant, global::Cosmos.Authz.V1Beta1.MsgGrantResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Grant",
        __Marshaller_cosmos_authz_v1beta1_MsgGrant,
        __Marshaller_cosmos_authz_v1beta1_MsgGrantResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Cosmos.Authz.V1Beta1.MsgExec, global::Cosmos.Authz.V1Beta1.MsgExecResponse> __Method_Exec = new grpc::Method<global::Cosmos.Authz.V1Beta1.MsgExec, global::Cosmos.Authz.V1Beta1.MsgExecResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Exec",
        __Marshaller_cosmos_authz_v1beta1_MsgExec,
        __Marshaller_cosmos_authz_v1beta1_MsgExecResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Cosmos.Authz.V1Beta1.MsgRevoke, global::Cosmos.Authz.V1Beta1.MsgRevokeResponse> __Method_Revoke = new grpc::Method<global::Cosmos.Authz.V1Beta1.MsgRevoke, global::Cosmos.Authz.V1Beta1.MsgRevokeResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Revoke",
        __Marshaller_cosmos_authz_v1beta1_MsgRevoke,
        __Marshaller_cosmos_authz_v1beta1_MsgRevokeResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Cosmos.Authz.V1Beta1.TxReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Msg</summary>
    [grpc::BindServiceMethod(typeof(Msg), "BindService")]
    public abstract partial class MsgBase
    {
      /// <summary>
      /// Grant grants the provided authorization to the grantee on the granter's
      /// account with the provided expiration time. If there is already a grant
      /// for the given (granter, grantee, Authorization) triple, then the grant
      /// will be overwritten.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Cosmos.Authz.V1Beta1.MsgGrantResponse> Grant(global::Cosmos.Authz.V1Beta1.MsgGrant request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Exec attempts to execute the provided messages using
      /// authorizations granted to the grantee. Each message should have only
      /// one signer corresponding to the granter of the authorization.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Cosmos.Authz.V1Beta1.MsgExecResponse> Exec(global::Cosmos.Authz.V1Beta1.MsgExec request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Revoke revokes any authorization corresponding to the provided method name on the
      /// granter's account that has been granted to the grantee.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Cosmos.Authz.V1Beta1.MsgRevokeResponse> Revoke(global::Cosmos.Authz.V1Beta1.MsgRevoke request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Msg</summary>
    public partial class MsgClient : grpc::ClientBase<MsgClient>
    {
      /// <summary>Creates a new client for Msg</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public MsgClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Msg that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public MsgClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected MsgClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected MsgClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Grant grants the provided authorization to the grantee on the granter's
      /// account with the provided expiration time. If there is already a grant
      /// for the given (granter, grantee, Authorization) triple, then the grant
      /// will be overwritten.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Cosmos.Authz.V1Beta1.MsgGrantResponse Grant(global::Cosmos.Authz.V1Beta1.MsgGrant request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Grant(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Grant grants the provided authorization to the grantee on the granter's
      /// account with the provided expiration time. If there is already a grant
      /// for the given (granter, grantee, Authorization) triple, then the grant
      /// will be overwritten.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Cosmos.Authz.V1Beta1.MsgGrantResponse Grant(global::Cosmos.Authz.V1Beta1.MsgGrant request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Grant, null, options, request);
      }
      /// <summary>
      /// Grant grants the provided authorization to the grantee on the granter's
      /// account with the provided expiration time. If there is already a grant
      /// for the given (granter, grantee, Authorization) triple, then the grant
      /// will be overwritten.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Cosmos.Authz.V1Beta1.MsgGrantResponse> GrantAsync(global::Cosmos.Authz.V1Beta1.MsgGrant request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GrantAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Grant grants the provided authorization to the grantee on the granter's
      /// account with the provided expiration time. If there is already a grant
      /// for the given (granter, grantee, Authorization) triple, then the grant
      /// will be overwritten.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Cosmos.Authz.V1Beta1.MsgGrantResponse> GrantAsync(global::Cosmos.Authz.V1Beta1.MsgGrant request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Grant, null, options, request);
      }
      /// <summary>
      /// Exec attempts to execute the provided messages using
      /// authorizations granted to the grantee. Each message should have only
      /// one signer corresponding to the granter of the authorization.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Cosmos.Authz.V1Beta1.MsgExecResponse Exec(global::Cosmos.Authz.V1Beta1.MsgExec request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Exec(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Exec attempts to execute the provided messages using
      /// authorizations granted to the grantee. Each message should have only
      /// one signer corresponding to the granter of the authorization.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Cosmos.Authz.V1Beta1.MsgExecResponse Exec(global::Cosmos.Authz.V1Beta1.MsgExec request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Exec, null, options, request);
      }
      /// <summary>
      /// Exec attempts to execute the provided messages using
      /// authorizations granted to the grantee. Each message should have only
      /// one signer corresponding to the granter of the authorization.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Cosmos.Authz.V1Beta1.MsgExecResponse> ExecAsync(global::Cosmos.Authz.V1Beta1.MsgExec request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ExecAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Exec attempts to execute the provided messages using
      /// authorizations granted to the grantee. Each message should have only
      /// one signer corresponding to the granter of the authorization.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Cosmos.Authz.V1Beta1.MsgExecResponse> ExecAsync(global::Cosmos.Authz.V1Beta1.MsgExec request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Exec, null, options, request);
      }
      /// <summary>
      /// Revoke revokes any authorization corresponding to the provided method name on the
      /// granter's account that has been granted to the grantee.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Cosmos.Authz.V1Beta1.MsgRevokeResponse Revoke(global::Cosmos.Authz.V1Beta1.MsgRevoke request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Revoke(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Revoke revokes any authorization corresponding to the provided method name on the
      /// granter's account that has been granted to the grantee.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Cosmos.Authz.V1Beta1.MsgRevokeResponse Revoke(global::Cosmos.Authz.V1Beta1.MsgRevoke request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Revoke, null, options, request);
      }
      /// <summary>
      /// Revoke revokes any authorization corresponding to the provided method name on the
      /// granter's account that has been granted to the grantee.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Cosmos.Authz.V1Beta1.MsgRevokeResponse> RevokeAsync(global::Cosmos.Authz.V1Beta1.MsgRevoke request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RevokeAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Revoke revokes any authorization corresponding to the provided method name on the
      /// granter's account that has been granted to the grantee.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Cosmos.Authz.V1Beta1.MsgRevokeResponse> RevokeAsync(global::Cosmos.Authz.V1Beta1.MsgRevoke request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Revoke, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override MsgClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new MsgClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(MsgBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Grant, serviceImpl.Grant)
          .AddMethod(__Method_Exec, serviceImpl.Exec)
          .AddMethod(__Method_Revoke, serviceImpl.Revoke).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, MsgBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Grant, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Cosmos.Authz.V1Beta1.MsgGrant, global::Cosmos.Authz.V1Beta1.MsgGrantResponse>(serviceImpl.Grant));
      serviceBinder.AddMethod(__Method_Exec, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Cosmos.Authz.V1Beta1.MsgExec, global::Cosmos.Authz.V1Beta1.MsgExecResponse>(serviceImpl.Exec));
      serviceBinder.AddMethod(__Method_Revoke, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Cosmos.Authz.V1Beta1.MsgRevoke, global::Cosmos.Authz.V1Beta1.MsgRevokeResponse>(serviceImpl.Revoke));
    }

  }
}
#endregion
