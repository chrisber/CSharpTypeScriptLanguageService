using System;

namespace TypeScriptLanguageService
{
	/// <summary>
	/// <para> script snapshot adapter</para>
	/// <para> </para>
	/// <para> The Interface is derived from IScriptSnapshot to let the V8 host environment communicate with the managed host environment.</para>
	/// <para> </para>
	/// <para> The implementation of the Interface represents an immutable snapshot of a script at a specified time.Once acquired, the</para>
	/// <para> snapshot is observably immutable. i.e. the same calls with the same parameters will return</para>
	/// <para> the same values.</para>
	/// <para></para>
	/// <para> Gets a portion of the script snapshot specified by [start, end).</para>
	/// <para> getText(start: number, end: number): string;</para>
	/// <para></para>
	/// <para> Gets the length of this script snapshot.</para>
	/// <para> getLength(): number;</para>
	/// <para></para>
	/// <para> Gets the TextChangeRange that describe how the text changed between this text and</para>
	/// <para> an older version.  This information is used by the incremental parser to determine</para>
	/// <para> what sections of the script need to be re-parsed.  'undefined' can be returned if the</para>
	/// <para> change range cannot be determined.  However, in that case, incremental parsing will</para>
	/// <para> not happen and the entire document will be re - parsed.</para>
	/// <para> getChangeRange(oldSnapshot: IScriptSnapshot): TextChangeRange;</para>
	/// </summary>
	public interface IScriptSnapshotExtension : IScriptSnapshot
	{
		/// <summary>
		/// Gets or sets the script source.
		/// </summary>
		/// <value>The script source.</value>
		string ScriptSource { get; }
		/// <summary>
		/// Gets or sets the positions.
		/// </summary>
		/// <value>The positions.</value>
		int[] LineStartPositions { get; }
		/// <summary>
		/// Gets or sets the script version.
		/// </summary>
		/// <value>The script version.</value>
		int ScriptVersion { get; }
	}
}

