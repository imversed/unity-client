// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: cosmos/base/reflection/v1beta1/reflection.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Cosmos.Base.Reflection.V1Beta1 {
  /// <summary>
  /// ReflectionService defines a service for interface reflection.
  /// </summary>
  public static partial class ReflectionService
  {
    static readonly string __ServiceName = "cosmos.base.reflection.v1beta1.ReflectionService";

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
    static readonly grpc::Marshaller<global::Cosmos.Base.Reflection.V1Beta1.ListAllInterfacesRequest> __Marshaller_cosmos_base_reflection_v1beta1_ListAllInterfacesRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Cosmos.Base.Reflection.V1Beta1.ListAllInterfacesRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Cosmos.Base.Reflection.V1Beta1.ListAllInterfacesResponse> __Marshaller_cosmos_base_reflection_v1beta1_ListAllInterfacesResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Cosmos.Base.Reflection.V1Beta1.ListAllInterfacesResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Cosmos.Base.Reflection.V1Beta1.ListImplementationsRequest> __Marshaller_cosmos_base_reflection_v1beta1_ListImplementationsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Cosmos.Base.Reflection.V1Beta1.ListImplementationsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Cosmos.Base.Reflection.V1Beta1.ListImplementationsResponse> __Marshaller_cosmos_base_reflection_v1beta1_ListImplementationsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Cosmos.Base.Reflection.V1Beta1.ListImplementationsResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Cosmos.Base.Reflection.V1Beta1.ListAllInterfacesRequest, global::Cosmos.Base.Reflection.V1Beta1.ListAllInterfacesResponse> __Method_ListAllInterfaces = new grpc::Method<global::Cosmos.Base.Reflection.V1Beta1.ListAllInterfacesRequest, global::Cosmos.Base.Reflection.V1Beta1.ListAllInterfacesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListAllInterfaces",
        __Marshaller_cosmos_base_reflection_v1beta1_ListAllInterfacesRequest,
        __Marshaller_cosmos_base_reflection_v1beta1_ListAllInterfacesResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Cosmos.Base.Reflection.V1Beta1.ListImplementationsRequest, global::Cosmos.Base.Reflection.V1Beta1.ListImplementationsResponse> __Method_ListImplementations = new grpc::Method<global::Cosmos.Base.Reflection.V1Beta1.ListImplementationsRequest, global::Cosmos.Base.Reflection.V1Beta1.ListImplementationsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListImplementations",
        __Marshaller_cosmos_base_reflection_v1beta1_ListImplementationsRequest,
        __Marshaller_cosmos_base_reflection_v1beta1_ListImplementationsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Cosmos.Base.Reflection.V1Beta1.ReflectionReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ReflectionService</summary>
    [grpc::BindServiceMethod(typeof(ReflectionService), "BindService")]
    public abstract partial class ReflectionServiceBase
    {
      /// <summary>
      /// ListAllInterfaces lists all the interfaces registered in the interface
      /// registry.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Cosmos.Base.Reflection.V1Beta1.ListAllInterfacesResponse> ListAllInterfaces(global::Cosmos.Base.Reflection.V1Beta1.ListAllInterfacesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// ListImplementations list all the concrete types that implement a given
      /// interface.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Cosmos.Base.Reflection.V1Beta1.ListImplementationsResponse> ListImplementations(global::Cosmos.Base.Reflection.V1Beta1.ListImplementationsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ReflectionService</summary>
    public partial class ReflectionServiceClient : grpc::ClientBase<ReflectionServiceClient>
    {
      /// <summary>Creates a new client for ReflectionService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ReflectionServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ReflectionService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ReflectionServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ReflectionServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ReflectionServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// ListAllInterfaces lists all the interfaces registered in the interface
      /// registry.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Cosmos.Base.Reflection.V1Beta1.ListAllInterfacesResponse ListAllInterfaces(global::Cosmos.Base.Reflection.V1Beta1.ListAllInterfacesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListAllInterfaces(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// ListAllInterfaces lists all the interfaces registered in the interface
      /// registry.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Cosmos.Base.Reflection.V1Beta1.ListAllInterfacesResponse ListAllInterfaces(global::Cosmos.Base.Reflection.V1Beta1.ListAllInterfacesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListAllInterfaces, null, options, request);
      }
      /// <summary>
      /// ListAllInterfaces lists all the interfaces registered in the interface
      /// registry.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Cosmos.Base.Reflection.V1Beta1.ListAllInterfacesResponse> ListAllInterfacesAsync(global::Cosmos.Base.Reflection.V1Beta1.ListAllInterfacesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListAllInterfacesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// ListAllInterfaces lists all the interfaces registered in the interface
      /// registry.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Cosmos.Base.Reflection.V1Beta1.ListAllInterfacesResponse> ListAllInterfacesAsync(global::Cosmos.Base.Reflection.V1Beta1.ListAllInterfacesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListAllInterfaces, null, options, request);
      }
      /// <summary>
      /// ListImplementations list all the concrete types that implement a given
      /// interface.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Cosmos.Base.Reflection.V1Beta1.ListImplementationsResponse ListImplementations(global::Cosmos.Base.Reflection.V1Beta1.ListImplementationsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListImplementations(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// ListImplementations list all the concrete types that implement a given
      /// interface.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Cosmos.Base.Reflection.V1Beta1.ListImplementationsResponse ListImplementations(global::Cosmos.Base.Reflection.V1Beta1.ListImplementationsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListImplementations, null, options, request);
      }
      /// <summary>
      /// ListImplementations list all the concrete types that implement a given
      /// interface.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Cosmos.Base.Reflection.V1Beta1.ListImplementationsResponse> ListImplementationsAsync(global::Cosmos.Base.Reflection.V1Beta1.ListImplementationsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListImplementationsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// ListImplementations list all the concrete types that implement a given
      /// interface.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Cosmos.Base.Reflection.V1Beta1.ListImplementationsResponse> ListImplementationsAsync(global::Cosmos.Base.Reflection.V1Beta1.ListImplementationsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListImplementations, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override ReflectionServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ReflectionServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(ReflectionServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ListAllInterfaces, serviceImpl.ListAllInterfaces)
          .AddMethod(__Method_ListImplementations, serviceImpl.ListImplementations).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ReflectionServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ListAllInterfaces, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Cosmos.Base.Reflection.V1Beta1.ListAllInterfacesRequest, global::Cosmos.Base.Reflection.V1Beta1.ListAllInterfacesResponse>(serviceImpl.ListAllInterfaces));
      serviceBinder.AddMethod(__Method_ListImplementations, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Cosmos.Base.Reflection.V1Beta1.ListImplementationsRequest, global::Cosmos.Base.Reflection.V1Beta1.ListImplementationsResponse>(serviceImpl.ListImplementations));
    }

  }
}
#endregion
