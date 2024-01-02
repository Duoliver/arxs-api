namespace ArxsAPI.Common
{
    public static class EmptyHelper
    {
        public static bool IsEmpty(string s)
        {
            return s.Length == 0;
        }

        public static bool IsNotEmpty(string s)
        {
            return !IsEmpty(s);
        }

        public static bool IsEmpty(object o)
        {
            return o == null;
        }

        public static bool IsNotEmpty(object o)
        {
            return !IsEmpty(o);
        }

        public static bool IsEmpty(IFormFile file)
        {
            return file == null || file.Length == 0;
        }

        public static bool IsNotEmpty(IFormFile file)
        {
            return !IsEmpty(file);
        }

        public static bool IsEmpty<T>(ICollection<T> c)
        {
            return c.Count == 0;
        }

        public static bool IsNotEmpty<T>(ICollection<T> c)
        {
            return !IsEmpty(c);
        }

        public static bool IsEmpty<T>(T[] array)
        {
            return array.Length == 0;
        }

        public static bool IsNotEmpty<T>(T[] array)
        {
            return !IsEmpty(array);
        }
        
    }
}