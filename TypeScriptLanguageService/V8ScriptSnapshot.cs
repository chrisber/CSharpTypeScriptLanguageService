using System;
using V8.Net;

namespace TypeScriptLanguageService
{
	[ScriptObject("ScriptSnapshot", ScriptMemberSecurity.Permanent)]
	public class V8ScriptSnapshot :  IV8NativeObject
	{

		IScriptSnapshot scriptSnapshot = null;
		V8Engine v8Engine = null;

		public V8ScriptSnapshot(V8Engine v8Engine, IScriptSnapshot scriptSnapshot)
		{
			this.v8Engine = v8Engine;
			this.scriptSnapshot = scriptSnapshot;
			this.Length = scriptSnapshot.getLength().ToString();
		}


		public string Length { set; get; }



		#region IScriptSnapshot implementation

		public InternalHandle getText(InternalHandle start, InternalHandle end)
		{
			return v8Engine.CreateValue(this.scriptSnapshot.getText(start, end));
		}

		public InternalHandle getLength()
		{
			return v8Engine.CreateValue(scriptSnapshot.getLength());
		}

		public InternalHandle[] getLineStartPositions()
		{
			var pos = this.scriptSnapshot.getLineStartPositions();
			InternalHandle[] handleArray = new InternalHandle[pos.Length];
			for (int i = 0; i < pos.Length; i++) {
				handleArray[i] = v8Engine.CreateValue(pos[i]);
			}
			return handleArray;
		}

		public InternalHandle getChangeRange(InternalHandle oldSnapshot)
		{

			var tChangeRange = scriptSnapshot.getChangeRange(new V8ScriptSnapshotAdapter(oldSnapshot));

			return v8Engine.GetTypeBinder(typeof(TextChangeRange)).CreateObject(tChangeRange);

			return null;
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

