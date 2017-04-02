// Guids.cs
// MUST match guids.h
using System;

namespace VSShellStub1.AboutBoxPackage
{
    static class GuidList
    {
        public const string guidAboutBoxPackagePkgString = "95e12722-f086-4f03-b2b8-2f61741da0cf";
        public const string guidAboutBoxPackageCmdSetString = "360f7a8b-bd9b-4a84-aa8e-039a5d0a39f6";

        public static readonly Guid guidAboutBoxPackageCmdSet = new Guid(guidAboutBoxPackageCmdSetString);
    };
}