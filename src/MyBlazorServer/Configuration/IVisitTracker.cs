namespace MyBlazorServer.Configuration
{
    public interface IVisitTracker
    {
        void TrackMyVisit();
        void UnTrackMyVisit();
        bool AmITracked();
    }
}
