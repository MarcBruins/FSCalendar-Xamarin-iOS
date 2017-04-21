XBUILD=/Applications/Xcode.app/Contents/Developer/usr/bin/xcodebuild
PROJECT_ROOT=./FSCalendar
PROJECT=FSCalendar.xcodeproj
TARGET=FSCalendar

all: lib$(TARGET).a

lib$(TARGET)-x86_64.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator -arch x86_64 -configuration Release clean build
	-mv ./build/Release-iphonesimulator/lib$(TARGET).a $@
lib$(TARGET)-i386.a:
		$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator -arch i386 -configuration Release clean build
		-mv ./build/Release-iphonesimulator/lib$(TARGET).a $@
lib$(TARGET)-armv7.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv7 -configuration Release clean build
	-mv ./build/Release-iphoneos/lib$(TARGET).a $@
lib$(TARGET)-armv7s.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv7s -configuration Release clean build
	-mv ./build/Release-iphoneos/lib$(TARGET).a $@
lib$(TARGET)-arm64.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch arm64 -configuration Release clean build
	-mv ./build/Release-iphoneos/lib$(TARGET).a $@
lib$(TARGET).a: lib$(TARGET)-x86_64.a lib$(TARGET)-i386.a lib$(TARGET)-armv7.a lib$(TARGET)-armv7s.a lib$(TARGET)-arm64.a
	xcrun -sdk iphoneos lipo -create -output $@ $^
clean:
	-rm -f *.a *.dll
