namespace ConsoleAppClassPractice;

public class EventsDelegates
{
    static void MainDuplicate(string[] args)
    {
        var video = new Video();
        var videoEncoder = new VideoEncoder();
        var mailService = new MailService();
        var messageService = new MessageService();

        videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
        videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
        videoEncoder.Encode(video);
    }

    public class Video
    {
        public string Title { get; set; }
    }

    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {
        //for empty Args
        // public delegate void VideoEncodedEventHandler(object source, EventArgs args);
        
        //with custom delegate
        // public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args)
        // public event VideoEncodedEventHandler VideoEncoded;

        public event EventHandler<VideoEventArgs> VideoEncoded; 
        //with no args
        //public event EventHandler VideoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding");
            Thread.Sleep(3000);
            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
            {
                //no args
                //VideoEncoded(this, EventArgs.Empty);
                VideoEncoded(this, new VideoEventArgs() { Video = video });
            }
        }
    }

    public class MailService
    {
        //with no args
        //public void OnVideoEncoded(object source, EventArgs e)
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MailService: Sending an email" +
                              e.Video.Title);
        }
    }

    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MessageService: Sending a text" + e.Video.Title);
        }
    }
}