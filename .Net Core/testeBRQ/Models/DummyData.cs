using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testeBRQ.Data;
using System.Web;
using System.IO;
using System.Reflection;

namespace testeBRQ.Models
{
    public class DummyData
    {
        public static void Initialize(ApplicationDbContext db)
        {
            if (!db.Clientes.Any())
            {
                string path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\Clientes.json";
                StreamReader sr = new StreamReader(path);
                string data = sr.ReadToEnd();

                List<Cliente> clientes = JsonConvert.DeserializeObject<List<Cliente>>(data);
                db.Clientes.AddRange(clientes);
                db.SaveChanges();
            }

            if (!db.Localizacao.Any())
            {
                string path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\Localizacao.json";
                StreamReader sr = new StreamReader(path);
                string data = sr.ReadToEnd();

                List<Localizacao> localizacoes = JsonConvert.DeserializeObject<List<Localizacao>>(data);
                db.Localizacao.AddRange(localizacoes);
                db.SaveChanges();
            }
        }
    }
}
