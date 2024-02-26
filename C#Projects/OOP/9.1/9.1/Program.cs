﻿using System.Text;
using static PlayerState;

class Program {
    static void Main() {
        Console.OutputEncoding = Console.InputEncoding = Encoding.Unicode;
        MusicPlayer player = new MusicPlayer();

        player.Play();
        player.SetState(new UnlockedState());

        player.Play();
        player.Stop();
        player.Pause();
        player.Repeat();

        player.SetState(new LowBatteryState());
        player.Play();

        Console.ReadLine();
    }
}