	.arch	armv8-a
	.file	"typemaps.arm64-v8a.s"

/* map_module_count: START */
	.section	.rodata.map_module_count,"a",@progbits
	.type	map_module_count, @object
	.p2align	2
	.global	map_module_count
map_module_count:
	.size	map_module_count, 4
	.word	20
/* map_module_count: END */

/* java_type_count: START */
	.section	.rodata.java_type_count,"a",@progbits
	.type	java_type_count, @object
	.p2align	2
	.global	java_type_count
java_type_count:
	.size	java_type_count, 4
	.word	614
/* java_type_count: END */

	.include	"typemaps.shared.inc"
	.include	"typemaps.arm64-v8a-managed.inc"

/* Managed to Java map: START */
	.section	.data.rel.map_modules,"aw",@progbits
	.type	map_modules, @object
	.p2align	3
	.global	map_modules
map_modules:
	/* module_uuid: 71641000-60bd-4a25-8422-337a37dddc8c */
	.byte	0x00, 0x10, 0x64, 0x71, 0xbd, 0x60, 0x25, 0x4a, 0x84, 0x22, 0x33, 0x7a, 0x37, 0xdd, 0xdc, 0x8c
	/* entry_count */
	.word	1
	/* duplicate_count */
	.word	1
	/* map */
	.xword	module0_managed_to_java
	/* duplicate_map */
	.xword	module0_managed_to_java_duplicates
	/* assembly_name: Xamarin.AndroidX.CustomView */
	.xword	.L.map_aname.0
	/* image */
	.xword	0
	/* java_name_width */
	.word	0
	/* java_map */
	.zero	4
	.xword	0

	/* module_uuid: 8c81d503-ba08-4e9e-955b-8e3f46e6259d */
	.byte	0x03, 0xd5, 0x81, 0x8c, 0x08, 0xba, 0x9e, 0x4e, 0x95, 0x5b, 0x8e, 0x3f, 0x46, 0xe6, 0x25, 0x9d
	/* entry_count */
	.word	3
	/* duplicate_count */
	.word	1
	/* map */
	.xword	module1_managed_to_java
	/* duplicate_map */
	.xword	module1_managed_to_java_duplicates
	/* assembly_name: Xamarin.AndroidX.DrawerLayout */
	.xword	.L.map_aname.1
	/* image */
	.xword	0
	/* java_name_width */
	.word	0
	/* java_map */
	.zero	4
	.xword	0

	/* module_uuid: 972fff0b-ebb0-452d-b81b-441068f3622b */
	.byte	0x0b, 0xff, 0x2f, 0x97, 0xb0, 0xeb, 0x2d, 0x45, 0xb8, 0x1b, 0x44, 0x10, 0x68, 0xf3, 0x62, 0x2b
	/* entry_count */
	.word	3
	/* duplicate_count */
	.word	1
	/* map */
	.xword	module2_managed_to_java
	/* duplicate_map */
	.xword	module2_managed_to_java_duplicates
	/* assembly_name: Xamarin.AndroidX.CoordinatorLayout */
	.xword	.L.map_aname.2
	/* image */
	.xword	0
	/* java_name_width */
	.word	0
	/* java_map */
	.zero	4
	.xword	0

	/* module_uuid: 7d69dc12-e81e-4d6b-999c-67acafd6a841 */
	.byte	0x12, 0xdc, 0x69, 0x7d, 0x1e, 0xe8, 0x6b, 0x4d, 0x99, 0x9c, 0x67, 0xac, 0xaf, 0xd6, 0xa8, 0x41
	/* entry_count */
	.word	74
	/* duplicate_count */
	.word	46
	/* map */
	.xword	module3_managed_to_java
	/* duplicate_map */
	.xword	module3_managed_to_java_duplicates
	/* assembly_name: Xamarin.Android.Glide */
	.xword	.L.map_aname.3
	/* image */
	.xword	0
	/* java_name_width */
	.word	0
	/* java_map */
	.zero	4
	.xword	0

	/* module_uuid: 3c72bc1a-f204-4813-9762-ea78f1253e2e */
	.byte	0x1a, 0xbc, 0x72, 0x3c, 0x04, 0xf2, 0x13, 0x48, 0x97, 0x62, 0xea, 0x78, 0xf1, 0x25, 0x3e, 0x2e
	/* entry_count */
	.word	4
	/* duplicate_count */
	.word	3
	/* map */
	.xword	module4_managed_to_java
	/* duplicate_map */
	.xword	module4_managed_to_java_duplicates
	/* assembly_name: Xamarin.AndroidX.Lifecycle.Common */
	.xword	.L.map_aname.4
	/* image */
	.xword	0
	/* java_name_width */
	.word	0
	/* java_map */
	.zero	4
	.xword	0

	/* module_uuid: 6da7651c-7eaf-45d5-8c61-16cf98fbcbbf */
	.byte	0x1c, 0x65, 0xa7, 0x6d, 0xaf, 0x7e, 0xd5, 0x45, 0x8c, 0x61, 0x16, 0xcf, 0x98, 0xfb, 0xcb, 0xbf
	/* entry_count */
	.word	314
	/* duplicate_count */
	.word	145
	/* map */
	.xword	module5_managed_to_java
	/* duplicate_map */
	.xword	module5_managed_to_java_duplicates
	/* assembly_name: Mono.Android */
	.xword	.L.map_aname.5
	/* image */
	.xword	0
	/* java_name_width */
	.word	0
	/* java_map */
	.zero	4
	.xword	0

	/* module_uuid: 1ef60720-2872-4973-9a3f-e801e9e99c67 */
	.byte	0x20, 0x07, 0xf6, 0x1e, 0x72, 0x28, 0x73, 0x49, 0x9a, 0x3f, 0xe8, 0x01, 0xe9, 0xe9, 0x9c, 0x67
	/* entry_count */
	.word	5
	/* duplicate_count */
	.word	3
	/* map */
	.xword	module6_managed_to_java
	/* duplicate_map */
	.xword	module6_managed_to_java_duplicates
	/* assembly_name: Xamarin.AndroidX.Lifecycle.ViewModel */
	.xword	.L.map_aname.6
	/* image */
	.xword	0
	/* java_name_width */
	.word	0
	/* java_map */
	.zero	4
	.xword	0

	/* module_uuid: e5c95621-2330-4916-ac88-9be153bf7c25 */
	.byte	0x21, 0x56, 0xc9, 0xe5, 0x30, 0x23, 0x16, 0x49, 0xac, 0x88, 0x9b, 0xe1, 0x53, 0xbf, 0x7c, 0x25
	/* entry_count */
	.word	15
	/* duplicate_count */
	.word	8
	/* map */
	.xword	module7_managed_to_java
	/* duplicate_map */
	.xword	module7_managed_to_java_duplicates
	/* assembly_name: Xamarin.AndroidX.Fragment */
	.xword	.L.map_aname.7
	/* image */
	.xword	0
	/* java_name_width */
	.word	0
	/* java_map */
	.zero	4
	.xword	0

	/* module_uuid: c0acd431-3aa7-4133-a340-6f1dbd90e20a */
	.byte	0x31, 0xd4, 0xac, 0xc0, 0xa7, 0x3a, 0x33, 0x41, 0xa3, 0x40, 0x6f, 0x1d, 0xbd, 0x90, 0xe2, 0x0a
	/* entry_count */
	.word	5
	/* duplicate_count */
	.word	4
	/* map */
	.xword	module8_managed_to_java
	/* duplicate_map */
	.xword	module8_managed_to_java_duplicates
	/* assembly_name: Xamarin.AndroidX.Loader */
	.xword	.L.map_aname.8
	/* image */
	.xword	0
	/* java_name_width */
	.word	0
	/* java_map */
	.zero	4
	.xword	0

	/* module_uuid: 1388e533-d15c-4a0b-bebb-d008c4679407 */
	.byte	0x33, 0xe5, 0x88, 0x13, 0x5c, 0xd1, 0x0b, 0x4a, 0xbe, 0xbb, 0xd0, 0x08, 0xc4, 0x67, 0x94, 0x07
	/* entry_count */
	.word	21
	/* duplicate_count */
	.word	0
	/* map */
	.xword	module9_managed_to_java
	/* duplicate_map */
	.xword	0
	/* assembly_name: OrdenTecnica_App */
	.xword	.L.map_aname.9
	/* image */
	.xword	0
	/* java_name_width */
	.word	0
	/* java_map */
	.zero	4
	.xword	0

	/* module_uuid: e2c0d34a-dd41-46d1-85a7-e1daca936d88 */
	.byte	0x4a, 0xd3, 0xc0, 0xe2, 0x41, 0xdd, 0xd1, 0x46, 0x85, 0xa7, 0xe1, 0xda, 0xca, 0x93, 0x6d, 0x88
	/* entry_count */
	.word	14
	/* duplicate_count */
	.word	10
	/* map */
	.xword	module10_managed_to_java
	/* duplicate_map */
	.xword	module10_managed_to_java_duplicates
	/* assembly_name: Xamarin.AndroidX.Activity */
	.xword	.L.map_aname.10
	/* image */
	.xword	0
	/* java_name_width */
	.word	0
	/* java_map */
	.zero	4
	.xword	0

	/* module_uuid: d2e8007b-a34c-4bd2-8f99-57d42a2015d7 */
	.byte	0x7b, 0x00, 0xe8, 0xd2, 0x4c, 0xa3, 0xd2, 0x4b, 0x8f, 0x99, 0x57, 0xd4, 0x2a, 0x20, 0x15, 0xd7
	/* entry_count */
	.word	21
	/* duplicate_count */
	.word	8
	/* map */
	.xword	module11_managed_to_java
	/* duplicate_map */
	.xword	module11_managed_to_java_duplicates
	/* assembly_name: Xamarin.Google.Android.Material */
	.xword	.L.map_aname.11
	/* image */
	.xword	0
	/* java_name_width */
	.word	0
	/* java_map */
	.zero	4
	.xword	0

	/* module_uuid: 12950a7d-ee77-4c74-8ff2-a86c7e6121fc */
	.byte	0x7d, 0x0a, 0x95, 0x12, 0x77, 0xee, 0x74, 0x4c, 0x8f, 0xf2, 0xa8, 0x6c, 0x7e, 0x61, 0x21, 0xfc
	/* entry_count */
	.word	2
	/* duplicate_count */
	.word	2
	/* map */
	.xword	module12_managed_to_java
	/* duplicate_map */
	.xword	module12_managed_to_java_duplicates
	/* assembly_name: Xamarin.AndroidX.Lifecycle.LiveData.Core */
	.xword	.L.map_aname.12
	/* image */
	.xword	0
	/* java_name_width */
	.word	0
	/* java_map */
	.zero	4
	.xword	0

	/* module_uuid: 99265a8b-e448-461a-b96c-14b73bc7d343 */
	.byte	0x8b, 0x5a, 0x26, 0x99, 0x48, 0xe4, 0x1a, 0x46, 0xb9, 0x6c, 0x14, 0xb7, 0x3b, 0xc7, 0xd3, 0x43
	/* entry_count */
	.word	3
	/* duplicate_count */
	.word	2
	/* map */
	.xword	module13_managed_to_java
	/* duplicate_map */
	.xword	module13_managed_to_java_duplicates
	/* assembly_name: Xamarin.AndroidX.SavedState */
	.xword	.L.map_aname.13
	/* image */
	.xword	0
	/* java_name_width */
	.word	0
	/* java_map */
	.zero	4
	.xword	0

	/* module_uuid: 379d77c4-cf8a-4445-860b-68af3453eb4e */
	.byte	0xc4, 0x77, 0x9d, 0x37, 0x8a, 0xcf, 0x45, 0x44, 0x86, 0x0b, 0x68, 0xaf, 0x34, 0x53, 0xeb, 0x4e
	/* entry_count */
	.word	30
	/* duplicate_count */
	.word	17
	/* map */
	.xword	module14_managed_to_java
	/* duplicate_map */
	.xword	module14_managed_to_java_duplicates
	/* assembly_name: Xamarin.AndroidX.AppCompat */
	.xword	.L.map_aname.14
	/* image */
	.xword	0
	/* java_name_width */
	.word	0
	/* java_map */
	.zero	4
	.xword	0

	/* module_uuid: 22ab85d9-c40c-4739-b6fe-c7ac6cfd022e */
	.byte	0xd9, 0x85, 0xab, 0x22, 0x0c, 0xc4, 0x39, 0x47, 0xb6, 0xfe, 0xc7, 0xac, 0x6c, 0xfd, 0x02, 0x2e
	/* entry_count */
	.word	1
	/* duplicate_count */
	.word	1
	/* map */
	.xword	module15_managed_to_java
	/* duplicate_map */
	.xword	module15_managed_to_java_duplicates
	/* assembly_name: Xamarin.Google.Guava.ListenableFuture */
	.xword	.L.map_aname.15
	/* image */
	.xword	0
	/* java_name_width */
	.word	0
	/* java_map */
	.zero	4
	.xword	0

	/* module_uuid: 38a409db-07bf-4774-9d12-ad823d8d1e34 */
	.byte	0xdb, 0x09, 0xa4, 0x38, 0xbf, 0x07, 0x74, 0x47, 0x9d, 0x12, 0xad, 0x82, 0x3d, 0x8d, 0x1e, 0x34
	/* entry_count */
	.word	4
	/* duplicate_count */
	.word	0
	/* map */
	.xword	module16_managed_to_java
	/* duplicate_map */
	.xword	0
	/* assembly_name: Xamarin.Essentials */
	.xword	.L.map_aname.16
	/* image */
	.xword	0
	/* java_name_width */
	.word	0
	/* java_map */
	.zero	4
	.xword	0

	/* module_uuid: 765436e0-f0d4-4c13-9ff3-172059415048 */
	.byte	0xe0, 0x36, 0x54, 0x76, 0xd4, 0xf0, 0x13, 0x4c, 0x9f, 0xf3, 0x17, 0x20, 0x59, 0x41, 0x50, 0x48
	/* entry_count */
	.word	3
	/* duplicate_count */
	.word	0
	/* map */
	.xword	module17_managed_to_java
	/* duplicate_map */
	.xword	0
	/* assembly_name: SignaturePad */
	.xword	.L.map_aname.17
	/* image */
	.xword	0
	/* java_name_width */
	.word	0
	/* java_map */
	.zero	4
	.xword	0

	/* module_uuid: 1b1afaeb-f818-47e6-aacc-6e74b9fc9f19 */
	.byte	0xeb, 0xfa, 0x1a, 0x1b, 0x18, 0xf8, 0xe6, 0x47, 0xaa, 0xcc, 0x6e, 0x74, 0xb9, 0xfc, 0x9f, 0x19
	/* entry_count */
	.word	55
	/* duplicate_count */
	.word	26
	/* map */
	.xword	module18_managed_to_java
	/* duplicate_map */
	.xword	module18_managed_to_java_duplicates
	/* assembly_name: Xamarin.AndroidX.Core */
	.xword	.L.map_aname.18
	/* image */
	.xword	0
	/* java_name_width */
	.word	0
	/* java_map */
	.zero	4
	.xword	0

	/* module_uuid: d73c73f2-9865-4692-982f-e89397baf909 */
	.byte	0xf2, 0x73, 0x3c, 0xd7, 0x65, 0x98, 0x92, 0x46, 0x98, 0x2f, 0xe8, 0x93, 0x97, 0xba, 0xf9, 0x09
	/* entry_count */
	.word	36
	/* duplicate_count */
	.word	20
	/* map */
	.xword	module19_managed_to_java
	/* duplicate_map */
	.xword	module19_managed_to_java_duplicates
	/* assembly_name: Xamarin.AndroidX.RecyclerView */
	.xword	.L.map_aname.19
	/* image */
	.xword	0
	/* java_name_width */
	.word	0
	/* java_map */
	.zero	4
	.xword	0

	.size	map_modules, 1440
/* Managed to Java map: END */

/* Java to managed map: START */
	.section	.rodata.map_java,"a",@progbits
	.type	map_java, @object
	.p2align	2
	.global	map_java
map_java:
	/* #0 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554815
	/* java_name */
	.ascii	"android/animation/Animator"
	.zero	77
	.zero	3

	/* #1 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"android/animation/Animator$AnimatorListener"
	.zero	60
	.zero	3

	/* #2 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"android/animation/Animator$AnimatorPauseListener"
	.zero	55
	.zero	3

	/* #3 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554821
	/* java_name */
	.ascii	"android/animation/AnimatorListenerAdapter"
	.zero	62
	.zero	3

	/* #4 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"android/animation/TimeInterpolator"
	.zero	69
	.zero	3

	/* #5 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554826
	/* java_name */
	.ascii	"android/app/Activity"
	.zero	83
	.zero	3

	/* #6 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554827
	/* java_name */
	.ascii	"android/app/AlertDialog"
	.zero	80
	.zero	3

	/* #7 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554828
	/* java_name */
	.ascii	"android/app/AlertDialog$Builder"
	.zero	72
	.zero	3

	/* #8 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554829
	/* java_name */
	.ascii	"android/app/Application"
	.zero	80
	.zero	3

	/* #9 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"android/app/Application$ActivityLifecycleCallbacks"
	.zero	53
	.zero	3

	/* #10 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554832
	/* java_name */
	.ascii	"android/app/Dialog"
	.zero	85
	.zero	3

	/* #11 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554837
	/* java_name */
	.ascii	"android/app/Fragment"
	.zero	83
	.zero	3

	/* #12 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554838
	/* java_name */
	.ascii	"android/app/PendingIntent"
	.zero	78
	.zero	3

	/* #13 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554847
	/* java_name */
	.ascii	"android/content/BroadcastReceiver"
	.zero	70
	.zero	3

	/* #14 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"android/content/ComponentCallbacks"
	.zero	69
	.zero	3

	/* #15 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"android/content/ComponentCallbacks2"
	.zero	68
	.zero	3

	/* #16 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554849
	/* java_name */
	.ascii	"android/content/ComponentName"
	.zero	74
	.zero	3

	/* #17 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554842
	/* java_name */
	.ascii	"android/content/ContentProvider"
	.zero	72
	.zero	3

	/* #18 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554851
	/* java_name */
	.ascii	"android/content/ContentResolver"
	.zero	72
	.zero	3

	/* #19 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554843
	/* java_name */
	.ascii	"android/content/ContentValues"
	.zero	74
	.zero	3

	/* #20 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554844
	/* java_name */
	.ascii	"android/content/Context"
	.zero	80
	.zero	3

	/* #21 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554854
	/* java_name */
	.ascii	"android/content/ContextWrapper"
	.zero	73
	.zero	3

	/* #22 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"android/content/DialogInterface"
	.zero	72
	.zero	3

	/* #23 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"android/content/DialogInterface$OnCancelListener"
	.zero	55
	.zero	3

	/* #24 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"android/content/DialogInterface$OnClickListener"
	.zero	56
	.zero	3

	/* #25 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"android/content/DialogInterface$OnDismissListener"
	.zero	54
	.zero	3

	/* #26 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554845
	/* java_name */
	.ascii	"android/content/Intent"
	.zero	81
	.zero	3

	/* #27 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554870
	/* java_name */
	.ascii	"android/content/IntentFilter"
	.zero	75
	.zero	3

	/* #28 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554871
	/* java_name */
	.ascii	"android/content/IntentSender"
	.zero	75
	.zero	3

	/* #29 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"android/content/SharedPreferences"
	.zero	70
	.zero	3

	/* #30 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"android/content/SharedPreferences$Editor"
	.zero	63
	.zero	3

	/* #31 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"android/content/SharedPreferences$OnSharedPreferenceChangeListener"
	.zero	37
	.zero	3

	/* #32 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554879
	/* java_name */
	.ascii	"android/content/pm/ApplicationInfo"
	.zero	69
	.zero	3

	/* #33 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554881
	/* java_name */
	.ascii	"android/content/pm/PackageInfo"
	.zero	73
	.zero	3

	/* #34 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554883
	/* java_name */
	.ascii	"android/content/pm/PackageItemInfo"
	.zero	69
	.zero	3

	/* #35 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554884
	/* java_name */
	.ascii	"android/content/pm/PackageManager"
	.zero	70
	.zero	3

	/* #36 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554887
	/* java_name */
	.ascii	"android/content/pm/Signature"
	.zero	75
	.zero	3

	/* #37 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554888
	/* java_name */
	.ascii	"android/content/res/AssetFileDescriptor"
	.zero	64
	.zero	3

	/* #38 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554889
	/* java_name */
	.ascii	"android/content/res/ColorStateList"
	.zero	69
	.zero	3

	/* #39 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554890
	/* java_name */
	.ascii	"android/content/res/Configuration"
	.zero	70
	.zero	3

	/* #40 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554891
	/* java_name */
	.ascii	"android/content/res/Resources"
	.zero	74
	.zero	3

	/* #41 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554892
	/* java_name */
	.ascii	"android/content/res/Resources$Theme"
	.zero	68
	.zero	3

	/* #42 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554893
	/* java_name */
	.ascii	"android/content/res/TypedArray"
	.zero	73
	.zero	3

	/* #43 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554609
	/* java_name */
	.ascii	"android/database/CharArrayBuffer"
	.zero	71
	.zero	3

	/* #44 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554610
	/* java_name */
	.ascii	"android/database/ContentObserver"
	.zero	71
	.zero	3

	/* #45 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"android/database/Cursor"
	.zero	80
	.zero	3

	/* #46 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554612
	/* java_name */
	.ascii	"android/database/DataSetObserver"
	.zero	71
	.zero	3

	/* #47 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554787
	/* java_name */
	.ascii	"android/graphics/Bitmap"
	.zero	80
	.zero	3

	/* #48 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554788
	/* java_name */
	.ascii	"android/graphics/Bitmap$CompressFormat"
	.zero	65
	.zero	3

	/* #49 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554789
	/* java_name */
	.ascii	"android/graphics/Bitmap$Config"
	.zero	73
	.zero	3

	/* #50 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554794
	/* java_name */
	.ascii	"android/graphics/BitmapFactory"
	.zero	73
	.zero	3

	/* #51 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554795
	/* java_name */
	.ascii	"android/graphics/BlendMode"
	.zero	77
	.zero	3

	/* #52 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554791
	/* java_name */
	.ascii	"android/graphics/Canvas"
	.zero	80
	.zero	3

	/* #53 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554796
	/* java_name */
	.ascii	"android/graphics/ColorFilter"
	.zero	75
	.zero	3

	/* #54 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554797
	/* java_name */
	.ascii	"android/graphics/Matrix"
	.zero	80
	.zero	3

	/* #55 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554798
	/* java_name */
	.ascii	"android/graphics/Paint"
	.zero	81
	.zero	3

	/* #56 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554799
	/* java_name */
	.ascii	"android/graphics/Paint$Cap"
	.zero	77
	.zero	3

	/* #57 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554800
	/* java_name */
	.ascii	"android/graphics/Paint$Join"
	.zero	76
	.zero	3

	/* #58 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554801
	/* java_name */
	.ascii	"android/graphics/Paint$Style"
	.zero	75
	.zero	3

	/* #59 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554802
	/* java_name */
	.ascii	"android/graphics/Path"
	.zero	82
	.zero	3

	/* #60 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554803
	/* java_name */
	.ascii	"android/graphics/Point"
	.zero	81
	.zero	3

	/* #61 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554804
	/* java_name */
	.ascii	"android/graphics/PointF"
	.zero	80
	.zero	3

	/* #62 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554805
	/* java_name */
	.ascii	"android/graphics/PorterDuff"
	.zero	76
	.zero	3

	/* #63 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554806
	/* java_name */
	.ascii	"android/graphics/PorterDuff$Mode"
	.zero	71
	.zero	3

	/* #64 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554807
	/* java_name */
	.ascii	"android/graphics/Rect"
	.zero	82
	.zero	3

	/* #65 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554808
	/* java_name */
	.ascii	"android/graphics/RectF"
	.zero	81
	.zero	3

	/* #66 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554809
	/* java_name */
	.ascii	"android/graphics/Region"
	.zero	80
	.zero	3

	/* #67 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554813
	/* java_name */
	.ascii	"android/graphics/drawable/ColorDrawable"
	.zero	64
	.zero	3

	/* #68 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554810
	/* java_name */
	.ascii	"android/graphics/drawable/Drawable"
	.zero	69
	.zero	3

	/* #69 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"android/graphics/drawable/Drawable$Callback"
	.zero	60
	.zero	3

	/* #70 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554778
	/* java_name */
	.ascii	"android/net/ConnectivityManager"
	.zero	72
	.zero	3

	/* #71 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554781
	/* java_name */
	.ascii	"android/net/Network"
	.zero	84
	.zero	3

	/* #72 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554782
	/* java_name */
	.ascii	"android/net/NetworkCapabilities"
	.zero	72
	.zero	3

	/* #73 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554783
	/* java_name */
	.ascii	"android/net/NetworkInfo"
	.zero	80
	.zero	3

	/* #74 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554784
	/* java_name */
	.ascii	"android/net/Uri"
	.zero	88
	.zero	3

	/* #75 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554765
	/* java_name */
	.ascii	"android/os/BaseBundle"
	.zero	82
	.zero	3

	/* #76 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554766
	/* java_name */
	.ascii	"android/os/Build"
	.zero	87
	.zero	3

	/* #77 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554767
	/* java_name */
	.ascii	"android/os/Build$VERSION"
	.zero	79
	.zero	3

	/* #78 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554769
	/* java_name */
	.ascii	"android/os/Bundle"
	.zero	86
	.zero	3

	/* #79 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554770
	/* java_name */
	.ascii	"android/os/Environment"
	.zero	81
	.zero	3

	/* #80 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554761
	/* java_name */
	.ascii	"android/os/Handler"
	.zero	85
	.zero	3

	/* #81 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"android/os/Handler$Callback"
	.zero	76
	.zero	3

	/* #82 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554775
	/* java_name */
	.ascii	"android/os/Looper"
	.zero	86
	.zero	3

	/* #83 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554764
	/* java_name */
	.ascii	"android/os/Message"
	.zero	85
	.zero	3

	/* #84 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554776
	/* java_name */
	.ascii	"android/os/Parcel"
	.zero	86
	.zero	3

	/* #85 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"android/os/Parcelable"
	.zero	82
	.zero	3

	/* #86 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"android/os/Parcelable$Creator"
	.zero	74
	.zero	3

	/* #87 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554760
	/* java_name */
	.ascii	"android/preference/PreferenceManager"
	.zero	67
	.zero	3

	/* #88 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554601
	/* java_name */
	.ascii	"android/provider/DocumentsContract"
	.zero	69
	.zero	3

	/* #89 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554602
	/* java_name */
	.ascii	"android/provider/MediaStore"
	.zero	76
	.zero	3

	/* #90 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554603
	/* java_name */
	.ascii	"android/provider/MediaStore$Audio"
	.zero	70
	.zero	3

	/* #91 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554604
	/* java_name */
	.ascii	"android/provider/MediaStore$Audio$Media"
	.zero	64
	.zero	3

	/* #92 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554605
	/* java_name */
	.ascii	"android/provider/MediaStore$Images"
	.zero	69
	.zero	3

	/* #93 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554606
	/* java_name */
	.ascii	"android/provider/MediaStore$Images$Media"
	.zero	63
	.zero	3

	/* #94 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554607
	/* java_name */
	.ascii	"android/provider/MediaStore$Video"
	.zero	70
	.zero	3

	/* #95 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554608
	/* java_name */
	.ascii	"android/provider/MediaStore$Video$Media"
	.zero	64
	.zero	3

	/* #96 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554939
	/* java_name */
	.ascii	"android/runtime/JavaProxyThrowable"
	.zero	69
	.zero	3

	/* #97 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554754
	/* java_name */
	.ascii	"android/text/style/CharacterStyle"
	.zero	70
	.zero	3

	/* #98 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554756
	/* java_name */
	.ascii	"android/text/style/ClickableSpan"
	.zero	71
	.zero	3

	/* #99 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"android/text/style/UpdateAppearance"
	.zero	68
	.zero	3

	/* #100 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"android/util/AttributeSet"
	.zero	78
	.zero	3

	/* #101 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554750
	/* java_name */
	.ascii	"android/util/DisplayMetrics"
	.zero	76
	.zero	3

	/* #102 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554753
	/* java_name */
	.ascii	"android/util/SparseArray"
	.zero	79
	.zero	3

	/* #103 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554680
	/* java_name */
	.ascii	"android/view/ActionMode"
	.zero	80
	.zero	3

	/* #104 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"android/view/ActionMode$Callback"
	.zero	71
	.zero	3

	/* #105 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554685
	/* java_name */
	.ascii	"android/view/ActionProvider"
	.zero	76
	.zero	3

	/* #106 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"android/view/CollapsibleActionView"
	.zero	69
	.zero	3

	/* #107 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"android/view/ContextMenu"
	.zero	79
	.zero	3

	/* #108 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"android/view/ContextMenu$ContextMenuInfo"
	.zero	63
	.zero	3

	/* #109 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554687
	/* java_name */
	.ascii	"android/view/ContextThemeWrapper"
	.zero	71
	.zero	3

	/* #110 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554688
	/* java_name */
	.ascii	"android/view/Display"
	.zero	83
	.zero	3

	/* #111 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554689
	/* java_name */
	.ascii	"android/view/DragEvent"
	.zero	81
	.zero	3

	/* #112 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554705
	/* java_name */
	.ascii	"android/view/InputEvent"
	.zero	80
	.zero	3

	/* #113 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554665
	/* java_name */
	.ascii	"android/view/KeyEvent"
	.zero	82
	.zero	3

	/* #114 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"android/view/KeyEvent$Callback"
	.zero	73
	.zero	3

	/* #115 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554716
	/* java_name */
	.ascii	"android/view/KeyboardShortcutGroup"
	.zero	69
	.zero	3

	/* #116 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554668
	/* java_name */
	.ascii	"android/view/LayoutInflater"
	.zero	76
	.zero	3

	/* #117 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"android/view/LayoutInflater$Factory"
	.zero	68
	.zero	3

	/* #118 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"android/view/LayoutInflater$Factory2"
	.zero	67
	.zero	3

	/* #119 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"android/view/Menu"
	.zero	86
	.zero	3

	/* #120 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554721
	/* java_name */
	.ascii	"android/view/MenuInflater"
	.zero	78
	.zero	3

	/* #121 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"android/view/MenuItem"
	.zero	82
	.zero	3

	/* #122 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"android/view/MenuItem$OnActionExpandListener"
	.zero	59
	.zero	3

	/* #123 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"android/view/MenuItem$OnMenuItemClickListener"
	.zero	58
	.zero	3

	/* #124 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554673
	/* java_name */
	.ascii	"android/view/MotionEvent"
	.zero	79
	.zero	3

	/* #125 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554725
	/* java_name */
	.ascii	"android/view/SearchEvent"
	.zero	79
	.zero	3

	/* #126 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"android/view/SubMenu"
	.zero	83
	.zero	3

	/* #127 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554656
	/* java_name */
	.ascii	"android/view/View"
	.zero	86
	.zero	3

	/* #128 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554657
	/* java_name */
	.ascii	"android/view/View$AccessibilityDelegate"
	.zero	64
	.zero	3

	/* #129 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"android/view/View$OnClickListener"
	.zero	70
	.zero	3

	/* #130 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"android/view/View$OnCreateContextMenuListener"
	.zero	58
	.zero	3

	/* #131 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554729
	/* java_name */
	.ascii	"android/view/ViewGroup"
	.zero	81
	.zero	3

	/* #132 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554730
	/* java_name */
	.ascii	"android/view/ViewGroup$LayoutParams"
	.zero	68
	.zero	3

	/* #133 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554731
	/* java_name */
	.ascii	"android/view/ViewGroup$MarginLayoutParams"
	.zero	62
	.zero	3

	/* #134 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"android/view/ViewManager"
	.zero	79
	.zero	3

	/* #135 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"android/view/ViewParent"
	.zero	80
	.zero	3

	/* #136 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554733
	/* java_name */
	.ascii	"android/view/ViewPropertyAnimator"
	.zero	70
	.zero	3

	/* #137 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554674
	/* java_name */
	.ascii	"android/view/ViewTreeObserver"
	.zero	74
	.zero	3

	/* #138 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"android/view/ViewTreeObserver$OnPreDrawListener"
	.zero	56
	.zero	3

	/* #139 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554677
	/* java_name */
	.ascii	"android/view/Window"
	.zero	84
	.zero	3

	/* #140 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"android/view/Window$Callback"
	.zero	75
	.zero	3

	/* #141 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554736
	/* java_name */
	.ascii	"android/view/WindowInsets"
	.zero	78
	.zero	3

	/* #142 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"android/view/WindowManager"
	.zero	77
	.zero	3

	/* #143 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554713
	/* java_name */
	.ascii	"android/view/WindowManager$LayoutParams"
	.zero	64
	.zero	3

	/* #144 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554737
	/* java_name */
	.ascii	"android/view/WindowMetrics"
	.zero	77
	.zero	3

	/* #145 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554742
	/* java_name */
	.ascii	"android/view/accessibility/AccessibilityEvent"
	.zero	58
	.zero	3

	/* #146 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"android/view/accessibility/AccessibilityEventSource"
	.zero	52
	.zero	3

	/* #147 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554743
	/* java_name */
	.ascii	"android/view/accessibility/AccessibilityNodeInfo"
	.zero	55
	.zero	3

	/* #148 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554744
	/* java_name */
	.ascii	"android/view/accessibility/AccessibilityRecord"
	.zero	57
	.zero	3

	/* #149 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554738
	/* java_name */
	.ascii	"android/view/animation/Animation"
	.zero	71
	.zero	3

	/* #150 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"android/view/animation/Interpolator"
	.zero	68
	.zero	3

	/* #151 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554599
	/* java_name */
	.ascii	"android/webkit/MimeTypeMap"
	.zero	77
	.zero	3

	/* #152 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"android/widget/Adapter"
	.zero	81
	.zero	3

	/* #153 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554617
	/* java_name */
	.ascii	"android/widget/AdapterView"
	.zero	77
	.zero	3

	/* #154 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"android/widget/AdapterView$OnItemSelectedListener"
	.zero	54
	.zero	3

	/* #155 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"android/widget/ArrayAdapter"
	.zero	76
	.zero	3

	/* #156 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554621
	/* java_name */
	.ascii	"android/widget/AutoCompleteTextView"
	.zero	68
	.zero	3

	/* #157 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554625
	/* java_name */
	.ascii	"android/widget/BaseAdapter"
	.zero	77
	.zero	3

	/* #158 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554627
	/* java_name */
	.ascii	"android/widget/Button"
	.zero	82
	.zero	3

	/* #159 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554628
	/* java_name */
	.ascii	"android/widget/EdgeEffect"
	.zero	78
	.zero	3

	/* #160 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554629
	/* java_name */
	.ascii	"android/widget/EditText"
	.zero	80
	.zero	3

	/* #161 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554630
	/* java_name */
	.ascii	"android/widget/Filter"
	.zero	82
	.zero	3

	/* #162 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"android/widget/Filter$FilterListener"
	.zero	67
	.zero	3

	/* #163 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"android/widget/Filterable"
	.zero	78
	.zero	3

	/* #164 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554634
	/* java_name */
	.ascii	"android/widget/FrameLayout"
	.zero	77
	.zero	3

	/* #165 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554635
	/* java_name */
	.ascii	"android/widget/FrameLayout$LayoutParams"
	.zero	64
	.zero	3

	/* #166 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554636
	/* java_name */
	.ascii	"android/widget/HorizontalScrollView"
	.zero	68
	.zero	3

	/* #167 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554643
	/* java_name */
	.ascii	"android/widget/ImageButton"
	.zero	77
	.zero	3

	/* #168 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554644
	/* java_name */
	.ascii	"android/widget/ImageView"
	.zero	79
	.zero	3

	/* #169 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554649
	/* java_name */
	.ascii	"android/widget/LinearLayout"
	.zero	76
	.zero	3

	/* #170 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"android/widget/ListAdapter"
	.zero	77
	.zero	3

	/* #171 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554650
	/* java_name */
	.ascii	"android/widget/RelativeLayout"
	.zero	74
	.zero	3

	/* #172 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554651
	/* java_name */
	.ascii	"android/widget/SearchView"
	.zero	78
	.zero	3

	/* #173 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"android/widget/SearchView$OnQueryTextListener"
	.zero	58
	.zero	3

	/* #174 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"android/widget/SpinnerAdapter"
	.zero	74
	.zero	3

	/* #175 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554622
	/* java_name */
	.ascii	"android/widget/TextView"
	.zero	80
	.zero	3

	/* #176 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"android/widget/ThemedSpinnerAdapter"
	.zero	68
	.zero	3

	/* #177 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554654
	/* java_name */
	.ascii	"android/widget/Toast"
	.zero	83
	.zero	3

	/* #178 */
	/* module_index */
	.word	10
	/* type_token_id */
	.word	33554442
	/* java_name */
	.ascii	"androidx/activity/ComponentActivity"
	.zero	68
	.zero	3

	/* #179 */
	/* module_index */
	.word	10
	/* type_token_id */
	.word	33554447
	/* java_name */
	.ascii	"androidx/activity/OnBackPressedCallback"
	.zero	64
	.zero	3

	/* #180 */
	/* module_index */
	.word	10
	/* type_token_id */
	.word	33554449
	/* java_name */
	.ascii	"androidx/activity/OnBackPressedDispatcher"
	.zero	62
	.zero	3

	/* #181 */
	/* module_index */
	.word	10
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/activity/OnBackPressedDispatcherOwner"
	.zero	57
	.zero	3

	/* #182 */
	/* module_index */
	.word	10
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/activity/contextaware/ContextAware"
	.zero	60
	.zero	3

	/* #183 */
	/* module_index */
	.word	10
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/activity/contextaware/OnContextAvailableListener"
	.zero	46
	.zero	3

	/* #184 */
	/* module_index */
	.word	10
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/activity/result/ActivityResultCallback"
	.zero	56
	.zero	3

	/* #185 */
	/* module_index */
	.word	10
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/activity/result/ActivityResultCaller"
	.zero	58
	.zero	3

	/* #186 */
	/* module_index */
	.word	10
	/* type_token_id */
	.word	33554456
	/* java_name */
	.ascii	"androidx/activity/result/ActivityResultLauncher"
	.zero	56
	.zero	3

	/* #187 */
	/* module_index */
	.word	10
	/* type_token_id */
	.word	33554458
	/* java_name */
	.ascii	"androidx/activity/result/ActivityResultRegistry"
	.zero	56
	.zero	3

	/* #188 */
	/* module_index */
	.word	10
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/activity/result/ActivityResultRegistryOwner"
	.zero	51
	.zero	3

	/* #189 */
	/* module_index */
	.word	10
	/* type_token_id */
	.word	33554467
	/* java_name */
	.ascii	"androidx/activity/result/contract/ActivityResultContract"
	.zero	47
	.zero	3

	/* #190 */
	/* module_index */
	.word	10
	/* type_token_id */
	.word	33554468
	/* java_name */
	.ascii	"androidx/activity/result/contract/ActivityResultContract$SynchronousResult"
	.zero	29
	.zero	3

	/* #191 */
	/* module_index */
	.word	14
	/* type_token_id */
	.word	33554474
	/* java_name */
	.ascii	"androidx/appcompat/app/ActionBar"
	.zero	71
	.zero	3

	/* #192 */
	/* module_index */
	.word	14
	/* type_token_id */
	.word	33554475
	/* java_name */
	.ascii	"androidx/appcompat/app/ActionBar$LayoutParams"
	.zero	58
	.zero	3

	/* #193 */
	/* module_index */
	.word	14
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/appcompat/app/ActionBar$OnMenuVisibilityListener"
	.zero	46
	.zero	3

	/* #194 */
	/* module_index */
	.word	14
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/appcompat/app/ActionBar$OnNavigationListener"
	.zero	50
	.zero	3

	/* #195 */
	/* module_index */
	.word	14
	/* type_token_id */
	.word	33554482
	/* java_name */
	.ascii	"androidx/appcompat/app/ActionBar$Tab"
	.zero	67
	.zero	3

	/* #196 */
	/* module_index */
	.word	14
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/appcompat/app/ActionBar$TabListener"
	.zero	59
	.zero	3

	/* #197 */
	/* module_index */
	.word	14
	/* type_token_id */
	.word	33554489
	/* java_name */
	.ascii	"androidx/appcompat/app/ActionBarDrawerToggle"
	.zero	59
	.zero	3

	/* #198 */
	/* module_index */
	.word	14
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/appcompat/app/ActionBarDrawerToggle$Delegate"
	.zero	50
	.zero	3

	/* #199 */
	/* module_index */
	.word	14
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/appcompat/app/ActionBarDrawerToggle$DelegateProvider"
	.zero	42
	.zero	3

	/* #200 */
	/* module_index */
	.word	14
	/* type_token_id */
	.word	33554494
	/* java_name */
	.ascii	"androidx/appcompat/app/AppCompatActivity"
	.zero	63
	.zero	3

	/* #201 */
	/* module_index */
	.word	14
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/appcompat/app/AppCompatCallback"
	.zero	63
	.zero	3

	/* #202 */
	/* module_index */
	.word	14
	/* type_token_id */
	.word	33554495
	/* java_name */
	.ascii	"androidx/appcompat/app/AppCompatDelegate"
	.zero	63
	.zero	3

	/* #203 */
	/* module_index */
	.word	14
	/* type_token_id */
	.word	33554473
	/* java_name */
	.ascii	"androidx/appcompat/graphics/drawable/DrawerArrowDrawable"
	.zero	47
	.zero	3

	/* #204 */
	/* module_index */
	.word	14
	/* type_token_id */
	.word	33554512
	/* java_name */
	.ascii	"androidx/appcompat/view/ActionMode"
	.zero	69
	.zero	3

	/* #205 */
	/* module_index */
	.word	14
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/appcompat/view/ActionMode$Callback"
	.zero	60
	.zero	3

	/* #206 */
	/* module_index */
	.word	14
	/* type_token_id */
	.word	33554516
	/* java_name */
	.ascii	"androidx/appcompat/view/menu/MenuBuilder"
	.zero	63
	.zero	3

	/* #207 */
	/* module_index */
	.word	14
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/appcompat/view/menu/MenuBuilder$Callback"
	.zero	54
	.zero	3

	/* #208 */
	/* module_index */
	.word	14
	/* type_token_id */
	.word	33554525
	/* java_name */
	.ascii	"androidx/appcompat/view/menu/MenuItemImpl"
	.zero	62
	.zero	3

	/* #209 */
	/* module_index */
	.word	14
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/appcompat/view/menu/MenuPresenter"
	.zero	61
	.zero	3

	/* #210 */
	/* module_index */
	.word	14
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/appcompat/view/menu/MenuPresenter$Callback"
	.zero	52
	.zero	3

	/* #211 */
	/* module_index */
	.word	14
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/appcompat/view/menu/MenuView"
	.zero	66
	.zero	3

	/* #212 */
	/* module_index */
	.word	14
	/* type_token_id */
	.word	33554526
	/* java_name */
	.ascii	"androidx/appcompat/view/menu/SubMenuBuilder"
	.zero	60
	.zero	3

	/* #213 */
	/* module_index */
	.word	14
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/appcompat/widget/DecorToolbar"
	.zero	65
	.zero	3

	/* #214 */
	/* module_index */
	.word	14
	/* type_token_id */
	.word	33554510
	/* java_name */
	.ascii	"androidx/appcompat/widget/ScrollingTabContainerView"
	.zero	52
	.zero	3

	/* #215 */
	/* module_index */
	.word	14
	/* type_token_id */
	.word	33554511
	/* java_name */
	.ascii	"androidx/appcompat/widget/ScrollingTabContainerView$VisibilityAnimListener"
	.zero	29
	.zero	3

	/* #216 */
	/* module_index */
	.word	14
	/* type_token_id */
	.word	33554499
	/* java_name */
	.ascii	"androidx/appcompat/widget/Toolbar"
	.zero	70
	.zero	3

	/* #217 */
	/* module_index */
	.word	14
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/appcompat/widget/Toolbar$OnMenuItemClickListener"
	.zero	46
	.zero	3

	/* #218 */
	/* module_index */
	.word	14
	/* type_token_id */
	.word	33554500
	/* java_name */
	.ascii	"androidx/appcompat/widget/Toolbar_NavigationOnClickEventDispatcher"
	.zero	37
	.zero	3

	/* #219 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554434
	/* java_name */
	.ascii	"androidx/coordinatorlayout/widget/CoordinatorLayout"
	.zero	52
	.zero	3

	/* #220 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554435
	/* java_name */
	.ascii	"androidx/coordinatorlayout/widget/CoordinatorLayout$Behavior"
	.zero	43
	.zero	3

	/* #221 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554437
	/* java_name */
	.ascii	"androidx/coordinatorlayout/widget/CoordinatorLayout$LayoutParams"
	.zero	39
	.zero	3

	/* #222 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	33554510
	/* java_name */
	.ascii	"androidx/core/app/ActivityCompat"
	.zero	71
	.zero	3

	/* #223 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/core/app/ActivityCompat$OnRequestPermissionsResultCallback"
	.zero	36
	.zero	3

	/* #224 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/core/app/ActivityCompat$PermissionCompatDelegate"
	.zero	46
	.zero	3

	/* #225 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/core/app/ActivityCompat$RequestPermissionsRequestCodeValidator"
	.zero	32
	.zero	3

	/* #226 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	33554517
	/* java_name */
	.ascii	"androidx/core/app/ActivityOptionsCompat"
	.zero	64
	.zero	3

	/* #227 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	33554518
	/* java_name */
	.ascii	"androidx/core/app/ComponentActivity"
	.zero	68
	.zero	3

	/* #228 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	33554519
	/* java_name */
	.ascii	"androidx/core/app/ComponentActivity$ExtraData"
	.zero	58
	.zero	3

	/* #229 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	33554520
	/* java_name */
	.ascii	"androidx/core/app/SharedElementCallback"
	.zero	64
	.zero	3

	/* #230 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/core/app/SharedElementCallback$OnSharedElementsReadyListener"
	.zero	34
	.zero	3

	/* #231 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	33554524
	/* java_name */
	.ascii	"androidx/core/app/TaskStackBuilder"
	.zero	69
	.zero	3

	/* #232 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/core/app/TaskStackBuilder$SupportParentable"
	.zero	51
	.zero	3

	/* #233 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	33554505
	/* java_name */
	.ascii	"androidx/core/content/ContextCompat"
	.zero	68
	.zero	3

	/* #234 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	33554506
	/* java_name */
	.ascii	"androidx/core/content/FileProvider"
	.zero	69
	.zero	3

	/* #235 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	33554507
	/* java_name */
	.ascii	"androidx/core/content/LocusIdCompat"
	.zero	68
	.zero	3

	/* #236 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	33554508
	/* java_name */
	.ascii	"androidx/core/content/PermissionChecker"
	.zero	64
	.zero	3

	/* #237 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	33554509
	/* java_name */
	.ascii	"androidx/core/content/pm/PackageInfoCompat"
	.zero	61
	.zero	3

	/* #238 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	33554504
	/* java_name */
	.ascii	"androidx/core/graphics/Insets"
	.zero	74
	.zero	3

	/* #239 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/core/internal/view/SupportMenu"
	.zero	64
	.zero	3

	/* #240 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/core/internal/view/SupportMenuItem"
	.zero	60
	.zero	3

	/* #241 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	33554496
	/* java_name */
	.ascii	"androidx/core/util/Pair"
	.zero	80
	.zero	3

	/* #242 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	33554497
	/* java_name */
	.ascii	"androidx/core/util/Pools"
	.zero	79
	.zero	3

	/* #243 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/core/util/Pools$Pool"
	.zero	74
	.zero	3

	/* #244 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	33554530
	/* java_name */
	.ascii	"androidx/core/view/AccessibilityDelegateCompat"
	.zero	57
	.zero	3

	/* #245 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	33554531
	/* java_name */
	.ascii	"androidx/core/view/ActionProvider"
	.zero	70
	.zero	3

	/* #246 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/core/view/ActionProvider$SubUiVisibilityListener"
	.zero	46
	.zero	3

	/* #247 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/core/view/ActionProvider$VisibilityListener"
	.zero	51
	.zero	3

	/* #248 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	33554545
	/* java_name */
	.ascii	"androidx/core/view/DisplayCutoutCompat"
	.zero	65
	.zero	3

	/* #249 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	33554546
	/* java_name */
	.ascii	"androidx/core/view/DragAndDropPermissionsCompat"
	.zero	56
	.zero	3

	/* #250 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	33554566
	/* java_name */
	.ascii	"androidx/core/view/KeyEventDispatcher"
	.zero	66
	.zero	3

	/* #251 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/core/view/KeyEventDispatcher$Component"
	.zero	56
	.zero	3

	/* #252 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/core/view/NestedScrollingChild"
	.zero	64
	.zero	3

	/* #253 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/core/view/NestedScrollingChild2"
	.zero	63
	.zero	3

	/* #254 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/core/view/NestedScrollingChild3"
	.zero	63
	.zero	3

	/* #255 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/core/view/NestedScrollingParent"
	.zero	63
	.zero	3

	/* #256 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/core/view/NestedScrollingParent2"
	.zero	62
	.zero	3

	/* #257 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/core/view/NestedScrollingParent3"
	.zero	62
	.zero	3

	/* #258 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/core/view/ScrollingView"
	.zero	71
	.zero	3

	/* #259 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/core/view/TintableBackgroundView"
	.zero	62
	.zero	3

	/* #260 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	33554569
	/* java_name */
	.ascii	"androidx/core/view/ViewPropertyAnimatorCompat"
	.zero	58
	.zero	3

	/* #261 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/core/view/ViewPropertyAnimatorListener"
	.zero	56
	.zero	3

	/* #262 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/core/view/ViewPropertyAnimatorUpdateListener"
	.zero	50
	.zero	3

	/* #263 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	33554570
	/* java_name */
	.ascii	"androidx/core/view/WindowInsetsCompat"
	.zero	66
	.zero	3

	/* #264 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	33554571
	/* java_name */
	.ascii	"androidx/core/view/accessibility/AccessibilityNodeInfoCompat"
	.zero	43
	.zero	3

	/* #265 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	33554572
	/* java_name */
	.ascii	"androidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat"
	.zero	17
	.zero	3

	/* #266 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	33554573
	/* java_name */
	.ascii	"androidx/core/view/accessibility/AccessibilityNodeInfoCompat$CollectionInfoCompat"
	.zero	22
	.zero	3

	/* #267 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	33554574
	/* java_name */
	.ascii	"androidx/core/view/accessibility/AccessibilityNodeInfoCompat$CollectionItemInfoCompat"
	.zero	18
	.zero	3

	/* #268 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	33554575
	/* java_name */
	.ascii	"androidx/core/view/accessibility/AccessibilityNodeInfoCompat$RangeInfoCompat"
	.zero	27
	.zero	3

	/* #269 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	33554576
	/* java_name */
	.ascii	"androidx/core/view/accessibility/AccessibilityNodeInfoCompat$TouchDelegateInfoCompat"
	.zero	19
	.zero	3

	/* #270 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	33554577
	/* java_name */
	.ascii	"androidx/core/view/accessibility/AccessibilityNodeProviderCompat"
	.zero	39
	.zero	3

	/* #271 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/core/view/accessibility/AccessibilityViewCommand"
	.zero	46
	.zero	3

	/* #272 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	33554579
	/* java_name */
	.ascii	"androidx/core/view/accessibility/AccessibilityViewCommand$CommandArguments"
	.zero	29
	.zero	3

	/* #273 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	33554578
	/* java_name */
	.ascii	"androidx/core/view/accessibility/AccessibilityWindowInfoCompat"
	.zero	41
	.zero	3

	/* #274 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/core/widget/TintableImageSourceView"
	.zero	59
	.zero	3

	/* #275 */
	/* module_index */
	.word	0
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/customview/widget/Openable"
	.zero	68
	.zero	3

	/* #276 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554454
	/* java_name */
	.ascii	"androidx/drawerlayout/widget/DrawerLayout"
	.zero	62
	.zero	3

	/* #277 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/drawerlayout/widget/DrawerLayout$DrawerListener"
	.zero	47
	.zero	3

	/* #278 */
	/* module_index */
	.word	7
	/* type_token_id */
	.word	33554469
	/* java_name */
	.ascii	"androidx/fragment/app/DialogFragment"
	.zero	67
	.zero	3

	/* #279 */
	/* module_index */
	.word	7
	/* type_token_id */
	.word	33554470
	/* java_name */
	.ascii	"androidx/fragment/app/Fragment"
	.zero	73
	.zero	3

	/* #280 */
	/* module_index */
	.word	7
	/* type_token_id */
	.word	33554471
	/* java_name */
	.ascii	"androidx/fragment/app/Fragment$SavedState"
	.zero	62
	.zero	3

	/* #281 */
	/* module_index */
	.word	7
	/* type_token_id */
	.word	33554468
	/* java_name */
	.ascii	"androidx/fragment/app/FragmentActivity"
	.zero	65
	.zero	3

	/* #282 */
	/* module_index */
	.word	7
	/* type_token_id */
	.word	33554472
	/* java_name */
	.ascii	"androidx/fragment/app/FragmentFactory"
	.zero	66
	.zero	3

	/* #283 */
	/* module_index */
	.word	7
	/* type_token_id */
	.word	33554473
	/* java_name */
	.ascii	"androidx/fragment/app/FragmentManager"
	.zero	66
	.zero	3

	/* #284 */
	/* module_index */
	.word	7
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/fragment/app/FragmentManager$BackStackEntry"
	.zero	51
	.zero	3

	/* #285 */
	/* module_index */
	.word	7
	/* type_token_id */
	.word	33554476
	/* java_name */
	.ascii	"androidx/fragment/app/FragmentManager$FragmentLifecycleCallbacks"
	.zero	39
	.zero	3

	/* #286 */
	/* module_index */
	.word	7
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/fragment/app/FragmentManager$OnBackStackChangedListener"
	.zero	39
	.zero	3

	/* #287 */
	/* module_index */
	.word	7
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/fragment/app/FragmentOnAttachListener"
	.zero	57
	.zero	3

	/* #288 */
	/* module_index */
	.word	7
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/fragment/app/FragmentResultListener"
	.zero	59
	.zero	3

	/* #289 */
	/* module_index */
	.word	7
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/fragment/app/FragmentResultOwner"
	.zero	62
	.zero	3

	/* #290 */
	/* module_index */
	.word	7
	/* type_token_id */
	.word	33554486
	/* java_name */
	.ascii	"androidx/fragment/app/FragmentTransaction"
	.zero	62
	.zero	3

	/* #291 */
	/* module_index */
	.word	6
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/lifecycle/HasDefaultViewModelProviderFactory"
	.zero	50
	.zero	3

	/* #292 */
	/* module_index */
	.word	4
	/* type_token_id */
	.word	33554436
	/* java_name */
	.ascii	"androidx/lifecycle/Lifecycle"
	.zero	75
	.zero	3

	/* #293 */
	/* module_index */
	.word	4
	/* type_token_id */
	.word	33554437
	/* java_name */
	.ascii	"androidx/lifecycle/Lifecycle$State"
	.zero	69
	.zero	3

	/* #294 */
	/* module_index */
	.word	4
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/lifecycle/LifecycleObserver"
	.zero	67
	.zero	3

	/* #295 */
	/* module_index */
	.word	4
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/lifecycle/LifecycleOwner"
	.zero	70
	.zero	3

	/* #296 */
	/* module_index */
	.word	12
	/* type_token_id */
	.word	33554441
	/* java_name */
	.ascii	"androidx/lifecycle/LiveData"
	.zero	76
	.zero	3

	/* #297 */
	/* module_index */
	.word	12
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/lifecycle/Observer"
	.zero	76
	.zero	3

	/* #298 */
	/* module_index */
	.word	6
	/* type_token_id */
	.word	33554441
	/* java_name */
	.ascii	"androidx/lifecycle/ViewModelProvider"
	.zero	67
	.zero	3

	/* #299 */
	/* module_index */
	.word	6
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/lifecycle/ViewModelProvider$Factory"
	.zero	59
	.zero	3

	/* #300 */
	/* module_index */
	.word	6
	/* type_token_id */
	.word	33554444
	/* java_name */
	.ascii	"androidx/lifecycle/ViewModelStore"
	.zero	70
	.zero	3

	/* #301 */
	/* module_index */
	.word	6
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/lifecycle/ViewModelStoreOwner"
	.zero	65
	.zero	3

	/* #302 */
	/* module_index */
	.word	8
	/* type_token_id */
	.word	33554452
	/* java_name */
	.ascii	"androidx/loader/app/LoaderManager"
	.zero	70
	.zero	3

	/* #303 */
	/* module_index */
	.word	8
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/loader/app/LoaderManager$LoaderCallbacks"
	.zero	54
	.zero	3

	/* #304 */
	/* module_index */
	.word	8
	/* type_token_id */
	.word	33554447
	/* java_name */
	.ascii	"androidx/loader/content/Loader"
	.zero	73
	.zero	3

	/* #305 */
	/* module_index */
	.word	8
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/loader/content/Loader$OnLoadCanceledListener"
	.zero	50
	.zero	3

	/* #306 */
	/* module_index */
	.word	8
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/loader/content/Loader$OnLoadCompleteListener"
	.zero	50
	.zero	3

	/* #307 */
	/* module_index */
	.word	19
	/* type_token_id */
	.word	33554505
	/* java_name */
	.ascii	"androidx/recyclerview/widget/ItemTouchHelper"
	.zero	59
	.zero	3

	/* #308 */
	/* module_index */
	.word	19
	/* type_token_id */
	.word	33554506
	/* java_name */
	.ascii	"androidx/recyclerview/widget/ItemTouchHelper$Callback"
	.zero	50
	.zero	3

	/* #309 */
	/* module_index */
	.word	19
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/recyclerview/widget/ItemTouchHelper$ViewDropHandler"
	.zero	43
	.zero	3

	/* #310 */
	/* module_index */
	.word	19
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/recyclerview/widget/ItemTouchUIUtil"
	.zero	59
	.zero	3

	/* #311 */
	/* module_index */
	.word	19
	/* type_token_id */
	.word	33554510
	/* java_name */
	.ascii	"androidx/recyclerview/widget/LinearLayoutManager"
	.zero	55
	.zero	3

	/* #312 */
	/* module_index */
	.word	19
	/* type_token_id */
	.word	33554511
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView"
	.zero	62
	.zero	3

	/* #313 */
	/* module_index */
	.word	19
	/* type_token_id */
	.word	33554512
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$Adapter"
	.zero	54
	.zero	3

	/* #314 */
	/* module_index */
	.word	19
	/* type_token_id */
	.word	33554513
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$Adapter$StateRestorationPolicy"
	.zero	31
	.zero	3

	/* #315 */
	/* module_index */
	.word	19
	/* type_token_id */
	.word	33554515
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$AdapterDataObserver"
	.zero	42
	.zero	3

	/* #316 */
	/* module_index */
	.word	19
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$ChildDrawingOrderCallback"
	.zero	36
	.zero	3

	/* #317 */
	/* module_index */
	.word	19
	/* type_token_id */
	.word	33554519
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$EdgeEffectFactory"
	.zero	44
	.zero	3

	/* #318 */
	/* module_index */
	.word	19
	/* type_token_id */
	.word	33554520
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$ItemAnimator"
	.zero	49
	.zero	3

	/* #319 */
	/* module_index */
	.word	19
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$ItemAnimator$ItemAnimatorFinishedListener"
	.zero	20
	.zero	3

	/* #320 */
	/* module_index */
	.word	19
	/* type_token_id */
	.word	33554523
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$ItemAnimator$ItemHolderInfo"
	.zero	34
	.zero	3

	/* #321 */
	/* module_index */
	.word	19
	/* type_token_id */
	.word	33554525
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$ItemDecoration"
	.zero	47
	.zero	3

	/* #322 */
	/* module_index */
	.word	19
	/* type_token_id */
	.word	33554527
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$LayoutManager"
	.zero	48
	.zero	3

	/* #323 */
	/* module_index */
	.word	19
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$LayoutManager$LayoutPrefetchRegistry"
	.zero	25
	.zero	3

	/* #324 */
	/* module_index */
	.word	19
	/* type_token_id */
	.word	33554530
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$LayoutManager$Properties"
	.zero	37
	.zero	3

	/* #325 */
	/* module_index */
	.word	19
	/* type_token_id */
	.word	33554532
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$LayoutParams"
	.zero	49
	.zero	3

	/* #326 */
	/* module_index */
	.word	19
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$OnChildAttachStateChangeListener"
	.zero	29
	.zero	3

	/* #327 */
	/* module_index */
	.word	19
	/* type_token_id */
	.word	33554538
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$OnFlingListener"
	.zero	46
	.zero	3

	/* #328 */
	/* module_index */
	.word	19
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$OnItemTouchListener"
	.zero	42
	.zero	3

	/* #329 */
	/* module_index */
	.word	19
	/* type_token_id */
	.word	33554546
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$OnScrollListener"
	.zero	45
	.zero	3

	/* #330 */
	/* module_index */
	.word	19
	/* type_token_id */
	.word	33554548
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$RecycledViewPool"
	.zero	45
	.zero	3

	/* #331 */
	/* module_index */
	.word	19
	/* type_token_id */
	.word	33554549
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$Recycler"
	.zero	53
	.zero	3

	/* #332 */
	/* module_index */
	.word	19
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$RecyclerListener"
	.zero	45
	.zero	3

	/* #333 */
	/* module_index */
	.word	19
	/* type_token_id */
	.word	33554554
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$SmoothScroller"
	.zero	47
	.zero	3

	/* #334 */
	/* module_index */
	.word	19
	/* type_token_id */
	.word	33554555
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$SmoothScroller$Action"
	.zero	40
	.zero	3

	/* #335 */
	/* module_index */
	.word	19
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$SmoothScroller$ScrollVectorProvider"
	.zero	26
	.zero	3

	/* #336 */
	/* module_index */
	.word	19
	/* type_token_id */
	.word	33554559
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$State"
	.zero	56
	.zero	3

	/* #337 */
	/* module_index */
	.word	19
	/* type_token_id */
	.word	33554560
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$ViewCacheExtension"
	.zero	43
	.zero	3

	/* #338 */
	/* module_index */
	.word	19
	/* type_token_id */
	.word	33554562
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$ViewHolder"
	.zero	51
	.zero	3

	/* #339 */
	/* module_index */
	.word	19
	/* type_token_id */
	.word	33554576
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerViewAccessibilityDelegate"
	.zero	41
	.zero	3

	/* #340 */
	/* module_index */
	.word	13
	/* type_token_id */
	.word	33554437
	/* java_name */
	.ascii	"androidx/savedstate/SavedStateRegistry"
	.zero	65
	.zero	3

	/* #341 */
	/* module_index */
	.word	13
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/savedstate/SavedStateRegistry$SavedStateProvider"
	.zero	46
	.zero	3

	/* #342 */
	/* module_index */
	.word	13
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"androidx/savedstate/SavedStateRegistryOwner"
	.zero	60
	.zero	3

	/* #343 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	33554472
	/* java_name */
	.ascii	"com/bumptech/glide/Glide"
	.zero	79
	.zero	3

	/* #344 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"com/bumptech/glide/Glide$RequestOptionsFactory"
	.zero	57
	.zero	3

	/* #345 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	33554475
	/* java_name */
	.ascii	"com/bumptech/glide/GlideBuilder"
	.zero	72
	.zero	3

	/* #346 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	33554476
	/* java_name */
	.ascii	"com/bumptech/glide/GlideExperiments"
	.zero	68
	.zero	3

	/* #347 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	33554477
	/* java_name */
	.ascii	"com/bumptech/glide/MemoryCategory"
	.zero	70
	.zero	3

	/* #348 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	33554478
	/* java_name */
	.ascii	"com/bumptech/glide/Priority"
	.zero	76
	.zero	3

	/* #349 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	33554479
	/* java_name */
	.ascii	"com/bumptech/glide/Registry"
	.zero	76
	.zero	3

	/* #350 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	33554471
	/* java_name */
	.ascii	"com/bumptech/glide/RequestBuilder"
	.zero	70
	.zero	3

	/* #351 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	33554480
	/* java_name */
	.ascii	"com/bumptech/glide/RequestManager"
	.zero	70
	.zero	3

	/* #352 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	33554481
	/* java_name */
	.ascii	"com/bumptech/glide/TransitionOptions"
	.zero	67
	.zero	3

	/* #353 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	33554524
	/* java_name */
	.ascii	"com/bumptech/glide/load/DataSource"
	.zero	69
	.zero	3

	/* #354 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	33554525
	/* java_name */
	.ascii	"com/bumptech/glide/load/DecodeFormat"
	.zero	67
	.zero	3

	/* #355 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	33554526
	/* java_name */
	.ascii	"com/bumptech/glide/load/EncodeStrategy"
	.zero	65
	.zero	3

	/* #356 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"com/bumptech/glide/load/Encoder"
	.zero	72
	.zero	3

	/* #357 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"com/bumptech/glide/load/ImageHeaderParser"
	.zero	62
	.zero	3

	/* #358 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	33554529
	/* java_name */
	.ascii	"com/bumptech/glide/load/ImageHeaderParser$ImageType"
	.zero	52
	.zero	3

	/* #359 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"com/bumptech/glide/load/Key"
	.zero	76
	.zero	3

	/* #360 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	33554540
	/* java_name */
	.ascii	"com/bumptech/glide/load/Option"
	.zero	73
	.zero	3

	/* #361 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"com/bumptech/glide/load/Option$CacheKeyUpdater"
	.zero	57
	.zero	3

	/* #362 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	33554543
	/* java_name */
	.ascii	"com/bumptech/glide/load/Options"
	.zero	72
	.zero	3

	/* #363 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"com/bumptech/glide/load/ResourceDecoder"
	.zero	64
	.zero	3

	/* #364 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"com/bumptech/glide/load/ResourceEncoder"
	.zero	64
	.zero	3

	/* #365 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"com/bumptech/glide/load/Transformation"
	.zero	65
	.zero	3

	/* #366 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"com/bumptech/glide/load/data/DataFetcher"
	.zero	63
	.zero	3

	/* #367 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"com/bumptech/glide/load/data/DataFetcher$DataCallback"
	.zero	50
	.zero	3

	/* #368 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"com/bumptech/glide/load/data/DataRewinder"
	.zero	62
	.zero	3

	/* #369 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"com/bumptech/glide/load/data/DataRewinder$Factory"
	.zero	54
	.zero	3

	/* #370 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	33554555
	/* java_name */
	.ascii	"com/bumptech/glide/load/engine/DiskCacheStrategy"
	.zero	55
	.zero	3

	/* #371 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	33554557
	/* java_name */
	.ascii	"com/bumptech/glide/load/engine/GlideException"
	.zero	58
	.zero	3

	/* #372 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	33554560
	/* java_name */
	.ascii	"com/bumptech/glide/load/engine/LoadPath"
	.zero	64
	.zero	3

	/* #373 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"com/bumptech/glide/load/engine/Resource"
	.zero	64
	.zero	3

	/* #374 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"com/bumptech/glide/load/engine/bitmap_recycle/ArrayPool"
	.zero	48
	.zero	3

	/* #375 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"com/bumptech/glide/load/engine/bitmap_recycle/BitmapPool"
	.zero	47
	.zero	3

	/* #376 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"com/bumptech/glide/load/engine/cache/DiskCache"
	.zero	57
	.zero	3

	/* #377 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"com/bumptech/glide/load/engine/cache/DiskCache$Factory"
	.zero	49
	.zero	3

	/* #378 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"com/bumptech/glide/load/engine/cache/DiskCache$Writer"
	.zero	50
	.zero	3

	/* #379 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"com/bumptech/glide/load/engine/cache/MemoryCache"
	.zero	55
	.zero	3

	/* #380 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"com/bumptech/glide/load/engine/cache/MemoryCache$ResourceRemovedListener"
	.zero	31
	.zero	3

	/* #381 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	33554573
	/* java_name */
	.ascii	"com/bumptech/glide/load/engine/cache/MemorySizeCalculator"
	.zero	46
	.zero	3

	/* #382 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	33554574
	/* java_name */
	.ascii	"com/bumptech/glide/load/engine/cache/MemorySizeCalculator$Builder"
	.zero	38
	.zero	3

	/* #383 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	33554579
	/* java_name */
	.ascii	"com/bumptech/glide/load/engine/executor/GlideExecutor"
	.zero	50
	.zero	3

	/* #384 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	33554580
	/* java_name */
	.ascii	"com/bumptech/glide/load/engine/executor/GlideExecutor$Builder"
	.zero	42
	.zero	3

	/* #385 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"com/bumptech/glide/load/engine/executor/GlideExecutor$UncaughtThrowableStrategy"
	.zero	24
	.zero	3

	/* #386 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	33554561
	/* java_name */
	.ascii	"com/bumptech/glide/load/engine/prefill/PreFillType"
	.zero	53
	.zero	3

	/* #387 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	33554562
	/* java_name */
	.ascii	"com/bumptech/glide/load/engine/prefill/PreFillType$Builder"
	.zero	45
	.zero	3

	/* #388 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"com/bumptech/glide/load/model/ModelLoader"
	.zero	62
	.zero	3

	/* #389 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	33554549
	/* java_name */
	.ascii	"com/bumptech/glide/load/model/ModelLoader$LoadData"
	.zero	53
	.zero	3

	/* #390 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"com/bumptech/glide/load/model/ModelLoaderFactory"
	.zero	55
	.zero	3

	/* #391 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	33554554
	/* java_name */
	.ascii	"com/bumptech/glide/load/model/MultiModelLoaderFactory"
	.zero	50
	.zero	3

	/* #392 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	33554546
	/* java_name */
	.ascii	"com/bumptech/glide/load/resource/bitmap/DownsampleStrategy"
	.zero	45
	.zero	3

	/* #393 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	33554547
	/* java_name */
	.ascii	"com/bumptech/glide/load/resource/bitmap/DownsampleStrategy$SampleSizeRounding"
	.zero	26
	.zero	3

	/* #394 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"com/bumptech/glide/load/resource/transcode/ResourceTranscoder"
	.zero	42
	.zero	3

	/* #395 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"com/bumptech/glide/manager/ConnectivityMonitor"
	.zero	57
	.zero	3

	/* #396 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"com/bumptech/glide/manager/ConnectivityMonitor$ConnectivityListener"
	.zero	36
	.zero	3

	/* #397 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"com/bumptech/glide/manager/ConnectivityMonitorFactory"
	.zero	50
	.zero	3

	/* #398 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"com/bumptech/glide/manager/Lifecycle"
	.zero	67
	.zero	3

	/* #399 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"com/bumptech/glide/manager/LifecycleListener"
	.zero	59
	.zero	3

	/* #400 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	33554495
	/* java_name */
	.ascii	"com/bumptech/glide/manager/RequestManagerRetriever"
	.zero	53
	.zero	3

	/* #401 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"com/bumptech/glide/manager/RequestManagerRetriever$RequestManagerFactory"
	.zero	31
	.zero	3

	/* #402 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"com/bumptech/glide/manager/RequestManagerTreeNode"
	.zero	54
	.zero	3

	/* #403 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	33554499
	/* java_name */
	.ascii	"com/bumptech/glide/request/BaseRequestOptions"
	.zero	58
	.zero	3

	/* #404 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"com/bumptech/glide/request/FutureTarget"
	.zero	64
	.zero	3

	/* #405 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"com/bumptech/glide/request/Request"
	.zero	69
	.zero	3

	/* #406 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"com/bumptech/glide/request/RequestListener"
	.zero	61
	.zero	3

	/* #407 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	33554498
	/* java_name */
	.ascii	"com/bumptech/glide/request/RequestOptions"
	.zero	62
	.zero	3

	/* #408 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	33554516
	/* java_name */
	.ascii	"com/bumptech/glide/request/target/BaseTarget"
	.zero	59
	.zero	3

	/* #409 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"com/bumptech/glide/request/target/SizeReadyCallback"
	.zero	52
	.zero	3

	/* #410 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"com/bumptech/glide/request/target/Target"
	.zero	63
	.zero	3

	/* #411 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	33554522
	/* java_name */
	.ascii	"com/bumptech/glide/request/target/ViewTarget"
	.zero	59
	.zero	3

	/* #412 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"com/bumptech/glide/request/transition/Transition"
	.zero	55
	.zero	3

	/* #413 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"com/bumptech/glide/request/transition/Transition$ViewAdapter"
	.zero	43
	.zero	3

	/* #414 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"com/bumptech/glide/request/transition/TransitionFactory"
	.zero	48
	.zero	3

	/* #415 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	33554513
	/* java_name */
	.ascii	"com/bumptech/glide/request/transition/ViewPropertyTransition"
	.zero	43
	.zero	3

	/* #416 */
	/* module_index */
	.word	3
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"com/bumptech/glide/request/transition/ViewPropertyTransition$Animator"
	.zero	34
	.zero	3

	/* #417 */
	/* module_index */
	.word	11
	/* type_token_id */
	.word	33554466
	/* java_name */
	.ascii	"com/google/android/material/animation/MotionSpec"
	.zero	55
	.zero	3

	/* #418 */
	/* module_index */
	.word	11
	/* type_token_id */
	.word	33554467
	/* java_name */
	.ascii	"com/google/android/material/animation/MotionTiming"
	.zero	53
	.zero	3

	/* #419 */
	/* module_index */
	.word	11
	/* type_token_id */
	.word	33554448
	/* java_name */
	.ascii	"com/google/android/material/behavior/SwipeDismissBehavior"
	.zero	46
	.zero	3

	/* #420 */
	/* module_index */
	.word	11
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"com/google/android/material/behavior/SwipeDismissBehavior$OnDismissListener"
	.zero	28
	.zero	3

	/* #421 */
	/* module_index */
	.word	11
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"com/google/android/material/expandable/ExpandableTransformationWidget"
	.zero	34
	.zero	3

	/* #422 */
	/* module_index */
	.word	11
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"com/google/android/material/expandable/ExpandableWidget"
	.zero	48
	.zero	3

	/* #423 */
	/* module_index */
	.word	11
	/* type_token_id */
	.word	33554441
	/* java_name */
	.ascii	"com/google/android/material/floatingactionbutton/FloatingActionButton"
	.zero	34
	.zero	3

	/* #424 */
	/* module_index */
	.word	11
	/* type_token_id */
	.word	33554442
	/* java_name */
	.ascii	"com/google/android/material/floatingactionbutton/FloatingActionButton$OnVisibilityChangedListener"
	.zero	6
	.zero	3

	/* #425 */
	/* module_index */
	.word	11
	/* type_token_id */
	.word	33554465
	/* java_name */
	.ascii	"com/google/android/material/internal/ScrimInsetsFrameLayout"
	.zero	44
	.zero	3

	/* #426 */
	/* module_index */
	.word	11
	/* type_token_id */
	.word	33554464
	/* java_name */
	.ascii	"com/google/android/material/internal/VisibilityAwareImageButton"
	.zero	40
	.zero	3

	/* #427 */
	/* module_index */
	.word	11
	/* type_token_id */
	.word	33554434
	/* java_name */
	.ascii	"com/google/android/material/navigation/NavigationView"
	.zero	50
	.zero	3

	/* #428 */
	/* module_index */
	.word	11
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"com/google/android/material/navigation/NavigationView$OnNavigationItemSelectedListener"
	.zero	17
	.zero	3

	/* #429 */
	/* module_index */
	.word	11
	/* type_token_id */
	.word	33554457
	/* java_name */
	.ascii	"com/google/android/material/snackbar/BaseTransientBottomBar"
	.zero	44
	.zero	3

	/* #430 */
	/* module_index */
	.word	11
	/* type_token_id */
	.word	33554458
	/* java_name */
	.ascii	"com/google/android/material/snackbar/BaseTransientBottomBar$BaseCallback"
	.zero	31
	.zero	3

	/* #431 */
	/* module_index */
	.word	11
	/* type_token_id */
	.word	33554460
	/* java_name */
	.ascii	"com/google/android/material/snackbar/BaseTransientBottomBar$Behavior"
	.zero	35
	.zero	3

	/* #432 */
	/* module_index */
	.word	11
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"com/google/android/material/snackbar/ContentViewCallback"
	.zero	47
	.zero	3

	/* #433 */
	/* module_index */
	.word	11
	/* type_token_id */
	.word	33554454
	/* java_name */
	.ascii	"com/google/android/material/snackbar/Snackbar"
	.zero	58
	.zero	3

	/* #434 */
	/* module_index */
	.word	11
	/* type_token_id */
	.word	33554456
	/* java_name */
	.ascii	"com/google/android/material/snackbar/Snackbar$Callback"
	.zero	49
	.zero	3

	/* #435 */
	/* module_index */
	.word	11
	/* type_token_id */
	.word	33554455
	/* java_name */
	.ascii	"com/google/android/material/snackbar/Snackbar_SnackbarActionClickImplementor"
	.zero	27
	.zero	3

	/* #436 */
	/* module_index */
	.word	15
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"com/google/common/util/concurrent/ListenableFuture"
	.zero	53
	.zero	3

	/* #437 */
	/* module_index */
	.word	9
	/* type_token_id */
	.word	33554462
	/* java_name */
	.ascii	"crc64101ab38e3d43aafd/ListOrdenDetalle"
	.zero	65
	.zero	3

	/* #438 */
	/* module_index */
	.word	9
	/* type_token_id */
	.word	33554464
	/* java_name */
	.ascii	"crc64101ab38e3d43aafd/ListOrden_Item"
	.zero	67
	.zero	3

	/* #439 */
	/* module_index */
	.word	9
	/* type_token_id */
	.word	33554463
	/* java_name */
	.ascii	"crc64101ab38e3d43aafd/ListTecnicos"
	.zero	69
	.zero	3

	/* #440 */
	/* module_index */
	.word	16
	/* type_token_id */
	.word	33554476
	/* java_name */
	.ascii	"crc64a0e0a82d0db9a07d/ActivityLifecycleContextListener"
	.zero	49
	.zero	3

	/* #441 */
	/* module_index */
	.word	16
	/* type_token_id */
	.word	33554472
	/* java_name */
	.ascii	"crc64a0e0a82d0db9a07d/ConnectivityBroadcastReceiver"
	.zero	52
	.zero	3

	/* #442 */
	/* module_index */
	.word	16
	/* type_token_id */
	.word	33554477
	/* java_name */
	.ascii	"crc64a0e0a82d0db9a07d/IntermediateActivity"
	.zero	61
	.zero	3

	/* #443 */
	/* module_index */
	.word	9
	/* type_token_id */
	.word	33554434
	/* java_name */
	.ascii	"crc64a1e84454907822fc/LoginActivity"
	.zero	68
	.zero	3

	/* #444 */
	/* module_index */
	.word	9
	/* type_token_id */
	.word	33554435
	/* java_name */
	.ascii	"crc64a1e84454907822fc/MainActivity"
	.zero	69
	.zero	3

	/* #445 */
	/* module_index */
	.word	17
	/* type_token_id */
	.word	33554434
	/* java_name */
	.ascii	"crc64a4453dc4d6b942b4/InkPresenter"
	.zero	69
	.zero	3

	/* #446 */
	/* module_index */
	.word	17
	/* type_token_id */
	.word	33554436
	/* java_name */
	.ascii	"crc64a4453dc4d6b942b4/SignaturePadCanvasView"
	.zero	59
	.zero	3

	/* #447 */
	/* module_index */
	.word	17
	/* type_token_id */
	.word	33554439
	/* java_name */
	.ascii	"crc64a4453dc4d6b942b4/SignaturePadView"
	.zero	65
	.zero	3

	/* #448 */
	/* module_index */
	.word	9
	/* type_token_id */
	.word	33554473
	/* java_name */
	.ascii	"crc64d818c4686ed024a0/Asignado_DialogF"
	.zero	65
	.zero	3

	/* #449 */
	/* module_index */
	.word	9
	/* type_token_id */
	.word	33554474
	/* java_name */
	.ascii	"crc64d818c4686ed024a0/Asignar_DialogF"
	.zero	66
	.zero	3

	/* #450 */
	/* module_index */
	.word	9
	/* type_token_id */
	.word	33554477
	/* java_name */
	.ascii	"crc64d818c4686ed024a0/NuevaOrden_Fragment"
	.zero	62
	.zero	3

	/* #451 */
	/* module_index */
	.word	9
	/* type_token_id */
	.word	33554479
	/* java_name */
	.ascii	"crc64d818c4686ed024a0/OrdenAsignada_Fragment"
	.zero	59
	.zero	3

	/* #452 */
	/* module_index */
	.word	9
	/* type_token_id */
	.word	33554475
	/* java_name */
	.ascii	"crc64d818c4686ed024a0/OrdenAtendida_Fragment"
	.zero	59
	.zero	3

	/* #453 */
	/* module_index */
	.word	9
	/* type_token_id */
	.word	33554476
	/* java_name */
	.ascii	"crc64d818c4686ed024a0/OrdenCerrada_Fragment"
	.zero	60
	.zero	3

	/* #454 */
	/* module_index */
	.word	9
	/* type_token_id */
	.word	33554478
	/* java_name */
	.ascii	"crc64d818c4686ed024a0/OrdenCreada_Fragment"
	.zero	61
	.zero	3

	/* #455 */
	/* module_index */
	.word	9
	/* type_token_id */
	.word	33554480
	/* java_name */
	.ascii	"crc64d818c4686ed024a0/OrdenProceso_Fragment"
	.zero	60
	.zero	3

	/* #456 */
	/* module_index */
	.word	9
	/* type_token_id */
	.word	33554481
	/* java_name */
	.ascii	"crc64d818c4686ed024a0/OrdenSolucionar0_Fragment"
	.zero	56
	.zero	3

	/* #457 */
	/* module_index */
	.word	9
	/* type_token_id */
	.word	33554482
	/* java_name */
	.ascii	"crc64d818c4686ed024a0/OrdenSolucionar_Fragment"
	.zero	57
	.zero	3

	/* #458 */
	/* module_index */
	.word	9
	/* type_token_id */
	.word	33554465
	/* java_name */
	.ascii	"crc64fac4dc6930c9ca92/ItemCliente_ac"
	.zero	67
	.zero	3

	/* #459 */
	/* module_index */
	.word	9
	/* type_token_id */
	.word	33554466
	/* java_name */
	.ascii	"crc64fac4dc6930c9ca92/ItemDispositivo_ac"
	.zero	63
	.zero	3

	/* #460 */
	/* module_index */
	.word	9
	/* type_token_id */
	.word	33554467
	/* java_name */
	.ascii	"crc64fac4dc6930c9ca92/ItemSucursal_ac"
	.zero	66
	.zero	3

	/* #461 */
	/* module_index */
	.word	9
	/* type_token_id */
	.word	33554468
	/* java_name */
	.ascii	"crc64fac4dc6930c9ca92/ListOrdenDetalle_Adapter"
	.zero	57
	.zero	3

	/* #462 */
	/* module_index */
	.word	9
	/* type_token_id */
	.word	33554469
	/* java_name */
	.ascii	"crc64fac4dc6930c9ca92/ListOrden_Adapter"
	.zero	64
	.zero	3

	/* #463 */
	/* module_index */
	.word	9
	/* type_token_id */
	.word	33554470
	/* java_name */
	.ascii	"crc64fac4dc6930c9ca92/ListTecnicos_Adapter"
	.zero	61
	.zero	3

	/* #464 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"java/io/Closeable"
	.zero	86
	.zero	3

	/* #465 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555114
	/* java_name */
	.ascii	"java/io/File"
	.zero	91
	.zero	3

	/* #466 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555115
	/* java_name */
	.ascii	"java/io/FileDescriptor"
	.zero	81
	.zero	3

	/* #467 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555116
	/* java_name */
	.ascii	"java/io/FileInputStream"
	.zero	80
	.zero	3

	/* #468 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"java/io/Flushable"
	.zero	86
	.zero	3

	/* #469 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555124
	/* java_name */
	.ascii	"java/io/IOException"
	.zero	84
	.zero	3

	/* #470 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555121
	/* java_name */
	.ascii	"java/io/InputStream"
	.zero	84
	.zero	3

	/* #471 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555123
	/* java_name */
	.ascii	"java/io/InterruptedIOException"
	.zero	73
	.zero	3

	/* #472 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555127
	/* java_name */
	.ascii	"java/io/OutputStream"
	.zero	83
	.zero	3

	/* #473 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555129
	/* java_name */
	.ascii	"java/io/PrintWriter"
	.zero	84
	.zero	3

	/* #474 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"java/io/Serializable"
	.zero	83
	.zero	3

	/* #475 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555130
	/* java_name */
	.ascii	"java/io/StringWriter"
	.zero	83
	.zero	3

	/* #476 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555131
	/* java_name */
	.ascii	"java/io/Writer"
	.zero	89
	.zero	3

	/* #477 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555073
	/* java_name */
	.ascii	"java/lang/AbstractMethodError"
	.zero	74
	.zero	3

	/* #478 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"java/lang/Appendable"
	.zero	83
	.zero	3

	/* #479 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555054
	/* java_name */
	.ascii	"java/lang/Boolean"
	.zero	86
	.zero	3

	/* #480 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555055
	/* java_name */
	.ascii	"java/lang/Byte"
	.zero	89
	.zero	3

	/* #481 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"java/lang/CharSequence"
	.zero	81
	.zero	3

	/* #482 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555056
	/* java_name */
	.ascii	"java/lang/Character"
	.zero	84
	.zero	3

	/* #483 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555057
	/* java_name */
	.ascii	"java/lang/Class"
	.zero	88
	.zero	3

	/* #484 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555074
	/* java_name */
	.ascii	"java/lang/ClassCastException"
	.zero	75
	.zero	3

	/* #485 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555075
	/* java_name */
	.ascii	"java/lang/ClassLoader"
	.zero	82
	.zero	3

	/* #486 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555058
	/* java_name */
	.ascii	"java/lang/ClassNotFoundException"
	.zero	71
	.zero	3

	/* #487 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"java/lang/Cloneable"
	.zero	84
	.zero	3

	/* #488 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"java/lang/Comparable"
	.zero	83
	.zero	3

	/* #489 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555059
	/* java_name */
	.ascii	"java/lang/Double"
	.zero	87
	.zero	3

	/* #490 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555077
	/* java_name */
	.ascii	"java/lang/Enum"
	.zero	89
	.zero	3

	/* #491 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555079
	/* java_name */
	.ascii	"java/lang/Error"
	.zero	88
	.zero	3

	/* #492 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555060
	/* java_name */
	.ascii	"java/lang/Exception"
	.zero	84
	.zero	3

	/* #493 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555061
	/* java_name */
	.ascii	"java/lang/Float"
	.zero	88
	.zero	3

	/* #494 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555090
	/* java_name */
	.ascii	"java/lang/IllegalArgumentException"
	.zero	69
	.zero	3

	/* #495 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555091
	/* java_name */
	.ascii	"java/lang/IllegalStateException"
	.zero	72
	.zero	3

	/* #496 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555092
	/* java_name */
	.ascii	"java/lang/IncompatibleClassChangeError"
	.zero	65
	.zero	3

	/* #497 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555093
	/* java_name */
	.ascii	"java/lang/IndexOutOfBoundsException"
	.zero	68
	.zero	3

	/* #498 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555063
	/* java_name */
	.ascii	"java/lang/Integer"
	.zero	86
	.zero	3

	/* #499 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"java/lang/Iterable"
	.zero	85
	.zero	3

	/* #500 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555096
	/* java_name */
	.ascii	"java/lang/LinkageError"
	.zero	81
	.zero	3

	/* #501 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555064
	/* java_name */
	.ascii	"java/lang/Long"
	.zero	89
	.zero	3

	/* #502 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555097
	/* java_name */
	.ascii	"java/lang/NoClassDefFoundError"
	.zero	73
	.zero	3

	/* #503 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555098
	/* java_name */
	.ascii	"java/lang/NullPointerException"
	.zero	73
	.zero	3

	/* #504 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555099
	/* java_name */
	.ascii	"java/lang/Number"
	.zero	87
	.zero	3

	/* #505 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555065
	/* java_name */
	.ascii	"java/lang/Object"
	.zero	87
	.zero	3

	/* #506 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555101
	/* java_name */
	.ascii	"java/lang/ReflectiveOperationException"
	.zero	65
	.zero	3

	/* #507 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"java/lang/Runnable"
	.zero	85
	.zero	3

	/* #508 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555066
	/* java_name */
	.ascii	"java/lang/RuntimeException"
	.zero	77
	.zero	3

	/* #509 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555102
	/* java_name */
	.ascii	"java/lang/SecurityException"
	.zero	76
	.zero	3

	/* #510 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555067
	/* java_name */
	.ascii	"java/lang/Short"
	.zero	88
	.zero	3

	/* #511 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555068
	/* java_name */
	.ascii	"java/lang/String"
	.zero	87
	.zero	3

	/* #512 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555070
	/* java_name */
	.ascii	"java/lang/Thread"
	.zero	87
	.zero	3

	/* #513 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555072
	/* java_name */
	.ascii	"java/lang/Throwable"
	.zero	84
	.zero	3

	/* #514 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555103
	/* java_name */
	.ascii	"java/lang/UnsupportedOperationException"
	.zero	64
	.zero	3

	/* #515 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"java/lang/annotation/Annotation"
	.zero	72
	.zero	3

	/* #516 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"java/lang/reflect/AnnotatedElement"
	.zero	69
	.zero	3

	/* #517 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"java/lang/reflect/GenericDeclaration"
	.zero	67
	.zero	3

	/* #518 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"java/lang/reflect/Type"
	.zero	81
	.zero	3

	/* #519 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"java/lang/reflect/TypeVariable"
	.zero	73
	.zero	3

	/* #520 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554963
	/* java_name */
	.ascii	"java/net/ConnectException"
	.zero	78
	.zero	3

	/* #521 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554965
	/* java_name */
	.ascii	"java/net/HttpURLConnection"
	.zero	77
	.zero	3

	/* #522 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554967
	/* java_name */
	.ascii	"java/net/InetSocketAddress"
	.zero	77
	.zero	3

	/* #523 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554968
	/* java_name */
	.ascii	"java/net/ProtocolException"
	.zero	77
	.zero	3

	/* #524 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554969
	/* java_name */
	.ascii	"java/net/Proxy"
	.zero	89
	.zero	3

	/* #525 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554970
	/* java_name */
	.ascii	"java/net/Proxy$Type"
	.zero	84
	.zero	3

	/* #526 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554971
	/* java_name */
	.ascii	"java/net/ProxySelector"
	.zero	81
	.zero	3

	/* #527 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554973
	/* java_name */
	.ascii	"java/net/SocketAddress"
	.zero	81
	.zero	3

	/* #528 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554975
	/* java_name */
	.ascii	"java/net/SocketException"
	.zero	79
	.zero	3

	/* #529 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554976
	/* java_name */
	.ascii	"java/net/SocketTimeoutException"
	.zero	72
	.zero	3

	/* #530 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554978
	/* java_name */
	.ascii	"java/net/URI"
	.zero	91
	.zero	3

	/* #531 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554979
	/* java_name */
	.ascii	"java/net/URL"
	.zero	91
	.zero	3

	/* #532 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554980
	/* java_name */
	.ascii	"java/net/URLConnection"
	.zero	81
	.zero	3

	/* #533 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554977
	/* java_name */
	.ascii	"java/net/UnknownServiceException"
	.zero	71
	.zero	3

	/* #534 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555030
	/* java_name */
	.ascii	"java/nio/Buffer"
	.zero	88
	.zero	3

	/* #535 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555032
	/* java_name */
	.ascii	"java/nio/ByteBuffer"
	.zero	84
	.zero	3

	/* #536 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"java/nio/channels/ByteChannel"
	.zero	74
	.zero	3

	/* #537 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"java/nio/channels/Channel"
	.zero	78
	.zero	3

	/* #538 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555034
	/* java_name */
	.ascii	"java/nio/channels/FileChannel"
	.zero	74
	.zero	3

	/* #539 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"java/nio/channels/GatheringByteChannel"
	.zero	65
	.zero	3

	/* #540 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"java/nio/channels/InterruptibleChannel"
	.zero	65
	.zero	3

	/* #541 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"java/nio/channels/ReadableByteChannel"
	.zero	66
	.zero	3

	/* #542 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"java/nio/channels/ScatteringByteChannel"
	.zero	64
	.zero	3

	/* #543 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"java/nio/channels/SeekableByteChannel"
	.zero	66
	.zero	3

	/* #544 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"java/nio/channels/WritableByteChannel"
	.zero	66
	.zero	3

	/* #545 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555052
	/* java_name */
	.ascii	"java/nio/channels/spi/AbstractInterruptibleChannel"
	.zero	53
	.zero	3

	/* #546 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555013
	/* java_name */
	.ascii	"java/security/KeyStore"
	.zero	81
	.zero	3

	/* #547 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"java/security/KeyStore$LoadStoreParameter"
	.zero	62
	.zero	3

	/* #548 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"java/security/KeyStore$ProtectionParameter"
	.zero	61
	.zero	3

	/* #549 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555018
	/* java_name */
	.ascii	"java/security/MessageDigest"
	.zero	76
	.zero	3

	/* #550 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555020
	/* java_name */
	.ascii	"java/security/MessageDigestSpi"
	.zero	73
	.zero	3

	/* #551 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"java/security/Principal"
	.zero	80
	.zero	3

	/* #552 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555022
	/* java_name */
	.ascii	"java/security/SecureRandom"
	.zero	77
	.zero	3

	/* #553 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555023
	/* java_name */
	.ascii	"java/security/cert/Certificate"
	.zero	73
	.zero	3

	/* #554 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555025
	/* java_name */
	.ascii	"java/security/cert/CertificateFactory"
	.zero	66
	.zero	3

	/* #555 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555028
	/* java_name */
	.ascii	"java/security/cert/X509Certificate"
	.zero	69
	.zero	3

	/* #556 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"java/security/cert/X509Extension"
	.zero	71
	.zero	3

	/* #557 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554931
	/* java_name */
	.ascii	"java/util/ArrayList"
	.zero	84
	.zero	3

	/* #558 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554920
	/* java_name */
	.ascii	"java/util/Collection"
	.zero	83
	.zero	3

	/* #559 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"java/util/Comparator"
	.zero	83
	.zero	3

	/* #560 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"java/util/Enumeration"
	.zero	82
	.zero	3

	/* #561 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554922
	/* java_name */
	.ascii	"java/util/HashMap"
	.zero	86
	.zero	3

	/* #562 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554940
	/* java_name */
	.ascii	"java/util/HashSet"
	.zero	86
	.zero	3

	/* #563 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"java/util/Iterator"
	.zero	85
	.zero	3

	/* #564 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554990
	/* java_name */
	.ascii	"java/util/Random"
	.zero	87
	.zero	3

	/* #565 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"java/util/Spliterator"
	.zero	82
	.zero	3

	/* #566 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"java/util/concurrent/Callable"
	.zero	74
	.zero	3

	/* #567 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"java/util/concurrent/Executor"
	.zero	74
	.zero	3

	/* #568 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"java/util/concurrent/ExecutorService"
	.zero	67
	.zero	3

	/* #569 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"java/util/concurrent/Future"
	.zero	76
	.zero	3

	/* #570 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555010
	/* java_name */
	.ascii	"java/util/concurrent/TimeUnit"
	.zero	74
	.zero	3

	/* #571 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"java/util/function/Consumer"
	.zero	76
	.zero	3

	/* #572 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"java/util/function/Function"
	.zero	76
	.zero	3

	/* #573 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"java/util/function/ToDoubleFunction"
	.zero	68
	.zero	3

	/* #574 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"java/util/function/ToIntFunction"
	.zero	71
	.zero	3

	/* #575 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"java/util/function/ToLongFunction"
	.zero	70
	.zero	3

	/* #576 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554571
	/* java_name */
	.ascii	"javax/net/SocketFactory"
	.zero	80
	.zero	3

	/* #577 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"javax/net/ssl/HostnameVerifier"
	.zero	73
	.zero	3

	/* #578 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554573
	/* java_name */
	.ascii	"javax/net/ssl/HttpsURLConnection"
	.zero	71
	.zero	3

	/* #579 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"javax/net/ssl/KeyManager"
	.zero	79
	.zero	3

	/* #580 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554587
	/* java_name */
	.ascii	"javax/net/ssl/KeyManagerFactory"
	.zero	72
	.zero	3

	/* #581 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554588
	/* java_name */
	.ascii	"javax/net/ssl/SSLContext"
	.zero	79
	.zero	3

	/* #582 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"javax/net/ssl/SSLSession"
	.zero	79
	.zero	3

	/* #583 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"javax/net/ssl/SSLSessionContext"
	.zero	72
	.zero	3

	/* #584 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554589
	/* java_name */
	.ascii	"javax/net/ssl/SSLSocketFactory"
	.zero	73
	.zero	3

	/* #585 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"javax/net/ssl/TrustManager"
	.zero	77
	.zero	3

	/* #586 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554591
	/* java_name */
	.ascii	"javax/net/ssl/TrustManagerFactory"
	.zero	70
	.zero	3

	/* #587 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"javax/net/ssl/X509TrustManager"
	.zero	73
	.zero	3

	/* #588 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554570
	/* java_name */
	.ascii	"javax/security/auth/Subject"
	.zero	76
	.zero	3

	/* #589 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554566
	/* java_name */
	.ascii	"javax/security/cert/Certificate"
	.zero	72
	.zero	3

	/* #590 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554568
	/* java_name */
	.ascii	"javax/security/cert/X509Certificate"
	.zero	68
	.zero	3

	/* #591 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555154
	/* java_name */
	.ascii	"mono/android/TypeManager"
	.zero	79
	.zero	3

	/* #592 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554865
	/* java_name */
	.ascii	"mono/android/content/DialogInterface_OnClickListenerImplementor"
	.zero	40
	.zero	3

	/* #593 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554916
	/* java_name */
	.ascii	"mono/android/runtime/InputStreamAdapter"
	.zero	64
	.zero	3

	/* #594 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"mono/android/runtime/JavaArray"
	.zero	73
	.zero	3

	/* #595 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554937
	/* java_name */
	.ascii	"mono/android/runtime/JavaObject"
	.zero	72
	.zero	3

	/* #596 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554955
	/* java_name */
	.ascii	"mono/android/runtime/OutputStreamAdapter"
	.zero	63
	.zero	3

	/* #597 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554660
	/* java_name */
	.ascii	"mono/android/view/View_OnClickListenerImplementor"
	.zero	54
	.zero	3

	/* #598 */
	/* module_index */
	.word	10
	/* type_token_id */
	.word	33554455
	/* java_name */
	.ascii	"mono/androidx/activity/contextaware/OnContextAvailableListenerImplementor"
	.zero	30
	.zero	3

	/* #599 */
	/* module_index */
	.word	14
	/* type_token_id */
	.word	33554479
	/* java_name */
	.ascii	"mono/androidx/appcompat/app/ActionBar_OnMenuVisibilityListenerImplementor"
	.zero	30
	.zero	3

	/* #600 */
	/* module_index */
	.word	14
	/* type_token_id */
	.word	33554505
	/* java_name */
	.ascii	"mono/androidx/appcompat/widget/Toolbar_OnMenuItemClickListenerImplementor"
	.zero	30
	.zero	3

	/* #601 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	33554535
	/* java_name */
	.ascii	"mono/androidx/core/view/ActionProvider_SubUiVisibilityListenerImplementor"
	.zero	30
	.zero	3

	/* #602 */
	/* module_index */
	.word	18
	/* type_token_id */
	.word	33554539
	/* java_name */
	.ascii	"mono/androidx/core/view/ActionProvider_VisibilityListenerImplementor"
	.zero	35
	.zero	3

	/* #603 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554461
	/* java_name */
	.ascii	"mono/androidx/drawerlayout/widget/DrawerLayout_DrawerListenerImplementor"
	.zero	31
	.zero	3

	/* #604 */
	/* module_index */
	.word	7
	/* type_token_id */
	.word	33554480
	/* java_name */
	.ascii	"mono/androidx/fragment/app/FragmentManager_OnBackStackChangedListenerImplementor"
	.zero	23
	.zero	3

	/* #605 */
	/* module_index */
	.word	7
	/* type_token_id */
	.word	33554491
	/* java_name */
	.ascii	"mono/androidx/fragment/app/FragmentOnAttachListenerImplementor"
	.zero	41
	.zero	3

	/* #606 */
	/* module_index */
	.word	19
	/* type_token_id */
	.word	33554537
	/* java_name */
	.ascii	"mono/androidx/recyclerview/widget/RecyclerView_OnChildAttachStateChangeListenerImplementor"
	.zero	13
	.zero	3

	/* #607 */
	/* module_index */
	.word	19
	/* type_token_id */
	.word	33554545
	/* java_name */
	.ascii	"mono/androidx/recyclerview/widget/RecyclerView_OnItemTouchListenerImplementor"
	.zero	26
	.zero	3

	/* #608 */
	/* module_index */
	.word	19
	/* type_token_id */
	.word	33554553
	/* java_name */
	.ascii	"mono/androidx/recyclerview/widget/RecyclerView_RecyclerListenerImplementor"
	.zero	29
	.zero	3

	/* #609 */
	/* module_index */
	.word	11
	/* type_token_id */
	.word	33554453
	/* java_name */
	.ascii	"mono/com/google/android/material/behavior/SwipeDismissBehavior_OnDismissListenerImplementor"
	.zero	12
	.zero	3

	/* #610 */
	/* module_index */
	.word	11
	/* type_token_id */
	.word	33554438
	/* java_name */
	.ascii	"mono/com/google/android/material/navigation/NavigationView_OnNavigationItemSelectedListenerImplementor"
	.zero	1
	.zero	3

	/* #611 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33555071
	/* java_name */
	.ascii	"mono/java/lang/RunnableImplementor"
	.zero	69
	.zero	3

	/* #612 */
	/* module_index */
	.word	5
	/* type_token_id */
	.word	33554565
	/* java_name */
	.ascii	"xamarin/android/net/OldAndroidSSLSocketFactory"
	.zero	57
	.zero	3

	/* #613 */
	/* module_index */
	.word	16
	/* type_token_id */
	.word	33554479
	/* java_name */
	.ascii	"xamarin/essentials/fileProvider"
	.zero	72
	.zero	3

	.size	map_java, 69996
/* Java to managed map: END */


/* java_name_width: START */
	.section	.rodata.java_name_width,"a",@progbits
	.type	java_name_width, @object
	.p2align	2
	.global	java_name_width
java_name_width:
	.size	java_name_width, 4
	.word	106
/* java_name_width: END */
