// WARNING - AUTOGENERATED - DO NOT EDIT
// 
// Generated using `sharpie urho`
// 
// AttributeAccessor.cs
// 
// Copyright 2015 Xamarin Inc. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using Urho.Urho2D;
using Urho.Gui;
using Urho.Resources;
using Urho.IO;
using Urho.Navigation;
using Urho.Network;

namespace Urho
{
	/// <summary>
	/// Abstract base class for invoking attribute accessors.
	/// </summary>
	public unsafe partial class AttributeAccessor : RefCounted
	{
		public AttributeAccessor (IntPtr handle) : base (handle)
		{
		}

		protected AttributeAccessor (UrhoObjectFlag emptyFlag) : base (emptyFlag)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void AttributeAccessor_Set0 (IntPtr handle, IntPtr ptr, ref Vector3 src);

		/// <summary>
		/// Set the attribute.
		/// </summary>
		public void Set (Serializable ptr, Vector3 src)
		{
			Runtime.ValidateRefCounted (this);
			AttributeAccessor_Set0 (handle, (object)ptr == null ? IntPtr.Zero : ptr.Handle, ref src);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void AttributeAccessor_Set1 (IntPtr handle, IntPtr ptr, ref IntRect src);

		/// <summary>
		/// Set the attribute.
		/// </summary>
		public void Set (Serializable ptr, IntRect src)
		{
			Runtime.ValidateRefCounted (this);
			AttributeAccessor_Set1 (handle, (object)ptr == null ? IntPtr.Zero : ptr.Handle, ref src);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void AttributeAccessor_Set2 (IntPtr handle, IntPtr ptr, ref Color src);

		/// <summary>
		/// Set the attribute.
		/// </summary>
		public void Set (Serializable ptr, Color src)
		{
			Runtime.ValidateRefCounted (this);
			AttributeAccessor_Set2 (handle, (object)ptr == null ? IntPtr.Zero : ptr.Handle, ref src);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void AttributeAccessor_Set3 (IntPtr handle, IntPtr ptr, ref Vector2 src);

		/// <summary>
		/// Set the attribute.
		/// </summary>
		public void Set (Serializable ptr, Vector2 src)
		{
			Runtime.ValidateRefCounted (this);
			AttributeAccessor_Set3 (handle, (object)ptr == null ? IntPtr.Zero : ptr.Handle, ref src);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void AttributeAccessor_Set4 (IntPtr handle, IntPtr ptr, ref Vector4 src);

		/// <summary>
		/// Set the attribute.
		/// </summary>
		public void Set (Serializable ptr, Vector4 src)
		{
			Runtime.ValidateRefCounted (this);
			AttributeAccessor_Set4 (handle, (object)ptr == null ? IntPtr.Zero : ptr.Handle, ref src);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void AttributeAccessor_Set5 (IntPtr handle, IntPtr ptr, ref IntVector2 src);

		/// <summary>
		/// Set the attribute.
		/// </summary>
		public void Set (Serializable ptr, IntVector2 src)
		{
			Runtime.ValidateRefCounted (this);
			AttributeAccessor_Set5 (handle, (object)ptr == null ? IntPtr.Zero : ptr.Handle, ref src);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void AttributeAccessor_Set6 (IntPtr handle, IntPtr ptr, ref Quaternion src);

		/// <summary>
		/// Set the attribute.
		/// </summary>
		public void Set (Serializable ptr, Quaternion src)
		{
			Runtime.ValidateRefCounted (this);
			AttributeAccessor_Set6 (handle, (object)ptr == null ? IntPtr.Zero : ptr.Handle, ref src);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void AttributeAccessor_Set7 (IntPtr handle, IntPtr ptr, ref Matrix4 src);

		/// <summary>
		/// Set the attribute.
		/// </summary>
		public void Set (Serializable ptr, Matrix4 src)
		{
			Runtime.ValidateRefCounted (this);
			AttributeAccessor_Set7 (handle, (object)ptr == null ? IntPtr.Zero : ptr.Handle, ref src);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void AttributeAccessor_Set8 (IntPtr handle, IntPtr ptr, ref Matrix3x4 src);

		/// <summary>
		/// Set the attribute.
		/// </summary>
		public void Set (Serializable ptr, Matrix3x4 src)
		{
			Runtime.ValidateRefCounted (this);
			AttributeAccessor_Set8 (handle, (object)ptr == null ? IntPtr.Zero : ptr.Handle, ref src);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void AttributeAccessor_Set9 (IntPtr handle, IntPtr ptr, int src);

		/// <summary>
		/// Set the attribute.
		/// </summary>
		public void Set (Serializable ptr, int src)
		{
			Runtime.ValidateRefCounted (this);
			AttributeAccessor_Set9 (handle, (object)ptr == null ? IntPtr.Zero : ptr.Handle, src);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void AttributeAccessor_Set10 (IntPtr handle, IntPtr ptr, float src);

		/// <summary>
		/// Set the attribute.
		/// </summary>
		public void Set (Serializable ptr, float src)
		{
			Runtime.ValidateRefCounted (this);
			AttributeAccessor_Set10 (handle, (object)ptr == null ? IntPtr.Zero : ptr.Handle, src);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void AttributeAccessor_Set11 (IntPtr handle, IntPtr ptr, string src);

		/// <summary>
		/// Set the attribute.
		/// </summary>
		public void Set (Serializable ptr, string src)
		{
			Runtime.ValidateRefCounted (this);
			AttributeAccessor_Set11 (handle, (object)ptr == null ? IntPtr.Zero : ptr.Handle, src);
		}
	}
}
