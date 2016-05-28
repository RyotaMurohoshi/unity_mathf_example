using UnityEngine;
using NUnit.Framework;

public class GammaLinearTest
{
    [Test]
    public void GammaToLinnearSpaceTest()
    {
        Assert.AreEqual(0.0F, Mathf.GammaToLinearSpace(0.0F));
        Assert.AreEqual(0.01002283F, Mathf.GammaToLinearSpace(0.1F), 0.00001F);
        Assert.AreEqual(0.03310477F, Mathf.GammaToLinearSpace(0.2F), 0.00001F);
        Assert.AreEqual(0.07323897F, Mathf.GammaToLinearSpace(0.3F), 0.00001F);
        Assert.AreEqual(0.13286830F, Mathf.GammaToLinearSpace(0.4F), 0.00001F);
        Assert.AreEqual(0.21404110F, Mathf.GammaToLinearSpace(0.5F), 0.00001F);
        Assert.AreEqual(0.31854680F, Mathf.GammaToLinearSpace(0.6F), 0.00001F);
        Assert.AreEqual(0.44798840F, Mathf.GammaToLinearSpace(0.7F), 0.00001F);
        Assert.AreEqual(0.60382740F, Mathf.GammaToLinearSpace(0.8F), 0.00001F);
        Assert.AreEqual(0.78741250F, Mathf.GammaToLinearSpace(0.9F), 0.00001F);
        Assert.AreEqual(1.0F, Mathf.GammaToLinearSpace(1.0F));

        // TODO Add more test
    }

    [Test]
    public void LinearToGammaSpaceTest()
    {
        Assert.AreEqual(0.0F, Mathf.LinearToGammaSpace(0.0F));
        Assert.AreEqual(0.3491902F, Mathf.LinearToGammaSpace(0.1F), 0.00001F);
        Assert.AreEqual(0.4845292F, Mathf.LinearToGammaSpace(0.2F), 0.00001F);
        Assert.AreEqual(0.5838314F, Mathf.LinearToGammaSpace(0.3F), 0.00001F);
        Assert.AreEqual(0.6651850F, Mathf.LinearToGammaSpace(0.4F), 0.00001F);
        Assert.AreEqual(0.7353570F, Mathf.LinearToGammaSpace(0.5F), 0.00001F);
        Assert.AreEqual(0.7977377F, Mathf.LinearToGammaSpace(0.6F), 0.00001F);
        Assert.AreEqual(0.8543057F, Mathf.LinearToGammaSpace(0.7F), 0.00001F);
        Assert.AreEqual(0.9063317F, Mathf.LinearToGammaSpace(0.8F), 0.00001F);
        Assert.AreEqual(0.9546872F, Mathf.LinearToGammaSpace(0.9F), 0.00001F);
        Assert.AreEqual(1.0F, Mathf.LinearToGammaSpace(1.0F));

        // TODO Add more test
    }
}
