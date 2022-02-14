# Intro

This is a repository with the generated C# code from the proto files.

Tested with Unity 2019.4.35f1, however it may work with a later version too.

# Prerequisites

Unfortunately, the gRPC stuff for iOS and Android drags in some really large .a and .so files (>800Mb) that cannot be directly pushed to this repository unless we wanted to include Git LFS. For that reason, you should download the gprc unity package from the official site. [This version](https://packages.grpc.io/archive/2022/02/08181286e326b6e68339d89ad598bbce39587c2f-c808f610-7309-4a71-be21-10aea04f2f35/csharp/grpc_unity_package.2.45.0-dev202202090938.zip) has been verified work, download the linked zip and unpack it to the Assets folder.

Currently, there is no logic added. All this project can do at the moment is to illustrate that the generated C# Protobuf code compiles. Here is a nice tutorial on how to use gRPC in C#: https://grpc.io/docs/languages/csharp/quickstart/

# Generating C#

We only used the simplest approach here: all the proto files are stored in the Swag folder. Also, there you find a python script that generates a shell script that calls the protoc compiler for all files. Output is placed under the out/ subbfolder, this needs to be manually copied over to the Unity project. 
