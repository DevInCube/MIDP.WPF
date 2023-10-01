namespace javax.microedition.pki
{

    using java.io;
    using java.lang;

    public class CertificateException : IOException
    {
        public const byte BAD_EXTENSIONS = 1;
        public const byte INAPPROPRIATE_KEY_USAGE = 10;
        public const byte BROKEN_CHAIN = 11;
        public const byte ROOT_CA_EXPIRED = 12;
        public const byte UNSUPPORTED_PUBLIC_KEY_TYPE = 13;
        public const byte VERIFICATION_FAILED = 14;
        public const byte CERTIFICATE_CHAIN_TOO_LONG = 2;
        public const byte EXPIRED = 3;
        public const byte UNAUTHORIZED_INTERMEDIATE_CA = 4;
        public const byte MISSING_SIGNATURE = 5;
        public const byte NOT_YET_VALID = 6;
        public const byte SITENAME_MISMATCH = 7;
        public const byte UNRECOGNIZED_ISSUER = 8;
        public const byte UNSUPPORTED_SIGALG = 9;

        public CertificateException(String paramString, Certificate paramCertificate, byte paramByte) { }

        public CertificateException(Certificate paramCertificate, byte paramByte) { }

        public byte getReason()
        {
            return 0;
        }

        public Certificate getCertificate()
        {
            return null;
        }
    }


}