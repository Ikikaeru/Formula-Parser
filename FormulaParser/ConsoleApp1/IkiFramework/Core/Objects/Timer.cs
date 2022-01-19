namespace IkiCore
{
	public struct Timer
	{
        public float TotalTime;
        public float CurrentTime { get; private set; }
        public float Time01 => CurrentTime / TotalTime;
        public float RemainingTime => TotalTime - CurrentTime;
        public bool HasLooped { get; private set; }
        public bool HasEnded { get; private set; }
        public Timer(float totalTime)
        {
            TotalTime = totalTime;
            CurrentTime = 0f;
            HasLooped = false;
            HasEnded = false;
        }
        public void LoopUpdate(float deltaTime)
        {
            HasLooped = false;
            CurrentTime += deltaTime;
            if(CurrentTime > TotalTime)
            {
                HasLooped = true;
                CurrentTime %= TotalTime;
            }
        }
        public void EndUpdate(float deltaTime)
        {
            if(!HasEnded)
            {
                CurrentTime += deltaTime;
                if (CurrentTime > TotalTime)
                {
                    HasEnded = true;
                    CurrentTime = TotalTime;
                }
            }            
        }
        public void InfiniteUpdate(float deltaTime) => CurrentTime += deltaTime;
        public void Reset()
        {
            CurrentTime = 0;
            HasLooped = false;
            HasEnded = false;
        }
    }
}
