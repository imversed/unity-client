# Intro

This is a repository with the generated C# code from the proto files.

Tested with Unity 2019.4.35f1, however it may work with a later version too.

Unfortunately, the gRPC stuff for iOS and Android drags in some really large .a and .so files (>800Mb) that cannot be directly pushed to this repository unless we wanted to include Git LFS. In the sake of keeping it minimal for now, I uploaded the whole Plugins folder over here: https://drive.google.com/file/d/12O_ABiGgs4V3_fHEsKl-LNG0eYVyZh4R/view?usp=sharing. Make sure to unzip it to Client/Assets/Plugins first.

Currently, there is no logic added. All this project can do at the moment is to illustrate that the generated C# Protobuf code compiles. Here is a nice tutorial on how to use gRPC in C#: https://grpc.io/docs/languages/csharp/quickstart/
