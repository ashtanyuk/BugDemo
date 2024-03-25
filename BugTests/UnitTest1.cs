namespace BugTests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        var bug = new Bug(Bug.State.Open);
        bug.Assign();
        var state = bug.getState();
        Assert.AreEqual(state, Bug.State.Assigned);
    }
    [TestMethod]
    public void TestMethod2()
    {
        var bug = new Bug(Bug.State.Open);
        bug.Assign();
        var state = bug.getState();
        Assert.AreEqual(state, Bug.State.Assigned);
    }
}