using System;
using V8.Net;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;

namespace TypeScriptLanguageService
{
	[ScriptObject("ScriptSnapshot", ScriptMemberSecurity.Permanent)]
	public class V8ScriptSnapshotAdapter :  IV8NativeObject
	{



		V8Engine v8engine = null;

		public string source;
		public int version;
		public List<int> positionsArrayHandle;
		public string filename;
		IScriptSnapshot scriptSnapshot;

		public V8ScriptSnapshotAdapter(V8Engine v8engine, IScriptSnapshot scriptSnapshot, string filename)
		{
			this.v8engine = v8engine;
			this.source = (scriptSnapshot as IScriptSnapshotExtension).ScriptSource;
			this.version = (scriptSnapshot as IScriptSnapshotExtension).ScriptVersion;
			this.positionsArrayHandle = new List<int> ((scriptSnapshot as IScriptSnapshotExtension).LineStartPositions);
			this.scriptSnapshot = scriptSnapshot;
			this.filename = filename;
		}
			
		#region IScriptSnapshot implementation
		public InternalHandle getText(InternalHandle start, InternalHandle end)
		{
			return v8engine.CreateValue(this.source.Substring(start, end - start));
		}

		public InternalHandle getLength()
		{
			return v8engine.CreateValue(this.source.Length);
		}

		public InternalHandle[] getLineStartPositions()
		{
			InternalHandle[] temp = new InternalHandle[this.positionsArrayHandle.Count];
			for (int i = 0; i < positionsArrayHandle.Count; i++) {
				temp[i] = v8engine.CreateValue(positionsArrayHandle[i]);
			}
			return temp;
		}

		public InternalHandle getChangeRange(InternalHandle oldSnapshot)
		{

			// TODO Create exact changerange this solution calculates the change from as start position to eof
			var tempOldSnapshot = oldSnapshot.Value;
			int oldVersion = ((V8ScriptSnapshotAdapter)tempOldSnapshot).version;
			string oldSource = ((V8ScriptSnapshotAdapter)tempOldSnapshot).source;
			List<int> oldPos = new List<int>(((V8ScriptSnapshotAdapter)tempOldSnapshot).positionsArrayHandle);

			var nativeSpan = v8engine.CreateObject<V8NativeObject>();
			var nativeTextRangeChange = v8engine.CreateObject<V8NativeObject>();

			List<int> differenceQuery =
					oldPos.Except(this.positionsArrayHandle).ToList<int>();

			if (this.version > oldVersion && differenceQuery.Count > 0 ) {
					
				nativeSpan.SetProperty("start", v8engine.CreateValue(differenceQuery[0]));
				nativeSpan.SetProperty("length", v8engine.CreateValue(oldSource.Length));

				nativeTextRangeChange.SetProperty("span", nativeSpan);
				nativeTextRangeChange.SetProperty("newLength", v8engine.CreateValue(this.source.Length));

				return nativeTextRangeChange;
			}
				
			nativeSpan.SetProperty("start", v8engine.CreateValue(0));
			nativeSpan.SetProperty("length", v8engine.CreateValue(0));

			nativeTextRangeChange.SetProperty("span", nativeSpan);
			nativeTextRangeChange.SetProperty("newLength", v8engine.CreateValue(0));

			return nativeTextRangeChange;
		}
		#endregion


		#region 
		InternalHandle ScriptSource { 
			get {return v8engine.CreateValue(this.source);}
		}

		InternalHandle[] LineStartPositions {
			get { return null; }
		}

		InternalHandle ScriptVersion { 
			get { return v8engine.CreateValue(this.version); }
		}
		#endregion




		#region IV8NativeObject implementation
		public void Initialize(V8NativeObject owner, bool isConstructCall, params InternalHandle[] args)
		{
		}

		public void Dispose()
		{
		}
		#endregion
	}
}

