using UnityEngine;
using NUnit.Framework;

public class PingPongRepeatTest
{
    [Test]
    public void PingPongTest()
    {
        // http://docs.unity3d.com/ja/current/ScriptReference/Mathf.PingPong.html
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
    }

    [Test]
    public void PingPongTestNegativeLength()
    {
        // http://docs.unity3d.com/ja/current/ScriptReference/Mathf.PingPong.html
        Assert.That(Mathf.PingPong(-1.75F, -1.0F), Is.EqualTo(-1.75F));
        Assert.That(Mathf.PingPong(-1.5F, -1.0F), Is.EqualTo(-1.5F));
        Assert.That(Mathf.PingPong(-1.25F, -1.0F), Is.EqualTo(-1.25F));
        Assert.That(Mathf.PingPong(-1.0F, -1.0F), Is.EqualTo(-1.0F));
        Assert.That(Mathf.PingPong(-0.75F, -1.0F), Is.EqualTo(-1.25F));
        Assert.That(Mathf.PingPong(-0.5F, -1.0F), Is.EqualTo(-1.5F));
        Assert.That(Mathf.PingPong(-0.25F, -1.0F), Is.EqualTo(-1.75F));
        Assert.That(Mathf.PingPong(0.0F, -1.0F), Is.EqualTo(-2.0F));
        Assert.That(Mathf.PingPong(0.25F, -1.0F), Is.EqualTo(-1.75F));
        Assert.That(Mathf.PingPong(0.5F, -1.0F), Is.EqualTo(-1.5F));
        Assert.That(Mathf.PingPong(0.75F, -1.0F), Is.EqualTo(-1.25F));
        Assert.That(Mathf.PingPong(1.0F, -1.0F), Is.EqualTo(-1.0F));
        Assert.That(Mathf.PingPong(1.25F, -1.0F), Is.EqualTo(-1.25F));
        Assert.That(Mathf.PingPong(1.5F, -1.0F), Is.EqualTo(-1.5F));
        Assert.That(Mathf.PingPong(1.75F, -1.0F), Is.EqualTo(-1.75F));
        Assert.That(Mathf.PingPong(2.0F, -1.0F), Is.EqualTo(-2.0F));
    }


    [Test]
    public void PingPongTestZeroLength()
    {
        // http://docs.unity3d.com/ja/current/ScriptReference/Mathf.PingPong.html
        Assert.True(float.IsNaN(Mathf.PingPong(0.5F, 0.0F)));
    }

    [Test]
    public void RepeatTest()
    {
        // http://docs.unity3d.com/ja/current/ScriptReference/Mathf.Repeat.html
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
    }

    [Test]
    public void RepeatTestNegativeLength()
    {
        // http://docs.unity3d.com/ja/current/ScriptReference/Mathf.Repeat.html
        Assert.That(Mathf.Repeat(-1.75F, -1.0F), Is.EqualTo(-0.75F));
        Assert.That(Mathf.Repeat(-1.5F, -1.0F), Is.EqualTo(-0.5F));
        Assert.That(Mathf.Repeat(-1.25F, -1.0F), Is.EqualTo(-0.25F));
        Assert.That(Mathf.Repeat(-1.0F, -1.0F), Is.EqualTo(0.0F));
        Assert.That(Mathf.Repeat(-0.75F, -1.0F), Is.EqualTo(-0.75F));
        Assert.That(Mathf.Repeat(-0.5F, -1.0F), Is.EqualTo(-0.5F));
        Assert.That(Mathf.Repeat(-0.25F, -1.0F), Is.EqualTo(-0.25F));
        Assert.That(Mathf.Repeat(0.0F, -1.0F), Is.EqualTo(0.0F));
        Assert.That(Mathf.Repeat(0.25F, -1.0F), Is.EqualTo(-0.75F));
        Assert.That(Mathf.Repeat(0.5F, -1.0F), Is.EqualTo(-0.5F));
        Assert.That(Mathf.Repeat(0.75F, -1.0F), Is.EqualTo(-0.25F));
        Assert.That(Mathf.Repeat(1.0F, -1.0F), Is.EqualTo(0.0F));
        Assert.That(Mathf.Repeat(1.25F, -1.0F), Is.EqualTo(-0.75F));
        Assert.That(Mathf.Repeat(1.5F, -1.0F), Is.EqualTo(-0.5F));
        Assert.That(Mathf.Repeat(1.75F, -1.0F), Is.EqualTo(-0.25F));
    }

    [Test]
    public void RepeatTestZeroLength()
    {
        // http://docs.unity3d.com/ja/current/ScriptReference/Mathf.Repeat.html
        Assert.True(float.IsNaN(Mathf.Repeat(0.5F, 0.0F)));
    }
}