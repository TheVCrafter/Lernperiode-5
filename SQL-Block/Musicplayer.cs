using NAudio.Wave;

public class MusicPlayer
{
    private static MusicPlayer instance;
    public static MusicPlayer Instance => instance ??= new MusicPlayer();

    private WaveOutEvent outputDevice;
    private AudioFileReader audioFile;
    private bool stopRequested;

    private float volume = 1.0f; // Standardlautstärke (maximal)

    private MusicPlayer()
    {
        outputDevice = new WaveOutEvent();
        outputDevice.PlaybackStopped += OnPlaybackStopped;
        outputDevice.Volume = volume;
    }

    public void PlayMusic(string filePath)
    {
        StopMusic();
        stopRequested = false;
        audioFile = new AudioFileReader(filePath);
        outputDevice.Init(audioFile);
        outputDevice.Volume = volume;
        outputDevice.Play();
    }

    public void StopMusic()
    {
        stopRequested = true;
        outputDevice?.Stop();
        audioFile?.Dispose();
        audioFile = null;
    }

    private void OnPlaybackStopped(object sender, StoppedEventArgs e)
    {
        if (!stopRequested && audioFile != null)
        {
            audioFile.Position = 0;
            outputDevice.Play();
        }
    }

    // Neue Eigenschaft zum Setzen der Lautstärke
    public float Volume
    {
        get => volume;
        set
        {
            volume = value;
            if (outputDevice != null)
            {
                outputDevice.Volume = volume;
            }
        }
    }
}
