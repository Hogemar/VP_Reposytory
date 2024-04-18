namespace FileClassLogic
{

	public class FileClass
	{
        private StreamReader? _reader;
		private StreamWriter? _writer;

		public bool isClosed { get; private set; } = true;

		private FileClass(string filePath, bool isNewFile)
		{
			if(CreateStream(filePath, isNewFile))
				isClosed = false;
		}
		~FileClass()
		{
			Close();
		}

		public static FileClass Create(string filePath) => new FileClass(filePath, true);
		public static FileClass Open(string filePath) => new FileClass(filePath, false);

		public string? ReadLine()
		{
			if (isClosed) throw new Exception("Error: cannot read from closed file!");

            _reader.DiscardBufferedData();
            _reader.BaseStream.Seek(0, SeekOrigin.Begin);

			return _reader.ReadLine();
		}
		public string Read(ushort count)
		{
			if (isClosed) throw new Exception("Error: cannot read from closed file!");

            _reader.DiscardBufferedData();
            _reader.BaseStream.Seek(0, SeekOrigin.Begin);

            var buffer = new char[count];

			if (_reader.Read(buffer, 0, Convert.ToInt32(count)) == 0)
				return "";
			else
				return new string(buffer);
		}
		public void WriteLine(string str)
		{
            if (isClosed) throw new Exception("Error: cannot write to closed file!");

			_writer.WriteLine(str);
			_writer.Flush();
        }
        public void Write(string str, ushort count)
		{
            if (isClosed) throw new Exception("Error: cannot write to closed file!");

			_writer.Write(str.Substring(0, Convert.ToInt32(count)));
            _writer.Flush();
        }
        public void Close()
		{
			if (isClosed) return;
            _writer.Dispose();
            _reader.Dispose();

			isClosed = true;
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
