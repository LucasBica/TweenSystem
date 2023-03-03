using System;
using UnityEngine;

namespace Bica.TweenSystem.Runtime.Internal {

    public class TweenComponent : MonoBehaviour {

        private static TweenComponent instance;
        public static TweenComponent Instance {
            get {
                if (instance == null) {
                    GameObject gameObject = new GameObject("[TweenSystem]");
                    DontDestroyOnLoad(gameObject);
                    instance = gameObject.AddComponent<TweenComponent>();
                }

                return instance;
            }
        }

        public static event Action OnUpdate;

        private void Update() {
            OnUpdate?.Invoke();
        }
    }
}