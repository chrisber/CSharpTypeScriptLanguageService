using System;
using V8.Net;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace TypeScriptLanguageService
{
	[ScriptObject("ScriptSnapshot", ScriptMemberSecurity.Permanent)]
	public class V8ScriptSnapshotAdapter :  IV8NativeObject
	{



		V8Engine v8engine = null;

		public InternalHandle source;
		public InternalHandle version;
		public InternalHandle[] positionsArrayHandle;

		public V8ScriptSnapshotAdapter(V8Engine v8engine, IScriptSnapshot scriptSnapshot)
		{
			this.v8engine = v8engine;
			this.source = v8engine.CreateValue((scriptSnapshot as IScriptSnapshotExtension).ScriptSource);
			this.version = v8engine.CreateValue((scriptSnapshot as IScriptSnapshotExtension).ScriptVersion);

			var positions = (scriptSnapshot as IScriptSnapshotExtension).LineStartPositions;
			positionsArrayHandle = new InternalHandle[positions.Length];
			for (int i = 0; i < positions.Length; i++) {
				positionsArrayHandle[i] = v8engine.CreateValue(positions[i]);
			}
		}



		#region IScriptSnapshot implementation
		public InternalHandle getText(InternalHandle start, InternalHandle end)
		{
			return v8engine.CreateValue(((string)this.source).Substring(start, end - start));
		}

		public InternalHandle getLength()
		{
			return v8engine.CreateValue(((string)this.source).Length);
		}

		public InternalHandle[] getLineStartPositions()
		{
			return this.positionsArrayHandle;
		}

		public InternalHandle getChangeRange(InternalHandle oldSnapshot)
		{

			var tempOldSnapshot = oldSnapshot.Value;

			int oldVersion = ((V8ScriptSnapshotAdapter)tempOldSnapshot).version;
			string oldSource = ((V8ScriptSnapshotAdapter)tempOldSnapshot).source;

			//TODO do we need line start
//			InternalHandle[] temp = ((V8ScriptSnapshotAdapter)tempOldSnapshot).positionsArrayHandle;
//			int[] oldPositionsArrayHandle = new int[temp.Length];
//			for (int i = 0; i < temp.Length; i++) {
//				oldPositionsArrayHandle[i] = temp[i];
//			}

			var nativeSpan = v8engine.CreateObject<V8NativeObject>();
			nativeSpan.SetProperty("start", v8engine.CreateValue(0));
			nativeSpan.SetProperty("length", v8engine.CreateValue(oldSource.Length));

			var nativeTextRangeChange = v8engine.CreateObject<V8NativeObject>();
			nativeTextRangeChange.SetProperty("span", nativeSpan);
			nativeTextRangeChange.SetProperty("newLength", v8engine.CreateValue(((string)this.source).Length));

			var guid = Guid.NewGuid().ToString();
			v8engine.GlobalObject.SetProperty(guid, nativeTextRangeChange);
			return nativeTextRangeChange;
		}
		#endregion


		#region 
		InternalHandle ScriptSource { 
			get {return this.source;}
		}

		InternalHandle[] LineStartPositions {
			get { return this.positionsArrayHandle; }
		}

		InternalHandle ScriptVersion { 
			get { return this.version; }
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

