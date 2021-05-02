using Lista03.Entities;
using Newtonsoft.Json;
using System.IO;
using System.Xml.Serialization;

namespace Lista03.Repositories
{
    public class FornecedorRepository
    {
        public void ExportarXml(Fornecedor fornecedor)
        {
            var path = $"c:\\temp\\fornecedor_{fornecedor.Id}.xml";

            var xmlSerializer = new XmlSerializer(fornecedor.GetType());

            using (var streamWriter = new StreamWriter(path))
            {
                xmlSerializer.Serialize(streamWriter, fornecedor);
            }
        }

        public void ExportarJson(Fornecedor fornecedor)
        {
            var path = $"c:\\temp\\fornecedor_{fornecedor.Id}.json";

            var json = JsonConvert.SerializeObject(fornecedor, Formatting.Indented);

            using (var streamWriter = new StreamWriter(path))
            {
                streamWriter.WriteLine(json);
            }
        }
        public void ExportartipoXml()
        {

        }
    }
}
