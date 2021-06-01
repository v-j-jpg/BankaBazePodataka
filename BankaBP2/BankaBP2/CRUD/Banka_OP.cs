using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaBP2.CRUD
{
  public  class Banka_OP
    {
        string naziv;
        int id;

        public string Naziv { get => naziv; set => naziv = value; }
        public int ID { get => id; set => id = value; }

        //CRUD
        public void AddBank(string ime)
        {
            using (var db = new Model1Container())
            {
                var banka = new BankaBP2.Banka
                {
                    Naziv = ime
                };
                db.Bankas.Add(banka);
                db.SaveChanges();
            }
        }
        //Read
        public List<Banka_OP> ReadBank()
        {
            List<Banka_OP> list = new List<Banka_OP>();
            Banka_OP bb;

            using (var db = new Model1Container())
            {
                foreach (var item in db.Bankas)
                {
                    bb = new Banka_OP();
                    bb.naziv = item.Naziv;
                    bb.ID = item.ID_Banka;
                    list.Add(bb);
                }
            }
            return list;
        } 
        //Update
        public void UpdateBank(string ime,int ID)
        {

            using (var db = new Model1Container())
            {
                var banka = db.Bankas.SingleOrDefault(n => n.ID_Banka == ID);
               
                if (banka!=null)
                {
                    banka.Naziv = ime;
                    db.SaveChanges();
                }
               
            }
        }
        //Delete
        public void DeleteBank(string ime)
        {

            using (var db = new Model1Container())
            {
                var banka = db.Bankas.SingleOrDefault(n => n.Naziv == ime);

                if (banka != null)
                {
                    db.Bankas.Remove(banka);
                }
                db.SaveChanges();
            }
        }
    }
}
