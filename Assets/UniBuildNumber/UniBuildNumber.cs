#if UNITY_IOS
using System.Runtime.InteropServices;
#endif
#if UNITY_EDITOR
using UnityEditor;

#endif

namespace nkjzm
{
    public static class UniBuildNumber
    {
        /// <summary>
        /// Get build number in current platform (iOS or Android)
        /// </summary>
        /// <remarks> Return "0" in other platform </remarks>
        /// <returns> Build number in current platform(iOS or Android) </returns>
        public static string GetCurrentBuildNumber()
        {
#if UNITY_IOS
            return GetIOSBuildNumber();
#elif UNITY_ANDROID
            return GetAndroidVersionCode();
#else
            return "0";
#endif
        }

        /// <summary>
        /// Get build number in iOS
        /// </summary>
        /// <remarks> Return "0" in other platform </remarks>
        /// <returns> Build number in iOS </returns>
        public static string GetIOSBuildNumber()
        {
#if UNITY_EDITOR
            return PlayerSettings.iOS.buildNumber;
#elif UNITY_IOS
            return GetBundleVersion();
#else
            return "0";
#endif
        }

        /// <summary>
        /// Get build number in Android
        /// </summary>
        /// <remarks> Return 0 in other platform </remarks>
        /// <returns> Build number in Android </returns>
        public static int GetAndroidVersionCode()
        {
#if UNITY_EDITOR
            return PlayerSettings.Android.bundleVersionCode;
#elif UNITY_ANDROID
            using (var packageInfo = GetPackageInfo())
            {
                return packageInfo.Get<int>("versionCode");
            }
#else
            return 0;
#endif
        }

#if UNITY_IOS
        [DllImport("__Internal")]
        static extern string GetBundleVersion();
#endif

#if UNITY_ANDROID
        static AndroidJavaObject GetPackageInfo()
        {
            using (var unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
            using (var currentActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity"))
            using (var context = currentActivity.Call<AndroidJavaObject>("getApplicationContext"))
            using (var packageManager = context.Call<AndroidJavaObject>("getPackageManager"))
            using (var packageManagerClass = new AndroidJavaClass("android.content.pm.PackageManager"))
            {
                string packageName = context.Call<string>("getPackageName");
                int activities = packageManagerClass.GetStatic<int>("GET_ACTIVITIES");
                return packageManager.Call<AndroidJavaObject>("getPackageInfo", packageName, activities);
            }
        }
#endif
    }
}