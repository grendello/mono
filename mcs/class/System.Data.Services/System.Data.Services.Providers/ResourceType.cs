// 
// ResourceType.cs
//  
// Author:
//       Marek Habersack <grendel@twistedcode.net>
// 
// Copyright (c) 2010 Novell, Inc (http://novell.com/)
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Services.Common;
using System.Data.Services.Providers;
using System.Diagnostics;
using System.Runtime;
using System.Runtime.CompilerServices;

namespace System.Data.Services.Providers
{
	[DebuggerDisplay ("{Name}: {InstanceType}, {ResourceTypeKind}")]
	public class ResourceType
	{
		public bool IsMediaLinkEntry {
			[DebuggerStepThrough]
			[TargetedPatchingOptOut ("Performance critical to inline this type of method across NGen image boundaries")]
			get { throw new NotImplementedException (); }

			set { throw new NotImplementedException (); }
		}

		public Type InstanceType {
			[DebuggerStepThrough]
			[TargetedPatchingOptOut ("Performance critical to inline this type of method across NGen image boundaries")]
			get { throw new NotImplementedException (); }
		}

		public ResourceType BaseType {
			[DebuggerStepThrough]
			[TargetedPatchingOptOut ("Performance critical to inline this type of method across NGen image boundaries")]
			get { throw new NotImplementedException (); }
		}

		public ResourceTypeKind ResourceTypeKind {
			[DebuggerStepThrough]
			[TargetedPatchingOptOut ("Performance critical to inline this type of method across NGen image boundaries")]
			get { throw new NotImplementedException (); }
		}

		public ReadOnlyCollection <ResourceProperty> Properties {
			[TargetedPatchingOptOut ("Performance critical to inline this type of method across NGen image boundaries")]
			get { throw new NotImplementedException (); }
		}

		public ReadOnlyCollection <ResourceProperty> PropertiesDeclaredOnThisType {
			get { throw new NotImplementedException (); }
		}

		public ReadOnlyCollection <ResourceProperty> KeyProperties {
			get { throw new NotImplementedException (); }
		}

		public ReadOnlyCollection <ResourceProperty> ETagProperties {
			get { throw new NotImplementedException (); }
		}

		public string Name {
			[TargetedPatchingOptOut ("Performance critical to inline this type of method across NGen image boundaries")]
			get { throw new NotImplementedException (); }
		}

		public string FullName {
			[TargetedPatchingOptOut ("Performance critical to inline this type of method across NGen image boundaries")]
			get { throw new NotImplementedException (); }
		}

		public string Namespace {
			[TargetedPatchingOptOut ("Performance critical to inline this type of method across NGen image boundaries")]
			get { throw new NotImplementedException (); }
		}

		public bool IsAbstract {
			[TargetedPatchingOptOut ("Performance critical to inline this type of method across NGen image boundaries")]
			get { throw new NotImplementedException (); }
		}

		public bool IsOpenType {
			[DebuggerStepThrough]
			[TargetedPatchingOptOut ("Performance critical to inline this type of method across NGen image boundaries")]
			get { throw new NotImplementedException (); }

			set { throw new NotImplementedException (); }
		}

		public bool CanReflectOnInstanceType {
			[DebuggerStepThrough]
			[TargetedPatchingOptOut ("Performance critical to inline this type of method across NGen image boundaries")]
			get { throw new NotImplementedException (); }

			set { throw new NotImplementedException (); }
		}

		public object CustomState {
			[CompilerGenerated]
			[TargetedPatchingOptOut ("Performance critical to inline this type of method across NGen image boundaries")]
			get { throw new NotImplementedException (); }

			[CompilerGenerated]
			[TargetedPatchingOptOut ("Performance critical to inline this type of method across NGen image boundaries")]
			set { throw new NotImplementedException (); }
		}

		public bool IsReadOnly {
			[TargetedPatchingOptOut ("Performance critical to inline this type of method across NGen image boundaries")]
			get { throw new NotImplementedException (); }
		}

		public ResourceType (Type instanceType, ResourceTypeKind resourceTypeKind, ResourceType baseType, string namespaceName, string name, bool isAbstract)
		{
			throw new NotImplementedException ();
		}

		public static ResourceType GetPrimitiveResourceType (Type type)
		{
			throw new NotImplementedException ();
		}

		public void AddProperty (ResourceProperty property)
		{
			throw new NotImplementedException ();
		}

		public void AddEntityPropertyMappingAttribute (EntityPropertyMappingAttribute attribute)
		{
			throw new NotImplementedException ();
		}

		public void SetReadOnly ()
		{
			throw new NotImplementedException ();
		}

		protected virtual IEnumerable <ResourceProperty> LoadPropertiesDeclaredOnThisType ()
		{
			throw new NotImplementedException ();
		}

		static ResourceType ()
		{
			throw new NotImplementedException ();
		}

	}
}
