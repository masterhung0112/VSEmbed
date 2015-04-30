﻿using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell.Interop;

namespace VSEmbed.Services {
	// This file contains stub implementations of services that we don't actually implement.

	class StubVsActivityLog : IVsActivityLog {
		public int LogEntry([ComAliasName("Microsoft.VisualStudio.Shell.Interop.ACTIVITYLOG_ENTRYTYPE")]uint actType, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LPCOLESTR")]string pszSource, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LPCOLESTR")]string pszDescription) {
			return 0;
		}

		public int LogEntryGuid([ComAliasName("Microsoft.VisualStudio.Shell.Interop.ACTIVITYLOG_ENTRYTYPE")]uint actType, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LPCOLESTR")]string pszSource, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LPCOLESTR")]string pszDescription, Guid guid) {
			return 0;
		}

		public int LogEntryGuidHr([ComAliasName("Microsoft.VisualStudio.Shell.Interop.ACTIVITYLOG_ENTRYTYPE")]uint actType, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LPCOLESTR")]string pszSource, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LPCOLESTR")]string pszDescription, Guid guid, int hr) {
			return 0;
		}

		public int LogEntryGuidHrPath([ComAliasName("Microsoft.VisualStudio.Shell.Interop.ACTIVITYLOG_ENTRYTYPE")]uint actType, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LPCOLESTR")]string pszSource, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LPCOLESTR")]string pszDescription, Guid guid, int hr, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LPCOLESTR")]string pszPath) {
			return 0;
		}

		public int LogEntryGuidPath([ComAliasName("Microsoft.VisualStudio.Shell.Interop.ACTIVITYLOG_ENTRYTYPE")]uint actType, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LPCOLESTR")]string pszSource, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LPCOLESTR")]string pszDescription, Guid guid, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LPCOLESTR")]string pszPath) {
			return 0;
		}

		public int LogEntryHr([ComAliasName("Microsoft.VisualStudio.Shell.Interop.ACTIVITYLOG_ENTRYTYPE")]uint actType, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LPCOLESTR")]string pszSource, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LPCOLESTR")]string pszDescription, int hr) {
			return 0;
		}

		public int LogEntryHrPath([ComAliasName("Microsoft.VisualStudio.Shell.Interop.ACTIVITYLOG_ENTRYTYPE")]uint actType, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LPCOLESTR")]string pszSource, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LPCOLESTR")]string pszDescription, int hr, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LPCOLESTR")]string pszPath) {
			return 0;
		}

		public int LogEntryPath([ComAliasName("Microsoft.VisualStudio.Shell.Interop.ACTIVITYLOG_ENTRYTYPE")]uint actType, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LPCOLESTR")]string pszSource, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LPCOLESTR")]string pszDescription, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LPCOLESTR")]string pszPath) {
			return 0;
		}
	}

	class StubVsShell : IVsShell {
		public int AdviseBroadcastMessages(IVsBroadcastMessageEvents pSink, out uint pdwCookie) {
			pdwCookie = 42;
			return 0;
		}

		public int AdviseShellPropertyChanges(IVsShellPropertyEvents pSink, out uint pdwCookie) {
			pdwCookie = 42;
			return 0;
		}

		public int GetPackageEnum(out IEnumPackages ppenum) {
			throw new NotImplementedException();
		}

		public int GetProperty(int propid, out object pvar) {
			switch (propid) {
				case -9002: // VirtualRegistryRoot; used by VsImageServiceTelemetryLogger.GetRootSuffix
					pvar = "";
					return VSConstants.S_OK;
				default:
					pvar = null;
					break;
			}
			return VSConstants.E_NOTIMPL;
		}

		public int IsPackageInstalled(ref Guid guidPackage, out int pfInstalled) {
			throw new NotImplementedException();
		}

		public int IsPackageLoaded(ref Guid guidPackage, out IVsPackage ppPackage) {
			throw new NotImplementedException();
		}

		public int LoadPackage(ref Guid guidPackage, out IVsPackage ppPackage) {
			throw new NotImplementedException();
		}

		public int LoadPackageString(ref Guid guidPackage, uint resid, out string pbstrOut) {
			throw new NotImplementedException();
		}

		public int LoadUILibrary(ref Guid guidPackage, uint dwExFlags, out uint phinstOut) {
			throw new NotImplementedException();
		}

		public int SetProperty(int propid, object var) {
			throw new NotImplementedException();
		}

		public int UnadviseBroadcastMessages(uint dwCookie) {
			return 0;
		}

		public int UnadviseShellPropertyChanges(uint dwCookie) {
			return 0;
		}
	}

	class StubVsFontAndColorCacheManager : IVsFontAndColorCacheManager {
		public int CheckCache(ref Guid rguidCategory, out int pfHasData) {
			pfHasData = 0;
			return 0;
		}

		public int CheckCacheable(ref Guid rguidCategory, out int pfCacheable) {
			pfCacheable = 0;
			return 0;
		}

		public int ClearAllCaches() {
			return 0;
		}

		public int ClearCache(ref Guid rguidCategory) {
			return 0;
		}

		public int RefreshCache(ref Guid rguidCategory) {
			return 0;
		}
	}

	class StubVsMonitorSelection : IVsMonitorSelection {
		public int AdviseSelectionEvents(IVsSelectionEvents pSink, out uint pdwCookie) {
			pdwCookie = 0;
			return 0;
		}

		public int GetCmdUIContextCookie(ref Guid rguidCmdUI, out uint pdwCmdUICookie) {
			pdwCmdUICookie = 0;
			return 0;
		}

		public int GetCurrentElementValue(uint elementid, out object pvarValue) {
			pvarValue = null;
			return 0;
		}

		public int GetCurrentSelection(out IntPtr ppHier, out uint pitemid, out IVsMultiItemSelect ppMIS, out IntPtr ppSC) {
			pitemid = 0;
			ppHier = IntPtr.Zero;
			ppMIS = null;
			ppSC = IntPtr.Zero;
			return 0;
		}

		public int IsCmdUIContextActive(uint dwCmdUICookie, out int pfActive) {
			pfActive = 0;
			return 0;
		}

		public int SetCmdUIContext(uint dwCmdUICookie, int fActive) {
			return 0;
		}

		public int UnadviseSelectionEvents(uint dwCookie) {
			return 0;
		}
	}
}
