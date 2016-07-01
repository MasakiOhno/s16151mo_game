#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <cstring>
#include <string.h>
#include <stdio.h>
#include <cmath>
#include <limits>
#include <assert.h>

// GameManager
struct GameManager_t2369589051;

#include "class-internals.h"
#include "codegen/il2cpp-codegen.h"
#include "mscorlib_System_Array2840145358.h"
#include "AssemblyU2DCSharp_U3CModuleU3E86524790.h"
#include "AssemblyU2DCSharp_U3CModuleU3E86524790MethodDeclarations.h"
#include "AssemblyU2DCSharp_GameManager2369589051.h"
#include "AssemblyU2DCSharp_GameManager2369589051MethodDeclarations.h"
#include "mscorlib_System_Void2779279689.h"
#include "UnityEngine_UnityEngine_MonoBehaviour3012272455MethodDeclarations.h"
#include "mscorlib_System_Int322847414787.h"
#include "mscorlib_System_Single958209021.h"
#include "mscorlib_System_String968488902.h"
#include "UnityEngine_UnityEngine_Time1525492538MethodDeclarations.h"
#include "mscorlib_System_String968488902MethodDeclarations.h"
#include "UnityEngine_UI_UnityEngine_UI_Text3286458198.h"
#include "mscorlib_System_Object837106420.h"
#include "UnityEngine_UI_UnityEngine_UI_Text3286458198MethodDeclarations.h"
#include "UnityEngine_UI_UnityEngine_UI_Toggle1499417981MethodDeclarations.h"
#include "UnityEngine_UnityEngine_Random3963434288MethodDeclarations.h"
#include "UnityEngine_UI_UnityEngine_UI_Toggle1499417981.h"
#include "mscorlib_System_Boolean211005341.h"
#include "UnityEngine_UI_UnityEngine_UI_Scrollbar1410649103MethodDeclarations.h"
#include "UnityEngine_UnityEngine_Color1588175760MethodDeclarations.h"
#include "UnityEngine_UI_UnityEngine_UI_Graphic933884113MethodDeclarations.h"
#include "UnityEngine_UI_UnityEngine_UI_Slider1468074762.h"
#include "UnityEngine_UI_UnityEngine_UI_Slider1468074762MethodDeclarations.h"
#include "UnityEngine_UI_UnityEngine_UI_Scrollbar1410649103.h"
#include "UnityEngine_UnityEngine_Color1588175760.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void GameManager::.ctor()
extern "C"  void GameManager__ctor_m4112277136 (GameManager_t2369589051 * __this, const MethodInfo* method)
{
	{
		MonoBehaviour__ctor_m2022291967(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void GameManager::Start()
extern Il2CppCodeGenString* _stringLiteral1722775630;
extern const uint32_t GameManager_Start_m3059414928_MetadataUsageId;
extern "C"  void GameManager_Start_m3059414928 (GameManager_t2369589051 * __this, const MethodInfo* method)
{
	static bool s_Il2CppMethodIntialized;
	if (!s_Il2CppMethodIntialized)
	{
		il2cpp_codegen_initialize_method (GameManager_Start_m3059414928_MetadataUsageId);
		s_Il2CppMethodIntialized = true;
	}
	{
		__this->set_score_10(0);
		__this->set_time_11((20.0f));
		__this->set_pname_12(_stringLiteral1722775630);
		return;
	}
}
// System.Void GameManager::Update()
extern TypeInfo* Int32_t2847414787_il2cpp_TypeInfo_var;
extern TypeInfo* Single_t958209021_il2cpp_TypeInfo_var;
extern TypeInfo* String_t_il2cpp_TypeInfo_var;
extern Il2CppCodeGenString* _stringLiteral1753338710;
extern Il2CppCodeGenString* _stringLiteral3701140426;
extern const uint32_t GameManager_Update_m358434429_MetadataUsageId;
extern "C"  void GameManager_Update_m358434429 (GameManager_t2369589051 * __this, const MethodInfo* method)
{
	static bool s_Il2CppMethodIntialized;
	if (!s_Il2CppMethodIntialized)
	{
		il2cpp_codegen_initialize_method (GameManager_Update_m358434429_MetadataUsageId);
		s_Il2CppMethodIntialized = true;
	}
	{
		float L_0 = __this->get_time_11();
		float L_1 = Time_get_deltaTime_m2741110510(NULL /*static, unused*/, /*hidden argument*/NULL);
		__this->set_time_11(((float)((float)L_0-(float)L_1)));
		float L_2 = __this->get_time_11();
		if ((!(((float)L_2) >= ((float)(0.0f)))))
		{
			goto IL_005d;
		}
	}
	{
		Text_t3286458198 * L_3 = __this->get_t_2();
		String_t* L_4 = __this->get_pname_12();
		int32_t L_5 = __this->get_score_10();
		int32_t L_6 = L_5;
		Il2CppObject * L_7 = Box(Int32_t2847414787_il2cpp_TypeInfo_var, &L_6);
		float L_8 = __this->get_time_11();
		float L_9 = L_8;
		Il2CppObject * L_10 = Box(Single_t958209021_il2cpp_TypeInfo_var, &L_9);
		IL2CPP_RUNTIME_CLASS_INIT(String_t_il2cpp_TypeInfo_var);
		String_t* L_11 = String_Format_m2398979370(NULL /*static, unused*/, _stringLiteral1753338710, L_7, L_10, /*hidden argument*/NULL);
		String_t* L_12 = String_Concat_m138640077(NULL /*static, unused*/, L_4, L_11, /*hidden argument*/NULL);
		NullCheck(L_3);
		VirtActionInvoker1< String_t* >::Invoke(65 /* System.Void UnityEngine.UI.Text::set_text(System.String) */, L_3, L_12);
		goto IL_0088;
	}

IL_005d:
	{
		Text_t3286458198 * L_13 = __this->get_t_2();
		String_t* L_14 = __this->get_pname_12();
		int32_t L_15 = __this->get_score_10();
		int32_t L_16 = L_15;
		Il2CppObject * L_17 = Box(Int32_t2847414787_il2cpp_TypeInfo_var, &L_16);
		IL2CPP_RUNTIME_CLASS_INIT(String_t_il2cpp_TypeInfo_var);
		String_t* L_18 = String_Format_m2471250780(NULL /*static, unused*/, _stringLiteral3701140426, L_17, /*hidden argument*/NULL);
		String_t* L_19 = String_Concat_m138640077(NULL /*static, unused*/, L_14, L_18, /*hidden argument*/NULL);
		NullCheck(L_13);
		VirtActionInvoker1< String_t* >::Invoke(65 /* System.Void UnityEngine.UI.Text::set_text(System.String) */, L_13, L_19);
	}

IL_0088:
	{
		return;
	}
}
// System.Void GameManager::ToggleChanged()
extern "C"  void GameManager_ToggleChanged_m4202508142 (GameManager_t2369589051 * __this, const MethodInfo* method)
{
	int32_t V_0 = 0;
	{
		Toggle_t1499417981 * L_0 = __this->get_tg_3();
		NullCheck(L_0);
		bool L_1 = Toggle_get_isOn_m2105608497(L_0, /*hidden argument*/NULL);
		if (L_1)
		{
			goto IL_008e;
		}
	}
	{
		Toggle_t1499417981 * L_2 = __this->get_tg1_4();
		NullCheck(L_2);
		bool L_3 = Toggle_get_isOn_m2105608497(L_2, /*hidden argument*/NULL);
		if (L_3)
		{
			goto IL_008e;
		}
	}
	{
		Toggle_t1499417981 * L_4 = __this->get_tg2_5();
		NullCheck(L_4);
		bool L_5 = Toggle_get_isOn_m2105608497(L_4, /*hidden argument*/NULL);
		if (L_5)
		{
			goto IL_008e;
		}
	}
	{
		float L_6 = __this->get_time_11();
		if ((!(((float)L_6) >= ((float)(0.0f)))))
		{
			goto IL_004e;
		}
	}
	{
		int32_t L_7 = __this->get_score_10();
		__this->set_score_10(((int32_t)((int32_t)L_7+(int32_t)1)));
	}

IL_004e:
	{
		int32_t L_8 = Random_Range_m75452833(NULL /*static, unused*/, 0, 3, /*hidden argument*/NULL);
		V_0 = L_8;
		int32_t L_9 = V_0;
		if (L_9)
		{
			goto IL_0068;
		}
	}
	{
		Toggle_t1499417981 * L_10 = __this->get_tg_3();
		NullCheck(L_10);
		Toggle_set_isOn_m3467664234(L_10, (bool)1, /*hidden argument*/NULL);
	}

IL_0068:
	{
		int32_t L_11 = V_0;
		if ((!(((uint32_t)L_11) == ((uint32_t)1))))
		{
			goto IL_007b;
		}
	}
	{
		Toggle_t1499417981 * L_12 = __this->get_tg1_4();
		NullCheck(L_12);
		Toggle_set_isOn_m3467664234(L_12, (bool)1, /*hidden argument*/NULL);
	}

IL_007b:
	{
		int32_t L_13 = V_0;
		if ((!(((uint32_t)L_13) == ((uint32_t)2))))
		{
			goto IL_008e;
		}
	}
	{
		Toggle_t1499417981 * L_14 = __this->get_tg2_5();
		NullCheck(L_14);
		Toggle_set_isOn_m3467664234(L_14, (bool)1, /*hidden argument*/NULL);
	}

IL_008e:
	{
		return;
	}
}
// System.Void GameManager::SetColor()
extern "C"  void GameManager_SetColor_m783652629 (GameManager_t2369589051 * __this, const MethodInfo* method)
{
	{
		Text_t3286458198 * L_0 = __this->get_t_2();
		Slider_t1468074762 * L_1 = __this->get_sl_6();
		NullCheck(L_1);
		float L_2 = VirtFuncInvoker0< float >::Invoke(45 /* System.Single UnityEngine.UI.Slider::get_value() */, L_1);
		Scrollbar_t1410649103 * L_3 = __this->get_sc_7();
		NullCheck(L_3);
		float L_4 = Scrollbar_get_value_m3398262479(L_3, /*hidden argument*/NULL);
		Scrollbar_t1410649103 * L_5 = __this->get_sc1_8();
		NullCheck(L_5);
		float L_6 = Scrollbar_get_value_m3398262479(L_5, /*hidden argument*/NULL);
		Color_t1588175760  L_7;
		memset(&L_7, 0, sizeof(L_7));
		Color__ctor_m103496991(&L_7, L_2, L_4, L_6, /*hidden argument*/NULL);
		NullCheck(L_0);
		Graphic_set_color_m1311501487(L_0, L_7, /*hidden argument*/NULL);
		return;
	}
}
// System.Void GameManager::SetName()
extern "C"  void GameManager_SetName_m604383035 (GameManager_t2369589051 * __this, const MethodInfo* method)
{
	{
		Text_t3286458198 * L_0 = __this->get_inputtext_9();
		NullCheck(L_0);
		String_t* L_1 = VirtFuncInvoker0< String_t* >::Invoke(64 /* System.String UnityEngine.UI.Text::get_text() */, L_0);
		__this->set_pname_12(L_1);
		__this->set_score_10(0);
		__this->set_time_11((20.0f));
		Toggle_t1499417981 * L_2 = __this->get_tg_3();
		NullCheck(L_2);
		Toggle_set_isOn_m3467664234(L_2, (bool)1, /*hidden argument*/NULL);
		Toggle_t1499417981 * L_3 = __this->get_tg1_4();
		NullCheck(L_3);
		Toggle_set_isOn_m3467664234(L_3, (bool)1, /*hidden argument*/NULL);
		Toggle_t1499417981 * L_4 = __this->get_tg2_5();
		NullCheck(L_4);
		Toggle_set_isOn_m3467664234(L_4, (bool)1, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
