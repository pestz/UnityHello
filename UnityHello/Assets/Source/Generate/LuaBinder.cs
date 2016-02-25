﻿using System;
using UnityEngine;
using LuaInterface;

public static class LuaBinder
{
	public static void Bind(LuaState L)
	{
		float t = Time.realtimeSinceStartup;
		L.BeginModule(null);
		DebuggerWrap.Register(L);
		UILayerWrap.Register(L);
		GameResFactoryWrap.Register(L);
		LayerBaseWrap.Register(L);
		L.BeginModule("UnityEngine");
		UnityEngine_ComponentWrap.Register(L);
		UnityEngine_BehaviourWrap.Register(L);
		UnityEngine_MonoBehaviourWrap.Register(L);
		UnityEngine_GameObjectWrap.Register(L);
		UnityEngine_TransformWrap.Register(L);
		UnityEngine_SpaceWrap.Register(L);
		UnityEngine_CameraWrap.Register(L);
		UnityEngine_CameraClearFlagsWrap.Register(L);
		UnityEngine_MaterialWrap.Register(L);
		UnityEngine_RendererWrap.Register(L);
		UnityEngine_MeshRendererWrap.Register(L);
		UnityEngine_SkinnedMeshRendererWrap.Register(L);
		UnityEngine_LightWrap.Register(L);
		UnityEngine_LightTypeWrap.Register(L);
		UnityEngine_ParticleEmitterWrap.Register(L);
		UnityEngine_ParticleRendererWrap.Register(L);
		UnityEngine_ParticleAnimatorWrap.Register(L);
		UnityEngine_ParticleSystemWrap.Register(L);
		UnityEngine_PhysicsWrap.Register(L);
		UnityEngine_ColliderWrap.Register(L);
		UnityEngine_BoxColliderWrap.Register(L);
		UnityEngine_MeshColliderWrap.Register(L);
		UnityEngine_SphereColliderWrap.Register(L);
		UnityEngine_CharacterControllerWrap.Register(L);
		UnityEngine_AnimationWrap.Register(L);
		UnityEngine_AnimationClipWrap.Register(L);
		UnityEngine_TrackedReferenceWrap.Register(L);
		UnityEngine_AnimationStateWrap.Register(L);
		UnityEngine_QueueModeWrap.Register(L);
		UnityEngine_PlayModeWrap.Register(L);
		UnityEngine_AudioClipWrap.Register(L);
		UnityEngine_AudioSourceWrap.Register(L);
		UnityEngine_ApplicationWrap.Register(L);
		UnityEngine_InputWrap.Register(L);
		UnityEngine_KeyCodeWrap.Register(L);
		UnityEngine_ScreenWrap.Register(L);
		UnityEngine_TimeWrap.Register(L);
		UnityEngine_RenderSettingsWrap.Register(L);
		UnityEngine_SleepTimeoutWrap.Register(L);
		UnityEngine_AsyncOperationWrap.Register(L);
		UnityEngine_AssetBundleWrap.Register(L);
		UnityEngine_BlendWeightsWrap.Register(L);
		UnityEngine_QualitySettingsWrap.Register(L);
		UnityEngine_AnimationBlendModeWrap.Register(L);
		UnityEngine_RenderTextureWrap.Register(L);
		UnityEngine_RigidbodyWrap.Register(L);
		UnityEngine_CapsuleColliderWrap.Register(L);
		UnityEngine_WrapModeWrap.Register(L);
		UnityEngine_TextureWrap.Register(L);
		UnityEngine_ShaderWrap.Register(L);
		UnityEngine_Texture2DWrap.Register(L);
		UnityEngine_WWWWrap.Register(L);
		UnityEngine_RectTransformWrap.Register(L);
		L.BeginModule("UI");
		UnityEngine_UI_ImageWrap.Register(L);
		UnityEngine_UI_ButtonWrap.Register(L);
		UnityEngine_UI_TextWrap.Register(L);
		UnityEngine_UI_MaskableGraphicWrap.Register(L);
		UnityEngine_UI_GraphicWrap.Register(L);
		UnityEngine_UI_SelectableWrap.Register(L);
		L.EndModule();
		L.BeginModule("EventSystems");
		UnityEngine_EventSystems_UIBehaviourWrap.Register(L);
		L.EndModule();
		L.EndModule();
		L.EndModule();
		Debugger.Log("Register lua type cost time: {0}", Time.realtimeSinceStartup - t);
	}
}

