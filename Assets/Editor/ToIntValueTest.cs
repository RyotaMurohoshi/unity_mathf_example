using UnityEngine;
using NUnit.Framework;

public class ToIntValueTest
{
    [Test]
    public void CeilTest()
    {
        // http://docs.unity3d.com/ja/current/ScriptReference/Mathf.Ceil.html
        Assert.That(Mathf.Ceil(+2.5F), Is.EqualTo(3.0F));
        Assert.That(Mathf.Ceil(+2.1F), Is.EqualTo(3.0F));
        Assert.That(Mathf.Ceil(+2.0F), Is.EqualTo(2.0F));
        Assert.That(Mathf.Ceil(+1.999999F), Is.EqualTo(2.0F));
        Assert.That(Mathf.Ceil(+1.5F), Is.EqualTo(2.0F));
        Assert.That(Mathf.Ceil(+1.1F), Is.EqualTo(2.0F));
        Assert.That(Mathf.Ceil(+1.0F), Is.EqualTo(1.0F));
        Assert.That(Mathf.Ceil(+0.999999F), Is.EqualTo(1.0F));
        Assert.That(Mathf.Ceil(+0.5F), Is.EqualTo(1.0F));
        Assert.That(Mathf.Ceil(+float.Epsilon), Is.EqualTo(1.0F));
        Assert.That(Mathf.Ceil(0.0F), Is.EqualTo(0.0F));
        Assert.That(Mathf.Ceil(-float.Epsilon), Is.EqualTo(0.0F));
        Assert.That(Mathf.Ceil(-0.5F), Is.EqualTo(0.0F));
        Assert.That(Mathf.Ceil(-0.999999F), Is.EqualTo(0.0F));
        Assert.That(Mathf.Ceil(-1.0F), Is.EqualTo(-1.0F));
        Assert.That(Mathf.Ceil(-1.1F), Is.EqualTo(-1.0F));
        Assert.That(Mathf.Ceil(-1.5F), Is.EqualTo(-1.0F));
        Assert.That(Mathf.Ceil(-1.999999F), Is.EqualTo(-1.0F));
        Assert.That(Mathf.Ceil(-2.0F), Is.EqualTo(-2.0F));
        Assert.That(Mathf.Ceil(-2.1F), Is.EqualTo(-2.0F));
        Assert.That(Mathf.Ceil(-2.5F), Is.EqualTo(-2.0F));
    }

    [Test]
    public void CeilToIntTest()
    {
        // http://docs.unity3d.com/ja/current/ScriptReference/Mathf.CeilToInt.html
        Assert.That(Mathf.CeilToInt(+2.5F), Is.EqualTo(3));
        Assert.That(Mathf.CeilToInt(+2.1F), Is.EqualTo(3));
        Assert.That(Mathf.CeilToInt(+2.0F), Is.EqualTo(2));
        Assert.That(Mathf.CeilToInt(+1.999999F), Is.EqualTo(2));
        Assert.That(Mathf.CeilToInt(+1.5F), Is.EqualTo(2));
        Assert.That(Mathf.CeilToInt(+1.1F), Is.EqualTo(2));
        Assert.That(Mathf.CeilToInt(+1.0F), Is.EqualTo(1));
        Assert.That(Mathf.CeilToInt(+0.999999F), Is.EqualTo(1));
        Assert.That(Mathf.CeilToInt(+0.5F), Is.EqualTo(1));
        Assert.That(Mathf.CeilToInt(+float.Epsilon), Is.EqualTo(1));
        Assert.That(Mathf.CeilToInt(0.0F), Is.EqualTo(0));
        Assert.That(Mathf.CeilToInt(-float.Epsilon), Is.EqualTo(0));
        Assert.That(Mathf.CeilToInt(-0.5F), Is.EqualTo(0));
        Assert.That(Mathf.CeilToInt(-0.999999F), Is.EqualTo(0));
        Assert.That(Mathf.CeilToInt(-1.0F), Is.EqualTo(-1));
        Assert.That(Mathf.CeilToInt(-1.1F), Is.EqualTo(-1));
        Assert.That(Mathf.CeilToInt(-1.5F), Is.EqualTo(-1));
        Assert.That(Mathf.CeilToInt(-1.999999F), Is.EqualTo(-1));
        Assert.That(Mathf.CeilToInt(-2.0F), Is.EqualTo(-2));
        Assert.That(Mathf.CeilToInt(-2.1F), Is.EqualTo(-2));
        Assert.That(Mathf.CeilToInt(-2.5F), Is.EqualTo(-2));
    }


    [Test]
    public void FloorTest()
    {
        // http://docs.unity3d.com/ja/current/ScriptReference/Mathf.Floor.html
        Assert.That(Mathf.Floor(+2.5F), Is.EqualTo(2.0F));
        Assert.That(Mathf.Floor(+2.1F), Is.EqualTo(2.0F));
        Assert.That(Mathf.Floor(+2.0F), Is.EqualTo(2.0F));
        Assert.That(Mathf.Floor(+1.999999F), Is.EqualTo(1.0F));
        Assert.That(Mathf.Floor(+1.5F), Is.EqualTo(1.0F));
        Assert.That(Mathf.Floor(+1.1F), Is.EqualTo(1.0F));
        Assert.That(Mathf.Floor(+1.0F), Is.EqualTo(1.0F));
        Assert.That(Mathf.Floor(+0.999999F), Is.EqualTo(0.0F));
        Assert.That(Mathf.Floor(+0.5F), Is.EqualTo(0.0F));
        Assert.That(Mathf.Floor(+float.Epsilon), Is.EqualTo(0.0F));
        Assert.That(Mathf.Floor(0.0F), Is.EqualTo(0.0F));
        Assert.That(Mathf.Floor(-float.Epsilon), Is.EqualTo(-1.0F));
        Assert.That(Mathf.Floor(-0.5F), Is.EqualTo(-1.0F));
        Assert.That(Mathf.Floor(-0.999999F), Is.EqualTo(-1.0F));
        Assert.That(Mathf.Floor(-1.0F), Is.EqualTo(-1.0F));
        Assert.That(Mathf.Floor(-1.1F), Is.EqualTo(-2.0F));
        Assert.That(Mathf.Floor(-1.5F), Is.EqualTo(-2.0F));
        Assert.That(Mathf.Floor(-1.999999F), Is.EqualTo(-2.0F));
        Assert.That(Mathf.Floor(-2.0F), Is.EqualTo(-2.0F));
        Assert.That(Mathf.Floor(-2.1F), Is.EqualTo(-3.0F));
        Assert.That(Mathf.Floor(-2.5F), Is.EqualTo(-3.0F));
    }

    [Test]
    public void FloorToIntTest()
    {
        // http://docs.unity3d.com/ja/current/ScriptReference/Mathf.FloorToInt.html
        Assert.That(Mathf.FloorToInt(+2.5F), Is.EqualTo(2));
        Assert.That(Mathf.FloorToInt(+2.1F), Is.EqualTo(2));
        Assert.That(Mathf.FloorToInt(+2.0F), Is.EqualTo(2));
        Assert.That(Mathf.FloorToInt(+1.999999F), Is.EqualTo(1));
        Assert.That(Mathf.FloorToInt(+1.5F), Is.EqualTo(1));
        Assert.That(Mathf.FloorToInt(+1.1F), Is.EqualTo(1));
        Assert.That(Mathf.FloorToInt(+1.0F), Is.EqualTo(1));
        Assert.That(Mathf.FloorToInt(+0.999999F), Is.EqualTo(0));
        Assert.That(Mathf.FloorToInt(+0.5F), Is.EqualTo(0));
        Assert.That(Mathf.FloorToInt(+float.Epsilon), Is.EqualTo(0));
        Assert.That(Mathf.FloorToInt(0.0F), Is.EqualTo(0));
        Assert.That(Mathf.FloorToInt(-float.Epsilon), Is.EqualTo(-1));
        Assert.That(Mathf.FloorToInt(-0.5F), Is.EqualTo(-1));
        Assert.That(Mathf.FloorToInt(-0.999999F), Is.EqualTo(-1));
        Assert.That(Mathf.FloorToInt(-1.0F), Is.EqualTo(-1));
        Assert.That(Mathf.FloorToInt(-1.1F), Is.EqualTo(-2));
        Assert.That(Mathf.FloorToInt(-1.5F), Is.EqualTo(-2));
        Assert.That(Mathf.FloorToInt(-1.999999F), Is.EqualTo(-2));
        Assert.That(Mathf.FloorToInt(-2.0F), Is.EqualTo(-2));
        Assert.That(Mathf.FloorToInt(-2.1F), Is.EqualTo(-3));
        Assert.That(Mathf.FloorToInt(-2.5F), Is.EqualTo(-3));
    }

    [Test]
    public void RoundTest()
    {
        // http://docs.unity3d.com/ja/current/ScriptReference/Mathf.Round.html
        Assert.That(Mathf.Round(+6.5F), Is.EqualTo(6.0F));
        Assert.That(Mathf.Round(+5.5F), Is.EqualTo(6.0F));

        Assert.That(Mathf.Round(+4.5F), Is.EqualTo(4.0F));
        Assert.That(Mathf.Round(+3.5F), Is.EqualTo(4.0F));

        Assert.That(Mathf.Round(+2.5F), Is.EqualTo(2.0F));
        Assert.That(Mathf.Round(+2.1F), Is.EqualTo(2.0F));
        Assert.That(Mathf.Round(+2.0F), Is.EqualTo(2.0F));
        Assert.That(Mathf.Round(+1.999999F), Is.EqualTo(2.0F));
        Assert.That(Mathf.Round(+1.5F), Is.EqualTo(2.0F));
        Assert.That(Mathf.Round(+1.1F), Is.EqualTo(1.0F));
        Assert.That(Mathf.Round(+1.0F), Is.EqualTo(1.0F));
        Assert.That(Mathf.Round(+0.999999F), Is.EqualTo(1.0F));
        Assert.That(Mathf.Round(+0.5F), Is.EqualTo(0.0F));
        Assert.That(Mathf.Round(+float.Epsilon), Is.EqualTo(0.0F));
        Assert.That(Mathf.Round(0.0F), Is.EqualTo(0.0F));
        Assert.That(Mathf.Round(-float.Epsilon), Is.EqualTo(0.0F));
        Assert.That(Mathf.Round(-0.5F), Is.EqualTo(0.0F));
        Assert.That(Mathf.Round(-0.999999F), Is.EqualTo(-1.0F));
        Assert.That(Mathf.Round(-1.0F), Is.EqualTo(-1.0F));
        Assert.That(Mathf.Round(-1.1F), Is.EqualTo(-1.0F));
        Assert.That(Mathf.Round(-1.5F), Is.EqualTo(-2.0F));
        Assert.That(Mathf.Round(-1.999999F), Is.EqualTo(-2.0F));
        Assert.That(Mathf.Round(-2.0F), Is.EqualTo(-2.0F));
        Assert.That(Mathf.Round(-2.1F), Is.EqualTo(-2.0F));
        Assert.That(Mathf.Round(-2.5F), Is.EqualTo(-2.0F));

        Assert.That(Mathf.Round(-3.5F), Is.EqualTo(-4.0F));
        Assert.That(Mathf.Round(-4.5F), Is.EqualTo(-4.0F));

        Assert.That(Mathf.Round(-5.5F), Is.EqualTo(-6.0F));
        Assert.That(Mathf.Round(-6.5F), Is.EqualTo(-6.0F));
    }

    [Test]
    public void RoundToIntTest()
    {
        // http://docs.unity3d.com/ja/current/ScriptReference/Mathf.RoundToInt.html
        Assert.That(Mathf.RoundToInt(+6.5F), Is.EqualTo(6));
        Assert.That(Mathf.RoundToInt(+5.5F), Is.EqualTo(6));

        Assert.That(Mathf.RoundToInt(+4.5F), Is.EqualTo(4));
        Assert.That(Mathf.RoundToInt(+3.5F), Is.EqualTo(4));

        Assert.That(Mathf.RoundToInt(+2.5F), Is.EqualTo(2));
        Assert.That(Mathf.RoundToInt(+2.1F), Is.EqualTo(2));
        Assert.That(Mathf.RoundToInt(+2.0F), Is.EqualTo(2));
        Assert.That(Mathf.RoundToInt(+1.999999F), Is.EqualTo(2));
        Assert.That(Mathf.RoundToInt(+1.5F), Is.EqualTo(2));
        Assert.That(Mathf.RoundToInt(+1.1F), Is.EqualTo(1));
        Assert.That(Mathf.RoundToInt(+1.0F), Is.EqualTo(1));
        Assert.That(Mathf.RoundToInt(+0.999999F), Is.EqualTo(1));
        Assert.That(Mathf.RoundToInt(+0.5F), Is.EqualTo(0));
        Assert.That(Mathf.RoundToInt(+float.Epsilon), Is.EqualTo(0));
        Assert.That(Mathf.RoundToInt(0.0F), Is.EqualTo(0));
        Assert.That(Mathf.RoundToInt(-float.Epsilon), Is.EqualTo(0));
        Assert.That(Mathf.RoundToInt(-0.5F), Is.EqualTo(0));
        Assert.That(Mathf.RoundToInt(-0.999999F), Is.EqualTo(-1));
        Assert.That(Mathf.RoundToInt(-1.0F), Is.EqualTo(-1));
        Assert.That(Mathf.RoundToInt(-1.1F), Is.EqualTo(-1));
        Assert.That(Mathf.RoundToInt(-1.5F), Is.EqualTo(-2));
        Assert.That(Mathf.RoundToInt(-1.999999F), Is.EqualTo(-2));
        Assert.That(Mathf.RoundToInt(-2.0F), Is.EqualTo(-2));
        Assert.That(Mathf.RoundToInt(-2.1F), Is.EqualTo(-2));
        Assert.That(Mathf.RoundToInt(-2.5F), Is.EqualTo(-2));

        Assert.That(Mathf.RoundToInt(-3.5F), Is.EqualTo(-4));
        Assert.That(Mathf.RoundToInt(-4.5F), Is.EqualTo(-4));

        Assert.That(Mathf.RoundToInt(-5.5F), Is.EqualTo(-6));
        Assert.That(Mathf.RoundToInt(-6.5F), Is.EqualTo(-6));
    }
}
