using System.Collections.Generic;
using Sirenix.OdinInspector;
using Target.Interface;
using UnityEngine;

namespace Target {
    /// <summary>
    /// 飛んでいる弾丸などが標的にする対象を管理するコンポーネント
    /// </summary>
    public class LookTargetManager : SerializedBehaviour , ITargetHolder<GameObject> {
        [SerializeField] protected GameObject m_target;
        [SerializeField] protected List<IPriorityHolder<GameObject>> m_priorityHolders;

        public GameObject GetTarget() {
            return m_target;
        }
    }
}