using System;
using V8.Net;

namespace TypeScriptLanguageService
{
    public class V8CancellationToken :  IV8NativeObject
    {
        V8Engine v8engine = null;

        public V8CancellationToken(V8Engine v8engine)
        {
            this.v8engine = v8engine;
        }

        InternalHandle isCancellationRequested(){
            return v8engine.CreateValue("false");
        }

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

