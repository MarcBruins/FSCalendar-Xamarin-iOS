XBUILD=/Applications/Xcode.app/Contents/Developer/usr/bin/xcodebuild 
PROJECT_ROOT=./FSCalendar
PROJECT=$(PROJECT_ROOT)/FSCalendar.xcodeproj 
TARGET=FSCalendar

all: lib$(TARGET).a 

lib$(TARGET)-i386.a: 
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator -configuration Release clean build 
	-mv $(PROJECT_ROOT)/build/Release-iphonesimulator/lib$(TARGET).a $@ 
lib$(TARGET)-armv7.a: 
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv7 -configuration Release clean build 
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@ 
lib$(TARGET)-arm64.a: 
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch arm64 -configuration Release clean build 
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@ 
lib$(TARGET).a: lib$(TARGET)-i386.a lib$(TARGET)-armv7.a lib$(TARGET)-arm64.a 
	xcrun -sdk iphoneos lipo -create -output $@ $^ 
clean: 
	-rm -f *.a *.dll 
