using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace StartThreads
{
	class Program
	{
		static void Main(string[] args)
		{
			if (args.Length == 1)
			{
				Console.Write(args[0]);
				return;
			}

			Program program = new Program();
			program.Run();
			Console.WriteLine("Complete - enter to end");
			Console.ReadLine();
		}

		private void Run()
		{
			Console.WriteLine("Application thread id is {0}", Thread.CurrentThread.ManagedThreadId);
			
			LongTermCommitment();
			TheGentlemansApproach();
			TheMentalist();
			TheVbSissy();
			TheInsaneCoWorker();
			TheTaskAtHand();
			TheTaskInOtherHand();
			TheContemporaryApproach();
			TheShowOff();
			OutOfProcess();
		}

		private delegate void BackgroundMethodDelegate(string approach);

		private void BackgroundMethod(string approach)
		{
			Console.WriteLine("Approach \"{0}\" Thread Id:{1} ({2})",
				approach,
				Thread.CurrentThread.ManagedThreadId,
				Thread.CurrentThread.IsThreadPoolThread ? "from ThreadPool" : "not from ThreadPool");
		}

		public void LongTermCommitment()
		{
			// create a thread, execute the background method and block until it's done
			Thread thread = new Thread(_ => BackgroundMethod("Long Term Commitment"));
			thread.Start();
			thread.Join();
		}

		public void TheGentlemansApproach()
		{
			// straight onto the threadpool - what could be better?
			ThreadPool.QueueUserWorkItem(_ => BackgroundMethod("The Gentleman's Approach"));
		}

		public void TheMentalist()
		{
			// Use the Asyncronous Programming Model (APM) - a bit ugly in my eyes
			BackgroundMethodDelegate x = new BackgroundMethodDelegate(BackgroundMethod);
			IAsyncResult a = x.BeginInvoke("The Mentalist", null, null);
			x.EndInvoke(a);
		}

		public void TheVbSissy()
		{
			// BackgroundWorkers are for wimps. Case closed.
			BackgroundWorker worker = new BackgroundWorker();
			worker.DoWork += delegate { BackgroundMethod("The VB Sissy Approach"); };
			worker.RunWorkerAsync();
		}

		public void TheInsaneCoWorker()
		{
			// this requires a certain level of teeth gritting
			Timer timer = new System.Threading.Timer(_ => BackgroundMethod("The Insane Coworker"), null, 0, Timeout.Infinite);
		}

		public void TheTaskAtHand()
		{
			// first of many TPL ways
			using (Task task = new Task(() => BackgroundMethod("The Task At Hand")))
			{
				task.Start();
				task.Wait();
			}
		}

		public void TheTaskInOtherHand()
		{
			Task.Factory.StartNew(() => BackgroundMethod("The Task In The Other Hand"));
		}

		public void TheContemporaryApproach()
		{
			// pretty neat - one has to admint
			Parallel.Invoke(() => BackgroundMethod("The Contemporary Approach"));
		}

		public void TheShowOff()
		{
			// RX - push the text into a subscribed method
			Observable.Return("The Show Off", Scheduler.Default).Subscribe(BackgroundMethod);
		}

		public void OutOfProcess()
		{
			// this is a bit of a kludge as we are writing to the console on the main application thread
			// even so, the operation (writing a string to output) is done in a second process and hence
			// thread, but we have to redirect the output here to see it....
			ProcessStartInfo startInfo = new ProcessStartInfo("StartThreads.exe", "OutOfProcess");
			startInfo.CreateNoWindow = false;
			startInfo.UseShellExecute = false;
			startInfo.RedirectStandardOutput = true;
			Process process = Process.Start(startInfo);
			Console.WriteLine("Approach \"{0}\" sent from second process", process.StandardOutput.ReadToEnd());
			process.WaitForExit();
		}
	}
}
