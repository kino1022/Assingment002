namespace Target.Interface {
    public interface IPriorityHolder<T> {
        public TargetPriority<T> GetPriority();
    }
}