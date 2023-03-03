﻿using System;
using UnityEngine;

namespace KDGame.UI
{
	public class UILayer : MonoBehaviour
	{
		[SerializeField] private Camera _camera;
		[SerializeField] private Canvas _canvas;

		public void InitDepth(int depth)
		{
			_camera.depth = depth;
		}

		public Transform GetRoot()
		{
			return _canvas.transform;
		}

		public Camera GetCamera()
		{
			return _camera;
		}
	}
}