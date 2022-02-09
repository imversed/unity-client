#!/bin/bash

cd ../

PROTOBUF_PATH=${PWD}/InternalFrameworks/Services/Imversed/Sources/Protobuf

echo "Removing contents of ${PROTOBUF_PATH}"
rm -r ${PROTOBUF_PATH}

echo "Creating grpc and swift protobuf directories"
mkdir -p ${PROTOBUF_PATH}/grpc
mkdir -p ${PROTOBUF_PATH}/swift

echo "Compiling..."

proto_dirs=$(find ./proto -path -prune -o -name '*.proto' -print0 | xargs -0 -n1 dirname | sort | uniq)
for dir in $proto_dirs; do
  protoc \
    --proto_path=proto \
    --plugin=./Pods/gRPC-Swift-Plugins/bin/protoc-gen-swift \
    --swift_opt=FileNaming=PathToUnderscores \
    --swift_out=${PROTOBUF_PATH}/swift \
    --plugin=./Pods/gRPC-Swift-Plugins/bin/protoc-gen-grpc-swift \
    --grpc-swift_opt=FileNaming=PathToUnderscores \
    --grpc-swift_out=${PROTOBUF_PATH}/grpc \
    $(find "${dir}" -maxdepth 1 -name '*.proto')
done

echo "Done"