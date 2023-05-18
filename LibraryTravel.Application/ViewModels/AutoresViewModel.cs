using LibraryTravel.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTravel.Application.ViewModels
{
    public class AutoresViewModel
    {
        public IEnumerable<Autores> Autores { get; set; }
    }
}
