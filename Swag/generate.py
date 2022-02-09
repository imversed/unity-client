
import os

template = "./protobuf-3.19.3/src/protoc -I=./proto-2 -I=./protobuf-3.19.3/src --csharp_out=%s %s"

def ensure_path(path):
	folders = path.split("/")

	for i in xrange(1, len(folders) + 1):
		p = "/".join(folders[0:i])
		if not os.path.exists(p):
			os.mkdir(p)

for root, dirs, files in os.walk("proto-2"):
	for f in files:
		if os.path.splitext(f)[1] == ".proto":
			target_path = "out/" + root
			ensure_path(target_path)
			com = template % (target_path, os.path.join(root, f))
			print com