using UnityEngine;
using NUnit.Framework;

public class MoveToTest
{
    [Test]
    public void MoveToWardsTest()
    {
        // http://docs.unity3d.com/ja/current/ScriptReference/Mathf.MoveTowards.html
        Assert.That(Mathf.MoveTowards(current: -5.0F, target: 0.0F, maxDelta: 1.0F), Is.EqualTo(-4.0F));
        Assert.That(Mathf.MoveTowards(current: -1.0F, target: 0.0F, maxDelta: 1.0F), Is.EqualTo(0.0F));
        Assert.That(Mathf.MoveTowards(current: -0.25F, target: 0.0F, maxDelta: 1.0F), Is.EqualTo(0.0F));
        Assert.That(Mathf.MoveTowards(current: 0.0F, target: 0.0F, maxDelta: 1.0F), Is.EqualTo(0.0F));
        Assert.That(Mathf.MoveTowards(current: 0.25F, target: 0.0F, maxDelta: 1.0F), Is.EqualTo(0.0F));
        Assert.That(Mathf.MoveTowards(current: 1.0F, target: 0.0F, maxDelta: 1.0F), Is.EqualTo(0.0F));
        Assert.That(Mathf.MoveTowards(current: 5.0F, target: 0.0F, maxDelta: 1.0F), Is.EqualTo(4.0F));
    }

    [Test]
    public void MoveToWardsZeroTest()
    {
        // http://docs.unity3d.com/ja/current/ScriptReference/Mathf.MoveTowards.html
        Assert.That(Mathf.MoveTowards(current: -5.0F, target: 0.0F, maxDelta: 0.0F), Is.EqualTo(-5.0F));
        Assert.That(Mathf.MoveTowards(current: -1.0F, target: 0.0F, maxDelta: 0.0F), Is.EqualTo(-1.0F));
        Assert.That(Mathf.MoveTowards(current: -0.25F, target: 0.0F, maxDelta: 0.0F), Is.EqualTo(-0.25F));
        Assert.That(Mathf.MoveTowards(current: 0.0F, target: 0.0F, maxDelta: 0.0F), Is.EqualTo(0.0F));
        Assert.That(Mathf.MoveTowards(current: 0.25F, target: 0.0F, maxDelta: 0.0F), Is.EqualTo(0.25F));
        Assert.That(Mathf.MoveTowards(current: 1.0F, target: 0.0F, maxDelta: 0.0F), Is.EqualTo(1.0F));
        Assert.That(Mathf.MoveTowards(current: 5.0F, target: 0.0F, maxDelta: 0.0F), Is.EqualTo(5.0F));
    }

    [Test]
    public void MoveToWardsNegativeTest()
    {
        // http://docs.unity3d.com/ja/current/ScriptReference/Mathf.MoveTowards.html
        Assert.That(Mathf.MoveTowards(current: -5.0F, target: 0.0F, maxDelta: -1.0F), Is.EqualTo(-6.0F));
        Assert.That(Mathf.MoveTowards(current: -1.0F, target: 0.0F, maxDelta: -1.0F), Is.EqualTo(-2.0F));
        Assert.That(Mathf.MoveTowards(current: -0.25F, target: 0.0F, maxDelta: -1.0F), Is.EqualTo(-1.25F));
        Assert.That(Mathf.MoveTowards(current: 0.0F, target: 0.0F, maxDelta: -1.0F), Is.EqualTo(-1.0F));
        Assert.That(Mathf.MoveTowards(current: 0.25F, target: 0.0F, maxDelta: -1.0F), Is.EqualTo(1.25F));
        Assert.That(Mathf.MoveTowards(current: 1.0F, target: 0.0F, maxDelta: -1.0F), Is.EqualTo(2.0F));
        Assert.That(Mathf.MoveTowards(current: 5.0F, target: 0.0F, maxDelta: -1.0F), Is.EqualTo(6.0F));
    }


    [Test]
    public void MoveToWardsAngleTest()
    {
        // http://docs.unity3d.com/ja/current/ScriptReference/Mathf.MoveTowardsAngle.html
        Assert.That(Mathf.MoveTowardsAngle(current: -5.0F, target: 0.0F, maxDelta: 1.0F), Is.EqualTo(-4.0F));
        Assert.That(Mathf.MoveTowardsAngle(current: -1.0F, target: 0.0F, maxDelta: 1.0F), Is.EqualTo(0.0F));
        Assert.That(Mathf.MoveTowardsAngle(current: -0.25F, target: 0.0F, maxDelta: 1.0F), Is.EqualTo(0.0F));
        Assert.That(Mathf.MoveTowardsAngle(current: 0.25F, target: 0.0F, maxDelta: 1.0F), Is.EqualTo(0.0F));
        Assert.That(Mathf.MoveTowardsAngle(current: 1.0F, target: 0.0F, maxDelta: 1.0F), Is.EqualTo(0.0F));
        Assert.That(Mathf.MoveTowardsAngle(current: 5.0F, target: 0.0F, maxDelta: 1.0F), Is.EqualTo(4.0F));

        Assert.That(Mathf.MoveTowardsAngle(current: -5.0F, target: 360.0F, maxDelta: 1.0F), Is.EqualTo(-4.0F));
        Assert.That(Mathf.MoveTowardsAngle(current: -1.0F, target: 360.0F, maxDelta: 1.0F), Is.EqualTo(0.0F));
        Assert.That(Mathf.MoveTowardsAngle(current: -0.25F, target: 360.0F, maxDelta: 1.0F), Is.EqualTo(0.0F));
        Assert.That(Mathf.MoveTowardsAngle(current: 0.25F, target: 360.0F, maxDelta: 1.0F), Is.EqualTo(0.0F));
        Assert.That(Mathf.MoveTowardsAngle(current: 1.0F, target: 360.0F, maxDelta: 1.0F), Is.EqualTo(0.0F));
        Assert.That(Mathf.MoveTowardsAngle(current: 5.0F, target: 360.0F, maxDelta: 1.0F), Is.EqualTo(4.0F));

        Assert.That(Mathf.MoveTowardsAngle(current: 355.0F, target: 0.0F, maxDelta: 1.0F), Is.EqualTo(356.0F));
        Assert.That(Mathf.MoveTowardsAngle(current: 359.0F, target: 0.0F, maxDelta: 1.0F), Is.EqualTo(360.0F));
        Assert.That(Mathf.MoveTowardsAngle(current: 359.75F, target: 0.0F, maxDelta: 1.0F), Is.EqualTo(360.0F));
        Assert.That(Mathf.MoveTowardsAngle(current: 360.25F, target: 0.0F, maxDelta: 1.0F), Is.EqualTo(360.0F));
        Assert.That(Mathf.MoveTowardsAngle(current: 361.0F, target: 0.0F, maxDelta: 1.0F), Is.EqualTo(360.0F));
        Assert.That(Mathf.MoveTowardsAngle(current: 365.0F, target: 0.0F, maxDelta: 1.0F), Is.EqualTo(364.0F));

        Assert.That(Mathf.MoveTowardsAngle(current: 355.0F, target: 360.0F, maxDelta: 1.0F), Is.EqualTo(356.0F));
        Assert.That(Mathf.MoveTowardsAngle(current: 359.0F, target: 360.0F, maxDelta: 1.0F), Is.EqualTo(360.0F));
        Assert.That(Mathf.MoveTowardsAngle(current: 359.75F, target: 360.0F, maxDelta: 1.0F), Is.EqualTo(360.0F));
        Assert.That(Mathf.MoveTowardsAngle(current: 360.25F, target: 360.0F, maxDelta: 1.0F), Is.EqualTo(360.0F));
        Assert.That(Mathf.MoveTowardsAngle(current: 361.0F, target: 360.0F, maxDelta: 1.0F), Is.EqualTo(360.0F));
        Assert.That(Mathf.MoveTowardsAngle(current: 365.0F, target: 360.0F, maxDelta: 1.0F), Is.EqualTo(364.0F));
    }
}
