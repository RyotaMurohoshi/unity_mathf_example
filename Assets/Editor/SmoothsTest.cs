using UnityEngine;
using System;
using NUnit.Framework;

public class SmoothsTest 
{
    [Test]
    public void SmoothDampTest()
    {
        float currentVelocity;
        float result;

        currentVelocity = 0.0F;
        // named argument and ref conflict?
        result = Mathf.SmoothDamp(
            0.0F, // current
            1.0F, // target
            ref currentVelocity, // currentVelocity
            0.1F, // smoothTime
            1.0F, // maxSpeed
            0.1F // deltaTime
        );
        Assert.That(result, Is.EqualTo(0.0558823533F));
        Assert.That(currentVelocity, Is.EqualTo(0.588235319F));

        currentVelocity = 1.0F;
        // named argument and ref conflict?
        result = Mathf.SmoothDamp(
            0.9F, // current
            1.0F, // target
            ref currentVelocity, // currentVelocity
            0.1F, // smoothTime
            1.0F, // maxSpeed
            0.1F // deltaTime
        );
        Assert.That(result, Is.EqualTo(0.970588207F));
        Assert.That(currentVelocity, Is.EqualTo(0.441176504F));
    }

    [Test]
    public void SmoothDampAngleTest()
    {
        float currentVelocity;
        float result;

        currentVelocity = 0.0F;
        // named argument and ref conflict?
        result = Mathf.SmoothDampAngle(
            0.0F, // current
            1.0F, // target
            ref currentVelocity, // currentVelocity
            0.1F, // smoothTime
            1.0F, // maxSpeed
            0.1F // deltaTime
        );
        Assert.That(result, Is.EqualTo(0.0558823533F));
        Assert.That(currentVelocity, Is.EqualTo(0.588235319F));

        currentVelocity = 1.0F;
        // named argument and ref conflict?
        result = Mathf.SmoothDampAngle(
            0.9F, // current
            1.0F, // target
            ref currentVelocity, // currentVelocity
            0.1F, // smoothTime
            1.0F, // maxSpeed
            0.1F // deltaTime
        );
        Assert.That(result, Is.EqualTo(0.970588207F));
        Assert.That(currentVelocity, Is.EqualTo(0.441176504F));
    }

    [Test]
    public void SmoothStepTest()
    {
        Assert.That(Mathf.SmoothStep(from: 0.0F, to: 1.0F, t: 0.0F), Is.EqualTo(0.0F));
        Assert.That(Mathf.SmoothStep(from: 0.0F, to: 1.0F, t: 0.1F), Is.EqualTo(0.0280000009F));
        Assert.That(Mathf.SmoothStep(from: 0.0F, to: 1.0F, t: 0.2F), Is.EqualTo(0.104000002F));
        Assert.That(Mathf.SmoothStep(from: 0.0F, to: 1.0F, t: 0.3F), Is.EqualTo(0.216000021F));
        Assert.That(Mathf.SmoothStep(from: 0.0F, to: 1.0F, t: 0.4F), Is.EqualTo(0.351999998F));
        Assert.That(Mathf.SmoothStep(from: 0.0F, to: 1.0F, t: 0.5F), Is.EqualTo(0.5F));
        Assert.That(Mathf.SmoothStep(from: 0.0F, to: 1.0F, t: 0.6F), Is.EqualTo(0.648000062F));
        Assert.That(Mathf.SmoothStep(from: 0.0F, to: 1.0F, t: 0.7F), Is.EqualTo(0.783999979F));
        Assert.That(Mathf.SmoothStep(from: 0.0F, to: 1.0F, t: 0.8F), Is.EqualTo(0.896000028F));
        Assert.That(Mathf.SmoothStep(from: 0.0F, to: 1.0F, t: 0.9F), Is.EqualTo(0.972000003F));
        Assert.That(Mathf.SmoothStep(from: 0.0F, to: 1.0F, t: 1.0F), Is.EqualTo(1.0F));

        Assert.That(Mathf.SmoothStep(from: 0.0F, to: 1.0F, t: -0.2F), Is.EqualTo(0.0F));
        Assert.That(Mathf.SmoothStep(from: 0.0F, to: 1.0F, t: 1.1F), Is.EqualTo(1.0F));

        Action<float, float, float> test = (float a, float b, float t) =>
        {
            float actual = Mathf.SmoothStep(a, b, t);
            float expected = Mathf.Lerp(a, b, -2 * t * t * t + 3 * t * t);
            Assert.AreEqual(expected, actual);
        };

        Assert.That(Mathf.SmoothStep(from: 0.0F, to: 1.0F, t: 0.0F), Is.EqualTo(0.0F));
        Assert.That(Mathf.SmoothStep(from: 0.0F, to: 1.0F, t: 1.0F), Is.EqualTo(1.0F));
        Assert.That(Mathf.SmoothStep(from: 0.0F, to: 1.0F, t: -0.3F), Is.EqualTo(0.0F));
        Assert.That(Mathf.SmoothStep(from: 0.0F, to: 1.0F, t: 1.2F), Is.EqualTo(1.0F));
        test(0.0F, 1.0F, 0.1F);
        test(0.0F, 1.0F, 0.5F);
        test(0.0F, 1.0F, 0.8F);

        Assert.That(Mathf.SmoothStep(from: 2.0F, to: 5.0F, t: 0.0F), Is.EqualTo(2.0F));
        Assert.That(Mathf.SmoothStep(from: 2.0F, to: 5.0F, t: 1.0F), Is.EqualTo(5.0F));
        Assert.That(Mathf.SmoothStep(from: 2.0F, to: 5.0F, t: -0.3F), Is.EqualTo(2.0F));
        Assert.That(Mathf.SmoothStep(from: 2.0F, to: 5.0F, t: 1.2F), Is.EqualTo(5.0F));
        test(2.0F, 5.0F, 0.1F);
        test(2.0F, 5.0F, 0.5F);
        test(2.0F, 5.0F, 0.8F);

        Assert.That(Mathf.SmoothStep(from: 4.0F, to: 1.0F, t: 0.0F), Is.EqualTo(4.0F));
        Assert.That(Mathf.SmoothStep(from: 4.0F, to: 1.0F, t: 1.0F), Is.EqualTo(1.0F));
        Assert.That(Mathf.SmoothStep(from: 4.0F, to: 1.0F, t: -0.3F), Is.EqualTo(4.0F));
        Assert.That(Mathf.SmoothStep(from: 4.0F, to: 1.0F, t: 1.2F), Is.EqualTo(1.0F));
        test(4.0F, 1.0F, 0.1F);
        test(4.0F, 1.0F, 0.5F);
        test(4.0F, 1.0F, 0.8F);
    }
}
