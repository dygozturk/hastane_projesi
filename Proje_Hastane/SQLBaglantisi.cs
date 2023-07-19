using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    internal class SQLBaglantisi // sınıfın adı
    {
        public SqlConnection baglanti() //methodun adı
        { 
            SqlConnection baglan=new SqlConnection("Data Source=DESKTOP-QD4IO9E\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True");
            baglan.Open(); //baglan sql adresimi tutan nesnemin adı, open bir methot
            return baglan; //return geriye dönen değeri tutan kısım
        }
    }
}
