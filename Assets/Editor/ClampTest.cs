using UnityEngine;
using NUnit.Framework;

public class ClampTest
{
    [Test]
    public void ClampIntTest()
    {
        // http://docs.unity3d.com/ja/current/ScriptReference/Mathf.Clamp.html
        // Mathf.Clamp (value, min, max);
        Assert.That(Mathf.Clamp(0, -1, 2), Is.EqualTo(0));
        Assert.That(Mathf.Clamp(3, -1, 2), Is.EqualTo(2));
        Assert.That(Mathf.Clamp(-2, -1, 2), Is.EqualTo(-1));

        // invalid args : switch min max
        Assert.That(Mathf.Clamp(0, 1, -1), Is.EqualTo(1));
        Assert.That(Mathf.Clamp(2, 1, -1), Is.EqualTo(-1));
        Assert.That(Mathf.Clamp(-2, 1, -1), Is.EqualTo(1));

        // invalid args : same min max
        Assert.That(Mathf.Clamp(0, 0, 0), Is.EqualTo(0));
        Assert.That(Mathf.Clamp(2, 0, 0), Is.EqualTo(0));
        Assert.That(Mathf.Clamp(-2, 0, 0), Is.EqualTo(0));
    }

    [Test]
    public void ClampFloatTest()
    {
        // http://docs.unity3d.com/ja/current/ScriptReference/Mathf.Clamp.html
        // Mathf.Clamp (value, min, max);
        Assert.That(Mathf.Clamp(0.5F, -1.0F, 1.0F), Is.EqualTo(0.5F));
        Assert.That(Mathf.Clamp(2.5F, -1.0F, 2.0F), Is.EqualTo(2.0F));
        Assert.That(Mathf.Clamp(-2.5F, -1.0F, 2.0F), Is.EqualTo(-1.0F));

        // invalid args : switch min max
        Assert.That(Mathf.Clamp(0.5F, 1.0F, -1.0F), Is.EqualTo(1.0F));
        Assert.That(Mathf.Clamp(2.5F, 1.0F, -1.0F), Is.EqualTo(-1.0F));
        Assert.That(Mathf.Clamp(-2.5F, 1.0F, -1.0F), Is.EqualTo(1.0F));

        // invalid args : same min max
        Assert.That(Mathf.Clamp(0.0F, 0.0F, 0.0F), Is.EqualTo(0.0F));
        Assert.That(Mathf.Clamp(2.5F, 0.0F, 0.0F), Is.EqualTo(0.0F));
        Assert.That(Mathf.Clamp(-2.5F, 0.0F, 0.0F), Is.EqualTo(0.0F));
    }

    [Test]
    public void Clamp01Test()
    {
        // http://docs.unity3d.com/ja/current/ScriptReference/Mathf.Clamp01.html
        Assert.That(Mathf.Clamp01(float.MinValue), Is.EqualTo(0.0F));
        Assert.That(Mathf.Clamp01(-1.0F), Is.EqualTo(0.0F));
        Assert.That(Mathf.Clamp01(-0.00001F), Is.EqualTo(0.0F));

        Assert.That(Mathf.Clamp01(0.0F), Is.EqualTo(0.0F));
        Assert.That(Mathf.Clamp01(0.00001F), Is.EqualTo(0.00001F));
        Assert.That(Mathf.Clamp01(0.5F), Is.EqualTo(0.5F));
        Assert.That(Mathf.Clamp01(0.99999F), Is.EqualTo(0.99999F));
        Assert.That(Mathf.Clamp01(1.0F), Is.EqualTo(1.0F));

        Assert.That(Mathf.Clamp01(1.00001F), Is.EqualTo(1.0F));
        Assert.That(Mathf.Clamp01(2.0F), Is.EqualTo(1.0F));
        Assert.That(Mathf.Clamp01(float.MaxValue), Is.EqualTo(1.0F));
    }
}
