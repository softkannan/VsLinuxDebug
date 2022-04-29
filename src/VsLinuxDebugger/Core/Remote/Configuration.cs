﻿// <auto-generated Note="Disabling CodeMaid sorting />
using System.Text.Json.Serialization;

namespace VsLinuxDebugger.Core.Remote
{
  /// <summary>Launch Configuration attributes.</summary>
  /// <remarks>https://code.visualstudio.com/docs/editor/debugging#_launchjson-attributes</remarks>
  public class Configuration
  {
    //// MANDITORY ATTRIBUTES ----------------

    /// <summary>The reader-friendly name to appear in the Debug launch configuration dropdown.</summary>
    public string Name { get; set; } = "Debug on Linux";

    /// <summary>The type of debugger to use for this launch configuration. (i.e. 'coreclr' for .NET 3.1/5/6, 'clr' for .NET Framework).</summary>
    public string Type { get; set; } = "coreclr";

    /// <summary>The request type of this launch configuration. Currently, launch and attach are supported.</summary>
    public string Request { get; set; } = "launch";

    //// OPTIONAL ATTRIBUTES ----------------

    /// <summary>Executable or file to run when launching the debugger.</summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string Program { get; set; }   //// _remoteDotNetPath;

    /// <summary>Arugments passed to the program to debug.</summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string[] Args { get; set; }    //// => _args;

    /// <summary>Current working directory for finding dependencies and other files.</summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string Cwd { get; set; }       //// => _remoteDebugFolder;

    /// <summary>Break immediately when the program launches.</summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public bool StopAtEntry { get; set; } //// => _stopAtEntry;

    /// <summary>What kind of console to use. For example, 'internalConsole', 'integratedTerminal', or 'externalTerminal'.</summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string Console => "internalConsole";

    /// <summary>Environment variables (the value null can be used to "undefine" a variable).</summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string Env { get; set; }       //// => _environmentVariables;

    //// ---- TESTING PHASE BELOW ----

    /// <summary>Program name to debug (i.e. 'TestApp.exe').</summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string ProcessName { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public PipeTransport PipeTransport { get; set; }
  }
}
