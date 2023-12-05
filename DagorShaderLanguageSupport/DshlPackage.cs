using Microsoft.VisualStudio.Editor;
using Microsoft.VisualStudio.LanguageServer.Client;
using Microsoft.VisualStudio.Shell;
using System;
using System.Runtime.InteropServices;

namespace Dshl
{
    [PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
    [ProvideWorkspaceSettings("VSWorkspaceSettings", "DshlSettings.json")]
    [ProvideConfig(CommonEditorConstants.TextMateRepositoryKey, Dshl.Identifier, "$PackageFolder$\\Dagor-Shader-Language-Server\\grammar")]
    [ProvideConfig(CommonEditorConstants.TextMateLanguageConfigurationGrammarMappingKey, Dshl.ScopeName, languageConfigurationPath)]
    [ProvideConfig(CommonEditorConstants.TextMateLanguageConfigurationContentTypeMappingKey, Dshl.Identifier, languageConfigurationPath)]
    [ProvideMenuResource("Menus.ctmenu", 1)]
    [Guid("9b051efc-40ee-4e16-874b-08c15d4aad9f")]
    public sealed class DshlPackage : AsyncPackage
    {
        private const string languageConfigurationPath = "$PackageFolder$\\Dagor-Shader-Language-Server\\grammar\\language-configuration.json";
    }
}
