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
        Action<float, float, float> test = (float a, float b, float t) =>
        {
            float actual = Mathf.SmoothStep(a, b, t);
            float expected = Mathf.Lerp(a, b, -2 * t * t * t + 3 * t * t);
            Assert.AreEqual(expected, actual);
        };

        Assert.That(Mathf.SmoothStep(0.0F, 1.0F, 0.0F), Is.EqualTo(0.0F));
        Assert.That(Mathf.SmoothStep(0.0F, 1.0F, 1.0F), Is.EqualTo(1.0F));
        Assert.That(Mathf.SmoothStep(0.0F, 1.0F, -0.3F), Is.EqualTo(0.0F));
        Assert.That(Mathf.SmoothStep(0.0F, 1.0F, 1.2F), Is.EqualTo(1.0F));
        test(0.0F, 1.0F, 0.1F);
        test(0.0F, 1.0F, 0.5F);
        test(0.0F, 1.0F, 0.8F);

        Assert.That(Mathf.SmoothStep(2.0F, 5.0F, 0.0F), Is.EqualTo(2.0F));
        Assert.That(Mathf.SmoothStep(2.0F, 5.0F, 1.0F), Is.EqualTo(5.0F));
        Assert.That(Mathf.SmoothStep(2.0F, 5.0F, -0.3F), Is.EqualTo(2.0F));
        Assert.That(Mathf.SmoothStep(2.0F, 5.0F, 1.2F), Is.EqualTo(5.0F));
        test(2.0F, 5.0F, 0.1F);
        test(2.0F, 5.0F, 0.5F);
        test(2.0F, 5.0F, 0.8F);

        Assert.That(Mathf.SmoothStep(4.0F, 1.0F, 0.0F), Is.EqualTo(4.0F));
        Assert.That(Mathf.SmoothStep(4.0F, 1.0F, 1.0F), Is.EqualTo(1.0F));
        Assert.That(Mathf.SmoothStep(4.0F, 1.0F, -0.3F), Is.EqualTo(4.0F));
        Assert.That(Mathf.SmoothStep(4.0F, 1.0F, 1.2F), Is.EqualTo(1.0F));
        test(4.0F, 1.0F, 0.1F);
        test(4.0F, 1.0F, 0.5F);
        test(4.0F, 1.0F, 0.8F);
    }
}
