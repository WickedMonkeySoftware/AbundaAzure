using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace api
{
    public class RSAClass
    {
        private static string privateKey = "<RSAKeyValue><Modulus>2KMHsdajIVIL+YI0JzQzfahldGifkMl4UuV4/coUflRwH1MnGz5eJucrYlHoBuuW+5H0S2g0yk0462hKrgXTdZdrVH/ANZz3njzex2ZAJBYJiQWOcAh/WH6E9HOQ4mSllkA3193Nk/4XBDWnr/0bOOJr7LjFnfReGecCQRmZPJK8WDtpjE8fH+tD1jW4pH5WS2T59Bdr1kDBqM+Wt2ABTUwZ3H24jvSCvjzrLyHmgNW3f29fbyGtUbth/vuIulIcRKtX/OlmoKanq1Xa1QF1xFjs56JrlfMM5l8LWcI23xUSVK4kOqi50iHrCSB9MyZOEeBfmbiv2JgS3nLJpimtdQ==</Modulus><Exponent>AQAB</Exponent><P>9CKQM3jJQqoOoyG0G0xdbz5SEl6Ga1Mz/H3CjwLc3B35OYMLsqPv/FouP9fmGAnp/rXgQSfJE07xIkb1WiadZnSij08BHPX4BpDa02KY0jWacA0619eZqPn3szXknWOQtknXNcC9KvFbbvtjLwjiF1NKPbM30KLn4BkxOqawHSM=</P><Q>4ypYP5s1NgqXGQLauoobnw8Lc7xbeqrW97NCOg7oERrL2HtAMVIJd7WEu4iLcegj74qJ/+CzLXbXrG4Xv8IhYlcjhaLY73Q1DsLxur09UHEQzS+XfCMB1jUwN5Jv5WiOzTYSptaMcYkd6TKAYMJVsOtrqwR69A55fi/pgq95cIc=</Q><DP>Edjg/9JJrETwUv6owwIfJn3A1DTy0K/Bcijjaz8DVFggmxK4bTPM3H7fOK2Y1ZML9yHmpfy5l17DBAV59EA0a4QFSkK1Sx+0JQ674I4pq9xdUOm2robFZfP4JrK+5r6bmqflQrm3WodQbtmT06Frndbp637JisgN+XT+A1KiN08=</DP><DQ>YcShwo5cMmwQZ9VQqiQyixyAg0k33e2VI3plMHOl8WalAQDaud9i78CR5dx4l4efn8LybcwZkaGqZS3kzsUQdTCnuyZBU52iED5ap1I3B14CKy0md2jhq32syN4fho6flzaEhIWmYF7xHqJ7milJlCFeb3Y4LL3mECcyyuoWzBU=</DQ><InverseQ>iCbFqYivt1dfA2NDzakrYNbIxHragWsWuWA/8A33oA4R0GgNQ5qW7tmioYGXXW1Qp89D23vBHLQUn813uq9N8pZSp8GEqbcBpREQlNPWDgVMi57O4e8jnknyIXLhJlt6UNCte48ZCTiO2DtUSnUPzjggyyVXQGmu033cRDUQX1Q=</InverseQ><D>B8Lvh6OU/KCf5TSRAcaRAbOCzwTgkqNlODMYfp861LvZuIWWJRe679HgcAlXMshGBIVaJ0l4ercBjw2Rf2KeDNx77+8Tx9fz1yt/H82+BozzkoEsdT8YsOb3hHqPekz40cVDOuyrbN3xnSj+9QMwcn1KOJT2H46dwHfSUNrF7rGSQzGZuv3IuJcpIWhFP/RYe/VwZRvRy8lBr0UI0SIZOhMMaR2H7GMyR3aRrOoMpuDpiOR6Dltm5CywsjlkpwWMPAyatk66gLEiWRiGMwd2Vt3eKVSDRAGDBklnVU6E4RkDIQRXPLcvqfBUMp6gMtUM3l/rGnXz0tfW6HLbHhKjEQ==</D></RSAKeyValue>";
        private static string publicKey = "<RSAKeyValue><Modulus>2KMHsdajIVIL+YI0JzQzfahldGifkMl4UuV4/coUflRwH1MnGz5eJucrYlHoBuuW+5H0S2g0yk0462hKrgXTdZdrVH/ANZz3njzex2ZAJBYJiQWOcAh/WH6E9HOQ4mSllkA3193Nk/4XBDWnr/0bOOJr7LjFnfReGecCQRmZPJK8WDtpjE8fH+tD1jW4pH5WS2T59Bdr1kDBqM+Wt2ABTUwZ3H24jvSCvjzrLyHmgNW3f29fbyGtUbth/vuIulIcRKtX/OlmoKanq1Xa1QF1xFjs56JrlfMM5l8LWcI23xUSVK4kOqi50iHrCSB9MyZOEeBfmbiv2JgS3nLJpimtdQ==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
        private static UnicodeEncoding encoder = new UnicodeEncoding();

        public static string Decrypt(string data)
        {
            var rsa = new RSACryptoServiceProvider();
            var dataArray = data.Split(new char[] { ',' });
            byte[] dataByte = new byte[dataArray.Length];
            for (int i = 0; i < dataArray.Length; i++)
            {
                dataByte[i] = Convert.ToByte(dataArray[i]);
            }

            rsa.FromXmlString(privateKey);
            var decryptedByte = rsa.Decrypt(dataByte, false);
            return encoder.GetString(decryptedByte);
        }

        public static string Encrypt(string data)
        {
            var rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(publicKey);
            var dataToEncrypt = encoder.GetBytes(data);
            var encryptedByteArray = rsa.Encrypt(dataToEncrypt, false).ToArray();
            var length = encryptedByteArray.Count();
            var item = 0;
            var sb = new StringBuilder();
            foreach (var x in encryptedByteArray)
            {
                item++;
                sb.Append(x);

                if (item < length)
                {
                    sb.Append(",");
                }
            }

            return sb.ToString();
        }
    }
}