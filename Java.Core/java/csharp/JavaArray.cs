namespace java.csharp
{
    public static class JavaArray
    {

        public static T[][] New<T>(int n, int m)
        {
            var array = new T[n][];
            for (var i = 0; i < n; i++)
                array[i] = new T[m];
            return array;
        }

    }
}
