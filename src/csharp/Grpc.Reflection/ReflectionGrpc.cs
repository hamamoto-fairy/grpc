// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: grpc/reflection/v1alpha/reflection.proto
// Original file comments:
// Copyright 2016, Google Inc.
// All rights reserved.
//
// Redistribution and use in source and binary forms, with or without
// modification, are permitted provided that the following conditions are
// met:
//
//     * Redistributions of source code must retain the above copyright
// notice, this list of conditions and the following disclaimer.
//     * Redistributions in binary form must reproduce the above
// copyright notice, this list of conditions and the following disclaimer
// in the documentation and/or other materials provided with the
// distribution.
//     * Neither the name of Google Inc. nor the names of its
// contributors may be used to endorse or promote products derived from
// this software without specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
// A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT
// OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
// SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT
// LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
// DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
// THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
// (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
// OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
//
// Service exported by server reflection
//
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace Grpc.Reflection.V1Alpha {
  public static partial class ServerReflection
  {
    static readonly string __ServiceName = "grpc.reflection.v1alpha.ServerReflection";

    static readonly Marshaller<global::Grpc.Reflection.V1Alpha.ServerReflectionRequest> __Marshaller_ServerReflectionRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Grpc.Reflection.V1Alpha.ServerReflectionRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Grpc.Reflection.V1Alpha.ServerReflectionResponse> __Marshaller_ServerReflectionResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Grpc.Reflection.V1Alpha.ServerReflectionResponse.Parser.ParseFrom);

    static readonly Method<global::Grpc.Reflection.V1Alpha.ServerReflectionRequest, global::Grpc.Reflection.V1Alpha.ServerReflectionResponse> __Method_ServerReflectionInfo = new Method<global::Grpc.Reflection.V1Alpha.ServerReflectionRequest, global::Grpc.Reflection.V1Alpha.ServerReflectionResponse>(
        MethodType.DuplexStreaming,
        __ServiceName,
        "ServerReflectionInfo",
        __Marshaller_ServerReflectionRequest,
        __Marshaller_ServerReflectionResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Grpc.Reflection.V1Alpha.ReflectionReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ServerReflection</summary>
    public abstract partial class ServerReflectionBase
    {
      /// <summary>
      ///  The reflection service is structured as a bidirectional stream, ensuring
      ///  all related requests go to a single server.
      /// </summary>
      public virtual global::System.Threading.Tasks.Task ServerReflectionInfo(IAsyncStreamReader<global::Grpc.Reflection.V1Alpha.ServerReflectionRequest> requestStream, IServerStreamWriter<global::Grpc.Reflection.V1Alpha.ServerReflectionResponse> responseStream, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ServerReflection</summary>
    public partial class ServerReflectionClient : ClientBase<ServerReflectionClient>
    {
      /// <summary>Creates a new client for ServerReflection</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ServerReflectionClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ServerReflection that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ServerReflectionClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ServerReflectionClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ServerReflectionClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      ///  The reflection service is structured as a bidirectional stream, ensuring
      ///  all related requests go to a single server.
      /// </summary>
      public virtual AsyncDuplexStreamingCall<global::Grpc.Reflection.V1Alpha.ServerReflectionRequest, global::Grpc.Reflection.V1Alpha.ServerReflectionResponse> ServerReflectionInfo(Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ServerReflectionInfo(new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  The reflection service is structured as a bidirectional stream, ensuring
      ///  all related requests go to a single server.
      /// </summary>
      public virtual AsyncDuplexStreamingCall<global::Grpc.Reflection.V1Alpha.ServerReflectionRequest, global::Grpc.Reflection.V1Alpha.ServerReflectionResponse> ServerReflectionInfo(CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_ServerReflectionInfo, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ServerReflectionClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ServerReflectionClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(ServerReflectionBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ServerReflectionInfo, serviceImpl.ServerReflectionInfo).Build();
    }

  }
}
#endregion
