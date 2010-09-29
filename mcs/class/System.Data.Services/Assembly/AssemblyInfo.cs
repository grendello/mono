// 
// AssemblyInfo.cs
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
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

[assembly: AssemblyCompany(Consts.MonoCompany)]
[assembly: AssemblyProduct(Consts.MonoProduct)]
[assembly: AssemblyCopyright(Consts.MonoCopyright)]
[assembly: AssemblyVersion(Consts.FxVersion)]
[assembly: SatelliteContractVersion(Consts.FxVersion)]
[assembly: AssemblyInformationalVersion(Consts.FxFileVersion)]
[assembly: AssemblyFileVersion(Consts.FxFileVersion)]

[assembly: RuntimeCompatibility (WrapNonExceptionThrows=true)]
[assembly: SecurityCritical]
[assembly: Debuggable (DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: ComCompatibleVersion (1, 0, 3300, 0)]
[assembly: AssemblyDefaultAlias ("System.Data.Services.dll")]
[assembly: CompilationRelaxations (8)]
[assembly: ComVisible (false)]
[assembly: CLSCompliant (true)]
[assembly: AllowPartiallyTrustedCallers]
#if NET_4_0
[assembly: SecurityRules (SecurityRuleSet.Level1, SkipVerificationInFullTrust=true)]
[assembly: AssemblyTargetedPatchBand ("1.0.21-0")]
#endif
[assembly: AssemblyTitle ("System.Data.Services.dll")]
[assembly: AssemblyDescription ("System.Data.Services.dll")]
[assembly: NeutralResourcesLanguage ("en-US")]
[assembly: AssemblyDelaySign (true)]
[assembly: AssemblyKeyFile ("../ecma.pub")]
