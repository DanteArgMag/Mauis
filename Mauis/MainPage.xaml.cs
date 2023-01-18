using NAudio.Wave;

namespace MAUIS;

public partial class MainPage : ContentPage
{
    private WaveOutEvent waveOut;

    public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
        waveOut = new WaveOutEvent();
        var audioFile = new AudioFileReader("C:\\Users\\dante\\source\\repos\\Mauis\\MAUIS\\songs\\c1.wav");
        waveOut.Init(audioFile);
        waveOut.Play();
    }
}

