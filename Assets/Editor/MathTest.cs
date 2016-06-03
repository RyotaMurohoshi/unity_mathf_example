using UnityEngine;
using NUnit.Framework;

public class MathTest
{

    [Test]
    public void SinTest()
    {
        // http://docs.unity3d.com/ja/current/ScriptReference/Mathf.Sin.html
        float root2Div2 = Mathf.Pow(2, 0.5F) / 2.0F;
        float root3Div2 = Mathf.Pow(3, 0.5F) / 2.0F;

        Assert.AreEqual(Mathf.Sin(-1.0F / 3.0F * Mathf.PI), -root3Div2, 0.00001F);
        Assert.AreEqual(Mathf.Sin(-1.0F / 4.0F * Mathf.PI), -root2Div2, 0.00001F);
        Assert.AreEqual(Mathf.Sin(-1.0F / 6.0F * Mathf.PI), -0.5F, 0.00001F);
        Assert.AreEqual(Mathf.Sin(0), 0.0F, 0.00001F);
        Assert.AreEqual(Mathf.Sin(1.0F / 6.0F * Mathf.PI), 0.5F, 0.00001F);
        Assert.AreEqual(Mathf.Sin(1.0F / 4.0F * Mathf.PI), root2Div2, 0.00001F);
        Assert.AreEqual(Mathf.Sin(1.0F / 3.0F * Mathf.PI), root3Div2, 0.00001F);
        Assert.AreEqual(Mathf.Sin(1.0F / 2.0F * Mathf.PI), 1.0F, 0.00001F);
        Assert.AreEqual(Mathf.Sin(2.0F / 3.0F * Mathf.PI), root3Div2, 0.00001F);
        Assert.AreEqual(Mathf.Sin(3.0F / 4.0F * Mathf.PI), root2Div2, 0.00001F);
        Assert.AreEqual(Mathf.Sin(5.0F / 6.0F * Mathf.PI), 0.5F, 0.00001F);
        Assert.AreEqual(Mathf.Sin(Mathf.PI), 0.0F, 0.00001F);
        Assert.AreEqual(Mathf.Sin(7.0F / 6.0F * Mathf.PI), -0.5F, 0.00001F);
        Assert.AreEqual(Mathf.Sin(5.0F / 4.0F * Mathf.PI), -root2Div2, 0.00001F);
        Assert.AreEqual(Mathf.Sin(4.0F / 3.0F * Mathf.PI), -root3Div2, 0.00001F);
        Assert.AreEqual(Mathf.Sin(3.0F / 2.0F * Mathf.PI), -1.0F, 0.00001F);
        Assert.AreEqual(Mathf.Sin(5.0F / 3.0F * Mathf.PI), -root3Div2, 0.00001F);
        Assert.AreEqual(Mathf.Sin(7.0F / 4.0F * Mathf.PI), -root2Div2, 0.00001F);
        Assert.AreEqual(Mathf.Sin(11.0F / 6.0F * Mathf.PI), -0.5F, 0.00001F);
        Assert.AreEqual(Mathf.Sin(2 *  Mathf.PI), 0.0F, 0.00001F);
        Assert.AreEqual(Mathf.Sin(13.0F / 6.0F * Mathf.PI), 0.5F, 0.00001F);
        Assert.AreEqual(Mathf.Sin(9.0F / 4.0F * Mathf.PI), root2Div2, 0.00001F);
        Assert.AreEqual(Mathf.Sin(7.0F / 3.0F * Mathf.PI), root3Div2, 0.00001F);
    }

    [Test]
    public void CosTest()
    {
        // http://docs.unity3d.com/ja/current/ScriptReference/Mathf.Cos.html

        float root2Div2 = Mathf.Pow(2, 0.5F) / 2.0F;
        float root3Div2 = Mathf.Pow(3, 0.5F) / 2.0F;
        Assert.AreEqual(Mathf.Cos(-1.0F / 3.0F * Mathf.PI), 0.5F, 0.00001F);
        Assert.AreEqual(Mathf.Cos(-1.0F / 4.0F * Mathf.PI), root2Div2, 0.00001F);
        Assert.AreEqual(Mathf.Cos(-1.0F / 6.0F * Mathf.PI), root3Div2, 0.00001F);
        Assert.AreEqual(Mathf.Cos(0), 1.0F, 0.00001F);
        Assert.AreEqual(Mathf.Cos(1.0F / 6.0F * Mathf.PI), root3Div2, 0.00001F);
        Assert.AreEqual(Mathf.Cos(1.0F / 4.0F * Mathf.PI), root2Div2, 0.00001F);
        Assert.AreEqual(Mathf.Cos(1.0F / 3.0F * Mathf.PI), 0.5F, 0.00001F);
        Assert.AreEqual(Mathf.Cos(1.0F / 2.0F * Mathf.PI), 0.0F, 0.00001F);
        Assert.AreEqual(Mathf.Cos(2.0F / 3.0F * Mathf.PI), -0.5, 0.00001F);
        Assert.AreEqual(Mathf.Cos(3.0F / 4.0F * Mathf.PI), -root2Div2, 0.00001F);
        Assert.AreEqual(Mathf.Cos(5.0F / 6.0F * Mathf.PI), -root3Div2, 0.00001F);
        Assert.AreEqual(Mathf.Cos(Mathf.PI), -1.0F, 0.00001F);
        Assert.AreEqual(Mathf.Cos(7.0F / 6.0F * Mathf.PI), -root3Div2, 0.00001F);
        Assert.AreEqual(Mathf.Cos(5.0F / 4.0F * Mathf.PI), -root2Div2, 0.00001F);
        Assert.AreEqual(Mathf.Cos(4.0F / 3.0F * Mathf.PI), -0.5F, 0.00001F);
        Assert.AreEqual(Mathf.Cos(3.0F / 2.0F * Mathf.PI), 0.0F, 0.00001F);
        Assert.AreEqual(Mathf.Cos(5.0F / 3.0F * Mathf.PI), 0.5F, 0.00001F);
        Assert.AreEqual(Mathf.Cos(7.0F / 4.0F * Mathf.PI), root2Div2, 0.00001F);
        Assert.AreEqual(Mathf.Cos(11.0F / 6.0F * Mathf.PI), root3Div2, 0.00001F);
        Assert.AreEqual(Mathf.Cos(2 * Mathf.PI), 1.0F, 0.00001F);
        Assert.AreEqual(Mathf.Cos(13.0F / 6.0F * Mathf.PI), root3Div2, 0.00001F);
        Assert.AreEqual(Mathf.Cos(9.0F / 4.0F * Mathf.PI), root2Div2, 0.00001F);
        Assert.AreEqual(Mathf.Cos(7.0F / 3.0F * Mathf.PI), 0.5F, 0.00001F);
    }

    [Test]
    public void TanTest()
    {
        // http://docs.unity3d.com/ja/current/ScriptReference/Mathf.Tan.html

        float root3 = Mathf.Pow(3, 0.5F);
        float oneDivRoot3 = 1.0F / root3;
        Assert.AreEqual(Mathf.Tan(-1.0F / 3.0F * Mathf.PI), -root3, 0.00001F);
        Assert.AreEqual(Mathf.Tan(-1.0F / 4.0F * Mathf.PI), -1, 0.00001F);
        Assert.AreEqual(Mathf.Tan(-1.0F / 6.0F * Mathf.PI), -oneDivRoot3, 0.00001F);
        Assert.AreEqual(Mathf.Tan(0), 0.0F, 0.00001F);
        Assert.AreEqual(Mathf.Tan(1.0F / 6.0F * Mathf.PI), oneDivRoot3, 0.00001F);
        Assert.AreEqual(Mathf.Tan(1.0F / 4.0F * Mathf.PI), 1, 0.00001F);
        Assert.AreEqual(Mathf.Tan(1.0F / 3.0F * Mathf.PI), root3, 0.00001F);
        Assert.AreEqual(Mathf.Tan(2.0F / 3.0F * Mathf.PI), -root3, 0.00001F);
        Assert.AreEqual(Mathf.Tan(3.0F / 4.0F * Mathf.PI), -1, 0.00001F);
        Assert.AreEqual(Mathf.Tan(5.0F / 6.0F * Mathf.PI), -oneDivRoot3, 0.00001F);
        Assert.AreEqual(Mathf.Tan(Mathf.PI), -0.0F, 0.00001F);
        Assert.AreEqual(Mathf.Tan(7.0F / 6.0F * Mathf.PI), oneDivRoot3, 0.00001F);
        Assert.AreEqual(Mathf.Tan(5.0F / 4.0F * Mathf.PI), 1, 0.00001F);
        Assert.AreEqual(Mathf.Tan(4.0F / 3.0F * Mathf.PI), root3, 0.00001F);
        Assert.AreEqual(Mathf.Tan(5.0F / 3.0F * Mathf.PI), -root3, 0.00001F);
        Assert.AreEqual(Mathf.Tan(7.0F / 4.0F * Mathf.PI), -1, 0.00001F);
        Assert.AreEqual(Mathf.Tan(11.0F / 6.0F * Mathf.PI), -oneDivRoot3, 0.00001F);
        Assert.AreEqual(Mathf.Tan(2 * Mathf.PI), 0.0F, 0.00001F);
        Assert.AreEqual(Mathf.Tan(13.0F / 6.0F * Mathf.PI), oneDivRoot3, 0.00001F);
        Assert.AreEqual(Mathf.Tan(9.0F / 4.0F * Mathf.PI), 1, 0.00001F);
        Assert.AreEqual(Mathf.Tan(7.0F / 3.0F * Mathf.PI), root3, 0.00001F);

        // Calculation error causet not equals to float.PositiveInfinity 
        Assert.AreEqual(Mathf.Tan(1.0F / 2.0F * Mathf.PI), -22877332.0F, 0.00001F);

        // Calculation error causet not equals to float.NegativeInfinity 
        Assert.AreEqual(Mathf.Tan(3.0F / 2.0F * Mathf.PI), -83858280.0F, 0.00001F);
    }

}
