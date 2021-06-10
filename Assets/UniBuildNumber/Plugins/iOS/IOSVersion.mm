extern "C" {
    char *GetBundleVersion() {
        NSString *bundleVersion = [[[NSBundle mainBundle] infoDictionary] objectForKey:@"CFBundleVersion"];
        const char *s = [bundleVersion UTF8String];
        return strcpy((char *)malloc(strlen(s) + 1), s);
    }
}