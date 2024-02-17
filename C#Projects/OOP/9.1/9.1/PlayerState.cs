public static class PlayerState {
    public class UnlockedState : IPlayerState {
        public void Play() {
            Console.WriteLine("Увімкнення плеєра.");
        }

        public void Stop() {
            Console.WriteLine("Зупинка роботи плеєра.");
        }

        public void Pause() {
            Console.WriteLine("Ви поставили на паузу.");
        }

        public void Repeat() {
            Console.WriteLine("Режим повторення увімкнено.");
        }
    }

    public class LockedState : IPlayerState {
        public void Play() {
            Console.WriteLine("Для увімкнення плеєра його необхідно розблокувати.");
        }

        public void Stop() {
            Console.WriteLine("Для зупинки плеєра його необхідно розблокувати.");
        }

        public void Pause() {
            Console.WriteLine("Для натиснення на паузу плеєр необхідно розблокувати.");
        }

        public void Repeat() {
            Console.WriteLine("Для увімкнення режиму повтору плеєр необхідно розблокувати.");
        }
    }

    public class LowBatteryState : IPlayerState {
        public void Play() {
            Console.WriteLine("Зарядіть свій плеєр перед його увімкненням!");
        }

        public void Stop() {
            Console.WriteLine("Зарядіть свій плеєр!");
        }

        public void Pause() {
            Console.WriteLine("Зарядіть свій плеєр!");
        }

        public void Repeat() {
            Console.WriteLine("Зарядіть свій плеєр!");
        }
    }
}
