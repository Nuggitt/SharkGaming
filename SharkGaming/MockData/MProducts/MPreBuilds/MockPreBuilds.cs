using SharkGaming.Products.PreBuilds;

namespace SharkGaming.MockData.Products.PreBuilds
{
    public class MockPreBuilds
    {
        public static List<PreBuildsClass> _preBuildsClasses = new List<PreBuildsClass>()
        {
            new PreBuildsClass("Dicklodon", ),

        };

        PreBuildsClass PreBuildsClass01 = new PreBuildsClass("Dickledon", 0, "Big dick pc for the big DICK GAMER",  );

        public static List<PreBuildsClass> GetMockPreBuilds() { return _preBuildsClasses; }

    }
}
