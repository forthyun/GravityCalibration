################################################################################
# Automatically-generated file. Do not edit!
################################################################################

# Add inputs and outputs from these tool invocations to the build variables 
CPP_SRCS += \
../src/AppResourceId.cpp \
../src/GravityCalibrationApp.cpp \
../src/GravityCalibrationEntry.cpp \
../src/GravityCalibrationFormFactory.cpp \
../src/GravityCalibrationFrame.cpp \
../src/GravityCalibrationMainForm.cpp \
../src/GravityCalibrationPanelFactory.cpp \
../src/qr_solve.cpp \
../src/r8lib.cpp \
../src/test_ls.cpp 

OBJS += \
./src/AppResourceId.o \
./src/GravityCalibrationApp.o \
./src/GravityCalibrationEntry.o \
./src/GravityCalibrationFormFactory.o \
./src/GravityCalibrationFrame.o \
./src/GravityCalibrationMainForm.o \
./src/GravityCalibrationPanelFactory.o \
./src/qr_solve.o \
./src/r8lib.o \
./src/test_ls.o 

CPP_DEPS += \
./src/AppResourceId.d \
./src/GravityCalibrationApp.d \
./src/GravityCalibrationEntry.d \
./src/GravityCalibrationFormFactory.d \
./src/GravityCalibrationFrame.d \
./src/GravityCalibrationMainForm.d \
./src/GravityCalibrationPanelFactory.d \
./src/qr_solve.d \
./src/r8lib.d \
./src/test_ls.d 


# Each subdirectory must supply rules for building sources it contributes
src/%.o: ../src/%.cpp
	@echo 'Building file: $<'
	@echo 'Invoking: C++ Compiler'
	clang++.exe -I"pch" -D_DEBUG -I"C:\Users\DC_hcKim\tizen_workspace\GravityCalibration\inc" -O0 -g3 -Wall -c -fmessage-length=0 -target arm-tizen-linux-gnueabi -gcc-toolchain "C:/tizen-sdk/tools/smart-build-interface/../arm-linux-gnueabi-gcc-4.5/" -ccc-gcc-name arm-linux-gnueabi-g++ -march=armv7-a -mfloat-abi=softfp -mfpu=vfpv3-d16 -mtune=cortex-a8 -Wno-gnu -fPIE --sysroot="C:/tizen-sdk/platforms/tizen2.2/rootstraps/tizen-device-2.2.native" -I"C:/tizen-sdk/platforms/tizen2.2/rootstraps/tizen-device-2.2.native/usr/include/libxml2" -I"C:\tizen-sdk\library" -I"C:/tizen-sdk/platforms/tizen2.2/rootstraps/tizen-device-2.2.native/usr/include" -I"C:/tizen-sdk/platforms/tizen2.2/rootstraps/tizen-device-2.2.native/usr/include/osp" -D_APP_LOG -MMD -MP -MF"$(@:%.o=%.d)" -MT"$(@:%.o=%.d)" -o "$@" "$<"
	@echo 'Finished building: $<'
	@echo ' '


