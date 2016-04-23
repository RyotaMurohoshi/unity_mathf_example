using UnityEngine;
using UnityEditor;
using System;
using NUnit.Framework;

public class MathfTest
{
	[Test]
	public void AbsIntTest ()
	{
		Assert.That (Mathf.Abs (0), Is.EqualTo (0));
		Assert.That (Mathf.Abs (1), Is.EqualTo (1));
		Assert.That (Mathf.Abs (-1), Is.EqualTo (1));
		Assert.That (Mathf.Abs (6), Is.EqualTo (6));
		Assert.That (Mathf.Abs (-7), Is.EqualTo (7));
		Assert.That (Mathf.Abs (int.MaxValue), Is.EqualTo (int.MaxValue));

		Assert.Throws<System.OverflowException> (() => {
			Mathf.Abs (int.MinValue);
		});
	}

	[Test]
	public void AbsFloatTest ()
	{
		Assert.That (Mathf.Abs (0.0F), Is.EqualTo (0.0F));
		Assert.That (Mathf.Abs (1.0F), Is.EqualTo (1.0F));
		Assert.That (Mathf.Abs (-1.0F), Is.EqualTo (1.0F));
		Assert.That (Mathf.Abs (6.0F), Is.EqualTo (6.0F));
		Assert.That (Mathf.Abs (-7.0F), Is.EqualTo (7.0F));
		Assert.That (Mathf.Abs (float.MaxValue), Is.EqualTo (float.MaxValue));
		Assert.That (Mathf.Abs (float.MinValue), Is.EqualTo (float.MaxValue));
	}

	[Test]
	public void ApproximatelyTest ()
	{
		Assert.That (Mathf.Approximately (0.0F, 0.0F), Is.True);
		Assert.That (Mathf.Approximately (0.0F, float.Epsilon), Is.True);
		Assert.That (Mathf.Approximately (1.0F, 1.000001F), Is.True);
		Assert.That (Mathf.Approximately (1.0F, 1.01F), Is.False);

		Assert.That (Mathf.Approximately (100000.0F, 100000.00F), Is.True);
		Assert.That (Mathf.Approximately (100000.0F, 100000.01F), Is.True);

		// TODO add more tests
	}

	[Test]
	public void CeilTest ()
	{
		Assert.That (Mathf.Ceil (+2.5F), Is.EqualTo (3.0F));
		Assert.That (Mathf.Ceil (+2.1F), Is.EqualTo (3.0F));
		Assert.That (Mathf.Ceil (+2.0F), Is.EqualTo (2.0F));
		Assert.That (Mathf.Ceil (+1.999999F), Is.EqualTo (2.0F));
		Assert.That (Mathf.Ceil (+1.5F), Is.EqualTo (2.0F));
		Assert.That (Mathf.Ceil (+1.1F), Is.EqualTo (2.0F));
		Assert.That (Mathf.Ceil (+1.0F), Is.EqualTo (1.0F));
		Assert.That (Mathf.Ceil (+0.999999F), Is.EqualTo (1.0F));
		Assert.That (Mathf.Ceil (+0.5F), Is.EqualTo (1.0F));
		Assert.That (Mathf.Ceil (+float.Epsilon), Is.EqualTo (1.0F));
		Assert.That (Mathf.Ceil (0.0F), Is.EqualTo (0.0F));
		Assert.That (Mathf.Ceil (-float.Epsilon), Is.EqualTo (0.0F));
		Assert.That (Mathf.Ceil (-0.5F), Is.EqualTo (0.0F));
		Assert.That (Mathf.Ceil (-0.999999F), Is.EqualTo (0.0F));
		Assert.That (Mathf.Ceil (-1.0F), Is.EqualTo (-1.0F));
		Assert.That (Mathf.Ceil (-1.1F), Is.EqualTo (-1.0F));
		Assert.That (Mathf.Ceil (-1.5F), Is.EqualTo (-1.0F));
		Assert.That (Mathf.Ceil (-1.999999F), Is.EqualTo (-1.0F));
		Assert.That (Mathf.Ceil (-2.0F), Is.EqualTo (-2.0F));
		Assert.That (Mathf.Ceil (-2.1F), Is.EqualTo (-2.0F));
		Assert.That (Mathf.Ceil (-2.5F), Is.EqualTo (-2.0F));
	}

	[Test]
	public void CeilToIntTest ()
	{
		Assert.That (Mathf.CeilToInt (+2.5F), Is.EqualTo (3));
		Assert.That (Mathf.CeilToInt (+2.1F), Is.EqualTo (3));
		Assert.That (Mathf.CeilToInt (+2.0F), Is.EqualTo (2));
		Assert.That (Mathf.CeilToInt (+1.999999F), Is.EqualTo (2));
		Assert.That (Mathf.CeilToInt (+1.5F), Is.EqualTo (2));
		Assert.That (Mathf.CeilToInt (+1.1F), Is.EqualTo (2));
		Assert.That (Mathf.CeilToInt (+1.0F), Is.EqualTo (1));
		Assert.That (Mathf.CeilToInt (+0.999999F), Is.EqualTo (1));
		Assert.That (Mathf.CeilToInt (+0.5F), Is.EqualTo (1));
		Assert.That (Mathf.CeilToInt (+float.Epsilon), Is.EqualTo (1));
		Assert.That (Mathf.CeilToInt (0.0F), Is.EqualTo (0));
		Assert.That (Mathf.CeilToInt (-float.Epsilon), Is.EqualTo (0));
		Assert.That (Mathf.CeilToInt (-0.5F), Is.EqualTo (0));
		Assert.That (Mathf.CeilToInt (-0.999999F), Is.EqualTo (0));
		Assert.That (Mathf.CeilToInt (-1.0F), Is.EqualTo (-1));
		Assert.That (Mathf.CeilToInt (-1.1F), Is.EqualTo (-1));
		Assert.That (Mathf.CeilToInt (-1.5F), Is.EqualTo (-1));
		Assert.That (Mathf.CeilToInt (-1.999999F), Is.EqualTo (-1));
		Assert.That (Mathf.CeilToInt (-2.0F), Is.EqualTo (-2));
		Assert.That (Mathf.CeilToInt (-2.1F), Is.EqualTo (-2));
		Assert.That (Mathf.CeilToInt (-2.5F), Is.EqualTo (-2));
	}

	[Test]
	public void ClampIntTest ()
	{
		//Mathf.Clamp (value, min, max);
		Assert.That (Mathf.Clamp (0, -1, 2), Is.EqualTo (0));
		Assert.That (Mathf.Clamp (3, -1, 2), Is.EqualTo (2));
		Assert.That (Mathf.Clamp (-2, -1, 2), Is.EqualTo (-1));

		// iregular args
		// We shoul with named arg?
		Assert.That (Mathf.Clamp (0, 1, -1), Is.EqualTo (1));
		Assert.That (Mathf.Clamp (2, 1, -1), Is.EqualTo (-1));
		Assert.That (Mathf.Clamp (-2, 1, -1), Is.EqualTo (1));
	}

	[Test]
	public void Clamp01Test ()
	{
		Assert.That (Mathf.Clamp01 (float.MinValue), Is.EqualTo (0.0F));
		Assert.That (Mathf.Clamp01 (-1.0F), Is.EqualTo (0.0F));
		Assert.That (Mathf.Clamp01 (-float.Epsilon), Is.EqualTo (0.0F));

		Assert.That (Mathf.Clamp01 (0.0F), Is.EqualTo (0.0F));
		Assert.That (Mathf.Clamp01 (float.Epsilon), Is.EqualTo (float.Epsilon));
		Assert.That (Mathf.Clamp01 (0.5F), Is.EqualTo (0.5F));
		Assert.That (Mathf.Clamp01 (1.0F - float.Epsilon), Is.EqualTo (1.0F - float.Epsilon));
		Assert.That (Mathf.Clamp01 (1.0F), Is.EqualTo (1.0F));

		Assert.That (Mathf.Clamp01 (1.0F + float.Epsilon), Is.EqualTo (1.0F + float.Epsilon));
		Assert.That (Mathf.Clamp01 (2.0F), Is.EqualTo (1.0F));
		Assert.That (Mathf.Clamp01 (float.MaxValue), Is.EqualTo (1.0F));
	}

	[Test]
	public void ClampFloatTest ()
	{
		//Mathf.Clamp (value, min, max);
		Assert.That (Mathf.Clamp (0.5F, -1.0F, 1.0F), Is.EqualTo (0.5F));
		Assert.That (Mathf.Clamp (2.5F, -1.0F, 2.0F), Is.EqualTo (2.0F));
		Assert.That (Mathf.Clamp (-2.5F, -1.0F, 2.0F), Is.EqualTo (-1.0F));

		// iregular args
		// We shoul with named arg?
		Assert.That (Mathf.Clamp (0.5F, 1.0F, -1.0F), Is.EqualTo (1.0F));
		Assert.That (Mathf.Clamp (2.5F, 1.0F, -1.0F), Is.EqualTo (-1.0F));
		Assert.That (Mathf.Clamp (-2.5F, 1.0F, -1.0F), Is.EqualTo (1.0F));
	}

	[Test]
	public void ClosestPowerOfTwoTest ()
	{
		Assert.That (Mathf.ClosestPowerOfTwo (-128), Is.EqualTo (0));
		Assert.That (Mathf.ClosestPowerOfTwo (-100), Is.EqualTo (0));

		Assert.That (Mathf.ClosestPowerOfTwo (-4), Is.EqualTo (0));
		Assert.That (Mathf.ClosestPowerOfTwo (-2), Is.EqualTo (0));
		Assert.That (Mathf.ClosestPowerOfTwo (-1), Is.EqualTo (0));
		Assert.That (Mathf.ClosestPowerOfTwo (0), Is.EqualTo (0));

		Assert.That (Mathf.ClosestPowerOfTwo (1), Is.EqualTo (1));
		Assert.That (Mathf.ClosestPowerOfTwo (2), Is.EqualTo (2));
		Assert.That (Mathf.ClosestPowerOfTwo (3), Is.EqualTo (4));
		Assert.That (Mathf.ClosestPowerOfTwo (4), Is.EqualTo (4));
		Assert.That (Mathf.ClosestPowerOfTwo (5), Is.EqualTo (4));
		Assert.That (Mathf.ClosestPowerOfTwo (6), Is.EqualTo (8));
		Assert.That (Mathf.ClosestPowerOfTwo (7), Is.EqualTo (8));
		Assert.That (Mathf.ClosestPowerOfTwo (8), Is.EqualTo (8));
		Assert.That (Mathf.ClosestPowerOfTwo (9), Is.EqualTo (8));
		Assert.That (Mathf.ClosestPowerOfTwo (10), Is.EqualTo (8));
		Assert.That (Mathf.ClosestPowerOfTwo (11), Is.EqualTo (8));
		Assert.That (Mathf.ClosestPowerOfTwo (12), Is.EqualTo (16));
		Assert.That (Mathf.ClosestPowerOfTwo (13), Is.EqualTo (16));
		Assert.That (Mathf.ClosestPowerOfTwo (14), Is.EqualTo (16));
		Assert.That (Mathf.ClosestPowerOfTwo (15), Is.EqualTo (16));
		Assert.That (Mathf.ClosestPowerOfTwo (16), Is.EqualTo (16));

		Assert.That (Mathf.ClosestPowerOfTwo (100), Is.EqualTo (128));
		Assert.That (Mathf.ClosestPowerOfTwo (128), Is.EqualTo (128));
	}

	[Test]
	public void DeltaAngleTest ()
	{
		Assert.That (Mathf.DeltaAngle (0, 170.0F), Is.EqualTo (170.0F));
		Assert.That (Mathf.DeltaAngle (0, 180.0F), Is.EqualTo (180.0F));
		Assert.That (Mathf.DeltaAngle (0, 181.0F), Is.EqualTo (-179.0F));

		Assert.That (Mathf.DeltaAngle (170.0F, 0.0F), Is.EqualTo (-170.0F));
		Assert.That (Mathf.DeltaAngle (180.0F, 0.0F), Is.EqualTo (180.0F));
		Assert.That (Mathf.DeltaAngle (181.0F, 0.0F), Is.EqualTo (179.0F));

		Assert.That (Mathf.DeltaAngle (-30.0F, 20.0F), Is.EqualTo (50.0F));
		Assert.That (Mathf.DeltaAngle (20.0F, -30.0F), Is.EqualTo (-50.0F));

		Assert.That (Mathf.DeltaAngle (0, 450.0F), Is.EqualTo (90.0F));
		Assert.That (Mathf.DeltaAngle (0, 540.0F), Is.EqualTo (180.0F));
		Assert.That (Mathf.DeltaAngle (0, 630.0F), Is.EqualTo (-90.0F));
		Assert.That (Mathf.DeltaAngle (0, 720.0F), Is.EqualTo (0.0F));
	}

	[Test]
	public void FloorTest ()
	{
		Assert.That (Mathf.Floor (+2.5F), Is.EqualTo (2.0F));
		Assert.That (Mathf.Floor (+2.1F), Is.EqualTo (2.0F));
		Assert.That (Mathf.Floor (+2.0F), Is.EqualTo (2.0F));
		Assert.That (Mathf.Floor (+1.999999F), Is.EqualTo (1.0F));
		Assert.That (Mathf.Floor (+1.5F), Is.EqualTo (1.0F));
		Assert.That (Mathf.Floor (+1.1F), Is.EqualTo (1.0F));
		Assert.That (Mathf.Floor (+1.0F), Is.EqualTo (1.0F));
		Assert.That (Mathf.Floor (+0.999999F), Is.EqualTo (0.0F));
		Assert.That (Mathf.Floor (+0.5F), Is.EqualTo (0.0F));
		Assert.That (Mathf.Floor (+float.Epsilon), Is.EqualTo (0.0F));
		Assert.That (Mathf.Floor (0.0F), Is.EqualTo (0.0F));
		Assert.That (Mathf.Floor (-float.Epsilon), Is.EqualTo (-1.0F));
		Assert.That (Mathf.Floor (-0.5F), Is.EqualTo (-1.0F));
		Assert.That (Mathf.Floor (-0.999999F), Is.EqualTo (-1.0F));
		Assert.That (Mathf.Floor (-1.0F), Is.EqualTo (-1.0F));
		Assert.That (Mathf.Floor (-1.1F), Is.EqualTo (-2.0F));
		Assert.That (Mathf.Floor (-1.5F), Is.EqualTo (-2.0F));
		Assert.That (Mathf.Floor (-1.999999F), Is.EqualTo (-2.0F));
		Assert.That (Mathf.Floor (-2.0F), Is.EqualTo (-2.0F));
		Assert.That (Mathf.Floor (-2.1F), Is.EqualTo (-3.0F));
		Assert.That (Mathf.Floor (-2.5F), Is.EqualTo (-3.0F));
	}

	[Test]
	public void FloorToIntTest ()
	{
		Assert.That (Mathf.FloorToInt (+2.5F), Is.EqualTo (2));
		Assert.That (Mathf.FloorToInt (+2.1F), Is.EqualTo (2));
		Assert.That (Mathf.FloorToInt (+2.0F), Is.EqualTo (2));
		Assert.That (Mathf.FloorToInt (+1.999999F), Is.EqualTo (1));
		Assert.That (Mathf.FloorToInt (+1.5F), Is.EqualTo (1));
		Assert.That (Mathf.FloorToInt (+1.1F), Is.EqualTo (1));
		Assert.That (Mathf.FloorToInt (+1.0F), Is.EqualTo (1));
		Assert.That (Mathf.FloorToInt (+0.999999F), Is.EqualTo (0));
		Assert.That (Mathf.FloorToInt (+0.5F), Is.EqualTo (0));
		Assert.That (Mathf.FloorToInt (+float.Epsilon), Is.EqualTo (0));
		Assert.That (Mathf.FloorToInt (0.0F), Is.EqualTo (0));
		Assert.That (Mathf.FloorToInt (-float.Epsilon), Is.EqualTo (-1));
		Assert.That (Mathf.FloorToInt (-0.5F), Is.EqualTo (-1));
		Assert.That (Mathf.FloorToInt (-0.999999F), Is.EqualTo (-1));
		Assert.That (Mathf.FloorToInt (-1.0F), Is.EqualTo (-1));
		Assert.That (Mathf.FloorToInt (-1.1F), Is.EqualTo (-2));
		Assert.That (Mathf.FloorToInt (-1.5F), Is.EqualTo (-2));
		Assert.That (Mathf.FloorToInt (-1.999999F), Is.EqualTo (-2));
		Assert.That (Mathf.FloorToInt (-2.0F), Is.EqualTo (-2));
		Assert.That (Mathf.FloorToInt (-2.1F), Is.EqualTo (-3));
		Assert.That (Mathf.FloorToInt (-2.5F), Is.EqualTo (-3));
	}

	[Test]
	public void GammaToLinnearSpaceTest ()
	{
		Assert.AreEqual (0.0F, Mathf.GammaToLinearSpace (0.0F));
		Assert.AreEqual (0.01002283F, Mathf.GammaToLinearSpace (0.1F), 0.00001F);
		Assert.AreEqual (0.03310477F, Mathf.GammaToLinearSpace (0.2F), 0.00001F);
		Assert.AreEqual (0.07323897F, Mathf.GammaToLinearSpace (0.3F), 0.00001F);
		Assert.AreEqual (0.13286830F, Mathf.GammaToLinearSpace (0.4F), 0.00001F);
		Assert.AreEqual (0.21404110F, Mathf.GammaToLinearSpace (0.5F), 0.00001F);
		Assert.AreEqual (0.31854680F, Mathf.GammaToLinearSpace (0.6F), 0.00001F);
		Assert.AreEqual (0.44798840F, Mathf.GammaToLinearSpace (0.7F), 0.00001F);
		Assert.AreEqual (0.60382740F, Mathf.GammaToLinearSpace (0.8F), 0.00001F);
		Assert.AreEqual (0.78741250F, Mathf.GammaToLinearSpace (0.9F), 0.00001F);
		Assert.AreEqual (1.0F, Mathf.GammaToLinearSpace (1.0F));

		// TODO Add more test
	}

	[Test]
	public void InverseLerpTest ()
	{
		Assert.That (Mathf.InverseLerp (0.0F, 10.0F, -1.0F), Is.EqualTo (0.0F));
		Assert.That (Mathf.InverseLerp (0.0F, 10.0F, 0.0F), Is.EqualTo (0.0F));
		Assert.That (Mathf.InverseLerp (0.0F, 10.0F, 2.5F), Is.EqualTo (0.25F));
		Assert.That (Mathf.InverseLerp (0.0F, 10.0F, 5.0F), Is.EqualTo (0.5F));
		Assert.That (Mathf.InverseLerp (0.0F, 10.0F, 10.0F), Is.EqualTo (1.0F));
		Assert.That (Mathf.InverseLerp (0.0F, 10.0F, 15.0F), Is.EqualTo (1.0F));

		Assert.That (Mathf.InverseLerp (-5.0F, 15.0F, -10.0F), Is.EqualTo (0.0F));
		Assert.That (Mathf.InverseLerp (-5.0F, 15.0F, -5.0F), Is.EqualTo (0.0F));
		Assert.That (Mathf.InverseLerp (-5.0F, 15.0F, 0.0F), Is.EqualTo (0.25F));
		Assert.That (Mathf.InverseLerp (-5.0F, 15.0F, 5.0F), Is.EqualTo (0.5F));
		Assert.That (Mathf.InverseLerp (-5.0F, 15.0F, 15.0F), Is.EqualTo (1.0F));
		Assert.That (Mathf.InverseLerp (-5.0F, 15.0F, 25.0F), Is.EqualTo (1.0F));

		Assert.That (Mathf.InverseLerp (10.0F, 0.0F, -1.0F), Is.EqualTo (1.0F));
		Assert.That (Mathf.InverseLerp (10.0F, 0.0F, 0.0F), Is.EqualTo (1.0F));
		Assert.That (Mathf.InverseLerp (10.0F, 0.0F, 2.5F), Is.EqualTo (0.75F));
		Assert.That (Mathf.InverseLerp (10.0F, 0.0F, 5.0F), Is.EqualTo (0.5F));
		Assert.That (Mathf.InverseLerp (10.0F, 0.0F, 10.0F), Is.EqualTo (0.0F));
		Assert.That (Mathf.InverseLerp (10.0F, 0.0F, 15.0F), Is.EqualTo (0.0F));
	}

	[Test]
	public void LerpTest ()
	{
		Assert.That (Mathf.Lerp (a: 0.0F, b: 1.0F, t: -1.0F), Is.EqualTo (0.0F));
		Assert.That (Mathf.Lerp (a: 0.0F, b: 1.0F, t: 0.0F), Is.EqualTo (0.0F));
		Assert.That (Mathf.Lerp (a: 0.0F, b: 1.0F, t: 1.0F), Is.EqualTo (1.0F));
		Assert.That (Mathf.Lerp (a: 0.0F, b: 1.0F, t: 0.25F), Is.EqualTo (0.25F));
		Assert.That (Mathf.Lerp (a: 0.0F, b: 1.0F, t: 1.25F), Is.EqualTo (1.0F));

		Assert.That (Mathf.Lerp (a: -1.0F, b: 3.0F, t: -1.0F), Is.EqualTo (-1.0F));
		Assert.That (Mathf.Lerp (a: -1.0F, b: 3.0F, t: 0.0F), Is.EqualTo (-1.0F));
		Assert.That (Mathf.Lerp (a: -1.0F, b: 3.0F, t: 1.0F), Is.EqualTo (3.0F));
		Assert.That (Mathf.Lerp (a: -1.0F, b: 3.0F, t: 0.25F), Is.EqualTo (0.0F));
		Assert.That (Mathf.Lerp (a: -1.0F, b: 3.0F, t: 1.25F), Is.EqualTo (3.0F));

		Assert.That (Mathf.Lerp (a: 4.0F, b: -4.0F, t: -1.0F), Is.EqualTo (4.0F));
		Assert.That (Mathf.Lerp (a: 4.0F, b: -4.0F, t: 0.0F), Is.EqualTo (4.0F));
		Assert.That (Mathf.Lerp (a: 4.0F, b: -4.0F, t: 1.0F), Is.EqualTo (-4.0F));
		Assert.That (Mathf.Lerp (a: 4.0F, b: -4.0F, t: 0.25F), Is.EqualTo (2.0F));
		Assert.That (Mathf.Lerp (a: 4.0F, b: -4.0F, t: 1.25F), Is.EqualTo (-4.0F));
	}

	[Test]
	public void LerpAngleTest ()
	{
		Assert.That (Mathf.LerpAngle (a: 45.0F, b: 90.0F, t: -1.0F), Is.EqualTo (45.0F));
		Assert.That (Mathf.LerpAngle (a: 45.0F, b: 90.0F, t: 0.0F), Is.EqualTo (45.0F));
		Assert.That (Mathf.LerpAngle (a: 45.0F, b: 90.0F, t: 1.0F), Is.EqualTo (90.0F));
		Assert.That (Mathf.LerpAngle (a: 45.0F, b: 90.0F, t: 0.25F), Is.EqualTo (56.25F));
		Assert.That (Mathf.LerpAngle (a: 45.0F, b: 90.0F, t: 1.25F), Is.EqualTo (90.0F));

		Assert.That (Mathf.LerpAngle (a: 90.0F, b: 45.0F, t: -1.0F), Is.EqualTo (90.0F));
		Assert.That (Mathf.LerpAngle (a: 90.0F, b: 45.0F, t: 0.0F), Is.EqualTo (90.0F));
		Assert.That (Mathf.LerpAngle (a: 90.0F, b: 45.0F, t: 1.0F), Is.EqualTo (45.0F));
		Assert.That (Mathf.LerpAngle (a: 90.0F, b: 45.0F, t: 0.25F), Is.EqualTo (78.75F));
		Assert.That (Mathf.LerpAngle (a: 90.0F, b: 45.0F, t: 1.25F), Is.EqualTo (45.0F));

		Assert.That (Mathf.LerpAngle (a: 360.0F, b: 405.0F, t: -1.0F), Is.EqualTo (360.0F));
		Assert.That (Mathf.LerpAngle (a: 360.0F, b: 405.0F, t: 0.0F), Is.EqualTo (360.0F));
		Assert.That (Mathf.LerpAngle (a: 360.0F, b: 405.0F, t: 1.0F), Is.EqualTo (405.0F));
		Assert.That (Mathf.LerpAngle (a: 360.0F, b: 405.0F, t: 0.25F), Is.EqualTo (371.25F));
		Assert.That (Mathf.LerpAngle (a: 360.0F, b: 405.0F, t: 1.25F), Is.EqualTo (405.0F));

		Assert.That (Mathf.LerpAngle (a: 315.0F, b: 45.0F, t: -1.0F), Is.EqualTo (315.0F));
		Assert.That (Mathf.LerpAngle (a: 315.0F, b: 45.0F, t: 0.0F), Is.EqualTo (315.0F));
		Assert.That (Mathf.LerpAngle (a: 315.0F, b: 45.0F, t: 1.0F), Is.EqualTo (405.0F));
		Assert.That (Mathf.LerpAngle (a: 315.0F, b: 45.0F, t: 0.25F), Is.EqualTo (337.5F));
		Assert.That (Mathf.LerpAngle (a: 315.0F, b: 45.0F, t: 1.25F), Is.EqualTo (405.0F));

		Assert.That (Mathf.LerpAngle (a: 45.0F, b: -45.0F, t: -1.0F), Is.EqualTo (45.0F));
		Assert.That (Mathf.LerpAngle (a: 45.0F, b: -45.0F, t: 0.0F), Is.EqualTo (45.0F));
		Assert.That (Mathf.LerpAngle (a: 45.0F, b: -45.0F, t: 1.0F), Is.EqualTo (-45.0F));
		Assert.That (Mathf.LerpAngle (a: 45.0F, b: -45.0F, t: 0.25F), Is.EqualTo (22.5F));
		Assert.That (Mathf.LerpAngle (a: 45.0F, b: -45.0F, t: 1.25F), Is.EqualTo (-45.0F));
	}

	[Test]
	public void LerpUnclampedTest ()
	{
		Assert.That (Mathf.LerpUnclamped (a: 0.0F, b: 1.0F, t: -1.0F), Is.EqualTo (-1.0F));
		Assert.That (Mathf.LerpUnclamped (a: 0.0F, b: 1.0F, t: 0.0F), Is.EqualTo (0.0F));
		Assert.That (Mathf.LerpUnclamped (a: 0.0F, b: 1.0F, t: 1.0F), Is.EqualTo (1.0F));
		Assert.That (Mathf.LerpUnclamped (a: 0.0F, b: 1.0F, t: 0.25F), Is.EqualTo (0.25F));
		Assert.That (Mathf.LerpUnclamped (a: 0.0F, b: 1.0F, t: 1.25F), Is.EqualTo (1.25F));

		Assert.That (Mathf.LerpUnclamped (a: -1.0F, b: 3.0F, t: -1.0F), Is.EqualTo (-5.0F));
		Assert.That (Mathf.LerpUnclamped (a: -1.0F, b: 3.0F, t: 0.0F), Is.EqualTo (-1.0F));
		Assert.That (Mathf.LerpUnclamped (a: -1.0F, b: 3.0F, t: 1.0F), Is.EqualTo (3.0F));
		Assert.That (Mathf.LerpUnclamped (a: -1.0F, b: 3.0F, t: 0.25F), Is.EqualTo (0.0F));
		Assert.That (Mathf.LerpUnclamped (a: -1.0F, b: 3.0F, t: 1.25F), Is.EqualTo (4.0F));

		Assert.That (Mathf.LerpUnclamped (a: 4.0F, b: -4.0F, t: -1.0F), Is.EqualTo (12.0F));
		Assert.That (Mathf.LerpUnclamped (a: 4.0F, b: -4.0F, t: 0.0F), Is.EqualTo (4.0F));
		Assert.That (Mathf.LerpUnclamped (a: 4.0F, b: -4.0F, t: 1.0F), Is.EqualTo (-4.0F));
		Assert.That (Mathf.LerpUnclamped (a: 4.0F, b: -4.0F, t: 0.25F), Is.EqualTo (2.0F));
		Assert.That (Mathf.LerpUnclamped (a: 4.0F, b: -4.0F, t: 1.25F), Is.EqualTo (-6.0F));
	}

	[Test]
	public void LinearToGammaSpaceTest ()
	{
		Assert.AreEqual (0.0F, Mathf.LinearToGammaSpace (0.0F));
		Assert.AreEqual (0.3491902F, Mathf.LinearToGammaSpace (0.1F), 0.00001F);
		Assert.AreEqual (0.4845292F, Mathf.LinearToGammaSpace (0.2F), 0.00001F);
		Assert.AreEqual (0.5838314F, Mathf.LinearToGammaSpace (0.3F), 0.00001F);
		Assert.AreEqual (0.6651850F, Mathf.LinearToGammaSpace (0.4F), 0.00001F);
		Assert.AreEqual (0.7353570F, Mathf.LinearToGammaSpace (0.5F), 0.00001F);
		Assert.AreEqual (0.7977377F, Mathf.LinearToGammaSpace (0.6F), 0.00001F);
		Assert.AreEqual (0.8543057F, Mathf.LinearToGammaSpace (0.7F), 0.00001F);
		Assert.AreEqual (0.9063317F, Mathf.LinearToGammaSpace (0.8F), 0.00001F);
		Assert.AreEqual (0.9546872F, Mathf.LinearToGammaSpace (0.9F), 0.00001F);
		Assert.AreEqual (1.0F, Mathf.LinearToGammaSpace (1.0F));

		// TODO Add more test
	}

	[Test]
	public void MaxIntTest ()
	{
		Assert.That (Mathf.Max (1, 2), Is.EqualTo (2));
		Assert.That (Mathf.Max (-1, 3), Is.EqualTo (3));
		Assert.That (Mathf.Max (2, 2), Is.EqualTo (2));
		Assert.That (Mathf.Max (0, 0), Is.EqualTo (0));
		Assert.That (Mathf.Max (3, 1), Is.EqualTo (3));
		Assert.That (Mathf.Max (2, -1), Is.EqualTo (2));
	}

	[Test]
	public void MaxFloatTest ()
	{
		Assert.That (Mathf.Max (1.0F, 2.0F), Is.EqualTo (2.0F));
		Assert.That (Mathf.Max (-1.0F, 3.0F), Is.EqualTo (3.0F));
		Assert.That (Mathf.Max (2.0F, 2.0F), Is.EqualTo (2.0F));
		Assert.That (Mathf.Max (0.0F, 0.0F), Is.EqualTo (0.0F));
		Assert.That (Mathf.Max (3.0F, 1.0F), Is.EqualTo (3.0F));
		Assert.That (Mathf.Max (2.0F, -1.0F), Is.EqualTo (2.0F));
	}

	[Test]
	public void MaxIntParamsTest ()
	{
		Assert.That (Mathf.Max (new int[0]), Is.EqualTo (0));
		Assert.That (Mathf.Max (new []{ 1 }), Is.EqualTo (1));
		Assert.That (Mathf.Max (new []{ -3, 1 }), Is.EqualTo (1));
		Assert.That (Mathf.Max (new []{ 2, 0 }), Is.EqualTo (2));
		Assert.That (Mathf.Max (new []{ 1, 2, -1, 2 }), Is.EqualTo (2));
		Assert.That (Mathf.Max (new []{ 3, 1, 4, 1, 5, 9, 2 }), Is.EqualTo (9));
		Assert.That (Mathf.Max (new []{ -3, -1, -4, -1, -5, -9, -2 }), Is.EqualTo (-1));
	}

	[Test]
	public void MaxFloatParamsTest ()
	{
		Assert.That (Mathf.Max (new float[0]), Is.EqualTo (0.0F));
		Assert.That (Mathf.Max (new []{ 1.0F }), Is.EqualTo (1.0F));
		Assert.That (Mathf.Max (new []{ -3.0F, 1.0F }), Is.EqualTo (1.0F));
		Assert.That (Mathf.Max (new []{ 2.0F, 0.0F }), Is.EqualTo (2.0F));
		Assert.That (Mathf.Max (new []{ 1.0F, 2.0F, -1.0F, 2.0F }), Is.EqualTo (2.0F));
		Assert.That (Mathf.Max (new []{ 3.0F, 1.0F, 4.0F, 1.0F, 5.0F, 9.0F, 2.0F }), Is.EqualTo (9.0F));
		Assert.That (Mathf.Max (new []{ -3.0F, -1.0F, -4.0F, -1.0F, -5.0F, -9.0F, -2.0F }), Is.EqualTo (-1.0F));
	}

	[Test]
	public void MinIntTest ()
	{
		Assert.That (Mathf.Min (1, 2), Is.EqualTo (1));
		Assert.That (Mathf.Min (-1, 3), Is.EqualTo (-1));
		Assert.That (Mathf.Min (2, 2), Is.EqualTo (2));
		Assert.That (Mathf.Min (0, 0), Is.EqualTo (0));
		Assert.That (Mathf.Min (3, 1), Is.EqualTo (1));
		Assert.That (Mathf.Min (2, -1), Is.EqualTo (-1));
	}

	[Test]
	public void MinFloatTest ()
	{
		Assert.That (Mathf.Min (1.0F, 2.0F), Is.EqualTo (1.0F));
		Assert.That (Mathf.Min (-1.0F, 3.0F), Is.EqualTo (-1.0F));
		Assert.That (Mathf.Min (2.0F, 2.0F), Is.EqualTo (2.0F));
		Assert.That (Mathf.Min (0.0F, 0.0F), Is.EqualTo (0.0F));
		Assert.That (Mathf.Min (3.0F, 1.0F), Is.EqualTo (1.0F));
		Assert.That (Mathf.Min (2.0F, -1.0F), Is.EqualTo (-1.0F));
	}

	[Test]
	public void MinIntParamsTest ()
	{
		Assert.That (Mathf.Min (new int[0]), Is.EqualTo (0));
		Assert.That (Mathf.Min (new []{ 1 }), Is.EqualTo (1));
		Assert.That (Mathf.Min (new []{ -3, 1 }), Is.EqualTo (-3));
		Assert.That (Mathf.Min (new []{ 2, 0 }), Is.EqualTo (0));
		Assert.That (Mathf.Min (new []{ -1, 2, -1, 1 }), Is.EqualTo (-1));
		Assert.That (Mathf.Min (new []{ 3, 1, 4, 1, 5, 9, 2 }), Is.EqualTo (1));
		Assert.That (Mathf.Min (new []{ -3, -1, -4, -1, -5, -9, -2 }), Is.EqualTo (-9));
	}

	[Test]
	public void MinFloatParamsTest ()
	{
		Assert.That (Mathf.Min (new float[0]), Is.EqualTo (0.0F));
		Assert.That (Mathf.Min (new []{ 1.0F }), Is.EqualTo (1.0F));
		Assert.That (Mathf.Min (new []{ -3.0F, 1.0F }), Is.EqualTo (-3.0F));
		Assert.That (Mathf.Min (new []{ 2.0F, 0.0F }), Is.EqualTo (0.0F));
		Assert.That (Mathf.Min (new []{ -1.0F, -2.0F, 1.0F, -2.0F }), Is.EqualTo (-2.0F));
		Assert.That (Mathf.Min (new []{ 3.0F, 1.0F, 4.0F, 1.0F, 5.0F, 9.0F, 2.0F }), Is.EqualTo (1.0F));
		Assert.That (Mathf.Min (new []{ -3.0F, -1.0F, -4.0F, -1.0F, -5.0F, -9.0F, -2.0F }), Is.EqualTo (-9.0F));
	}

	[Test]
	public void PingPongTest ()
	{
		Assert.That (Mathf.PingPong (-1.75F, 1.0F), Is.EqualTo (0.25F));
		Assert.That (Mathf.PingPong (-1.5F, 1.0F), Is.EqualTo (0.5F));
		Assert.That (Mathf.PingPong (-1.25F, 1.0F), Is.EqualTo (0.75F));
		Assert.That (Mathf.PingPong (-1.0F, 1.0F), Is.EqualTo (1.0F));
		Assert.That (Mathf.PingPong (-0.75F, 1.0F), Is.EqualTo (0.75F));
		Assert.That (Mathf.PingPong (-0.5F, 1.0F), Is.EqualTo (0.5F));
		Assert.That (Mathf.PingPong (-0.25F, 1.0F), Is.EqualTo (0.25F));
		Assert.That (Mathf.PingPong (0.0F, 1.0F), Is.EqualTo (0.0F));
		Assert.That (Mathf.PingPong (0.25F, 1.0F), Is.EqualTo (0.25F));
		Assert.That (Mathf.PingPong (0.5F, 1.0F), Is.EqualTo (0.5F));
		Assert.That (Mathf.PingPong (0.75F, 1.0F), Is.EqualTo (0.75F));
		Assert.That (Mathf.PingPong (1.0F, 1.0F), Is.EqualTo (1.0F));
		Assert.That (Mathf.PingPong (1.25F, 1.0F), Is.EqualTo (0.75F));
		Assert.That (Mathf.PingPong (1.5F, 1.0F), Is.EqualTo (0.5F));
		Assert.That (Mathf.PingPong (1.75F, 1.0F), Is.EqualTo (0.25F));

		Assert.True (float.IsNaN (Mathf.PingPong (0.5F, 0.0F)));
	}

	[Test]
	public void RepeatTest ()
	{
		Assert.That (Mathf.Repeat (-1.75F, 1.0F), Is.EqualTo (0.25F));
		Assert.That (Mathf.Repeat (-1.5F, 1.0F), Is.EqualTo (0.5F));
		Assert.That (Mathf.Repeat (-1.25F, 1.0F), Is.EqualTo (0.75F));
		Assert.That (Mathf.Repeat (-1.0F, 1.0F), Is.EqualTo (0.0F));
		Assert.That (Mathf.Repeat (-0.75F, 1.0F), Is.EqualTo (0.25F));
		Assert.That (Mathf.Repeat (-0.5F, 1.0F), Is.EqualTo (0.5F));
		Assert.That (Mathf.Repeat (-0.25F, 1.0F), Is.EqualTo (0.75F));
		Assert.That (Mathf.Repeat (0.0F, 1.0F), Is.EqualTo (0.0F));
		Assert.That (Mathf.Repeat (0.25F, 1.0F), Is.EqualTo (0.25F));
		Assert.That (Mathf.Repeat (0.5F, 1.0F), Is.EqualTo (0.5F));
		Assert.That (Mathf.Repeat (0.75F, 1.0F), Is.EqualTo (0.75F));
		Assert.That (Mathf.Repeat (1.0F, 1.0F), Is.EqualTo (0.0F));
		Assert.That (Mathf.Repeat (1.25F, 1.0F), Is.EqualTo (0.25F));
		Assert.That (Mathf.Repeat (1.5F, 1.0F), Is.EqualTo (0.5F));
		Assert.That (Mathf.Repeat (1.75F, 1.0F), Is.EqualTo (0.75F));

		Assert.True (float.IsNaN (Mathf.Repeat (0.5F, 0.0F)));
	}

	[Test]
	public void RoundTest ()
	{
		Assert.That (Mathf.Round (+6.5F), Is.EqualTo (6.0F));
		Assert.That (Mathf.Round (+5.5F), Is.EqualTo (6.0F));

		Assert.That (Mathf.Round (+4.5F), Is.EqualTo (4.0F));
		Assert.That (Mathf.Round (+3.5F), Is.EqualTo (4.0F));

		Assert.That (Mathf.Round (+2.5F), Is.EqualTo (2.0F));
		Assert.That (Mathf.Round (+2.1F), Is.EqualTo (2.0F));
		Assert.That (Mathf.Round (+2.0F), Is.EqualTo (2.0F));
		Assert.That (Mathf.Round (+1.999999F), Is.EqualTo (2.0F));
		Assert.That (Mathf.Round (+1.5F), Is.EqualTo (2.0F));
		Assert.That (Mathf.Round (+1.1F), Is.EqualTo (1.0F));
		Assert.That (Mathf.Round (+1.0F), Is.EqualTo (1.0F));
		Assert.That (Mathf.Round (+0.999999F), Is.EqualTo (1.0F));
		Assert.That (Mathf.Round (+0.5F), Is.EqualTo (0.0F));
		Assert.That (Mathf.Round (+float.Epsilon), Is.EqualTo (0.0F));
		Assert.That (Mathf.Round (0.0F), Is.EqualTo (0.0F));
		Assert.That (Mathf.Round (-float.Epsilon), Is.EqualTo (0.0F));
		Assert.That (Mathf.Round (-0.5F), Is.EqualTo (0.0F));
		Assert.That (Mathf.Round (-0.999999F), Is.EqualTo (-1.0F));
		Assert.That (Mathf.Round (-1.0F), Is.EqualTo (-1.0F));
		Assert.That (Mathf.Round (-1.1F), Is.EqualTo (-1.0F));
		Assert.That (Mathf.Round (-1.5F), Is.EqualTo (-2.0F));
		Assert.That (Mathf.Round (-1.999999F), Is.EqualTo (-2.0F));
		Assert.That (Mathf.Round (-2.0F), Is.EqualTo (-2.0F));
		Assert.That (Mathf.Round (-2.1F), Is.EqualTo (-2.0F));
		Assert.That (Mathf.Round (-2.5F), Is.EqualTo (-2.0F));

		Assert.That (Mathf.Round (-3.5F), Is.EqualTo (-4.0F));
		Assert.That (Mathf.Round (-4.5F), Is.EqualTo (-4.0F));

		Assert.That (Mathf.Round (-5.5F), Is.EqualTo (-6.0F));
		Assert.That (Mathf.Round (-6.5F), Is.EqualTo (-6.0F));
	}

	[Test]
	public void RoundToIntTest ()
	{
		Assert.That (Mathf.RoundToInt (+6.5F), Is.EqualTo (6));
		Assert.That (Mathf.RoundToInt (+5.5F), Is.EqualTo (6));

		Assert.That (Mathf.RoundToInt (+4.5F), Is.EqualTo (4));
		Assert.That (Mathf.RoundToInt (+3.5F), Is.EqualTo (4));

		Assert.That (Mathf.RoundToInt (+2.5F), Is.EqualTo (2));
		Assert.That (Mathf.RoundToInt (+2.1F), Is.EqualTo (2));
		Assert.That (Mathf.RoundToInt (+2.0F), Is.EqualTo (2));
		Assert.That (Mathf.RoundToInt (+1.999999F), Is.EqualTo (2));
		Assert.That (Mathf.RoundToInt (+1.5F), Is.EqualTo (2));
		Assert.That (Mathf.RoundToInt (+1.1F), Is.EqualTo (1));
		Assert.That (Mathf.RoundToInt (+1.0F), Is.EqualTo (1));
		Assert.That (Mathf.RoundToInt (+0.999999F), Is.EqualTo (1));
		Assert.That (Mathf.RoundToInt (+0.5F), Is.EqualTo (0));
		Assert.That (Mathf.RoundToInt (+float.Epsilon), Is.EqualTo (0));
		Assert.That (Mathf.RoundToInt (0.0F), Is.EqualTo (0));
		Assert.That (Mathf.RoundToInt (-float.Epsilon), Is.EqualTo (0));
		Assert.That (Mathf.RoundToInt (-0.5F), Is.EqualTo (0));
		Assert.That (Mathf.RoundToInt (-0.999999F), Is.EqualTo (-1));
		Assert.That (Mathf.RoundToInt (-1.0F), Is.EqualTo (-1));
		Assert.That (Mathf.RoundToInt (-1.1F), Is.EqualTo (-1));
		Assert.That (Mathf.RoundToInt (-1.5F), Is.EqualTo (-2));
		Assert.That (Mathf.RoundToInt (-1.999999F), Is.EqualTo (-2));
		Assert.That (Mathf.RoundToInt (-2.0F), Is.EqualTo (-2));
		Assert.That (Mathf.RoundToInt (-2.1F), Is.EqualTo (-2));
		Assert.That (Mathf.RoundToInt (-2.5F), Is.EqualTo (-2));

		Assert.That (Mathf.RoundToInt (-3.5F), Is.EqualTo (-4));
		Assert.That (Mathf.RoundToInt (-4.5F), Is.EqualTo (-4));

		Assert.That (Mathf.RoundToInt (-5.5F), Is.EqualTo (-6));
		Assert.That (Mathf.RoundToInt (-6.5F), Is.EqualTo (-6));
	}

	[Test]
	public void SignTest ()
	{
		Assert.That (Mathf.Sign (float.PositiveInfinity), Is.EqualTo (+1.0F));
		Assert.That (Mathf.Sign (+1.5F), Is.EqualTo (+1.0F));
		Assert.That (Mathf.Sign (+1.0F), Is.EqualTo (+1.0F));
		Assert.That (Mathf.Sign (+0.999999F), Is.EqualTo (+1.0F));
		Assert.That (Mathf.Sign (+float.Epsilon), Is.EqualTo (+1.0F));
		Assert.That (Mathf.Sign (+0.0F), Is.EqualTo (+1.0F));
		Assert.That (Mathf.Sign (-0.0F), Is.EqualTo (+1.0F));
		Assert.That (Mathf.Sign (-float.Epsilon), Is.EqualTo (-1.0F));
		Assert.That (Mathf.Sign (-0.999999F), Is.EqualTo (-1.0F));
		Assert.That (Mathf.Sign (-1.0F), Is.EqualTo (-1.0F));
		Assert.That (Mathf.Sign (-1.5F), Is.EqualTo (-1.0F));
		Assert.That (Mathf.Sign (float.NegativeInfinity), Is.EqualTo (-1.0F));
	}

	[Test]
	public void SmoothStepTest ()
	{
		Action<float, float, float> test = (float a, float b, float t) => {
			float actual = Mathf.SmoothStep (a, b, t);
			float expected = Mathf.Lerp (a, b, -2 * t * t * t + 3 * t * t);
			Assert.AreEqual (expected, actual);
		};

		Assert.That (Mathf.SmoothStep (0.0F, 1.0F, 0.0F), Is.EqualTo (0.0F));
		Assert.That (Mathf.SmoothStep (0.0F, 1.0F, 1.0F), Is.EqualTo (1.0F));
		Assert.That (Mathf.SmoothStep (0.0F, 1.0F, -0.3F), Is.EqualTo (0.0F));
		Assert.That (Mathf.SmoothStep (0.0F, 1.0F, 1.2F), Is.EqualTo (1.0F));
		test (0.0F, 1.0F, 0.1F);
		test (0.0F, 1.0F, 0.5F);
		test (0.0F, 1.0F, 0.8F);

		Assert.That (Mathf.SmoothStep (2.0F, 5.0F, 0.0F), Is.EqualTo (2.0F));
		Assert.That (Mathf.SmoothStep (2.0F, 5.0F, 1.0F), Is.EqualTo (5.0F));
		Assert.That (Mathf.SmoothStep (2.0F, 5.0F, -0.3F), Is.EqualTo (2.0F));
		Assert.That (Mathf.SmoothStep (2.0F, 5.0F, 1.2F), Is.EqualTo (5.0F));
		test (2.0F, 5.0F, 0.1F);
		test (2.0F, 5.0F, 0.5F);
		test (2.0F, 5.0F, 0.8F);

		Assert.That (Mathf.SmoothStep (4.0F, 1.0F, 0.0F), Is.EqualTo (4.0F));
		Assert.That (Mathf.SmoothStep (4.0F, 1.0F, 1.0F), Is.EqualTo (1.0F));
		Assert.That (Mathf.SmoothStep (4.0F, 1.0F, -0.3F), Is.EqualTo (4.0F));
		Assert.That (Mathf.SmoothStep (4.0F, 1.0F, 1.2F), Is.EqualTo (1.0F));
		test (4.0F, 1.0F, 0.1F);
		test (4.0F, 1.0F, 0.5F);
		test (4.0F, 1.0F, 0.8F);
	}
}
