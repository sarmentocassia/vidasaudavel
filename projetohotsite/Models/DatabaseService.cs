using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Hotsite.Models
{
    public class DatabaseService
    {
        public int CadastraInteresse(Interesse cad)
        {
            using (var context = new DatabaseContext())
            {
                int res = -1;
                try
                {
                    context.Add(cad);
                    context.SaveChanges();
                    res = cad.Id;
                    Console.WriteLine("cadastro ok");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    throw e;
                }
                 return res;
            }
        }
    }
}