using System;
using Microsoft.AppCenter.Analytics;
using NotesMAUI.Services;

namespace NotesMAUI.Implementations
{
	public class AppCenterTrackerService : ITrackerService
    {
        public void TrackEvent(string eventName)
        {
            Analytics.TrackEvent(eventName);
        }
    }
}

