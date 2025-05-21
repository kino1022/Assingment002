using Sirenix.OdinInspector;
using UnityEngine;

namespace Status {
    public class CorrectableStatus : Status {
        [SerializeField] protected CorrectValue m_correctValue;
        
        //----------------Create Methods-------------------

        protected void CreateCorrectValueInstance() {
            m_correctValue = new CorrectValue(startValue);
        }
        
        //----------------Hook Point----------------
        protected override void OnAwake() {
            base.OnAwake();
            CreateCorrectValueInstance();
        }
    }
}