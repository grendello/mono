// 
// DataServiceException.cs
//  
// Authors:
//       Eric Maupin  <me@ermau.com>
//       Marek Habersack <grendel@twistedcode.net>
//
// Copyright (c) 2009 Eric Maupin (http://www.ermau.com)
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
using System.Data.Services;
using System.Diagnostics;
using System.Runtime;
using System.Runtime.Serialization;
using System.Security;

namespace System.Data.Services
{
	[Serializable]
	[DebuggerDisplay ("{statusCode}: {Message}")]
	public sealed class DataServiceException : InvalidOperationException
	{
		public string ErrorCode {
#if NET_4_0
			[TargetedPatchingOptOut ("Performance critical to inline this type of method across NGen image boundaries")]
#endif
			get; private set;
		}

		public string MessageLanguage {
#if NET_4_0
			[TargetedPatchingOptOut ("Performance critical to inline this type of method across NGen image boundaries")]
#endif
			get; private set;
		}

		public int StatusCode {
#if NET_4_0
			[TargetedPatchingOptOut ("Performance critical to inline this type of method across NGen image boundaries")]
#endif
			get; private set;
		}

		public DataServiceException ()
		{
			throw new NotImplementedException ();
		}
#if NET_4_0
		[TargetedPatchingOptOut ("Performance critical to inline this type of method across NGen image boundaries")]
#endif
		public DataServiceException (string message)
			: base (message)
		{
		}
#if NET_4_0
		[TargetedPatchingOptOut ("Performance critical to inline this type of method across NGen image boundaries")]
#endif
		public DataServiceException (string message, Exception innerException)
			: base (message, innerException)
		{
		}
#if NET_4_0
		[TargetedPatchingOptOut ("Performance critical to inline this type of method across NGen image boundaries")]
#endif
		public DataServiceException (int statusCode, string message)
			: this (message)
		{
			this.StatusCode = statusCode;
		}

		public DataServiceException (int statusCode, string errorCode, string message, string messageXmlLang, Exception innerException)
			: base (message, innerException)
		{
			this.StatusCode = statusCode;
			this.ErrorCode = errorCode;
			this.MessageLanguage = messageXmlLang;
		}

		protected DataServiceException (SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw new NotImplementedException ();
		}

		[SecurityCritical]
		public override void GetObjectData (SerializationInfo info, StreamingContext context)
		{
			throw new NotImplementedException ();
		}

	}
}
