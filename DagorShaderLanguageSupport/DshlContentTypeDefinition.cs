using Microsoft.VisualStudio.LanguageServer.Client;
using Microsoft.VisualStudio.Utilities;
using System.ComponentModel.Composition;

namespace Dshl
{
#pragma warning disable 649
    static class Dshl
    {
        public const string ExtensionName = "Dagor Shader Language Support";
        public const string Identifier = "dshl";
        public const string Extension = ".dshl";
        public const string ScopeName = "source.dshl";
    }

    public class DshlContentDefinition
    {

        [Export]
        [Name(Dshl.Identifier)]
        [BaseDefinition(CodeRemoteContentDefinition.CodeRemoteContentTypeName)]
        internal static ContentTypeDefinition DshlContentTypeDefinition;


        [Export]
        [FileExtension(Dshl.Extension)]
        [ContentType(Dshl.Identifier)]
        internal static FileExtensionToContentTypeDefinition DshlFileExtensionDefinition;
    }
#pragma warning restore 649
}
