namespace javax.microedition.io
{

    using java.lang;

    public interface HttpConnection //: ContentConnection
    {
        /*
        public static readonly int HTTP_OK = 200;
        public static readonly int HTTP_CREATED = 201;
        public static readonly int HTTP_ACCEPTED = 202;
        public static readonly int HTTP_NOT_AUTHORITATIVE = 203;
        public static readonly int HTTP_NO_CONTENT = 204;
        public static readonly int HTTP_RESET = 205;
        public static readonly int HTTP_PARTIAL = 206;
        public static readonly int HTTP_MULT_CHOICE = 300;
        public static readonly int HTTP_MOVED_PERM = 301;
        public static readonly int HTTP_MOVED_TEMP = 302;
        public static readonly int HTTP_SEE_OTHER = 303;
        public static readonly int HTTP_NOT_MODIFIED = 304;
        public static readonly int HTTP_USE_PROXY = 305;
        public static readonly int HTTP_TEMP_REDIRECT = 307;
        public static readonly int HTTP_BAD_REQUEST = 400;
        public static readonly int HTTP_UNAUTHORIZED = 401;
        public static readonly int HTTP_PAYMENT_REQUIRED = 402;
        public static readonly int HTTP_FORBIDDEN = 403;
        public static readonly int HTTP_NOT_FOUND = 404;
        public static readonly int HTTP_BAD_METHOD = 405;
        public static readonly int HTTP_NOT_ACCEPTABLE = 406;
        public static readonly int HTTP_PROXY_AUTH = 407;
        public static readonly int HTTP_CLIENT_TIMEOUT = 408;
        public static readonly int HTTP_CONFLICT = 409;
        public static readonly int HTTP_GONE = 410;
        public static readonly int HTTP_LENGTH_REQUIRED = 411;
        public static readonly int HTTP_PRECON_FAILED = 412;
        public static readonly int HTTP_ENTITY_TOO_LARGE = 413;
        public static readonly int HTTP_REQ_TOO_LONG = 414;
        public static readonly int HTTP_UNSUPPORTED_TYPE = 415;
        public static readonly int HTTP_UNSUPPORTED_RANGE = 416;
        public static readonly int HTTP_EXPECT_FAILED = 417;
        public static readonly int HTTP_INTERNAL_ERROR = 500;
        public static readonly int HTTP_NOT_IMPLEMENTED = 501;
        public static readonly int HTTP_BAD_GATEWAY = 502;
        public static readonly int HTTP_UNAVAILABLE = 503;
        public static readonly int HTTP_GATEWAY_TIMEOUT = 504;
        public static readonly int HTTP_VERSION = 505;
        public static readonly String GET = "GET";
        public static readonly String HEAD = "HEAD";
        public static readonly String POST = "POST";

         */

        int getHeaderFieldInt(String paramString, int paramInt);


        int getPort();

        int getResponseCode();


        String getFile();

        String getHeaderField(int paramInt);


        String getHeaderField(String paramString);


        String getHeaderFieldKey(int paramInt);


        String getHost();

        String getProtocol();

        String getQuery();

        String getRef();

        String getRequestMethod();

        String getRequestProperty(String paramString);

        String getResponseMessage();


        String getURL();

        long getDate();


        long getExpiration();


        long getHeaderFieldDate(String paramString, long paramLong);


        long getLastModified();


        void setRequestMethod(String paramString);


        void setRequestProperty(String paramString1, String paramString2);

    }
}