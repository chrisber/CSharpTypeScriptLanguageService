using System;
using V8.Net;

namespace TypeScriptLanguageService
{
    public interface IScriptSnapshoAdapter
    {
        //return string
        InternalHandle getText(int start, int end);
        //return int
        InternalHandle getLength();
        //return int[]
        InternalHandle[] getLineStartPositions();
        //return TextChangeRange
        InternalHandle getChangeRange(IScriptSnapshoAdapter oldSnapshot);
    }
}

