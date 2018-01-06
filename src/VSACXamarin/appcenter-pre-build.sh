/usr/libexec/plistbuddy -c "Set :CFBundleDisplayName VSACXamarin.$APPCENTER_BRANCH" "iOS/Info.plist"

sed -i -e "s/[VSAC_API_KEY]/$VSAC_Key/g" Constants.cs