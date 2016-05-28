using UnityEngine;
using NUnit.Framework;

public class MinMaxTest
{
    [Test]
    public void MaxIntTest()
    {
        // http://docs.unity3d.com/ja/current/ScriptReference/Mathf.Max.html
        Assert.That(Mathf.Max(1, 2), Is.EqualTo(2));
        Assert.That(Mathf.Max(-1, 3), Is.EqualTo(3));
        Assert.That(Mathf.Max(2, 2), Is.EqualTo(2));
        Assert.That(Mathf.Max(0, 0), Is.EqualTo(0));
        Assert.That(Mathf.Max(3, 1), Is.EqualTo(3));
        Assert.That(Mathf.Max(2, -1), Is.EqualTo(2));
    }

    [Test]
    public void MaxFloatTest()
    {
        // http://docs.unity3d.com/ja/current/ScriptReference/Mathf.Max.html
        Assert.That(Mathf.Max(1.0F, 2.0F), Is.EqualTo(2.0F));
        Assert.That(Mathf.Max(-1.0F, 3.0F), Is.EqualTo(3.0F));
        Assert.That(Mathf.Max(2.0F, 2.0F), Is.EqualTo(2.0F));
        Assert.That(Mathf.Max(0.0F, 0.0F), Is.EqualTo(0.0F));
        Assert.That(Mathf.Max(3.0F, 1.0F), Is.EqualTo(3.0F));
        Assert.That(Mathf.Max(2.0F, -1.0F), Is.EqualTo(2.0F));
    }

    [Test]
    public void MaxIntParamsTest()
    {
        // http://docs.unity3d.com/ja/current/ScriptReference/Mathf.Max.html
        Assert.That(Mathf.Max(new int[0]), Is.EqualTo(0));
        Assert.That(Mathf.Max(1), Is.EqualTo(1));
        Assert.That(Mathf.Max(-3, 1), Is.EqualTo(1));
        Assert.That(Mathf.Max(2, 0), Is.EqualTo(2));
        Assert.That(Mathf.Max(1, 2, -1, 2), Is.EqualTo(2));
        Assert.That(Mathf.Max(3, 1, 4, 1, 5, 9, 2), Is.EqualTo(9));
        Assert.That(Mathf.Max(-3, -1, -4, -1, -5, -9, -2), Is.EqualTo(-1));
    }

    [Test]
    public void MaxFloatParamsTest()
    {
        // http://docs.unity3d.com/ja/current/ScriptReference/Mathf.Max.html
        Assert.That(Mathf.Max(new float[0]), Is.EqualTo(0.0F));
        Assert.That(Mathf.Max(1.0F), Is.EqualTo(1.0F));
        Assert.That(Mathf.Max(-3.0F, 1.0F), Is.EqualTo(1.0F));
        Assert.That(Mathf.Max(2.0F, 0.0F), Is.EqualTo(2.0F));
        Assert.That(Mathf.Max(1.0F, 2.0F, -1.0F, 2.0F), Is.EqualTo(2.0F));
        Assert.That(Mathf.Max(3.0F, 1.0F, 4.0F, 1.0F, 5.0F, 9.0F, 2.0F), Is.EqualTo(9.0F));
        Assert.That(Mathf.Max(-3.0F, -1.0F, -4.0F, -1.0F, -5.0F, -9.0F, -2.0F), Is.EqualTo(-1.0F));
    }

    [Test]
    public void MinIntTest()
    {
        // http://docs.unity3d.com/ja/current/ScriptReference/Mathf.Min.html
        Assert.That(Mathf.Min(1, 2), Is.EqualTo(1));
        Assert.That(Mathf.Min(-1, 3), Is.EqualTo(-1));
        Assert.That(Mathf.Min(2, 2), Is.EqualTo(2));
        Assert.That(Mathf.Min(0, 0), Is.EqualTo(0));
        Assert.That(Mathf.Min(3, 1), Is.EqualTo(1));
        Assert.That(Mathf.Min(2, -1), Is.EqualTo(-1));
    }

    [Test]
    public void MinFloatTest()
    {
        // http://docs.unity3d.com/ja/current/ScriptReference/Mathf.Min.html
        Assert.That(Mathf.Min(1.0F, 2.0F), Is.EqualTo(1.0F));
        Assert.That(Mathf.Min(-1.0F, 3.0F), Is.EqualTo(-1.0F));
        Assert.That(Mathf.Min(2.0F, 2.0F), Is.EqualTo(2.0F));
        Assert.That(Mathf.Min(0.0F, 0.0F), Is.EqualTo(0.0F));
        Assert.That(Mathf.Min(3.0F, 1.0F), Is.EqualTo(1.0F));
        Assert.That(Mathf.Min(2.0F, -1.0F), Is.EqualTo(-1.0F));
    }

    [Test]
    public void MinIntParamsTest()
    {
        // http://docs.unity3d.com/ja/current/ScriptReference/Mathf.Min.html
        Assert.That(Mathf.Min(new int[0]), Is.EqualTo(0));
        Assert.That(Mathf.Min(1), Is.EqualTo(1));
        Assert.That(Mathf.Min(-3, 1), Is.EqualTo(-3));
        Assert.That(Mathf.Min(2, 0), Is.EqualTo(0));
        Assert.That(Mathf.Min(-1, 2, -1, 1), Is.EqualTo(-1));
        Assert.That(Mathf.Min(3, 1, 4, 1, 5, 9, 2), Is.EqualTo(1));
        Assert.That(Mathf.Min(-3, -1, -4, -1, -5, -9, -2), Is.EqualTo(-9));
    }

    [Test]
    public void MinFloatParamsTest()
    {
        // http://docs.unity3d.com/ja/current/ScriptReference/Mathf.Min.html
        Assert.That(Mathf.Min(new float[0]), Is.EqualTo(0.0F));
        Assert.That(Mathf.Min(1.0F), Is.EqualTo(1.0F));
        Assert.That(Mathf.Min(-3.0F, 1.0F), Is.EqualTo(-3.0F));
        Assert.That(Mathf.Min(2.0F, 0.0F), Is.EqualTo(0.0F));
        Assert.That(Mathf.Min(-1.0F, -2.0F, 1.0F, -2.0F), Is.EqualTo(-2.0F));
        Assert.That(Mathf.Min(3.0F, 1.0F, 4.0F, 1.0F, 5.0F, 9.0F, 2.0F), Is.EqualTo(1.0F));
        Assert.That(Mathf.Min(-3.0F, -1.0F, -4.0F, -1.0F, -5.0F, -9.0F, -2.0F), Is.EqualTo(-9.0F));
    }
}
