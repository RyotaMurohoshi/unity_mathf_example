using UnityEngine;
using NUnit.Framework;

public class OthersTest
{
    [Test]
    public void ConstantsTest()
    {
        Assert.That(Mathf.Rad2Deg, Is.EqualTo(57.2957802F));
        Assert.That(Mathf.Deg2Rad, Is.EqualTo(0.0174532924F));
        Assert.That(Mathf.PI, Is.EqualTo(3.14159274F));
        Assert.That(Mathf.Epsilon, Is.EqualTo(1.40129846E-45F));
        Assert.That(Mathf.Infinity, Is.EqualTo(float.PositiveInfinity));
        Assert.That(Mathf.NegativeInfinity, Is.EqualTo(float.NegativeInfinity));
    }

    [Test]
    public void AbsIntTest()
    {
        // http://docs.unity3d.com/ja/current/ScriptReference/Mathf.Abs.html
        Assert.That(Mathf.Abs(0), Is.EqualTo(0));
        Assert.That(Mathf.Abs(1), Is.EqualTo(1));
        Assert.That(Mathf.Abs(-1), Is.EqualTo(1));
        Assert.That(Mathf.Abs(6), Is.EqualTo(6));
        Assert.That(Mathf.Abs(-7), Is.EqualTo(7));
        Assert.That(Mathf.Abs(int.MaxValue), Is.EqualTo(int.MaxValue));

        Assert.Throws<System.OverflowException>(() =>
        {
            Mathf.Abs(int.MinValue);
        });
    }

    [Test]
    public void AbsFloatTest()
    {
        // http://docs.unity3d.com/ja/current/ScriptReference/Mathf.Abs.html
        Assert.That(Mathf.Abs(0.0F), Is.EqualTo(0.0F));
        Assert.That(Mathf.Abs(1.0F), Is.EqualTo(1.0F));
        Assert.That(Mathf.Abs(-1.0F), Is.EqualTo(1.0F));
        Assert.That(Mathf.Abs(6.0F), Is.EqualTo(6.0F));
        Assert.That(Mathf.Abs(-7.0F), Is.EqualTo(7.0F));
        Assert.That(Mathf.Abs(float.MaxValue), Is.EqualTo(float.MaxValue));
        Assert.That(Mathf.Abs(float.MinValue), Is.EqualTo(float.MaxValue));
    }

    [Test]
    public void ApproximatelyTest()
    {
        // http://docs.unity3d.com/ja/current/ScriptReference/Mathf.Approximately.html
        Assert.That(Mathf.Approximately(0.0F, 0.0F), Is.True);
        Assert.That(Mathf.Approximately(0.0F, float.Epsilon), Is.True);
        Assert.That(Mathf.Approximately(1.0F, 1.000001F), Is.True);
        Assert.That(Mathf.Approximately(1.0F, 1.01F), Is.False);

        Assert.That(Mathf.Approximately(100000.0F, 100000.00F), Is.True);
        Assert.That(Mathf.Approximately(100000.0F, 100000.01F), Is.True);
    }

    [Test]
    public void DeltaAngleTest()
    {
        // http://docs.unity3d.com/ja/current/ScriptReference/Mathf.DeltaAngle.html
        Assert.That(Mathf.DeltaAngle(0, 170.0F), Is.EqualTo(170.0F));
        Assert.That(Mathf.DeltaAngle(0, 180.0F), Is.EqualTo(180.0F));
        Assert.That(Mathf.DeltaAngle(0, 181.0F), Is.EqualTo(-179.0F));

        Assert.That(Mathf.DeltaAngle(170.0F, 0.0F), Is.EqualTo(-170.0F));
        Assert.That(Mathf.DeltaAngle(180.0F, 0.0F), Is.EqualTo(180.0F));
        Assert.That(Mathf.DeltaAngle(181.0F, 0.0F), Is.EqualTo(179.0F));

        Assert.That(Mathf.DeltaAngle(-30.0F, 20.0F), Is.EqualTo(50.0F));
        Assert.That(Mathf.DeltaAngle(20.0F, -30.0F), Is.EqualTo(-50.0F));

        Assert.That(Mathf.DeltaAngle(0, 450.0F), Is.EqualTo(90.0F));
        Assert.That(Mathf.DeltaAngle(0, 540.0F), Is.EqualTo(180.0F));
        Assert.That(Mathf.DeltaAngle(0, 630.0F), Is.EqualTo(-90.0F));
        Assert.That(Mathf.DeltaAngle(0, 720.0F), Is.EqualTo(0.0F));
    }

    [Test]
    public void SignTest()
    {
        // http://docs.unity3d.com/ja/current/ScriptReference/Mathf.Sign.html
        Assert.That(Mathf.Sign(float.PositiveInfinity), Is.EqualTo(+1.0F));
        Assert.That(Mathf.Sign(+1.5F), Is.EqualTo(+1.0F));
        Assert.That(Mathf.Sign(+1.0F), Is.EqualTo(+1.0F));
        Assert.That(Mathf.Sign(+0.999999F), Is.EqualTo(+1.0F));
        Assert.That(Mathf.Sign(+float.Epsilon), Is.EqualTo(+1.0F));
        Assert.That(Mathf.Sign(+0.0F), Is.EqualTo(+1.0F));
        Assert.That(Mathf.Sign(-0.0F), Is.EqualTo(+1.0F));
        Assert.That(Mathf.Sign(-float.Epsilon), Is.EqualTo(-1.0F));
        Assert.That(Mathf.Sign(-0.999999F), Is.EqualTo(-1.0F));
        Assert.That(Mathf.Sign(-1.0F), Is.EqualTo(-1.0F));
        Assert.That(Mathf.Sign(-1.5F), Is.EqualTo(-1.0F));
        Assert.That(Mathf.Sign(float.NegativeInfinity), Is.EqualTo(-1.0F));
    }
}
