# UniBuildNumber

Build number getter at runtime on iOS and Android.

# UPM Package

After Unity 2019.3.4f1, Unity 2020.1a21, that support path query parameter of git package. 

1. Open your Unity project.
2. Open `Window -> Package Manager`.
3. Click "+" > "Add package from git URL...".
4. Enter `https://github.com/nkjzm/UniBuildNumber.git?path=Assets/UniBuildNumber` and click "Add".

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
