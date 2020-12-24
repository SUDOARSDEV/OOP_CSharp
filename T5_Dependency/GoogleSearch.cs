using System;
namespace Dependency
{
    public class GoogleSearch
    {
        private USAServer _usaServer { get; set; } // getter setter

        public GoogleSearch(USAServer usaServer) // constructor
        {
            this._usaServer = usaServer;
        }

        public void USA_Searching(string text) // method
        {
            _usaServer.Searching(text);
        }

    }
}
