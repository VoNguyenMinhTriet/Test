using System;
using System.IO;
using System.Reflection;
using System.Threading;
using LibVLCSharp.Shared;

namespace ConsoleTest
{
	class Program
	{
		static void Main (string[] args)
		{
			Console.WriteLine("Now Playing: JJD & Alex Skrindo - Elation");
			Core.Initialize();
			LibVLC libVLC = new LibVLC("--input-repeat=2");
			MediaPlayer mp = new MediaPlayer(libVLC)
			{
				Media = new Media(libVLC, new Uri("https://upload.wikimedia.org/wikipedia/commons/7/79/Example_of_flats_in_music.ogg"))
			};
			mp.Play();
			mp.Volume = 100;
			Console.ReadKey();
		}
	}
}
