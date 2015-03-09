using System;

namespace TypeScriptLanguageService
{
    public interface IScript
    {
        void Update(string source);
        string Id { get; }
        string Source { get; }
        int Version { get; }
        int[] GetLineStartPositions();
        TextChangeRange GetTextChangeRangeSinceVersion(int scriptVersion);
    }
}

