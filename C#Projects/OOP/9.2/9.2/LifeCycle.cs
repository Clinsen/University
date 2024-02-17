namespace _9._2 {
    public class LifeCycle {
        public string CurrentState { get; set; }

        public LifeCycle(string currentState) {
            CurrentState = currentState;
        }

        public void SetLifeState(string state) {
            CurrentState = state;
        }

        public override string ToString() {
            return $"{CurrentState}";
        }
    }
}
