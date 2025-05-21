using System;

namespace Target {
    /// <summary>
    /// ターゲットにするべき対象を選出するための優先度と対象を保持するためのクラス
    /// </summary>
    [Serializable]
    public class TargetPriority<T> {
        /// <summary>
        /// ターゲットにする候補
        /// </summary>
        public T candidate;
        /// <summary>
        /// その優先度
        /// </summary>
        public float priority;
    }
}