namespace java.lang
{
    public class JavaSystem
    {

        public static long currentTimeMillis()
        {
            return System.DateTime.Now.Millisecond;
        }

        public static void gc()
        {
            System.GC.Collect();
        }

        public static void arraycopy<T>(T[] a1, int p1, T[] a2, int p2, int p3)
        {
            System.Array.Copy(a1, p1, a2, p2, p3);
        }
    }
}
