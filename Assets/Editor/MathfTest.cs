﻿using UnityEngine;
using UnityEditor;
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


}
