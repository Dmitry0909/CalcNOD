
namespace Calculator.Test
{
    [TestClass]
    public class TestNOD
    {
        [TestMethod]
        [DataRow(14144, 26163, "17")]
        [DataRow(1, 0, "0")]
        [DataRow(24, 36, "12")]
        [DataRow(84, 90, "6")]
        public void Test(int x, int y, string expectation)
        {
            CalcNOD equCalc = new CalcNOD();
            if (expectation != null)
            {
                string result = equCalc.NOD(x, y);
                Assert.AreEqual(expectation, result);
            }
            else
            {
                Assert.ThrowsException<DivideByZeroException>(() => { equCalc.NOD(x, y); });
            }
        }
    }
}