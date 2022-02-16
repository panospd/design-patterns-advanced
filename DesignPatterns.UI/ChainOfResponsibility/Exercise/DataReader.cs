namespace DesignPatterns.UI.ChainOfResponsibility.Exercise
{
    public abstract class DataReader
    {
        private readonly DataReader? _next;

        protected DataReader(DataReader? next)
        {
            _next = next;
        }

        public void Read(string fileName)
        {
            if(fileName.EndsWith(GetFileExtention()))
            {
                DoRead(fileName);
                return;
            }

            if(_next == default)
            {
                throw new NotSupportedException("File format not supported");
            }

            _next.Read(fileName);
        }

        public abstract void DoRead(string fileName);
        public abstract string GetFileExtention();
    }
}