using System;
using UnityEngine;
using Zenject;

namespace ITAcademy
{
    public class InputHandler : ITickable
    {
        private const string LayerName = "Ground";

        private readonly Camera _camera;

        public Action<Vector3> OnClicked;

        public InputHandler([Inject(Id = BaseIds.GameCameraId)] Camera camera)
        {
            _camera = camera;
        }

        public void Tick()
        {
            if (Input.GetMouseButtonDown(0))
            {
                var ray = _camera.ScreenPointToRay(Input.mousePosition);
                var mask = LayerMask.GetMask(LayerName);
                if (Physics.Raycast(ray, out RaycastHit hitInfo, 100, mask))
                {
                    OnClicked?.Invoke(hitInfo.point);
                }
            }
        }
    }
}