using UnityEngine;
using NUnit.Framework;

public class LerpsTest
{
    [Test]
    public void InverseLerpTest()
    {
        Assert.That(Mathf.InverseLerp(0.0F, 10.0F, -1.0F), Is.EqualTo(0.0F));
        Assert.That(Mathf.InverseLerp(0.0F, 10.0F, 0.0F), Is.EqualTo(0.0F));
        Assert.That(Mathf.InverseLerp(0.0F, 10.0F, 2.5F), Is.EqualTo(0.25F));
        Assert.That(Mathf.InverseLerp(0.0F, 10.0F, 5.0F), Is.EqualTo(0.5F));
        Assert.That(Mathf.InverseLerp(0.0F, 10.0F, 10.0F), Is.EqualTo(1.0F));
        Assert.That(Mathf.InverseLerp(0.0F, 10.0F, 15.0F), Is.EqualTo(1.0F));

        Assert.That(Mathf.InverseLerp(-5.0F, 15.0F, -10.0F), Is.EqualTo(0.0F));
        Assert.That(Mathf.InverseLerp(-5.0F, 15.0F, -5.0F), Is.EqualTo(0.0F));
        Assert.That(Mathf.InverseLerp(-5.0F, 15.0F, 0.0F), Is.EqualTo(0.25F));
        Assert.That(Mathf.InverseLerp(-5.0F, 15.0F, 5.0F), Is.EqualTo(0.5F));
        Assert.That(Mathf.InverseLerp(-5.0F, 15.0F, 15.0F), Is.EqualTo(1.0F));
        Assert.That(Mathf.InverseLerp(-5.0F, 15.0F, 25.0F), Is.EqualTo(1.0F));

        Assert.That(Mathf.InverseLerp(10.0F, 0.0F, -1.0F), Is.EqualTo(1.0F));
        Assert.That(Mathf.InverseLerp(10.0F, 0.0F, 0.0F), Is.EqualTo(1.0F));
        Assert.That(Mathf.InverseLerp(10.0F, 0.0F, 2.5F), Is.EqualTo(0.75F));
        Assert.That(Mathf.InverseLerp(10.0F, 0.0F, 5.0F), Is.EqualTo(0.5F));
        Assert.That(Mathf.InverseLerp(10.0F, 0.0F, 10.0F), Is.EqualTo(0.0F));
        Assert.That(Mathf.InverseLerp(10.0F, 0.0F, 15.0F), Is.EqualTo(0.0F));
    }

    [Test]
    public void LerpTest()
    {
        Assert.That(Mathf.Lerp(a: 0.0F, b: 1.0F, t: -1.0F), Is.EqualTo(0.0F));
        Assert.That(Mathf.Lerp(a: 0.0F, b: 1.0F, t: 0.0F), Is.EqualTo(0.0F));
        Assert.That(Mathf.Lerp(a: 0.0F, b: 1.0F, t: 1.0F), Is.EqualTo(1.0F));
        Assert.That(Mathf.Lerp(a: 0.0F, b: 1.0F, t: 0.25F), Is.EqualTo(0.25F));
        Assert.That(Mathf.Lerp(a: 0.0F, b: 1.0F, t: 1.25F), Is.EqualTo(1.0F));

        Assert.That(Mathf.Lerp(a: -1.0F, b: 3.0F, t: -1.0F), Is.EqualTo(-1.0F));
        Assert.That(Mathf.Lerp(a: -1.0F, b: 3.0F, t: 0.0F), Is.EqualTo(-1.0F));
        Assert.That(Mathf.Lerp(a: -1.0F, b: 3.0F, t: 1.0F), Is.EqualTo(3.0F));
        Assert.That(Mathf.Lerp(a: -1.0F, b: 3.0F, t: 0.25F), Is.EqualTo(0.0F));
        Assert.That(Mathf.Lerp(a: -1.0F, b: 3.0F, t: 1.25F), Is.EqualTo(3.0F));

        Assert.That(Mathf.Lerp(a: 4.0F, b: -4.0F, t: -1.0F), Is.EqualTo(4.0F));
        Assert.That(Mathf.Lerp(a: 4.0F, b: -4.0F, t: 0.0F), Is.EqualTo(4.0F));
        Assert.That(Mathf.Lerp(a: 4.0F, b: -4.0F, t: 1.0F), Is.EqualTo(-4.0F));
        Assert.That(Mathf.Lerp(a: 4.0F, b: -4.0F, t: 0.25F), Is.EqualTo(2.0F));
        Assert.That(Mathf.Lerp(a: 4.0F, b: -4.0F, t: 1.25F), Is.EqualTo(-4.0F));
    }

    [Test]
    public void LerpAngleTest()
    {
        Assert.That(Mathf.LerpAngle(a: 45.0F, b: 90.0F, t: -1.0F), Is.EqualTo(45.0F));
        Assert.That(Mathf.LerpAngle(a: 45.0F, b: 90.0F, t: 0.0F), Is.EqualTo(45.0F));
        Assert.That(Mathf.LerpAngle(a: 45.0F, b: 90.0F, t: 1.0F), Is.EqualTo(90.0F));
        Assert.That(Mathf.LerpAngle(a: 45.0F, b: 90.0F, t: 0.25F), Is.EqualTo(56.25F));
        Assert.That(Mathf.LerpAngle(a: 45.0F, b: 90.0F, t: 1.25F), Is.EqualTo(90.0F));

        Assert.That(Mathf.LerpAngle(a: 90.0F, b: 45.0F, t: -1.0F), Is.EqualTo(90.0F));
        Assert.That(Mathf.LerpAngle(a: 90.0F, b: 45.0F, t: 0.0F), Is.EqualTo(90.0F));
        Assert.That(Mathf.LerpAngle(a: 90.0F, b: 45.0F, t: 1.0F), Is.EqualTo(45.0F));
        Assert.That(Mathf.LerpAngle(a: 90.0F, b: 45.0F, t: 0.25F), Is.EqualTo(78.75F));
        Assert.That(Mathf.LerpAngle(a: 90.0F, b: 45.0F, t: 1.25F), Is.EqualTo(45.0F));

        Assert.That(Mathf.LerpAngle(a: 360.0F, b: 405.0F, t: -1.0F), Is.EqualTo(360.0F));
        Assert.That(Mathf.LerpAngle(a: 360.0F, b: 405.0F, t: 0.0F), Is.EqualTo(360.0F));
        Assert.That(Mathf.LerpAngle(a: 360.0F, b: 405.0F, t: 1.0F), Is.EqualTo(405.0F));
        Assert.That(Mathf.LerpAngle(a: 360.0F, b: 405.0F, t: 0.25F), Is.EqualTo(371.25F));
        Assert.That(Mathf.LerpAngle(a: 360.0F, b: 405.0F, t: 1.25F), Is.EqualTo(405.0F));

        Assert.That(Mathf.LerpAngle(a: 315.0F, b: 45.0F, t: -1.0F), Is.EqualTo(315.0F));
        Assert.That(Mathf.LerpAngle(a: 315.0F, b: 45.0F, t: 0.0F), Is.EqualTo(315.0F));
        Assert.That(Mathf.LerpAngle(a: 315.0F, b: 45.0F, t: 1.0F), Is.EqualTo(405.0F));
        Assert.That(Mathf.LerpAngle(a: 315.0F, b: 45.0F, t: 0.25F), Is.EqualTo(337.5F));
        Assert.That(Mathf.LerpAngle(a: 315.0F, b: 45.0F, t: 1.25F), Is.EqualTo(405.0F));

        Assert.That(Mathf.LerpAngle(a: 45.0F, b: -45.0F, t: -1.0F), Is.EqualTo(45.0F));
        Assert.That(Mathf.LerpAngle(a: 45.0F, b: -45.0F, t: 0.0F), Is.EqualTo(45.0F));
        Assert.That(Mathf.LerpAngle(a: 45.0F, b: -45.0F, t: 1.0F), Is.EqualTo(-45.0F));
        Assert.That(Mathf.LerpAngle(a: 45.0F, b: -45.0F, t: 0.25F), Is.EqualTo(22.5F));
        Assert.That(Mathf.LerpAngle(a: 45.0F, b: -45.0F, t: 1.25F), Is.EqualTo(-45.0F));
    }

    [Test]
    public void LerpUnclampedTest()
    {
        Assert.That(Mathf.LerpUnclamped(a: 0.0F, b: 1.0F, t: -1.0F), Is.EqualTo(-1.0F));
        Assert.That(Mathf.LerpUnclamped(a: 0.0F, b: 1.0F, t: 0.0F), Is.EqualTo(0.0F));
        Assert.That(Mathf.LerpUnclamped(a: 0.0F, b: 1.0F, t: 1.0F), Is.EqualTo(1.0F));
        Assert.That(Mathf.LerpUnclamped(a: 0.0F, b: 1.0F, t: 0.25F), Is.EqualTo(0.25F));
        Assert.That(Mathf.LerpUnclamped(a: 0.0F, b: 1.0F, t: 1.25F), Is.EqualTo(1.25F));

        Assert.That(Mathf.LerpUnclamped(a: -1.0F, b: 3.0F, t: -1.0F), Is.EqualTo(-5.0F));
        Assert.That(Mathf.LerpUnclamped(a: -1.0F, b: 3.0F, t: 0.0F), Is.EqualTo(-1.0F));
        Assert.That(Mathf.LerpUnclamped(a: -1.0F, b: 3.0F, t: 1.0F), Is.EqualTo(3.0F));
        Assert.That(Mathf.LerpUnclamped(a: -1.0F, b: 3.0F, t: 0.25F), Is.EqualTo(0.0F));
        Assert.That(Mathf.LerpUnclamped(a: -1.0F, b: 3.0F, t: 1.25F), Is.EqualTo(4.0F));

        Assert.That(Mathf.LerpUnclamped(a: 4.0F, b: -4.0F, t: -1.0F), Is.EqualTo(12.0F));
        Assert.That(Mathf.LerpUnclamped(a: 4.0F, b: -4.0F, t: 0.0F), Is.EqualTo(4.0F));
        Assert.That(Mathf.LerpUnclamped(a: 4.0F, b: -4.0F, t: 1.0F), Is.EqualTo(-4.0F));
        Assert.That(Mathf.LerpUnclamped(a: 4.0F, b: -4.0F, t: 0.25F), Is.EqualTo(2.0F));
        Assert.That(Mathf.LerpUnclamped(a: 4.0F, b: -4.0F, t: 1.25F), Is.EqualTo(-6.0F));
    }

}
