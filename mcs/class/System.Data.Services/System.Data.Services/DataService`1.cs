// 
// DataService`1.cs
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
using System.IO;
using System.Runtime;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Channels;

namespace System.Data.Services
{
	[AspNetCompatibilityRequirements (RequirementsMode=AspNetCompatibilityRequirementsMode.Allowed)]
	[ServiceBehavior (InstanceContextMode=InstanceContextMode.PerCall)]
	public class DataService <T> : IRequestHandler
	{
#if NET_4_0
		public DataServiceProcessingPipeline ProcessingPipeline {
			[DebuggerStepThrough]
			[TargetedPatchingOptOut ("Performance critical to inline this type of method across NGen image boundaries")]
			get { throw new NotImplementedException (); }
		}
#endif
		protected T CurrentDataSource {
			get; private set;
		}

		public void AttachHost (IDataServiceHost host)
		{
			if (host == null)
				throw new ArgumentNullException();

			throw new NotImplementedException ();
		}

		public Message ProcessRequestForMessage (Stream messageBody)
		{
			if (messageBody == null)
				throw new ArgumentNullException ("messageBody");

			throw new NotImplementedException ();
		}

		public void ProcessRequest ()
		{
			throw new NotImplementedException ();
		}

		protected virtual T CreateDataSource ()
		{
			throw new NotImplementedException ();
		}

		protected virtual void HandleException (HandleExceptionArgs args)
		{
			if (args == null)
				throw new ArgumentNullException ("args");

			throw new NotImplementedException ();
		}

		protected virtual void OnStartProcessingRequest (ProcessRequestArgs args)
		{
			throw new NotImplementedException ();
		}

		public DataService ()
		{
		}
	}
}
