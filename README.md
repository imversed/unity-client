# Intro

This is a repository with the generated C# code from the proto files.

Tested with Unity 2019.4.35f1, however it may work with a later version too.

Here is a nice tutorial on how to use gRPC in C#: https://grpc.io/docs/languages/csharp/quickstart/

# Prerequisites


Unfortunately, the gRPC stuff for iOS and Android drags in some really large .a and .so files (>800Mb) that cannot be directly pushed to this repository unless we wanted to enable Git LFS. For that reason, you should download the gprc unity package from the official site. [This version](https://packages.grpc.io/archive/2022/02/08181286e326b6e68339d89ad598bbce39587c2f-c808f610-7309-4a71-be21-10aea04f2f35/csharp/grpc_unity_package.2.45.0-dev202202090938.zip) has been verified to work, download the linked zip and unpack it to the Assets folder.

The contents of this repository is good for Unity, however if you'd like to edit code in an IDE, you need to install one of the [Unity supported IDEs](https://docs.unity3d.com/Manual/ScriptingToolsIDEs.html) and generate a C# Solution for them. 

![Screenshot 2022-02-14 at 20 16 48](https://user-images.githubusercontent.com/503321/153913892-863ae333-3c5d-4646-8c11-2bad384d8af4.png)
