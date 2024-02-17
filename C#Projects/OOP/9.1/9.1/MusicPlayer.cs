using static PlayerState;

public class MusicPlayer {
    private IPlayerState _state;

    public MusicPlayer() {
        _state = new LockedState();
    }

    public void SetState(IPlayerState state) {
        _state = state;
    }

    public void Play() {
        _state.Play();
    }

    public void Stop() {
        _state.Stop();
    }

    public void Pause() {
        _state.Pause();
    }

    public void Repeat() {
        _state.Repeat();
    }
}
