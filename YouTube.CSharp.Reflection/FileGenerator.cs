using System.Text;

namespace YouTube.CSharp.Reflection
{
    public class FileGenerator<T>
    {
        private IEnumerable<T> _data;
        private string _filename;
        private Type _type;

        public FileGenerator(IEnumerable<T> data,string filename)
        {
            _filename = filename;
            _data = data;
            _type = typeof(T);
        }


        public void GenerateFile()
        {
            var rows = new List<string>();

            rows.Add(Header()); 

            foreach (var item in _data)
            {
                rows.Add(Row(item)); //
            }

            File.WriteAllLines($"{_filename}.csv", rows, Encoding.UTF8);
        }

        private string Header()
        {
            var properties = _type.GetProperties();

            var builder = new StringBuilder();
            foreach (var property in properties)
            {
                builder.Append(property.Name).Append(",");
            }
            return builder.ToString()[..^1];
        }

        private string Row(T item)
        {
            var properties = _type.GetProperties();
            var build = new StringBuilder();

            foreach (var property in properties)
            {
                build.Append(property.GetValue(item)).Append(",");
            }
            
            return build.ToString()[..^1];
        }
    }
}
