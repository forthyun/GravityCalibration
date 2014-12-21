S/W Version Information
Model: Ref.Device-PQ
Tizen-Version: 2.2.1
Build-Number: Tizen_Ref.Device-PQ_20131118.1124
Build-Date: 2013.11.18 11:24:59

Crash Information
Process Name: GravityCalibration
PID: 30526
Date: 2014-12-20 08:21:23(GMT+0900)
Executable File Path: /opt/apps/53qxkXM9Op/bin/GravityCalibration
This process is multi-thread process
pid=30526 tid=30526
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x18

Register Information
r0   = 0x00000000, r1   = 0x00000006
r2   = 0x00000000, r3   = 0x2a17f950
r4   = 0x2a007800, r5   = 0x2a1439a8
r6   = 0x2a2e6ed0, r7   = 0x2a29fae0
r8   = 0xbeffca80, r9   = 0x2a0c1c30
r10  = 0xb6644940, fp   = 0xbeffc928
ip   = 0xb61cb000, sp   = 0xbeffc890
lr   = 0xb6110e04, pc   = 0x2a006cbc
cpsr = 0x20000010

Memory Information
MemTotal:   797320 KB
MemFree:    100084 KB
Buffers:    109352 KB
Cached:     359940 KB
VmPeak:      93496 KB
VmSize:      86292 KB
VmLck:           0 KB
VmHWM:       36780 KB
VmRSS:       36780 KB
VmData:      15112 KB
VmStk:         136 KB
VmExe:         320 KB
VmLib:       62096 KB
VmPTE:          78 KB
VmSwap:          0 KB

Maps Information
2a000000 2a050000 r-xp /opt/usr/apps/53qxkXM9Op/bin/GravityCalibration.exe
2a050000 2a051000 rwxp /opt/usr/apps/53qxkXM9Op/bin/GravityCalibration.exe
2a051000 2a6a7000 rwxp [heap]
b1f5d000 b1f62000 r-xp /usr/lib/libhaptic-module.so
b1f69000 b1f6a000 rwxp /usr/lib/libhaptic-module.so
b1f6a000 b22ee000 rwxs /drm
b22ee000 b2672000 rwxs /drm
b2672000 b269d000 rwxs /dev/shm/elm_indicator_portrait-0-1418793371.3195.909768277
b269d000 b26e8000 rwxs /dev/shm/elm_indicator_landscape-0-1418793371.3195.1492470831
b273b000 b2786000 rwxs /dev/shm/elm_indicator_landscape-0-1418793371.3195.1492470831
b27b1000 b27dc000 rwxs /dev/shm/elm_indicator_portrait-0-1418793371.3195.909768277
b27dc000 b2801000 r-xp /usr/share/fonts/TizenSansMedium.ttf
b2801000 b2826000 r-xp /usr/share/fonts/TizenSansRegular.ttf
b2826000 b282e000 r-xs /var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-3
b282e000 b282f000 r-xp /usr/lib/libdrm_slp.so.1.0.0
b2836000 b2837000 rwxp /usr/lib/libdrm_slp.so.1.0.0
b283e000 b2841000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
b2848000 b2849000 rwxp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
b2849000 b2852000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
b285a000 b285b000 rwxp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
b285b000 b2862000 r-xs /usr/lib/gconv/gconv-modules.cache
b2862000 b2886000 r-xp /usr/share/locale/ko/LC_MESSAGES/libc.mo
b2886000 b2890000 r-xp /lib/libnss_files-2.13.so
b2897000 b2898000 r-xp /lib/libnss_files-2.13.so
b2898000 b2899000 rwxp /lib/libnss_files-2.13.so
b2899000 b28a2000 r-xp /lib/libnss_nis-2.13.so
b28a9000 b28aa000 r-xp /lib/libnss_nis-2.13.so
b28aa000 b28ab000 rwxp /lib/libnss_nis-2.13.so
b28ab000 b28bc000 r-xp /lib/libnsl-2.13.so
b28c3000 b28c4000 r-xp /lib/libnsl-2.13.so
b28c4000 b28c5000 rwxp /lib/libnsl-2.13.so
b28c7000 b28cd000 r-xp /lib/libnss_compat-2.13.so
b28d4000 b28d5000 r-xp /lib/libnss_compat-2.13.so
b28d5000 b28d6000 rwxp /lib/libnss_compat-2.13.so
b28d6000 b29a1000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b29a9000 b29b7000 rwxp /usr/lib/libscim-1.0.so.8.2.3
b29b7000 b29c1000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b29c8000 b29c9000 rwxp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b29c9000 b29ed000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b29f4000 b29f6000 rwxp /usr/lib/ecore/immodules/libisf-imf-module.so
b29f6000 b2bf6000 r-xp /usr/lib/locale/locale-archive
b2bfe000 b2c38000 r-xp /usr/lib/libpulsecommon-0.9.23.so
b2c40000 b2c41000 rwxp /usr/lib/libpulsecommon-0.9.23.so
b2c41000 b2c45000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b2c4c000 b2c4d000 rwxp /usr/lib/libmmfsoundcommon.so.0.0.0
b2c4e000 b2c51000 r-xp /lib/libattr.so.1.1.0
b2c58000 b2c59000 rwxp /lib/libattr.so.1.1.0
b2c59000 b2c5c000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b2c63000 b2c64000 rwxp /usr/lib/libsyspopup_caller.so.0.1.0
b2c65000 b2c96000 r-xp /usr/lib/libpulse.so.0.12.4
b2c9d000 b2c9e000 rwxp /usr/lib/libpulse.so.0.12.4
b2c9e000 b2d01000 r-xp /usr/lib/libasound.so.2.0.0
b2d08000 b2d0b000 rwxp /usr/lib/libasound.so.2.0.0
b2d0b000 b2d0e000 r-xp /usr/lib/libpulse-simple.so.0.0.3
b2d15000 b2d16000 rwxp /usr/lib/libpulse-simple.so.0.0.3
b2d16000 b2d1a000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
b2d22000 b2d23000 rwxp /usr/lib/libascenario-0.2.so.0.0.0
b2d23000 b2d40000 r-xp /usr/lib/libavsysaudio.so.0.0.1
b2d47000 b2d48000 rwxp /usr/lib/libavsysaudio.so.0.0.1
b2d49000 b2d57000 r-xp /usr/lib/libmmfsound.so.0.1.0
b2d5e000 b2d5f000 rwxp /usr/lib/libmmfsound.so.0.1.0
b2d5f000 b2dfb000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
b2e03000 b2e06000 rwxp /usr/lib/libgstreamer-0.10.so.0.30.0
b2e07000 b2e48000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
b2e50000 b2e51000 rwxp /usr/lib/libgstbase-0.10.so.0.30.0
b2e51000 b2e5a000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
b2e61000 b2e62000 rwxp /usr/lib/libgstapp-0.10.so.0.25.0
b2e62000 b2e6f000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
b2e77000 b2e78000 rwxp /usr/lib/libgstinterfaces-0.10.so.0.25.0
b2e79000 b2e7f000 r-xp /usr/lib/libUMP.so
b2e86000 b2e87000 rwxp /usr/lib/libUMP.so
b2e87000 b2eb3000 r-xp /usr/lib/libidn.so.11.5.44
b2ebb000 b2ebc000 rwxp /usr/lib/libidn.so.11.5.44
b2ebc000 b2ec6000 r-xp /usr/lib/libcares.so.2.0.0
b2ecd000 b2ece000 rwxp /usr/lib/libcares.so.2.0.0
b2ece000 b2ed0000 r-xp /usr/lib/libXau.so.6.0.0
b2ed7000 b2ed8000 rwxp /usr/lib/libXau.so.6.0.0
b2ed9000 b2ee9000 r-xp /lib/libresolv-2.13.so
b2ee9000 b2eea000 r-xp /lib/libresolv-2.13.so
b2eea000 b2eeb000 rwxp /lib/libresolv-2.13.so
b2eed000 b2ef2000 r-xp /usr/lib/libffi.so.5.0.10
b2ef9000 b2efa000 rwxp /usr/lib/libffi.so.5.0.10
b2efa000 b2f04000 r-xp /usr/lib/libethumb.so.1.7.99
b2f0b000 b2f0c000 rwxp /usr/lib/libethumb.so.1.7.99
b2f0c000 b2f50000 r-xp /usr/lib/libsndfile.so.1.0.25
b2f58000 b2f5a000 rwxp /usr/lib/libsndfile.so.1.0.25
b2f5f000 b2f61000 r-xp /usr/lib/libctxdata.so.0.0.0
b2f68000 b2f69000 rwxp /usr/lib/libctxdata.so.0.0.0
b2f69000 b2f77000 r-xp /usr/lib/libremix.so.0.0.0
b2f7e000 b2f7f000 rwxp /usr/lib/libremix.so.0.0.0
b2f7f000 b2f86000 r-xp /usr/lib/libembryo.so.1.7.99
b2f8e000 b2f8f000 rwxp /usr/lib/libembryo.so.1.7.99
b2f8f000 b2fb3000 r-xp /usr/lib/libjpeg.so.8.0.2
b2fba000 b2fbb000 rwxp /usr/lib/libjpeg.so.8.0.2
b2fcb000 b2fcd000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b2fd4000 b2fd5000 rwxp /usr/lib/libgmodule-2.0.so.0.3200.3
b2fd6000 b2fd9000 r-xp /usr/lib/libmm_ta.so.0.0.0
b2fe0000 b2fe1000 rwxp /usr/lib/libmm_ta.so.0.0.0
b2fe1000 b2ff0000 r-xp /usr/lib/libICE.so.6.3.0
b2ff7000 b2ff8000 rwxp /usr/lib/libICE.so.6.3.0
b2ffa000 b2fff000 r-xp /usr/lib/libSM.so.6.0.1
b3006000 b3007000 rwxp /usr/lib/libSM.so.6.0.1
b3007000 b300f000 r-xp /lib/libcrypt-2.13.so
b3016000 b3017000 r-xp /lib/libcrypt-2.13.so
b3017000 b3018000 rwxp /lib/libcrypt-2.13.so
b303f000 b3042000 r-xp /lib/libcap.so.2.21
b3049000 b304a000 rwxp /lib/libcap.so.2.21
b304b000 b304d000 r-xp /usr/lib/libiri.so
b3054000 b3055000 rwxp /usr/lib/libiri.so
b3055000 b3066000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b306e000 b306f000 rwxp /usr/lib/libsecurity-server-commons.so.1.0.0
b306f000 b3071000 r-xp /usr/lib/libsystemd-daemon.so.0.0.1
b3078000 b3079000 rwxp /usr/lib/libsystemd-daemon.so.0.0.1
b3079000 b307a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b3081000 b3082000 rwxp /usr/lib/libgthread-2.0.so.0.3200.3
b3083000 b3085000 r-xp /usr/lib/libdeviced.so.0.1.0
b308c000 b308d000 rwxp /usr/lib/libdeviced.so.0.1.0
b308d000 b30a3000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b30aa000 b30ab000 rwxp /usr/lib/libpkgmgr_parser.so.0.1.0
b30ab000 b30ad000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b30b4000 b30b5000 rwxp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b30b5000 b30b8000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b30bf000 b30c0000 rwxp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b30c1000 b30d2000 r-xp /usr/lib/libcom-core.so.0.0.1
b30d9000 b30da000 rwxp /usr/lib/libcom-core.so.0.0.1
b30da000 b30dd000 r-xp /usr/lib/libdevice-node.so.0.1
b30e4000 b30e5000 rwxp /usr/lib/libdevice-node.so.0.1
b30e5000 b30e9000 r-xp /usr/lib/libheynoti.so.0.0.2
b30f0000 b30f1000 rwxp /usr/lib/libheynoti.so.0.0.2
b30f1000 b30f3000 r-xp /usr/lib/libapp-checker.so.0.1.0
b30fa000 b30fb000 rwxp /usr/lib/libapp-checker.so.0.1.0
b30fc000 b30ff000 r-xp /usr/lib/libsmack.so.1.0.0
b3106000 b3107000 rwxp /usr/lib/libsmack.so.1.0.0
b3107000 b3153000 r-xp /usr/lib/libssl.so.1.0.0
b315a000 b315f000 rwxp /usr/lib/libssl.so.1.0.0
b315f000 b3160000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3167000 b3168000 rwxp /usr/lib/libmmfkeysound.so.0.0.0
b3168000 b3170000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3177000 b3178000 rwxp /usr/lib/libmmfcommon.so.0.0.0
b3179000 b317d000 r-xp /usr/lib/libsysman.so.0.2.0
b3184000 b3185000 rwxp /usr/lib/libsysman.so.0.2.0
b3185000 b318d000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
b3194000 b3195000 rwxp /usr/lib/libaudio-session-mgr.so.0.0.0
b3198000 b319b000 r-xp /usr/lib/libmmfsession.so.0.0.0
b31a2000 b31a3000 rwxp /usr/lib/libmmfsession.so.0.0.0
b31a3000 b31e7000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b31ee000 b31ef000 rwxp /usr/lib/libmmfplayer.so.0.0.0
b31f0000 b3203000 r-xp /usr/lib/libEGL_platform.so
b320b000 b320c000 rwxp /usr/lib/libEGL_platform.so
b320d000 b32e4000 r-xp /usr/lib/libMali.so
b32ec000 b32ef000 rwxp /usr/lib/libMali.so
b32ef000 b3313000 r-xp /usr/lib/libicule.so.48.1
b331b000 b331c000 rwxp /usr/lib/libicule.so.48.1
b331c000 b3322000 r-xp /usr/lib/libxcb-render.so.0.0.0
b3329000 b332a000 rwxp /usr/lib/libxcb-render.so.0.0.0
b332a000 b332b000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b3333000 b3334000 rwxp /usr/lib/libxcb-shm.so.0.0.0
b3334000 b3372000 r-xp /usr/lib/libGLESv2.so.2.0
b3379000 b337a000 rwxp /usr/lib/libGLESv2.so.2.0
b337b000 b3392000 r-xp /lib/libexpat.so.1.5.2
b339a000 b339c000 rwxp /lib/libexpat.so.1.5.2
b339c000 b339f000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b33a6000 b33a7000 rwxp /usr/lib/libecore_input_evas.so.1.7.99
b33a7000 b33e4000 r-xp /usr/lib/libcurl.so.4.3.0
b33ec000 b33ee000 rwxp /usr/lib/libcurl.so.4.3.0
b33ee000 b33f2000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b33fa000 b33fb000 rwxp /usr/lib/libecore_ipc.so.1.7.99
b33fb000 b3401000 r-xp /usr/lib/libXrender.so.1.3.0
b3408000 b3409000 rwxp /usr/lib/libXrender.so.1.3.0
b340a000 b3410000 r-xp /usr/lib/libXrandr.so.2.2.0
b3417000 b3418000 rwxp /usr/lib/libXrandr.so.2.2.0
b3418000 b3419000 r-xp /usr/lib/libXinerama.so.1.0.0
b3421000 b3422000 rwxp /usr/lib/libXinerama.so.1.0.0
b3422000 b342b000 r-xp /usr/lib/libXi.so.6.1.0
b3432000 b3433000 rwxp /usr/lib/libXi.so.6.1.0
b3433000 b3435000 r-xp /usr/lib/libXgesture.so.7.0.0
b343c000 b343d000 rwxp /usr/lib/libXgesture.so.7.0.0
b343d000 b343f000 r-xp /usr/lib/libXcomposite.so.1.0.0
b3446000 b3447000 rwxp /usr/lib/libXcomposite.so.1.0.0
b3448000 b344f000 r-xp /usr/lib/libXcursor.so.1.0.2
b3456000 b3457000 rwxp /usr/lib/libXcursor.so.1.0.2
b3457000 b345a000 r-xp /usr/lib/libXfixes.so.3.1.0
b3461000 b3462000 rwxp /usr/lib/libXfixes.so.3.1.0
b3462000 b3477000 r-xp /usr/lib/libxcb.so.1.1.0
b347e000 b347f000 rwxp /usr/lib/libxcb.so.1.1.0
b347f000 b3487000 r-xp /usr/lib/libemotion.so.1.7.99
b348e000 b348f000 rwxp /usr/lib/libemotion.so.1.7.99
b348f000 b3494000 r-xp /usr/lib/libecore_fb.so.1.7.99
b349b000 b349d000 rwxp /usr/lib/libecore_fb.so.1.7.99
b349e000 b34a6000 r-xp /usr/lib/libsf_common.so
b34ad000 b34ae000 rwxp /usr/lib/libsf_common.so
b34ae000 b358b000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b3592000 b3595000 rwxp /usr/lib/libgio-2.0.so.0.3200.3
b3596000 b35db000 r-xp /usr/lib/libsoup-2.4.so.1.5.0
b35e2000 b35e4000 rwxp /usr/lib/libsoup-2.4.so.1.5.0
b35e4000 b3618000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b361f000 b3621000 rwxp /usr/lib/libgobject-2.0.so.0.3200.3
b3622000 b363d000 r-xp /usr/lib/libecore_con.so.1.7.99
b3644000 b3645000 rwxp /usr/lib/libecore_con.so.1.7.99
b3646000 b364e000 r-xp /usr/lib/libethumb_client.so.1.7.99
b3655000 b3656000 rwxp /usr/lib/libethumb_client.so.1.7.99
b3656000 b365f000 r-xp /usr/lib/libedbus.so.1.7.99
b3666000 b3667000 rwxp /usr/lib/libedbus.so.1.7.99
b3667000 b3669000 r-xp /usr/lib/libefreet_trash.so.1.7.99
b3670000 b3671000 rwxp /usr/lib/libefreet_trash.so.1.7.99
b3671000 b3675000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b367d000 b367e000 rwxp /usr/lib/libefreet_mime.so.1.7.99
b367f000 b3695000 r-xp /usr/lib/libefreet.so.1.7.99
b369d000 b369e000 rwxp /usr/lib/libefreet.so.1.7.99
b369f000 b36fb000 r-xp /usr/lib/libedje.so.1.7.99
b3703000 b3705000 rwxp /usr/lib/libedje.so.1.7.99
b3705000 b370a000 r-xp /usr/lib/libecore_file.so.1.7.99
b3711000 b3712000 rwxp /usr/lib/libecore_file.so.1.7.99
b3712000 b3725000 r-xp /usr/lib/libeet.so.1.7.99
b372d000 b372e000 rwxp /usr/lib/libeet.so.1.7.99
b372e000 b4835000 r-xp /usr/lib/libicudata.so.48.1
b483c000 b483d000 rwxp /usr/lib/libicudata.so.48.1
b483d000 b4840000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b4847000 b4848000 rwxp /usr/lib/libSLP-db-util.so.0.1.0
b4849000 b484f000 r-xp /usr/lib/libxdgmime.so.1.1.0
b4856000 b4857000 rwxp /usr/lib/libxdgmime.so.1.1.0
b4857000 b4865000 r-xp /usr/lib/libail.so.0.1.0
b486c000 b486d000 rwxp /usr/lib/libail.so.0.1.0
b486d000 b4892000 r-xp /usr/lib/libexif.so.12.3.3
b4899000 b48a6000 rwxp /usr/lib/libexif.so.12.3.3
b48a6000 b48f1000 r-xp /usr/lib/libtiff.so.5.1.0
b48f9000 b48fc000 rwxp /usr/lib/libtiff.so.5.1.0
b48fc000 b4925000 r-xp /usr/lib/libturbojpeg.so
b492d000 b492e000 rwxp /usr/lib/libturbojpeg.so
b493f000 b4945000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b494c000 b494d000 rwxp /usr/lib/libmmutil_imgp.so.0.0.0
b494d000 b4953000 r-xp /usr/lib/libgif.so.4.1.6
b495a000 b495b000 rwxp /usr/lib/libgif.so.4.1.6
b495b000 b497d000 r-xp /usr/lib/libavutil.so.51.73.101
b4985000 b4988000 rwxp /usr/lib/libavutil.so.51.73.101
b498c000 b49ba000 r-xp /usr/lib/libswscale.so.2.1.101
b49c2000 b49c3000 rwxp /usr/lib/libswscale.so.2.1.101
b49c3000 b4cba000 r-xp /usr/lib/libavcodec.so.54.59.100
b4cc2000 b4cd2000 rwxp /usr/lib/libavcodec.so.54.59.100
b4fe1000 b4ffa000 r-xp /usr/lib/libpng12.so.0.50.0
b5002000 b5003000 rwxp /usr/lib/libpng12.so.0.50.0
b5004000 b500d000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.17
b5014000 b5016000 rwxp /usr/lib/libcapi-system-sensor.so.0.1.17
b5016000 b5023000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b502b000 b502c000 rwxp /usr/lib/libprivilege-control.so.0.0.2
b502c000 b517f000 r-xp /usr/lib/libcrypto.so.1.0.0
b5187000 b519a000 rwxp /usr/lib/libcrypto.so.1.0.0
b519d000 b51b2000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b51ba000 b51bb000 rwxp /usr/lib/libsecurity-server-client.so.1.0.1
b51bc000 b51c0000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b51c7000 b51c8000 rwxp /usr/lib/libcapi-system-info.so.0.2.0
b51c8000 b51cd000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b51d4000 b51d5000 rwxp /usr/lib/libcapi-system-system-settings.so.0.0.2
b51d5000 b51d6000 r-xp /usr/lib/libcapi-system-power.so.0.1.1
b51de000 b51df000 rwxp /usr/lib/libcapi-system-power.so.0.1.1
b51df000 b51e2000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
b51e9000 b51ea000 rwxp /usr/lib/libcapi-system-device.so.0.1.0
b51ea000 b51ed000 r-xp /usr/lib/libcapi-network-serial.so.0.0.8
b51f4000 b51f5000 rwxp /usr/lib/libcapi-network-serial.so.0.0.8
b51f6000 b51f7000 r-xp /usr/lib/libcapi-content-mime-type.so.0.0.2
b51fe000 b51ff000 rwxp /usr/lib/libcapi-content-mime-type.so.0.0.2
b51ff000 b5221000 r-xp /usr/lib/libSLP-tapi.so.0.0.0
b5228000 b5229000 rwxp /usr/lib/libSLP-tapi.so.0.0.0
b5229000 b5240000 r-xp /lib/libz.so.1.2.5
b5247000 b5248000 rwxp /lib/libz.so.1.2.5
b5248000 b524b000 r-xp /usr/lib/libuuid.so.1.3.0
b5253000 b5254000 rwxp /usr/lib/libuuid.so.1.3.0
b5254000 b52be000 r-xp /usr/lib/libsqlite3.so.0.8.6
b52c5000 b52c7000 rwxp /usr/lib/libsqlite3.so.0.8.6
b52c9000 b52e7000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b52ee000 b52ef000 rwxp /usr/lib/libpkgmgr-info.so.0.0.17
b52ef000 b531b000 r-xp /usr/lib/libdbus-1.so.3.7.2
b5323000 b5324000 rwxp /usr/lib/libdbus-1.so.3.7.2
b5324000 b533c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b533c000 b533d000 rwxp /usr/lib/libdbus-glib-1.so.2.2.2
b533d000 b533e000 r-xp /usr/lib/libdlog.so.0.0.0
b5345000 b5346000 rwxp /usr/lib/libdlog.so.0.0.0
b5346000 b535d000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b5365000 b5366000 rwxp /usr/lib/libpkgmgr-client.so.0.1.68
b5366000 b5367000 r-xp /usr/lib/libpmapi.so.1.2
b536e000 b536f000 rwxp /usr/lib/libpmapi.so.1.2
b5370000 b5374000 r-xp /usr/lib/libbundle.so.0.1.22
b537b000 b537c000 rwxp /usr/lib/libbundle.so.0.1.22
b537c000 b538c000 r-xp /usr/lib/libnotification.so.0.1.0
b5393000 b5394000 rwxp /usr/lib/libnotification.so.0.1.0
b5394000 b539c000 r-xp /usr/lib/libminizip.so.1.0.0
b53a3000 b53a4000 rwxp /usr/lib/libminizip.so.1.0.0
b53a4000 b53af000 r-xp /usr/lib/libmessage-port.so.1.2.2.1
b53b6000 b53b7000 rwxp /usr/lib/libmessage-port.so.1.2.2.1
b53b7000 b53d5000 r-xp /usr/lib/libpcre.so.0.0.1
b53dc000 b53dd000 rwxp /usr/lib/libpcre.so.0.0.1
b53dd000 b53e0000 r-xp /usr/lib/libiniparser.so.0
b53e7000 b53e8000 rwxp /usr/lib/libiniparser.so.0
b53ea000 b54d2000 r-xp /usr/lib/libicuuc.so.48.1
b54d2000 b54dd000 rwxp /usr/lib/libicuuc.so.48.1
b54df000 b55ff000 r-xp /usr/lib/libicui18n.so.48.1
b5606000 b560c000 rwxp /usr/lib/libicui18n.so.48.1
b560d000 b5611000 r-xp /usr/lib/libhaptic.so.0.1
b5618000 b5619000 rwxp /usr/lib/libhaptic.so.0.1
b5619000 b5624000 r-xp /usr/lib/libcryptsvc.so.0.0.1
b562c000 b562d000 rwxp /usr/lib/libcryptsvc.so.0.0.1
b5631000 b5636000 r-xp /usr/lib/libdevman.so.0.1
b563e000 b563f000 rwxp /usr/lib/libdevman.so.0.1
b5640000 b564b000 r-xp /usr/lib/libaul.so.0.1.0
b5653000 b5654000 rwxp /usr/lib/libaul.so.0.1.0
b5654000 b5655000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b565c000 b565d000 rwxp /usr/lib/osp/libappinfo.so.1.2.2.1
b565d000 b5663000 r-xp /usr/lib/libalarm.so.0.0.0
b566b000 b566c000 rwxp /usr/lib/libalarm.so.0.0.0
b566c000 b5675000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0.0.3
b567d000 b567e000 rwxp /usr/lib/libcapi-security-privilege-manager.so.0.0.3
b567e000 b5690000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.5
b5697000 b5698000 rwxp /usr/lib/libprivacy-manager-client.so.0.0.5
b5699000 b569f000 r-xp /lib/librt-2.13.so
b56a6000 b56a7000 r-xp /lib/librt-2.13.so
b56a7000 b56a8000 rwxp /lib/librt-2.13.so
b56a8000 b56ac000 r-xp /usr/lib/libchromium.so.1.0
b56b3000 b56b4000 rwxp /usr/lib/libchromium.so.1.0
b56b4000 b56b7000 r-xp /usr/lib/libXtst.so.6.1.0
b56be000 b56bf000 rwxp /usr/lib/libXtst.so.6.1.0
b56bf000 b56c6000 r-xp /usr/lib/libutilX.so.1.1.0
b56cd000 b56ce000 rwxp /usr/lib/libutilX.so.1.1.0
b56ce000 b56d1000 r-xp /usr/lib/libcapi-system-runtime-info.so.0.0.3
b56d9000 b56da000 rwxp /usr/lib/libcapi-system-runtime-info.so.0.0.3
b56db000 b56f4000 r-xp /usr/lib/liblua-5.1.so
b56fc000 b56fd000 rwxp /usr/lib/liblua-5.1.so
b56fd000 b5701000 r-xp /usr/lib/libtbm.so.1.0.0
b5708000 b5709000 rwxp /usr/lib/libtbm.so.1.0.0
b5709000 b5711000 r-xp /usr/lib/libdrm.so.2.4.0
b5718000 b5719000 rwxp /usr/lib/libdrm.so.2.4.0
b5719000 b571b000 r-xp /usr/lib/libdri2.so.0.0.0
b5722000 b5723000 rwxp /usr/lib/libdri2.so.0.0.0
b5723000 b5729000 r-xp /usr/lib/libfeedback.so.0.1.4
b5730000 b5731000 rwxp /usr/lib/libfeedback.so.0.1.4
b5731000 b573d000 r-xp /usr/lib/libtts.so
b5744000 b5745000 rwxp /usr/lib/libtts.so
b5746000 b5749000 r-xp /usr/lib/libXv.so.1.0.0
b5750000 b5751000 rwxp /usr/lib/libXv.so.1.0.0
b5751000 b5768000 r-xp /usr/lib/libEGL.so.1.4
b5770000 b5771000 rwxp /usr/lib/libEGL.so.1.4
b5771000 b577b000 r-xp /usr/lib/libXext.so.6.4.0
b5783000 b5784000 rwxp /usr/lib/libXext.so.6.4.0
b5784000 b57e0000 r-xp /usr/lib/libharfbuzz.so.0.907.0
b57e8000 b57f2000 rwxp /usr/lib/libharfbuzz.so.0.907.0
b57f2000 b5806000 r-xp /usr/lib/libfribidi.so.0.3.1
b580d000 b580e000 rwxp /usr/lib/libfribidi.so.0.3.1
b580e000 b5863000 r-xp /usr/lib/libfreetype.so.6.8.1
b586a000 b586e000 rwxp /usr/lib/libfreetype.so.6.8.1
b586f000 b5949000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b5951000 b5952000 rwxp /usr/lib/libglib-2.0.so.0.3200.3
b5952000 b59bc000 r-xp /usr/lib/libpixman-1.so.0.28.2
b59c4000 b59c9000 rwxp /usr/lib/libpixman-1.so.0.28.2
b59c9000 b5a80000 r-xp /usr/lib/libcairo.so.2.11200.12
b5a87000 b5a8a000 rwxp /usr/lib/libcairo.so.2.11200.12
b5a8a000 b5aae000 r-xp /usr/lib/libfontconfig.so.1.5.0
b5ab5000 b5ab7000 rwxp /usr/lib/libfontconfig.so.1.5.0
b5ab7000 b5b8f000 r-xp /usr/lib/libxml2.so.2.7.8
b5b96000 b5b9c000 rwxp /usr/lib/libxml2.so.2.7.8
b5b9c000 b5bb3000 r-xp /usr/lib/libecore_input.so.1.7.99
b5bba000 b5bce000 rwxp /usr/lib/libecore_input.so.1.7.99
b5bcf000 b5bd0000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5bd7000 b5bd8000 rwxp /usr/lib/libecore_imf_evas.so.1.7.99
b5bd8000 b5bdd000 r-xp /usr/lib/libecore_imf.so.1.7.99
b5be5000 b5be6000 rwxp /usr/lib/libecore_imf.so.1.7.99
b5be6000 b5c16000 r-xp /usr/lib/libecore_x.so.1.7.99
b5c1d000 b5c1f000 rwxp /usr/lib/libecore_x.so.1.7.99
b5c1f000 b5c3c000 r-xp /usr/lib/libecore_evas.so.1.7.99
b5c43000 b5c45000 rwxp /usr/lib/libecore_evas.so.1.7.99
b5c45000 b5c84000 r-xp /usr/lib/libeina.so.1.7.99
b5c8b000 b5c8d000 rwxp /usr/lib/libeina.so.1.7.99
b5c8d000 b5d3c000 r-xp /usr/lib/libevas.so.1.7.99
b5d44000 b5d4c000 rwxp /usr/lib/libevas.so.1.7.99
b5d5e000 b5d73000 r-xp /usr/lib/libecore.so.1.7.99
b5d7b000 b5d7c000 rwxp /usr/lib/libecore.so.1.7.99
b5d8a000 b5d9e000 r-xp /lib/libpthread-2.13.so
b5da5000 b5da6000 r-xp /lib/libpthread-2.13.so
b5da6000 b5da7000 rwxp /lib/libpthread-2.13.so
b5da9000 b5db2000 r-xp /usr/lib/libvconf.so.0.2.45
b5db9000 b5dba000 rwxp /usr/lib/libvconf.so.0.2.45
b5dba000 b5dbb000 r-xp /usr/lib/libXdamage.so.1.1.0
b5dc3000 b5dc4000 rwxp /usr/lib/libXdamage.so.1.1.0
b5dc4000 b5eaa000 r-xp /usr/lib/libX11.so.6.3.0
b5eb1000 b5eb5000 rwxp /usr/lib/libX11.so.6.3.0
b5eb5000 b5fd5000 r-xp /usr/lib/libelementary.so.1.7.99
b5fdc000 b5fe3000 rwxp /usr/lib/libelementary.so.1.7.99
b5fe7000 b5ff4000 r-xp /usr/lib/libsensor.so.1.1.0
b5ffc000 b5ffd000 rwxp /usr/lib/libsensor.so.1.1.0
b5fff000 b6005000 r-xp /usr/lib/libappsvc.so.0.1.0
b600c000 b600d000 rwxp /usr/lib/libappsvc.so.0.1.0
b600d000 b6011000 r-xp /usr/lib/libappcore-efl.so.1.1
b6018000 b6019000 rwxp /usr/lib/libappcore-efl.so.1.1
b6019000 b601e000 r-xp /usr/lib/libappcore-common.so.1.1
b6025000 b6026000 rwxp /usr/lib/libappcore-common.so.1.1
b6026000 b6034000 r-xp /usr/lib/libcapi-appfw-application.so.0.1.0
b603b000 b603c000 rwxp /usr/lib/libcapi-appfw-application.so.0.1.0
b603d000 b6057000 r-xp /usr/lib/osp/libosp-image-core.so.1.2.2.0
b605f000 b6060000 rwxp /usr/lib/osp/libosp-image-core.so.1.2.2.0
b6060000 b6062000 r-xp /lib/libdl-2.13.so
b6069000 b606a000 r-xp /lib/libdl-2.13.so
b606a000 b606b000 rwxp /lib/libdl-2.13.so
b606b000 b6076000 r-xp /lib/libunwind.so.8.0.1
b607e000 b607f000 rwxp /lib/libunwind.so.8.0.1
b60a4000 b61c1000 r-xp /lib/libc-2.13.so
b61c9000 b61cb000 r-xp /lib/libc-2.13.so
b61cb000 b61cc000 rwxp /lib/libc-2.13.so
b61cf000 b61d8000 r-xp /lib/libgcc_s-4.5.3.so.1
b61df000 b61e0000 rwxp /lib/libgcc_s-4.5.3.so.1
b61e0000 b624a000 r-xp /lib/libm-2.13.so
b6251000 b6252000 r-xp /lib/libm-2.13.so
b6252000 b6253000 rwxp /lib/libm-2.13.so
b6253000 b62ee000 r-xp /usr/lib/libstdc++.so.6.0.14
b62f6000 b62f9000 r-xp /usr/lib/libstdc++.so.6.0.14
b62f9000 b62fb000 rwxp /usr/lib/libstdc++.so.6.0.14
b6301000 b631e000 r-xp /usr/lib/osp/libosp-uix.so.1.2.2.0
b6325000 b6328000 rwxp /usr/lib/osp/libosp-uix.so.1.2.2.0
b6328000 b6627000 r-xp /usr/lib/osp/libosp-appfw.so.1.2.2.1
b662f000 b664d000 rwxp /usr/lib/osp/libosp-appfw.so.1.2.2.1
b664e000 b6f49000 r-xp /usr/lib/osp/libosp-uifw.so.1.2.2.1
b6f50000 b6fb9000 rwxp /usr/lib/osp/libosp-uifw.so.1.2.2.1
b6fbe000 b6fbf000 r-xs /var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-3
b6fc0000 b6fc5000 r-xp /usr/lib/libslp_devman_plugin.so
b6fcd000 b6fce000 rwxp /usr/lib/libslp_devman_plugin.so
b6fce000 b6fd2000 r-xp /usr/lib/libsys-assert.so
b6fd9000 b6fda000 rwxp /usr/lib/libsys-assert.so
b6fda000 b6ff7000 r-xp /lib/ld-2.13.so
b6ffe000 b6fff000 r-xp /lib/ld-2.13.so
b6fff000 b7000000 rwxp /lib/ld-2.13.so
befdf000 bf000000 rwxp [stack]
End of Maps Information

Callstack Information (PID:30526)
Call Stack Count: 40
 0: (0x2a006cbc) [/opt/apps/53qxkXM9Op/bin/GravityCalibration] + 0x6cbc
 1: (0x2a0077d4) [/opt/apps/53qxkXM9Op/bin/GravityCalibration] + 0x77d4
 2: (0x2a00783c) [/opt/apps/53qxkXM9Op/bin/GravityCalibration] + 0x783c
End of Call Stack

Package Information
Package Name: 53qxkXM9Op.GravityCalibration
Package ID : 53qxkXM9Op
Version: 1.0.0
Package Type: tpk
App Name: GravityCalibration
App ID: 53qxkXM9Op.GravityCalibration
Type: Application
Categories: (NULL)
