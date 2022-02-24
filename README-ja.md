[README(English)](https://github.com/nkjzm/UniBuildNumber/blob/master/README.md)

# UniBuildNumber

ランタイム上でビルド番号を取得するiOS/Android用プラグイン

# UPM Package

Unity 2019.3.4f1, 2020.1a21以降では下記の形式での導入がサポートされています。

1. Unityプロジェクトを開く
2. `Window -> Package Manager`を開く
3. 左上の"+"から"Add package from git URL..."をクリック
4. `https://github.com/nkjzm/UniBuildNumber.git?path=Assets/UniBuildNumber`を入力して"Add"をクリック

# Usage

```.cs
// Get build number in current platform (iOS or Android)
string buildNumber = nkjzm.UniBuildNumber.GetCurrentBuildNumber();

// Get build number in iOS
string buildNumber_ios = nkjzm.UniBuildNumber.GetIOSBuildNumber();

// Get build number in Android
int buildNumber_android = nkjzm.UniBuildNumber.GetAndroidVersionCode();
```

# LICENSE

[MIT LICENSE](https://github.com/nkjzm/UniBuildNumber/blob/master/LICENSE)

# Author

https://twitter.com/nkjzm

# Reference

http://nobollel-tech.hatenablog.com/entry/unity-app-version
