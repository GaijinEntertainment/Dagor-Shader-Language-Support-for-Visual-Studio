using Microsoft.VisualStudio.LanguageServer.Client;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Threading;
using System.ComponentModel.Composition;
using System.IO;
using System.Reflection;

namespace Dshl
{
    [ContentType(Dshl.Identifier)]
    [Export(typeof(ILanguageClient))]
    [RunOnContext(RunningContext.RunOnHost)]
    public class DagorShaderLanguageSupportClient : ILanguageClient
    {

        public event AsyncEventHandler<EventArgs> StartAsync;
        public event AsyncEventHandler<EventArgs> StopAsync;

        public string Name => Dshl.ExtensionName;

        public object InitializationOptions => null;

        public IEnumerable<string> FilesToWatch { get; }

        public bool ShowNotificationOnInitializeFailed => true;

        public async Task<Connection> ActivateAsync(CancellationToken token)
        {
            await Task.Yield();
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
#if DEBUG
                    FileName = "node",
                    WorkingDirectory = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Dagor-Shader-Language-Server\\out"),
                    Arguments = "server-desktop.js --stdio",
#else
                    FileName = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Dagor-Shader-Language-Server\\bin\\server-desktop-win.exe"),
                    Arguments = "--stdio",
#endif
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };
            if (process.Start())
            {
                return new Connection(process.StandardOutput.BaseStream, process.StandardInput.BaseStream);
            }
            return null;
        }

        public IEnumerable<string> ConfigurationSections
        {
            get
            {
                yield return "dagorShaderLanguageServer";
            }
        }

        public async Task OnLoadedAsync()
        {
            if (StartAsync != null)
            {
                await StartAsync.InvokeAsync(this, EventArgs.Empty);
            }
        }

        public Task OnServerInitializedAsync()
        {
            return Task.CompletedTask;
        }

        public Task<InitializationFailureContext> OnServerInitializeFailedAsync(ILanguageClientInitializationInfo initializationState)
        {
            var failureContext = new InitializationFailureContext()
            {
                FailureMessage = initializationState.InitializationException?.ToString() ?? string.Empty,
            };
            return Task.FromResult(failureContext);
        }

    }
}
