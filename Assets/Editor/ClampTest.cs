using UnityEngine;
using NUnit.Framework;

public class ClampTest
{
    [Test]
    public void ClampIntTest()
    {
        //Mathf.Clamp (value, min, max);
        Assert.That(Mathf.Clamp(0, -1, 2), Is.EqualTo(0));
        Assert.That(Mathf.Clamp(3, -1, 2), Is.EqualTo(2));
        Assert.That(Mathf.Clamp(-2, -1, 2), Is.EqualTo(-1));

        // iregular args
        // We shoul with named arg?
        Assert.That(Mathf.Clamp(0, 1, -1), Is.EqualTo(1));
        Assert.That(Mathf.Clamp(2, 1, -1), Is.EqualTo(-1));
        Assert.That(Mathf.Clamp(-2, 1, -1), Is.EqualTo(1));
    }

    [Test]
    public void ClampFloatTest()
    {
        //Mathf.Clamp (value, min, max);
        Assert.That(Mathf.Clamp(0.5F, -1.0F, 1.0F), Is.EqualTo(0.5F));
        Assert.That(Mathf.Clamp(2.5F, -1.0F, 2.0F), Is.EqualTo(2.0F));
        Assert.That(Mathf.Clamp(-2.5F, -1.0F, 2.0F), Is.EqualTo(-1.0F));

        // iregular args
        // We shoul with named arg?
        Assert.That(Mathf.Clamp(0.5F, 1.0F, -1.0F), Is.EqualTo(1.0F));
        Assert.That(Mathf.Clamp(2.5F, 1.0F, -1.0F), Is.EqualTo(-1.0F));
        Assert.That(Mathf.Clamp(-2.5F, 1.0F, -1.0F), Is.EqualTo(1.0F));
    }

    [Test]
    public void Clamp01Test()
    {
        Assert.That(Mathf.Clamp01(float.MinValue), Is.EqualTo(0.0F));
        Assert.That(Mathf.Clamp01(-1.0F), Is.EqualTo(0.0F));
        Assert.That(Mathf.Clamp01(-float.Epsilon), Is.EqualTo(0.0F));

        Assert.That(Mathf.Clamp01(0.0F), Is.EqualTo(0.0F));
        Assert.That(Mathf.Clamp01(float.Epsilon), Is.EqualTo(float.Epsilon));
        Assert.That(Mathf.Clamp01(0.5F), Is.EqualTo(0.5F));
        Assert.That(Mathf.Clamp01(1.0F - float.Epsilon), Is.EqualTo(1.0F - float.Epsilon));
        Assert.That(Mathf.Clamp01(1.0F), Is.EqualTo(1.0F));

        Assert.That(Mathf.Clamp01(1.0F + float.Epsilon), Is.EqualTo(1.0F + float.Epsilon));
        Assert.That(Mathf.Clamp01(2.0F), Is.EqualTo(1.0F));
        Assert.That(Mathf.Clamp01(float.MaxValue), Is.EqualTo(1.0F));
    }
}
