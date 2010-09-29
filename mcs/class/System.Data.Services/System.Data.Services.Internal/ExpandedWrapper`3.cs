// 
// ExpandedWrapper`3.cs
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
using System.ComponentModel;
using System.Data.Services.Internal;
using System.Runtime;
using System.Runtime.CompilerServices;

namespace System.Data.Services.Internal
{
	[EditorBrowsable (EditorBrowsableState.Never)]
	public sealed class ExpandedWrapper <TExpandedElement, TProperty0, TProperty1> : ExpandedWrapper <TExpandedElement>
	{
		public TProperty0 ProjectedProperty0 {
			[CompilerGenerated]
#if NET_4_0
			[TargetedPatchingOptOut ("Performance critical to inline this type of method across NGen image boundaries")]
#endif
			get { throw new NotImplementedException (); }

			[CompilerGenerated]
#if NET_4_0
			[TargetedPatchingOptOut ("Performance critical to inline this type of method across NGen image boundaries")]
#endif
			set { throw new NotImplementedException (); }
		}

		public TProperty1 ProjectedProperty1 {
			[CompilerGenerated]
#if NET_4_0
			[TargetedPatchingOptOut ("Performance critical to inline this type of method across NGen image boundaries")]
#endif
			get { throw new NotImplementedException (); }

			[CompilerGenerated]
#if NET_4_0
			[TargetedPatchingOptOut ("Performance critical to inline this type of method across NGen image boundaries")]
#endif
			set { throw new NotImplementedException (); }
		}

		protected override object InternalGetExpandedPropertyValue (int nameIndex)
		{
			throw new NotImplementedException ();
		}

#if NET_4_0
		[TargetedPatchingOptOut ("Performance critical to inline this type of method across NGen image boundaries")]
#endif
		public ExpandedWrapper ()
		{
			throw new NotImplementedException ();
		}

	}
}
