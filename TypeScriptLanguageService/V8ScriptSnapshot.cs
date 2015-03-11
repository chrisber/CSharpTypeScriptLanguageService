using System;
using V8.Net;

namespace TypeScriptLanguageService
{
    [ScriptObject("ScriptSnapshot", ScriptMemberSecurity.Permanent)]
    public class V8ScriptSnapshot :  IV8NativeObject
    {

        IScriptSnapshot scriptSnapshot = null;
        V8Engine v8Engine = null;

        public V8ScriptSnapshot(V8Engine v8Engine, IScriptSnapshot scriptSnapshot )
        {
            this.v8Engine = v8Engine;
            this.scriptSnapshot = scriptSnapshot;
        }

        #region IScriptSnapshot implementation
        public InternalHandle getText(InternalHandle start, InternalHandle end)
        {
            return v8Engine.CreateValue(scriptSnapshot.getText(start, end));
        }
        public InternalHandle getLength()
        {
            return v8Engine.CreateValue(scriptSnapshot.getLength());
        }
        public InternalHandle[] getLineStartPositions()
        {
            var pos = scriptSnapshot.getLineStartPositions();
            InternalHandle[] handleArray = new InternalHandle[pos.Length];
            for (int i = 0; i < pos.Length; i++)
            {
                handleArray[i] = v8Engine.CreateValue(pos[i]);
            }
            return handleArray;
        }
        //@TODO place old snapshot into script???
        public InternalHandle getChangeRange(InternalHandle oldSnapshot)
        {
            //@ TODO IScriptsnapshot needs to be accessible from outside

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

