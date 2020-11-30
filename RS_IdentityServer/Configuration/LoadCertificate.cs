using System;
using System.Security.Cryptography.X509Certificates;

namespace RS_IdentityServer.Configuration
{
    internal class LoadCertificate
    {
        public static X509Certificate2 LoadCertuficateFromStore(string thumbprint)
        {

            using (X509Store store = new X509Store(StoreName.My, StoreLocation.LocalMachine))
            {
                store.Open(OpenFlags.ReadOnly);

                var CertColl = store.Certificates.Find(X509FindType.FindByThumbprint, thumbprint, true);

                if (CertColl.Count == 0)
                    throw new Exception("The specified certificate wasn't found.");

                return CertColl[0];
            }
        }
    }
}
