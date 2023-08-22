# Minimal Repro of [Mirror's Issue #3588](https://github.com/MirrorNetworking/Mirror/issues/3588)

Repro steps:

1. Build a windows standalone build.
2. Start the server in Unity Editor.
3. Connect to the server with the standalone build.
4. In Unity Editor, the client's player's child's position.y is not 1.5.
