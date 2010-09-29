// 
// DataServiceConfiguration.cs
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
#if NET_4_0
using System;
using System.Data.Services;
using System.Runtime;

namespace System.Data.Services
{
	public sealed class DataServiceConfiguration : IDataServiceConfiguration
	{
		public bool EnableTypeConversion {
			[TargetedPatchingOptOut ("Performance critical to inline this type of method across NGen image boundaries")]
			get { throw new NotImplementedException (); }

			set { throw new NotImplementedException (); }
		}

		public int MaxBatchCount {
			[TargetedPatchingOptOut ("Performance critical to inline this type of method across NGen image boundaries")]
			get { throw new NotImplementedException (); }

			set { throw new NotImplementedException (); }
		}

		public int MaxChangesetCount {
			[TargetedPatchingOptOut ("Performance critical to inline this type of method across NGen image boundaries")]
			get { throw new NotImplementedException (); }

			set { throw new NotImplementedException (); }
		}

		public int MaxExpandCount {
			[TargetedPatchingOptOut ("Performance critical to inline this type of method across NGen image boundaries")]
			get { throw new NotImplementedException (); }

			set { throw new NotImplementedException (); }
		}

		public int MaxExpandDepth {
			[TargetedPatchingOptOut ("Performance critical to inline this type of method across NGen image boundaries")]
			get { throw new NotImplementedException (); }

			set { throw new NotImplementedException (); }
		}

		public int MaxResultsPerCollection {
			[TargetedPatchingOptOut ("Performance critical to inline this type of method across NGen image boundaries")]
			get { throw new NotImplementedException (); }

			set { throw new NotImplementedException (); }
		}

		public int MaxObjectCountOnInsert {
			[TargetedPatchingOptOut ("Performance critical to inline this type of method across NGen image boundaries")]
			get { throw new NotImplementedException (); }

			set { throw new NotImplementedException (); }
		}

		public bool UseVerboseErrors {
			[TargetedPatchingOptOut ("Performance critical to inline this type of method across NGen image boundaries")]
			get { throw new NotImplementedException (); }

			set { throw new NotImplementedException (); }
		}

		public DataServiceBehavior DataServiceBehavior {
			[TargetedPatchingOptOut ("Performance critical to inline this type of method across NGen image boundaries")]
			get { throw new NotImplementedException (); }
		}

		public void SetEntitySetAccessRule (string name, EntitySetRights rights)
		{
			throw new NotImplementedException ();
		}

		public void SetServiceOperationAccessRule (string name, ServiceOperationRights rights)
		{
			throw new NotImplementedException ();
		}

		public void RegisterKnownType (Type type)
		{
			throw new NotImplementedException ();
		}

		public void SetEntitySetPageSize (string name, int size)
		{
			throw new NotImplementedException ();
		}

		public void EnableTypeAccess (string typeName)
		{
			throw new NotImplementedException ();
		}
	}
}
#endif