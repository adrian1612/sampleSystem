using System;
using System.Security.Cryptography.X509Certificates;
using SampleSystem.Classes;

namespace sampleSystem.Models
{
    public class Sample
    {
        dbcontrol s = new dbcontrol();
        public int ID { get; set; }
        public string fname { get; set; }
        public string mn { get; set; }
        public string lname { get; set; }
        public DateTime Timestamp { get; set; }

        public List<Sample> List() {
            return s.Query<Sample>("SELECT * FROM tbl_person", null);
        }

        public void Create(Sample m){
            s.InsertNormal("tbl_person", new {
                fname = m.fname,
                mn = m.mn,
                lname = m.lname
            });

        }

        public void Update(Sample m){
            s.Update("tbl_person", m.ID, new {
                fname = m.fname,
                mn = m.mn,
                lname = m.lname
            });
        }

        public void Delete(int id) {
            s.Query("DELETE FROM tbl_person WHERE ID = @ID", new { ID = id });
        }
    }
}