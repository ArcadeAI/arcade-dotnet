# Changelog

## 0.2.0 (2025-11-15)

Full Changelog: [v0.1.0...v0.2.0](https://github.com/ArcadeAI/arcade-dotnet/compare/v0.1.0...v0.2.0)

### ⚠ BREAKING CHANGES

* **client:** improve names of some types
* **client:** flatten service namespaces
* **client:** interpret null as omitted in some properties
* **client:** make models immutable

### Features

* **api:** api update ([97bf4ae](https://github.com/ArcadeAI/arcade-dotnet/commit/97bf4ae13656802a9b0524f388164b293d777fbc))
* **client:** add `HttpResponse.ReadAsStream` method ([04be863](https://github.com/ArcadeAI/arcade-dotnet/commit/04be863a4959115675d0fc28b60d74a4626e40c6))
* **client:** add cancellation token support ([810487b](https://github.com/ArcadeAI/arcade-dotnet/commit/810487b7c6c284468df0c6153089799d06e1d11e))
* **client:** add response validation option ([e650190](https://github.com/ArcadeAI/arcade-dotnet/commit/e65019076d4661de8c22e927e833845f85131f03))
* **client:** add retries support ([ce12fd4](https://github.com/ArcadeAI/arcade-dotnet/commit/ce12fd4e19e9079aedc5dc550ec731e0c5f496fd))
* **client:** add support for option modification ([5e140ed](https://github.com/ArcadeAI/arcade-dotnet/commit/5e140ed731f05741ae5137269196121e11413823))
* **client:** make models immutable ([8e0a84d](https://github.com/ArcadeAI/arcade-dotnet/commit/8e0a84db0afebd88e1b06d5afed561a7105e6ba1))
* **client:** send `User-Agent` header ([c0e3c14](https://github.com/ArcadeAI/arcade-dotnet/commit/c0e3c14a08292e723553357b1453a5d54ae6847e))
* **client:** send `X-Stainless-Arch` header ([e0698da](https://github.com/ArcadeAI/arcade-dotnet/commit/e0698daf4efe355053be9064651f5a766b8e8618))
* **client:** send `X-Stainless-Lang` and `X-Stainless-OS` headers ([4b74b43](https://github.com/ArcadeAI/arcade-dotnet/commit/4b74b439b0cc802039a3a0a6c60513631465efa3))
* **client:** send `X-Stainless-Package-Version` headers ([e645cb6](https://github.com/ArcadeAI/arcade-dotnet/commit/e645cb6bd2ebf723984771fa4c63e9099ddca9a2))
* **client:** send `X-Stainless-Runtime` and `X-Stainless-Runtime-Version` ([5e6b3bd](https://github.com/ArcadeAI/arcade-dotnet/commit/5e6b3bd4c007bde0989adce4701bc06f6446aca9))
* **client:** send `X-Stainless-Timeout` header ([b59d0db](https://github.com/ArcadeAI/arcade-dotnet/commit/b59d0db698d881af35b2de470b64b8f4de3dee55))
* **client:** support request timeout ([96b705e](https://github.com/ArcadeAI/arcade-dotnet/commit/96b705eb58dc2e617fd0cfd3b742e44d4ee4a448))


### Bug Fixes

* **client:** interpret null as omitted in some properties ([a58c5a8](https://github.com/ArcadeAI/arcade-dotnet/commit/a58c5a8333df53103cde71cbcc19b33a8436d8f2))


### Performance Improvements

* **client:** optimize header creation ([77ed083](https://github.com/ArcadeAI/arcade-dotnet/commit/77ed08308e0061269750185035e68c1a5accc50f))


### Chores

* **client:** deprecate some symbols ([bdcd9d0](https://github.com/ArcadeAI/arcade-dotnet/commit/bdcd9d0a55f91a9a73c653d8c8ac35cef0e81cac))
* **client:** simplify field validations ([e650190](https://github.com/ArcadeAI/arcade-dotnet/commit/e65019076d4661de8c22e927e833845f85131f03))
* **internal:** add prism log file to gitignore ([f4ac04b](https://github.com/ArcadeAI/arcade-dotnet/commit/f4ac04bc530260f0bd0817d616abf3da4e85b317))
* **internal:** codegen related update ([0f18e7f](https://github.com/ArcadeAI/arcade-dotnet/commit/0f18e7fdd585319545336a161ff2de93f84f4be0))
* **internal:** codegen related update ([349eebd](https://github.com/ArcadeAI/arcade-dotnet/commit/349eebdbac15e38c9cc1670e4ae6bcf071ba54c0))
* **internal:** delete empty test files ([39cfcbe](https://github.com/ArcadeAI/arcade-dotnet/commit/39cfcbe19af6cb08ef818cfb2737aab09a34c9bd))
* **internal:** extract `ClientOptions` struct ([01495b2](https://github.com/ArcadeAI/arcade-dotnet/commit/01495b2ce312bbdb634946f3bc046bacc77828f0))
* **internal:** full qualify some references ([46bb02c](https://github.com/ArcadeAI/arcade-dotnet/commit/46bb02caf8591105fcbcfcb00095ebdc506203ee))
* **internal:** improve devcontainer ([dc3815e](https://github.com/ArcadeAI/arcade-dotnet/commit/dc3815e9f426b54479743861934e6a0a1bb10f49))
* **internal:** minor improvements to csproj and gitignore ([64e5236](https://github.com/ArcadeAI/arcade-dotnet/commit/64e52369527198000f34ea2ba1b4d70915282b7c))
* **internal:** reduce import qualification ([7ca8392](https://github.com/ArcadeAI/arcade-dotnet/commit/7ca8392108a2c4ca51456ff06d9352895dc3d023))
* **internal:** update release please config ([11a9d80](https://github.com/ArcadeAI/arcade-dotnet/commit/11a9d80ae219cfeb5406a6684b1b2f6d9369268a))


### Documentation

* **client:** document `WithOptions` ([b3db621](https://github.com/ArcadeAI/arcade-dotnet/commit/b3db6211ade5a2cde44506628c6d90e4a9607fd7))
* **client:** document max retries ([aecc000](https://github.com/ArcadeAI/arcade-dotnet/commit/aecc000dcb8d5efd6ae9c269f046e8055520f6ae))
* **client:** document response validation ([4cac330](https://github.com/ArcadeAI/arcade-dotnet/commit/4cac3308245a9006a8b11af36ce9e786b1a8d498))
* **client:** document timeout option ([5d23f4f](https://github.com/ArcadeAI/arcade-dotnet/commit/5d23f4f618f1ca8ff95d1a5633b519b5ba1ac34b))
* **client:** improve snippet formatting ([868be10](https://github.com/ArcadeAI/arcade-dotnet/commit/868be107c479e66a67da081f7f701bf71e6cb826))
* **client:** separate comment content into paragraphs ([84fc132](https://github.com/ArcadeAI/arcade-dotnet/commit/84fc132681e14125d4e611b62c86a7443b9621aa))


### Refactors

* **client:** flatten service namespaces ([2de54d7](https://github.com/ArcadeAI/arcade-dotnet/commit/2de54d791d1a78fc159b5d88e34856fea8449166))
* **client:** improve names of some types ([ae85584](https://github.com/ArcadeAI/arcade-dotnet/commit/ae85584db77f44bec76c9363f1364e4f8f6d656d))
* **client:** move some defaults out of `ClientOptions` ([3274d75](https://github.com/ArcadeAI/arcade-dotnet/commit/3274d7579686acaeb9ebd6404b3de9c048ed25e8))
* **client:** pass around `ClientOptions` instead of client ([b2442cf](https://github.com/ArcadeAI/arcade-dotnet/commit/b2442cfa369c54a178f89147bcb1cbf2e7bc124f))

## 0.1.0 (2025-10-29)

Full Changelog: [v0.0.1...v0.1.0](https://github.com/ArcadeAI/arcade-dotnet/compare/v0.0.1...v0.1.0)

### Features

* **api:** api update ([e731ecf](https://github.com/ArcadeAI/arcade-dotnet/commit/e731ecf0945af45989f03aa3cb73a557562974b8))


### Chores

* configure new SDK language ([a3f7f88](https://github.com/ArcadeAI/arcade-dotnet/commit/a3f7f8840bf0a4f27a93ca34ffb6d41d012f1b22))
* update SDK settings ([e48eeed](https://github.com/ArcadeAI/arcade-dotnet/commit/e48eeede2c39ba869c37e5bb47ade19fba268a62))
