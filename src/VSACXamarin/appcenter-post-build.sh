appcenter login -u $VSAC_usr -p $VSAC_pwd

appcenter test run uitest --app "IntroToVSAC/XamarinApp-iOS" --devices 54c01546 --app-path "$APPCENTER_SOURCE_DIRECTORY/src/VSACXamarin/iOS/bin/iPhone/$APPCENTER_BRANCH/VSACXamarin.iOS.ipa"  --test-series "master" --locale "en_US" --build-dir "$APPCENTER_SOURCE_DIRECTORY/src/VSACXamarin/VSACXamarin.UITest.Ios/bin/Release"

