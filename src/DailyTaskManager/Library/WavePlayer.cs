using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace DailyTaskManager
{
  public class WavePlayer
  {
    private WaveFileReader reader;
    private WaveOut player;

    public WavePlayer(Stream stream, float volume = 0.1f)
    {
      reader = new WaveFileReader(stream);
      player = new WaveOut();
      player.PlaybackStopped += player_PlaybackStopped;
      player.Init(reader);
      player.Volume = volume;
      player.Play();
    }

    private void player_PlaybackStopped(object sender, StoppedEventArgs e)
    {
      player.Dispose();
      reader.Dispose();
    }
  }
}
