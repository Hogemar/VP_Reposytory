namespace ClassLibrary
{

	public class FileClass : IDisposable
    {
        private StreamReader? _reader;
		private StreamWriter? _writer;
        private bool _isDisposed = true;


		private FileClass(string filePath, bool isNewFile)
		{
            if (CreateStream(filePath, isNewFile))
                _isDisposed = false;
		}
		~FileClass()
		{
            Dispose();
        }

		public static FileClass Create(string filePath) => new FileClass(filePath, true);
		public static FileClass Open(string filePath) => new FileClass(filePath, false);

		public string? ReadLine()
		{
			if (_isDisposed) throw new Exception("Error: cannot read from file!");

			return _reader.ReadLine();
		}
		public string Read(ushort count)
		{
			if (_isDisposed) throw new Exception("Error: cannot read from file!");

			var buffer = new char[count];

			if (_reader.Read(buffer, 0, Convert.ToInt32(count)) == 0)
				return "";
			else
				return new string(buffer);
		}
		public void WriteLine(string str)
		{
            if (_isDisposed) throw new Exception("Error: cannot write to file!");

			_writer.WriteLine(str);
			_writer.Flush();
        }
        public void Write(string str, ushort count)
		{
            if (_isDisposed) throw new Exception("Error: cannot write to file!");

            _writer.Write(str.Substring(0, Convert.ToInt32(count)));
            _writer.Flush();
        }
        public void Close() => Dispose();
        public void Dispose()
        {
            if (_isDisposed) return;

            //Освобождаем неуправляемые ресурсы
            if (_writer != null)
            {
                _writer.Flush();
                _writer.Close();
                _writer = null;
            }

            //Освобождаем неуправляемые ресурсы
            if (_reader != null)
            {
                _reader.Close();
                _reader = null;
            }

            //Не отправлять объект в очередь финализации
            GC.SuppressFinalize(this);

            //Ресурсы были освобождены
            _isDisposed = true;
        }

        private bool CreateStream(string filePath, bool isNewFile)
        {
            FileStream stream;

            if (isNewFile)
                stream = new FileStream
                    (
                    filePath,
                    FileMode.Create,
                    FileAccess.ReadWrite,
                    FileShare.ReadWrite | FileShare.Delete
                    );
            else
                try
                {
                    stream = new FileStream
                        (
                        filePath,
                        FileMode.Open,
                        FileAccess.ReadWrite,
                        FileShare.ReadWrite | FileShare.Delete
                        );
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine($"\n Error: file '{filePath}' not found!");
                    return false;
                }

            _reader = new StreamReader(stream);
            _writer = new StreamWriter(stream);

            return true;
        }
    }

}
