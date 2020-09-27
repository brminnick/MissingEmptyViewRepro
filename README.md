# MissingEmptyViewRepro
A reproduction sample for Xamarin.Forms v5.0-pre1

On iOS, using Xamarin.Forms v5.0.0.1487-pre1, the `CollectionView.EmptyView` no longer appears.

## Reproduction

1. Download/Clone this repo
2. In Visual Sudio, open `MissingEmptyViewRepro.sln`
3. In Visual Studio, set the Startup Project to `MissingEmptyViewRepro.iOS`
4. In Visual Studio, buld/deploy `MissingEmptyViewRepro.iOS` to an iOS Simulator/Device
5. On the **iOS** device, confirm the `EmptyView` image (Microsoft Logo) **does not** appear
6. In Visual Studio, set the Startup Project to `MissingEmptyViewRepro.Android`
7. In Visual Studio, buld/deploy `MissingEmptyViewRepro.iOS` to an Android Simulator/Device
8. On the **Android** device, confirm `EmptyView` image (Microsoft Logo) **does** appear

| iOS EmptyView, Xamarin.Forms v5.0.0.1487-pre1 | Android EmptyView, Xamarin.Forms v5.0.0.1487-pre1 | 
| --------------------------------------------- | ------------------------------------------------- |
| ![](https://user-images.githubusercontent.com/13558917/94372323-575f3200-00b1-11eb-9f9e-d142941e0932.png) | ![](https://user-images.githubusercontent.com/13558917/94372474-b7a2a380-00b2-11eb-8a3f-06058a8f78a3.png) | 

## Workaround

Downgrade to Xamarin.Forms v4.8.0.1451

| iOS EmptyView, Xamarin.Forms v4.8.0.1451 | Android EmptyView, Xamarin.Forms v4.8.0.1451 | 
| --------------------------------------------- | ------------------------------------------------- |
| ![](https://user-images.githubusercontent.com/13558917/94372368-ad33da00-00b1-11eb-83de-d70d2b7c5e82.png) | ![](https://user-images.githubusercontent.com/13558917/94372474-b7a2a380-00b2-11eb-8a3f-06058a8f78a3.png) | 

## Environment

=== Visual Studio Enterprise 2019 for Mac ===

Version 8.7.8 (build 4)
Installation UUID: 56831f8a-a252-4cee-9eeb-8327c0830784
	GTK+ 2.24.23 (Raleigh theme)
	Xamarin.Mac 6.18.0.23 (d16-6 / 088c73638)

	Package version: 612000093

=== Mono Framework MDK ===

Runtime:
	Mono 6.12.0.93 (2020-02/620cf538206) (64-bit)
	Package version: 612000093

=== Roslyn (Language Service) ===

3.7.0-6.20427.1+18ede13943b0bfae1b44ef078b2f3923159bcd32

=== NuGet ===

Version: 5.7.0.6702

=== .NET Core SDK ===

SDK: /usr/local/share/dotnet/sdk/3.1.402/Sdks
SDK Versions:
	3.1.402
	3.1.301
	3.0.101
	2.1.809
	2.1.803
MSBuild SDKs: /Library/Frameworks/Mono.framework/Versions/6.12.0/lib/mono/msbuild/Current/bin/Sdks

=== .NET Core Runtime ===

Runtime: /usr/local/share/dotnet/dotnet
Runtime Versions:
	3.1.8
	3.1.5
	3.1.4
	3.1.2
	3.1.1
	3.1.0
	3.0.3
	3.0.1
	2.1.22
	2.1.21
	2.1.20
	2.1.19
	2.1.18
	2.1.17
	2.1.16
	2.1.15
	2.1.14

=== Xamarin.Profiler ===

Version: 1.6.15.68
Location: /Applications/Xamarin Profiler.app/Contents/MacOS/Xamarin Profiler

=== Updater ===

Version: 11

=== Apple Developer Tools ===

Xcode 12.0 (17219)
Build 12A7300

=== Xamarin.Mac ===

Version: 6.20.2.2 (Visual Studio Enterprise)
Hash: 817b6f72a
Branch: d16-7
Build date: 2020-07-18 18:44:59-0400

=== Xamarin.iOS ===

Version: 14.0.0.0 (Visual Studio Enterprise)
Hash: 7ec3751a1
Branch: xcode12
Build date: 2020-09-16 11:33:15-0400

=== Xamarin.Android ===

Version: 11.0.2.0 (Visual Studio Enterprise)
Commit: xamarin-android/d16-7/025fde9
Android SDK: /Users/bramin/Library/Developer/Xamarin/android-sdk-macosx
	Supported Android versions:
		7.0 (API level 24)
		8.0 (API level 26)
		8.1 (API level 27)

SDK Tools Version: 26.1.1
SDK Platform Tools Version: 30.0.4
SDK Build Tools Version: 30.0.2

Build Information: 
Mono: 83105ba
Java.Interop: xamarin/java.interop/d16-7@1f3388a
ProGuard: Guardsquare/proguard/proguard6.2.2@ebe9000
SQLite: xamarin/sqlite/3.32.1@1a3276b
Xamarin.Android Tools: xamarin/xamarin-android-tools/d16-7@017078f

=== Microsoft OpenJDK for Mobile ===

Java SDK: /Users/bramin/Library/Developer/Xamarin/jdk/microsoft_dist_openjdk_1.8.0.25
1.8.0-25
Android Designer EPL code available here:
https://github.com/xamarin/AndroidDesigner.EPL

=== Android SDK Manager ===

Version: 16.7.0.13
Hash: 8380518
Branch: remotes/origin/d16-7~2
Build date: 2020-09-16 05:12:24 UTC

=== Android Device Manager ===

Version: 16.7.0.24
Hash: bb090a3
Branch: remotes/origin/d16-7
Build date: 2020-09-16 05:12:46 UTC

=== Xamarin Designer ===

Version: 16.7.0.495
Hash: 03d50a221
Branch: remotes/origin/d16-7-vsmac
Build date: 2020-08-28 13:12:52 UTC

=== Build Information ===

Release ID: 807080004
Git revision: 9ea7bef96d65cdc3f4288014a799026ccb1993bc
Build date: 2020-09-16 17:22:54-04
Build branch: release-8.7
Xamarin extensions: 9ea7bef96d65cdc3f4288014a799026ccb1993bc

=== Operating System ===

Mac OS X 10.16.0
Darwin 20.1.0 Darwin Kernel Version 20.1.0
    Thu Sep 17 22:14:18 PDT 2020
    root:xnu-7195.40.84.171.5~4/RELEASE_X86_64 x86_64

