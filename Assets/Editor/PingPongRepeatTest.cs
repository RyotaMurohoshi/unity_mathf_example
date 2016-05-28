using UnityEngine;
using NUnit.Framework;

public class PingPongRepeatTest
{
    [Test]
    public void PingPongTest()
    {
        Assert.That(Mathf.PingPong(-1.75F, 1.0F), Is.EqualTo(0.25F));
        Assert.That(Mathf.PingPong(-1.5F, 1.0F), Is.EqualTo(0.5F));
        Assert.That(Mathf.PingPong(-1.25F, 1.0F), Is.EqualTo(0.75F));
        Assert.That(Mathf.PingPong(-1.0F, 1.0F), Is.EqualTo(1.0F));
        Assert.That(Mathf.PingPong(-0.75F, 1.0F), Is.EqualTo(0.75F));
        Assert.That(Mathf.PingPong(-0.5F, 1.0F), Is.EqualTo(0.5F));
        Assert.That(Mathf.PingPong(-0.25F, 1.0F), Is.EqualTo(0.25F));
        Assert.That(Mathf.PingPong(0.0F, 1.0F), Is.EqualTo(0.0F));
        Assert.That(Mathf.PingPong(0.25F, 1.0F), Is.EqualTo(0.25F));
        Assert.That(Mathf.PingPong(0.5F, 1.0F), Is.EqualTo(0.5F));
        Assert.That(Mathf.PingPong(0.75F, 1.0F), Is.EqualTo(0.75F));
        Assert.That(Mathf.PingPong(1.0F, 1.0F), Is.EqualTo(1.0F));
        Assert.That(Mathf.PingPong(1.25F, 1.0F), Is.EqualTo(0.75F));
        Assert.That(Mathf.PingPong(1.5F, 1.0F), Is.EqualTo(0.5F));
        Assert.That(Mathf.PingPong(1.75F, 1.0F), Is.EqualTo(0.25F));

        Assert.True(float.IsNaN(Mathf.PingPong(0.5F, 0.0F)));
    }

    [Test]
    public void RepeatTest()
    {
        Assert.That(Mathf.Repeat(-1.75F, 1.0F), Is.EqualTo(0.25F));
        Assert.That(Mathf.Repeat(-1.5F, 1.0F), Is.EqualTo(0.5F));
        Assert.That(Mathf.Repeat(-1.25F, 1.0F), Is.EqualTo(0.75F));
        Assert.That(Mathf.Repeat(-1.0F, 1.0F), Is.EqualTo(0.0F));
        Assert.That(Mathf.Repeat(-0.75F, 1.0F), Is.EqualTo(0.25F));
        Assert.That(Mathf.Repeat(-0.5F, 1.0F), Is.EqualTo(0.5F));
        Assert.That(Mathf.Repeat(-0.25F, 1.0F), Is.EqualTo(0.75F));
        Assert.That(Mathf.Repeat(0.0F, 1.0F), Is.EqualTo(0.0F));
        Assert.That(Mathf.Repeat(0.25F, 1.0F), Is.EqualTo(0.25F));
        Assert.That(Mathf.Repeat(0.5F, 1.0F), Is.EqualTo(0.5F));
        Assert.That(Mathf.Repeat(0.75F, 1.0F), Is.EqualTo(0.75F));
        Assert.That(Mathf.Repeat(1.0F, 1.0F), Is.EqualTo(0.0F));
        Assert.That(Mathf.Repeat(1.25F, 1.0F), Is.EqualTo(0.25F));
        Assert.That(Mathf.Repeat(1.5F, 1.0F), Is.EqualTo(0.5F));
        Assert.That(Mathf.Repeat(1.75F, 1.0F), Is.EqualTo(0.75F));

        Assert.True(float.IsNaN(Mathf.Repeat(0.5F, 0.0F)));
    }
}
