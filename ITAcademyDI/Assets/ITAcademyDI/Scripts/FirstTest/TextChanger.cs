using TMPro;
using UnityEngine;
using Zenject;

namespace ITAcademy
{
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class TextChanger : MonoBehaviour
    {
        [HideInInspector, SerializeField] private TextMeshProUGUI _label;
        
        private string _message;

        private void OnValidate()
        {
            _label = GetComponent<TextMeshProUGUI>();
        }

        [Inject]
        public void Construct(string message)
        {
            _message = message;
            _label.text = _message;
        }
    }
}