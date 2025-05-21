using System;

namespace Status {
    /// <summary>
    /// ステータスの元々の値と補正後の値などの構成する要素を管理するクラス
    /// </summary>
    [Serializable]
    public abstract class AStatusElement {
        private float value;

        protected float m_value {
            get => value;
            set {
                value = OnPreValueChanged(value);
                m_value = value;
                OnPostValueChanged();
                ValueChangeEvent?.Invoke();
            }
        }

        public Action ValueChangeEvent;

        public AStatusElement(float startValue) {
            value = startValue;
        }

        public ref float GetVlaueReference() {
            return ref value;
        }

        protected virtual float OnPreValueChanged(float changeValue) {
            return changeValue;
        }
        
        protected virtual void OnPostValueChanged() {}
    }
}