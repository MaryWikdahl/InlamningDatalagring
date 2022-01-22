using InlamningDatabas.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlamningDatabas.Services
{

    internal interface IErrandServices
    {
        void CreateErrand(Errand Errand);
        Errand Get(int id);

        IEnumerable<Errand> GetAll();

        String ChangeState(State State);
    }
    internal class ErrandServices : IErrandServices
    {
        private readonly SqlContext _context = new SqlContext();
        public void CreateErrand(Errand errand)
        {
            var _Errand = _context.Errands.Where(x => x.Id == errand.Id).FirstOrDefault();
            if (_Errand == null)
            {
                _context.Errands.Add(errand);
                _context.SaveChanges();
            }
        }

        public Errand Get(int id)
        {
            return _context.Errands.Find(id);
        }

        public IEnumerable<Errand> GetAll()
        {
            return _context.Errands;
        }

        public string ChangeState(State State)
        {
            switch (State)
            {

                case State.NotRunning:
                    return "Not Running";
                case State.UnderProcess:
                    return "Under Process";
                case State.Finished:
                    return "Finished";

            }
            return "";
        }

    }


}
