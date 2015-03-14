using System;
using V8.Net;

namespace TypeScriptLanguageService
{
	public class V8ScriptSnapshotAdapter : IScriptSnapshot
    {
		InternalHandle snapshot;

        public V8ScriptSnapshotAdapter( InternalHandle snapshot)
        {
			this.snapshot = snapshot;
        }

		#region IScriptSnapshot implementation

		public string getText(int start, int end)
		{
			throw new NotImplementedException();
		}

		public int getLength()
		{	int length;
			if(int.TryParse( snapshot.GetProperty("Length"), out length)){
				return length;
			}
				return 0;
		}

		public int[] getLineStartPositions()
		{
			throw new NotImplementedException();
		}

		public TextChangeRange getChangeRange(IScriptSnapshot oldSnapshot)
		{
			throw new NotImplementedException();
		}

		#endregion
    }
}

