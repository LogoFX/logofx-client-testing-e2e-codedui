using Attest.Testing.Contracts;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace LogoFX.Client.Testing.EndToEnd.CodedUI
{
    class ApplicationFacade : IApplicationFacade
    {
        public void Start(string startupPath)
        {
            Playback.Initialize();
            ApplicationUnderTest.Launch(startupPath);
        }

        public void Stop()
        {
            Playback.Cleanup();
        }
    }
}
