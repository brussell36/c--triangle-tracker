using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;

namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleTrackerTests
  {
    [TestMethod]
    public void CheckTriangle_SidesCanBeTriangle_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual("not a triangle", testTriangle.CheckTriangle(2, 2, 22));
    }

    [TestMethod]
    public void CheckTriangle_IsScalene_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual("scalene", testTriangle.CheckTriangle(3, 4, 5));
    }

    [TestMethod]
    public void CheckTriangle_IsIsosceles_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual("isosceles", testTriangle.CheckTriangle(3, 3, 5));
    }

    [TestMethod]

    public void CheckTriangle_IsEquilateral_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual("equilateral", testTriangle.CheckTriangle(3,3,3));
    }

  }
}