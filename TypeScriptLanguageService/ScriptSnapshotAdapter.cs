using System;
using V8.Net;

namespace TypeScriptLanguageService
{
    [ScriptObject("ScriptSnapshot", ScriptMemberSecurity.Permanent)]
    public class ScriptSnapshotAdapter :  IV8NativeObject, IScriptSnapshoAdapter
    {

        IScript script = null;
        V8Engine v8Engine = null;

        public ScriptSnapshotAdapter(IScript script)
        {
            this.script = script;
        }
        public ScriptSnapshotAdapter(IScript script, V8Engine v8Engine)
        {
            this.script = script;
            this.v8Engine = v8Engine;
        }

        #region IScriptSnapshot implementation
        public InternalHandle getText(int start, int end)
        {
            return v8Engine.CreateValue(script.Source.Substring(start, end - start));
        }
        public InternalHandle getLength()
        {
            return v8Engine.CreateValue(script.Source.Length);
        }
        public InternalHandle[] getLineStartPositions()
        {
            var pos = script.GetLineStartPositions();
            InternalHandle[] handleArray = new InternalHandle[pos.Length];
            for (int i = 0; i < pos.Length; i++)
            {
                handleArray[i] = v8Engine.CreateValue(pos[i]);
            }
            return handleArray;
        }
        //@TODO place old snapshot into script???
        public InternalHandle getChangeRange(IScriptSnapshoAdapter oldSnapshot)
        {
            V8NativeObject textChangeRange = this. v8Engine.CreateObject<V8NativeObject>();
            textChangeRange.SetProperty("span", v8Engine.CreateValue(""));
            textChangeRange.SetProperty("newLength", v8Engine.CreateValue(""));

            return textChangeRange;
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

