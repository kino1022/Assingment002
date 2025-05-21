using UnityEngine;

namespace Target.Interface {
    /// <summary>
    /// 標的のゲームオブジェクトなどを保持するクラスに約束するインターフェース
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ITargetHolder<T> {
        public T GetTarget();
    }
}
