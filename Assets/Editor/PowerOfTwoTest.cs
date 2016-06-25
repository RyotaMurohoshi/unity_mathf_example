using UnityEngine;
using NUnit.Framework;
using System;

public class PowerOfTwoTest
{
    [Test]
    public void AndTest()
    {
        Func<string, int> convert = str => Convert.ToInt32(str, 2);

        Assert.That(convert("0001") & convert("0000"), Is.EqualTo(convert("0000")));
        Assert.That(convert("0010") & convert("0001"), Is.EqualTo(convert("0000")));
        Assert.That(convert("0100") & convert("0011"), Is.EqualTo(convert("0000")));
        Assert.That(convert("1000") & convert("0111"), Is.EqualTo(convert("0000")));
    }

    [Test]
    public void ClosestPowerOfTwoTest()
    {
        // http://docs.unity3d.com/ja/current/ScriptReference/Mathf.ClosestPowerOfTwo.html
        Assert.That(Mathf.ClosestPowerOfTwo(int.MinValue), Is.EqualTo(int.MinValue));
        Assert.That(Mathf.ClosestPowerOfTwo(-128), Is.EqualTo(0));
        Assert.That(Mathf.ClosestPowerOfTwo(-100), Is.EqualTo(0));

        Assert.That(Mathf.ClosestPowerOfTwo(-4), Is.EqualTo(0));
        Assert.That(Mathf.ClosestPowerOfTwo(-2), Is.EqualTo(0));
        Assert.That(Mathf.ClosestPowerOfTwo(-1), Is.EqualTo(0));
        Assert.That(Mathf.ClosestPowerOfTwo(0), Is.EqualTo(0));

        Assert.That(Mathf.ClosestPowerOfTwo(1), Is.EqualTo(1));
        Assert.That(Mathf.ClosestPowerOfTwo(2), Is.EqualTo(2));
        Assert.That(Mathf.ClosestPowerOfTwo(3), Is.EqualTo(4));
        Assert.That(Mathf.ClosestPowerOfTwo(4), Is.EqualTo(4));
        Assert.That(Mathf.ClosestPowerOfTwo(5), Is.EqualTo(4));
        Assert.That(Mathf.ClosestPowerOfTwo(6), Is.EqualTo(8));
        Assert.That(Mathf.ClosestPowerOfTwo(7), Is.EqualTo(8));
        Assert.That(Mathf.ClosestPowerOfTwo(8), Is.EqualTo(8));
        Assert.That(Mathf.ClosestPowerOfTwo(9), Is.EqualTo(8));
        Assert.That(Mathf.ClosestPowerOfTwo(10), Is.EqualTo(8));
        Assert.That(Mathf.ClosestPowerOfTwo(11), Is.EqualTo(8));
        Assert.That(Mathf.ClosestPowerOfTwo(12), Is.EqualTo(16));
        Assert.That(Mathf.ClosestPowerOfTwo(13), Is.EqualTo(16));
        Assert.That(Mathf.ClosestPowerOfTwo(14), Is.EqualTo(16));
        Assert.That(Mathf.ClosestPowerOfTwo(15), Is.EqualTo(16));
        Assert.That(Mathf.ClosestPowerOfTwo(16), Is.EqualTo(16));

        Assert.That(Mathf.ClosestPowerOfTwo(100), Is.EqualTo(128));
        Assert.That(Mathf.ClosestPowerOfTwo(128), Is.EqualTo(128));
    }

    [Test]
    public void IsPowerOfTwoTest()
    {
        // http://docs.unity3d.com/ja/current/ScriptReference/Mathf.IsPowerOfTwo.html

        Assert.True(Mathf.IsPowerOfTwo(int.MinValue));
        Assert.True(Mathf.IsPowerOfTwo(0));

        Assert.False(Mathf.IsPowerOfTwo(-1));
        Assert.True(Mathf.IsPowerOfTwo(1));
        Assert.True(Mathf.IsPowerOfTwo(2));
        Assert.False(Mathf.IsPowerOfTwo(3));
        Assert.True(Mathf.IsPowerOfTwo(4));
        Assert.False(Mathf.IsPowerOfTwo(5));
        Assert.False(Mathf.IsPowerOfTwo(6));
        Assert.False(Mathf.IsPowerOfTwo(7));
        Assert.True(Mathf.IsPowerOfTwo(8));
        Assert.False(Mathf.IsPowerOfTwo(9));
        Assert.False(Mathf.IsPowerOfTwo(10));

        Assert.True(Mathf.IsPowerOfTwo(16));
        Assert.True(Mathf.IsPowerOfTwo(32));
        Assert.True(Mathf.IsPowerOfTwo(64));
        Assert.True(Mathf.IsPowerOfTwo(128));
        Assert.True(Mathf.IsPowerOfTwo(256));
        Assert.True(Mathf.IsPowerOfTwo(512));
        Assert.True(Mathf.IsPowerOfTwo(1024));
        Assert.True(Mathf.IsPowerOfTwo(2048));
        Assert.True(Mathf.IsPowerOfTwo(4096));
        Assert.True(Mathf.IsPowerOfTwo(8192));
    }

    [Test]
    public void NextPowerOfTwoTest()
    {
        // http://docs.unity3d.com/ja/current/ScriptReference/Mathf.NextPowerOfTwo.html
        Assert.That(Mathf.NextPowerOfTwo(-128), Is.EqualTo(0));
        Assert.That(Mathf.NextPowerOfTwo(-100), Is.EqualTo(0));

        Assert.That(Mathf.NextPowerOfTwo(-4), Is.EqualTo(0));
        Assert.That(Mathf.NextPowerOfTwo(-2), Is.EqualTo(0));
        Assert.That(Mathf.NextPowerOfTwo(-1), Is.EqualTo(0));
        Assert.That(Mathf.NextPowerOfTwo(0), Is.EqualTo(0));

        Assert.That(Mathf.NextPowerOfTwo(1), Is.EqualTo(1));
        Assert.That(Mathf.NextPowerOfTwo(2), Is.EqualTo(2));
        Assert.That(Mathf.NextPowerOfTwo(3), Is.EqualTo(4));
        Assert.That(Mathf.NextPowerOfTwo(4), Is.EqualTo(4));
        Assert.That(Mathf.NextPowerOfTwo(5), Is.EqualTo(8));
        Assert.That(Mathf.NextPowerOfTwo(6), Is.EqualTo(8));
        Assert.That(Mathf.NextPowerOfTwo(7), Is.EqualTo(8));
        Assert.That(Mathf.NextPowerOfTwo(8), Is.EqualTo(8));
        Assert.That(Mathf.NextPowerOfTwo(9), Is.EqualTo(16));
        Assert.That(Mathf.NextPowerOfTwo(10), Is.EqualTo(16));
        Assert.That(Mathf.NextPowerOfTwo(11), Is.EqualTo(16));
        Assert.That(Mathf.NextPowerOfTwo(12), Is.EqualTo(16));
        Assert.That(Mathf.NextPowerOfTwo(13), Is.EqualTo(16));
        Assert.That(Mathf.NextPowerOfTwo(14), Is.EqualTo(16));
        Assert.That(Mathf.NextPowerOfTwo(15), Is.EqualTo(16));
        Assert.That(Mathf.NextPowerOfTwo(16), Is.EqualTo(16));
        Assert.That(Mathf.NextPowerOfTwo(17), Is.EqualTo(32));

        Assert.That(Mathf.NextPowerOfTwo(100), Is.EqualTo(128));
        Assert.That(Mathf.NextPowerOfTwo(128), Is.EqualTo(128));
        Assert.That(Mathf.NextPowerOfTwo(129), Is.EqualTo(256));
    }
}
