namespace ConsoleAppClassPractice;

public class Delegates
{
    public class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photo);

        //without generic delegate Action
        //public void Process(string path, PhotoFilterHandler filterHandler)
        
        //with Action delegate
        public void Process(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);
            var filters = new PhotoFilters();
            //without delegate
            //filters.ApplyBrightness(photo);
            //filters.ApplyContrast(photo);

            filterHandler(photo);
            
            photo.Save();
        }
    }
}