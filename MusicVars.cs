using System;
using System.Media;
class MusicPlayer
{
    public static string StartMusic = @"C:\Users\Henrique\Desktop\WorldGenerator\music\The_Heros_Quest.wav";

    public static string HitSoundMale = @"C:\Users\Henrique\Desktop\WorldGenerator\sfx\hitsoundmale.wav";
    public static SoundPlayer Music = new SoundPlayer();
    public static SoundPlayer sfxhit = new SoundPlayer();
    public static void PlayMusic(string MusName)
    {
        Music = new SoundPlayer(MusName);
        Music.Load(); // Load the .wav file into memory
        Music.PlayLooping(); // Play the .wav file
    }

    public static void StopMusic()
    {
        Music.Stop();
    }

    public static void HitSoundMalePlay()
    {
        sfxhit = new SoundPlayer(HitSoundMale);
        sfxhit.Load(); // Load the .wav file into memory
        sfxhit.Play(); // Play the .wav file
    }
}