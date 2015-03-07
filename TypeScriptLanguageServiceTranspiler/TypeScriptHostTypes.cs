using System;
using V8.Net;
using System.Collections.Generic;

namespace TypeScriptLanguageServiceTranspiler
{
   

    public enum ModuleGenTarget
    {
        Unspecified = 0,
        Synchronous = 1,
        Asynchronous = 2,
    }

    public enum ModuleKind
    {
        None,
        CommonJS,
        AMD,
    }

    public enum ScriptTarget
    {
        ES3,
        ES5,
        ES6,
        Latest = ES6,
    }



    public interface ITypeScriptOptions
    {
        bool RemoveComments { get; }

        bool GenerateSourceMap { get; }

        bool NoImplicitAny { get; }

        string ModuleKind { get; }

        string EcmaScriptVersion { get; }

        ScriptTarget GetLanguageVersion();

        ModuleGenTarget GetModuleTarget();

        string GetOutputFileFullPath();

        string GetOutputDirectoryFullPath();
    }

  

    [ScriptObject("CompilerOptions", security: ScriptMemberSecurity.Permanent)]
    public class CompilerOptions
    {
        public CompilerOptions(ITypeScriptOptions options)
            : this()
        {
            diagnostics = true;
            removeComments = options.RemoveComments;
            sourceMap = options.GenerateSourceMap;
            noImplicitAny = options.NoImplicitAny;
            target = options.GetLanguageVersion();
            outFile = options.GetOutputFileFullPath();
            outDir = options.GetOutputDirectoryFullPath();

        }

        public CompilerOptions()
        {
            outFile = "";
            outDir = "";
            mapRoot = "";
            sourceRoot = "";
            target = ScriptTarget.ES5;
            module = ModuleKind.None;
            noImplicitAny = true;
            declaration = true;
            diagnostics = true;
        }

        public string charset { get; set; }

        public int codepage { get; set; }

        public bool declaration { get; set; }

        public bool diagnostics { get; set; }

        public bool emitBOM { get; set; }

        public bool help { get; set; }

        public string locale { get; set; }

        public string mapRoot { get; set; }

        public ModuleKind module { get; set; }

        public bool noErrorTruncation { get; set; }

        public bool noImplicitAny { get; set; }

        public bool noLib { get; set; }

        public bool noLibCheck { get; set; }

        public bool noResolve { get; set; }

        [ScriptMember("out", security: ScriptMemberSecurity.Permanent)]
        public string outFile { get; set; }

        public string outDir { get; set; }

        public bool removeComments { get; set; }

        public bool sourceMap { get; set; }

        public string sourceRoot { get; set; }

        public ScriptTarget target { get; set; }

        public bool version { get; set; }

        public bool watch { get; set; }

        public List<KeyValuePair<string, object>> option { get; set; }
    }

    public interface IScriptSnapshotShim
    {
        string getText(int start, int end);

        int getLength();

        int[] getLineStartPositions();

        TextChangeRange getChangeRange(IScriptSnapshotShim oldSnapshot);
    }

    [ScriptObject("ScriptSnapshotShim", security: ScriptMemberSecurity.Permanent)]
    public class ScriptSnapshotShim : IScriptSnapshotShim
    {


        Script script;

        public ScriptSnapshotShim(Script script)
        {

            this.script = script;
        }

        [ScriptMember(inScriptName: "getText", security: ScriptMemberSecurity.Permanent)]
        public string getText(int start, int end)
        {
            return script.Source.Substring(start, end - start);
        }

        [ScriptMember(inScriptName: "getLength", security: ScriptMemberSecurity.Permanent)]
        public int getLength()
        {
            return script.Source.Length;
        }

        [ScriptMember(inScriptName: "getLineStartPositions", security: ScriptMemberSecurity.Permanent)]
        public int[] getLineStartPositions()
        {
            Log("ScriptSnapshotShim.getLineStartPositions");

            //          int[] positions = script.GetLineStartPositions();
            //          string json = JsonConvert.SerializeObject(positions);

            //Log("ScriptSnapshotShim.getLineStartPositions: {0}", json);

            return script.GetLineStartPositions();
        }

        /// <summary>
        /// TODO: Fix this
        /// </summary>
        [ScriptMember(inScriptName: "getChangeRange", security: ScriptMemberSecurity.Permanent)]
        public TextChangeRange getChangeRange(IScriptSnapshotShim oldSnapshot)
        {
            //            Log("ScriptSnapshotShim.getChangeRange: version={0}", oldSnapshot);
            //            if (script. == oldSnapshot.)
            //              return null;
            //          
            //            TextChangeRange textChangeRange = script.GetTextChangeRangeSinceVersion(oldSnapshot);
            //          string json = JsonConvert.SerializeObject(textChangeRange);
            //          
            //          Log("ScriptSnapshotShim.getTextChangeRangeSinceVersion: json: {0}", json);

            return null;
        }

        [ScriptMember(inScriptName: "Log", security: ScriptMemberSecurity.Permanent)]
        void Log(string format, params object[] args)
        {
            Console.WriteLine(String.Format(format, args));
        }
    }

    [ScriptObject("Script", security: ScriptMemberSecurity.Permanent)]
    public class Script
    {
        string fileName;
        List<int> lineStartPositions = new List<int>();
        List<int> lengths = new List<int>();


        public Script(string fileName, string source)
        {
            this.fileName = fileName;
            this.Source = source;
            this.Version = 1;
            lengths.Add(source.Length);
        }

        public void Update(string source)
        {
            this.Source = source;
            lengths.Add(source.Length);
            Version++;
        }

        public string Id
        {
            get { return fileName; }
        }

        public string Source { get; private set; }

        public int Version { get; private set; }

        public int[] GetLineStartPositions()
        {
            if (lineStartPositions.Count == 0)
            {
                string[] lines = Source.Split('\r');
                lineStartPositions.Add(0);
                int position = 0;
                for (int i = 0; i < lines.Length; ++i)
                {
                    position += lines[i].Length + 2;
                    lineStartPositions.Add(position);
                }
            }

            return lineStartPositions.ToArray();
        }

        public TextChangeRange GetTextChangeRangeSinceVersion(int scriptVersion)
        {
            return new TextChangeRange(0, lengths[scriptVersion - 1], Source.Length);
        }
    }

    public class TextChangeRange
    {
        public TextChangeRange(int start, int length, int newLength)
            : this(new TextSpan(start, length), newLength)
        {
        }

        public TextChangeRange(TextSpan span, int newLength)
        {
            this.span = span;
            this.newLength = newLength;
        }

        public TextSpan span { get; set; }

        public int newLength { get; set; }
    }

    public class TextSpan
    {
        public TextSpan(int start, int length)
        {
            this.start = start;
            this.length = length;
        }

        public int start { get; set; }

        public int length { get; set; }
    }
}

