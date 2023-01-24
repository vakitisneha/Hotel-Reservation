using samplewebapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace samplewebapi.rep
{
    public interface IReservation
    {
        List<ReservationModel> GetallDetails();
        ReservationModel GetDetailsbyid(int Slno);
        string  insertdetails(ReservationModel i);
        string updatedetails(ReservationModel u);
        string DeleteDetails(int Slno);

        List<ReservationModel> getMaster();

     }
    class ResDetailes : IReservation
    {
       sampleEntities8 sx = new sampleEntities8();

        List<ReservationModel> res = new List<ReservationModel> { };

        List<ReservationModel> IReservation.GetallDetails()
        {
            List<ReservationModel> res = null;
            res = sx.Reservations.Select(sx => new ReservationModel()
            {
                Slno=sx.Slno,
                Hotel=sx.Hotel,
                Arrival=sx.Arrival,
                Departure=sx.Departure,
                Type=sx.Type,
                Guests=sx.Guests,
                Price=sx.Price,

            }).ToList<ReservationModel>();
           return res;
        }
        ReservationModel IReservation.GetDetailsbyid(int Slno)
        {

            var res = sx.Reservations.Where(g => g.Slno == Slno).Select(sx => new ReservationModel()
            {
                Slno = sx.Slno,
                Hotel = sx.Hotel,
                Arrival = sx.Arrival,
                Departure = sx.Departure,
                Type = sx.Type,
                Guests = sx.Guests,
                Price = sx.Price,
            }).ToList<ReservationModel>();
            var s = res.Where(g => g.Slno == Slno).FirstOrDefault();
            return s;
        }

        string  IReservation.insertdetails(ReservationModel i)
        {
            var res = sx.Reservations.Where(s => s.Slno == i.Slno).FirstOrDefault();
            if (res == null)
            {
                sx.Reservations.Add(new Reservation
                {
                    Slno = i.Slno,
                    Hotel = i.Hotel,
                    Arrival = i.Arrival,
                    Departure = i.Departure,
                    Type = i.Type,
                    Guests = i.Guests,
                    Price = i.Price
                });
                sx.SaveChanges();
                sx.Dispose();
            }
            else
            {
                res.Slno = i.Slno;
                res.Hotel = i.Hotel;
                res.Arrival = i.Arrival;
                res.Departure = i.Departure;
                res.Type = i.Type;
                res.Guests = i.Guests;
                res.Price = i.Price;

            }
            
            sx.SaveChanges();
            sx.Dispose();
            return "inserted";
        }
       

        string IReservation.updatedetails(ReservationModel u)
        {
            var res = sx.Reservations.Where(s => s.Slno == u.Slno).FirstOrDefault();
            {
                if (res != null)
                {
                    res.Slno = u.Slno;
                    res.Hotel = u.Hotel;
                    res.Arrival = u.Arrival;
                    res.Departure = u.Departure;
                    res.Type = u.Type;
                    res.Guests = u.Guests;
                    res.Price = u.Price;
                }
            }
            sx.SaveChanges();
            return "updated";
        }
       
        string IReservation.DeleteDetails(int Slno)
        {
            var ret = sx.Reservations.Where(s => s.Slno == Slno).FirstOrDefault();
            if (ret != null)
            {
                sx.Reservations.Remove(ret);
            }
            sx.SaveChanges();
            return "deleted";
        }

        List<ReservationModel> IReservation.getMaster()
        {
            //List<ReservationModel> res = null;
            var res = sx.MasterTables.Select(s => new ReservationModel()
            {
                hotelId = s.hotelId,
                Hotel = s.Hotel,
               
                Type = s.Type,
                Guests = s.Guests,
                Price = s.Price,

            }).ToList<ReservationModel>();
            return res;
        }


    }
}
