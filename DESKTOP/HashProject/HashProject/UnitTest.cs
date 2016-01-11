using NUnit.Framework;
using HashCode;

namespace HashProject
{
    [TestFixture]
    public class UnitTest
    {
        [Test]
        [TestCase(new string[] { "Aaa","aAa","aaA","aaa","AAA","aAA","AAa","AaA"},new string[] {"Bbb","bBb","bbB","bbb","BBB","bBB","BBb","BbB" },new int[] {42,24,22,44,61,16,11,66 })]
        public void AddInHashTable(string[] fNames,string[] lNames,int[] ages)
        {
            PersonHashCode phc = new PersonHashCode();
            int[] hashes = new int[fNames.Length];
            for (int i = 0; i < fNames.Length; i++)
            {
                phc.Add(new Person(fNames[i], lNames[i], ages[i]));
            }
            

        }
    }
}
