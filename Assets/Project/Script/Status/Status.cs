using Sirenix.OdinInspector;
using UnityEngine;

namespace Status {
    public class Status : SerializedMonoBehaviour {
        [SerializeField] protected float startValue;
        [SerializeField] protected BaseValue m_baseValue;

        private void Awake() {
            CreateBaseValueInstance();
            OnAwake();
        }
        private void Start() {
            OnStart();
        }

        private void Update() {
            OnUpdate();
        }

        private void OnDestroy() {
            OnPostDestroy();
        }
        
        //-------------Create Methods--------------

        protected void CreateBaseValueInstance() {
            m_baseValue = new BaseValue(startValue);
        }
        
        //-------------Hook Point-------------

        protected virtual void OnAwake() { }
        protected virtual void OnStart() { }
        protected virtual void OnUpdate() { }
        protected virtual void OnPostDestroy() { }
    }
}
