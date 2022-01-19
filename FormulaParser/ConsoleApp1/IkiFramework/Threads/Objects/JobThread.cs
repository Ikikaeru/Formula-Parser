using System.Collections;
using System.Threading;
namespace IkiCore.Core
{
    public class JobThread
    {
        protected Thread thread = null;
        public bool IsDone { get; set; } = false;
        public virtual void SetAffinity()
        {
            thread.Priority = ThreadPriority.Highest;
            thread.IsBackground = true;
        }
        public virtual void Start()
        {
            thread = new Thread(Run);
            thread.Start();
        }
        public virtual void Start(object param)
        {
            thread = new Thread(RunN);
            thread.Start(param);
        }
        protected virtual void ThreadFunction()
        {

        }
        protected virtual void ThreadFunction(object param)
        {

        }
        protected virtual void OnFinished()
        {

        }
        public virtual bool Update()
        {
            if (IsDone)
            {
                OnFinished();
                return true;
            }
            return false;
        }
        public IEnumerator WaitFor()
        {
            while (!Update())
            {
                yield return null;
            }
        }
        void Run()
        {
            ThreadFunction();
            IsDone = true;
        }
        void RunN(object param)
        {
            ThreadFunction(param);
            IsDone = true;
        }
    }
}
