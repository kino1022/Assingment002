using System;

namespace Status {
    [Serializable]
    public class BaseValue : AStatusElement{
        public BaseValue(float startValue) : base(startValue) {
            
        }
    }
}