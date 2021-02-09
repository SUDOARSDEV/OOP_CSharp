using System;
namespace Interface
{
    public class Youtube:VideoPlayer
    {
        protected int VideoId;
        protected string VideoName;

        public void Setting(int vID, string vName)
        {
            VideoId = vID;
            VideoName = vName;
        }

        public String Play()
        {
            return VideoName;
        }
    }
}
