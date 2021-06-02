﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaBP2.CRUD
{
 public   class Klijent_OP
    {

        //CRUD
        public void AddKLi(string ime,string prz,int zirant,int plt)
        {
            if (ime != null)
            {
                using (var db = new Model1Container())
                {
                    Klijent k = new Klijent();
                    k.IME_KLI = ime;
                    k.PRZ_KLI = prz;
                    k.ZirantID_ZIR = zirant;

                    db.Klijents.Add(k);
                    db.SaveChanges();
                }
            }

        }
        
        //Update
        public void UpdateKli(string ime, string prz, int zirant, int plt, int id)
        {

            using (var db = new Model1Container())
            {
                var k = db.Klijents.SingleOrDefault(n => n.JMBG_KLI == id);

                if (k != null)
                {
                    k.IME_KLI = ime;
                    k.PRZ_KLI = prz;
                    k.ZirantID_ZIR = zirant;
                    k.JMBG_KLI = id;

                    db.SaveChanges();
                }

            }
        }
        //Delete
        public void DeleteKli(Klijent k)
        {


            //using (var db = new Model1Container())
            //{


        //        var banka = db.Bankas.SingleOrDefault(n => n.ID_Banka == f.BankaID_Banka);
        //        var filijala = db.Filijalas.SingleOrDefault(a => a.ID_FIL == f.ID_FIL);
        //        var sluzbenik = db.Sluzbeniks.SingleOrDefault(s => s.Filijala.ID_FIL == f.ID_FIL);
        //        var izdati_kr = db.IzdatiKreditis.SingleOrDefault(s => s.SluzbenikJMBG_RAD == sluzbenik.JMBG_RAD);
        //        var klijent = db.Klijents.SingleOrDefault(s => s.JMBG_KLI == izdati_kr.KlijentJMBG_KLI);
        //        var zirant = db.Zirants.SingleOrDefault(z => z.ID_ZIR == klijent.ZirantID_ZIR);
        //        var odobrenje = db.Odobrenjes.SingleOrDefault(s => s.OdlukaID_ODLUKE == izdati_kr.OdobrenjeOdlukaID_ODLUKE && s.RISKID_KOMISIJE == izdati_kr.OdobrenjeRISKID_KOMISIJE);

        //        var kredit = db.Kredits.Where(k =>
        //         k.IzdatiKreditiKlijentJMBG_KLI.Equals(klijent.JMBG_KLI)
        //         && k.IzdatiKreditiOdobrenjeOdlukaID_ODLUKE.Equals(odobrenje.OdlukaID_ODLUKE) &&
        //         k.IzdatiKreditiOdobrenjeRISKID_KOMISIJE.Equals(odobrenje.RISKID_KOMISIJE)
        //         && k.IzdatiKreditiSluzbenikJMBG_RAD.Equals(sluzbenik.JMBG_RAD));

        //        var instance_kredit = kredit.Single(s => s.DAT_IZD != null);

        //        var tipKreditaAgro = db.Gazdnistvoes.SingleOrDefault(a => a.Agro.ID_ZAHT == instance_kredit.ID_ZAHT);
        //        var tipKreditaBiznis = db.Kompanijas.SingleOrDefault(k => k.Bizni.ID_ZAHT == instance_kredit.ID_ZAHT);
        //        var tipKreditaKes = db.Jemacs.SingleOrDefault(k => k.Kes_kredit.ID_ZAHT == instance_kredit.ID_ZAHT);

        //        if (tipKreditaAgro != null)
        //        {
        //            db.Gazdnistvoes.Remove(tipKreditaAgro);
        //        }

        //        if (tipKreditaBiznis != null)
        //        {
        //            db.Kompanijas.Remove(tipKreditaBiznis);
        //        }

        //        if (tipKreditaKes != null)
        //        {
        //            db.Jemacs.Remove(tipKreditaKes);
        //        }

        //        if (odobrenje != null)
        //        {
        //            db.Odobrenjes.Remove(odobrenje);
        //        }

        //        if (kredit != null)
        //        {
        //            db.Kredits.Remove(instance_kredit);
        //        }
        //        if (klijent != null)
        //        {
        //            db.Klijents.Remove(klijent);
        //        }

        //        if (zirant != null)
        //        {
        //            db.Zirants.Remove(zirant);
        //        }
        //        if (izdati_kr != null)
        //        {
        //            db.IzdatiKreditis.Remove(izdati_kr);
        //        }

        //        if (sluzbenik != null)
        //        {
        //            db.Sluzbeniks.Remove(sluzbenik);
        //        }

        //        if (filijala != null)
        //        {
        //            db.Filijalas.Remove(filijala);
        //        }

        //        if (banka != null)
        //        {
        //            db.Bankas.Remove(banka);
        //        }

        //        db.SaveChanges();

        //    }
        }
    }
}
