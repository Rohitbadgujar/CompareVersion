
namespace CompareVersionTest
{
    public class UnitTest
    {
        [Fact]
        public void VersionComparerTest1()
        {
            string v1 = "1.10";
            string v2 = "1.9.1";
            Assert.Equal(1, VC.Program.CompareVersion(v1, v2));

        }
        [Fact]
        public void VersionComparerTest2()
        {
            string v1 = "1.1.0";
            string v2 = "1.1.1";
            Assert.Equal(-1, VC.Program.CompareVersion(v1, v2));

        }
        [Fact]
        public void VersionComparerTest3()
        {
            string v1 = "1.1.0";
            string v2 = "1.1.0";
            Assert.Equal(0, VC.Program.CompareVersion(v1, v2));

        }
    }
}