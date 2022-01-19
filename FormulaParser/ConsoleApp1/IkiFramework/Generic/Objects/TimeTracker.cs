using System.Collections.Generic;
namespace IkiCore.Generic
{
	public class TimeTracker<T> where T : struct
	{
        List<T> trackValue = new List<T>();
        List<float> timeValue = new List<float>();
        public int Changes { get => trackValue.Count; }
        public float InitialTime { get => timeValue.Count > 0 ? timeValue[0] : 0f; }
        public T[] GetValues => trackValue.ToArray();
        public float[] GetTimes => timeValue.ToArray();
        public void Add(T value, float time)
        {
            if (time < 0f)
            {
                throw new System.Exception("Time is out of range");
            }
            if (trackValue.Count > 0)
            {
                if(!trackValue[trackValue.Count - 1].Equals(value))
                {
                    trackValue.Add(value);
                    timeValue.Add(time);
                }
            }
            else
            {
                trackValue.Add(value);
                timeValue.Add(time);
            }
        }
        public void Clear()
        {
            trackValue = new List<T>();
            timeValue = new List<float>();
        }
        public void CleanBeforeTime(float time, bool safe = false)
        {
            if (safe)
            {
                for (int i = timeValue.Count - 1; i >= 0; i--)
                {
                    if (timeValue[i] < time)
                    {
                        timeValue.RemoveAt(i);
                        trackValue.RemoveAt(i);
                    }
                }
            }
            else
            {
                while(timeValue.Count > 0)
                {
                    if (timeValue[0] < time)
                    {
                        timeValue.RemoveAt(0);
                        trackValue.RemoveAt(0);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        public void CleanAfterTime(float time, bool safe = false)
        {
            if(safe)
            {
                for (int i = timeValue.Count - 1; i >= 0; i--)
                {
                    if (timeValue[i] > time)
                    {
                        timeValue.RemoveAt(i);
                        trackValue.RemoveAt(i);
                    }
                }
            }
            else
            {
                for (int i = timeValue.Count - 1; i >= 0; i--)
                {
                    if (timeValue[i] > time)
                    {
                        timeValue.RemoveAt(i);
                        trackValue.RemoveAt(i);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
