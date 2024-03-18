using AvoChocarithms.SectionA.DataStructures2.Models;
using System.Data;

namespace AvoChocarithms.SectionA.DataStructures2.Tests
{
    [TestClass]
    public class TestContactRepo
    {
        [TestMethod]
        [DataRow("first_name;last_name\r\nLeota;Dilliard\r\nJosephine;Darakjy\r\nLindsey;Dilello\r\n")]
        public void TestThreeContactOnePage(string Data, string LineDelimiter = "\r\n", string FieldDelimiter = ";")
        {
            ContactRepo repo = new ContactRepo(Data);
            int expectedContactCount = 3;
            int expectedPageCount = 1;
            int expectedPageBSize = 0;
            int expectedPageDSize = 3;
            int expectedPageVSize = 0;

            int actualContactCount = repo.GetContactCount();
            int actualPageCount = repo.GetContactPageCount();
            int actualPageBSize = repo.GetContactPageSize('B');
            int actualPageDSize = repo.GetContactPageSize('D');
            int actualPageVSize = repo.GetContactPageSize('V');
            List<PersonInfo>? pageB = repo.GetContactPage('B')?.ToList();
            List<PersonInfo>? pageD = repo.GetContactPage('D')?.ToList();
            List<PersonInfo>? pageV = repo.GetContactPage('V')?.ToList();

            Assert.IsNotNull(repo);
            Assert.IsNull(pageB);
            Assert.IsNotNull(pageD);
            Assert.IsNull(pageV);
            Assert.AreEqual(expectedContactCount, actualContactCount);
            Assert.AreEqual(expectedPageCount, actualPageCount);
            Assert.AreEqual(expectedPageBSize, actualPageBSize);
            Assert.AreEqual(expectedPageDSize, actualPageDSize);
            Assert.AreEqual(expectedPageVSize, actualPageVSize);
        }

        [TestMethod]
        [DataRow("first_name;last_name\r\nJames;Butt\r\nJosephine;Darakjy\r\nCarissa;Batman\r\n")]
        public void TestThreeContactTwoPage(string Data, string LineDelimiter = "\r\n", string FieldDelimiter = ";")
        {
            ContactRepo repo = new ContactRepo(Data);
            int expectedContactCount = 3;
            int expectedPageCount = 2;
            int expectedPageBSize = 2;
            int expectedPageDSize = 1;
            int expectedPageVSize = 0;

            int actualContactCount = repo.GetContactCount();
            int actualPageCount = repo.GetContactPageCount();
            int actualPageBSize = repo.GetContactPageSize('B');
            int actualPageDSize = repo.GetContactPageSize('D');
            int actualPageVSize = repo.GetContactPageSize('V');
            List<PersonInfo>? pageB = repo.GetContactPage('B')?.ToList();
            List<PersonInfo>? pageD = repo.GetContactPage('D')?.ToList();
            List<PersonInfo>? pageV = repo.GetContactPage('V')?.ToList();

            Assert.IsNotNull(repo);
            Assert.IsNotNull(pageB);
            Assert.IsNotNull(pageD);
            Assert.IsNull(pageV);
            Assert.AreEqual(expectedContactCount, actualContactCount);
            Assert.AreEqual(expectedPageCount, actualPageCount);
            Assert.AreEqual(expectedPageBSize, actualPageBSize);
            Assert.AreEqual(expectedPageDSize, actualPageDSize);
            Assert.AreEqual(expectedPageVSize, actualPageVSize);
        }

        [TestMethod]
        [DataRow("first_name;last_name\r\nJames;Butt\r\nJosephine;Darakjy\r\nArt;Venere\r\n")]
        public void TestThreeContactThreePage(string Data, string LineDelimiter = "\r\n", string FieldDelimiter = ";")
        {
            ContactRepo repo = new ContactRepo(Data);
            int expectedContactCount = 3;
            int expectedPageCount = 3;
            int expectedPageBSize = 1;
            int expectedPageDSize = 1;
            int expectedPageVSize = 1;

            int actualContactCount = repo.GetContactCount();
            int actualPageCount = repo.GetContactPageCount();
            int actualPageBSize = repo.GetContactPageSize('B');
            int actualPageDSize = repo.GetContactPageSize('D');
            int actualPageVSize = repo.GetContactPageSize('V');
            List<PersonInfo>? pageB = repo.GetContactPage('B')?.ToList();
            List<PersonInfo>? pageD = repo.GetContactPage('D')?.ToList();
            List<PersonInfo>? pageV = repo.GetContactPage('V')?.ToList();

            Assert.IsNotNull(repo);
            Assert.IsNotNull(pageB);
            Assert.IsNotNull(pageD);
            Assert.IsNotNull(pageV);
            Assert.AreEqual(expectedContactCount, actualContactCount);
            Assert.AreEqual(expectedPageCount, actualPageCount);
            Assert.AreEqual(expectedPageBSize, actualPageBSize);
            Assert.AreEqual(expectedPageDSize, actualPageDSize);
            Assert.AreEqual(expectedPageVSize, actualPageVSize);
        }
    }
}