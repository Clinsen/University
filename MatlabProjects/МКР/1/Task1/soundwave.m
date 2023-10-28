% Побудуйте звукову хвилю частотою 5Гц з частотою дискретизації 50Гц
wave_frequency = 5;
sampling_rate = 50;
duration = 1;
time = 0:1/sampling_rate:duration;
sound_wave = sin(2 * pi * wave_frequency * time);
sound(sound_wave, sampling_rate);